using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using WebGame.Server.Data;
using WebGame.Server.Models;

namespace WebGame.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly GameDbContext _dbc;
        public GameController(GameDbContext context)
        {
            _dbc = context;
        }
        [HttpGet("create")]
        public async Task<IActionResult> GetPlayers(string? playerId = null)
        {
            string readableWord = !string.IsNullOrEmpty(playerId) ? playerId : new WordGenerator().Generate(6);
            // create new map
            var buildingMap = new Map { Title = "Building Layer:" + readableWord };
            
            var townHall = new MapBuilding
            {
                BuildingId = 1,
                BottomLeftX = 17,
                BottomLeftY = 4
            };
            buildingMap.Buildings.Add(townHall);

            // calculate free space
            int freeSpace = 0;
            Map? defaultGroundMap = _dbc.Maps
                .Include(m => m.Tiles)
                .ThenInclude(mt => mt.Tile)
                .FirstOrDefault(m => m.MapId == 1);
            if (defaultGroundMap != null)
            {
                foreach (MapTile tile in defaultGroundMap.Tiles)
                {
                    if (tile.Tile.IsPlaceable)
                    {
                        freeSpace++;
                    }
                }
            }
            Building? townHallBuilding = _dbc.Buildings.Include(b => b.Levels).FirstOrDefault(b => b.BuildingId == 1);
            if (townHallBuilding != null)
            {
                freeSpace -= townHallBuilding.BaseWidth * townHallBuilding.BaseHeight;
            }

            // create game state
            GameState newGameState = new GameState
            {
                PlayerId = readableWord,
                Sheep = 50,
                Population = 10,
                FreeSpace = freeSpace,
                MaxPopulation = townHallBuilding.Levels.FirstOrDefault(l => l.Level == 1)?.Capacity ?? 32,
                LastUpdated = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow,
                BuildingMap = buildingMap
            };
            _dbc.GameStates.Add(newGameState);
            await _dbc.SaveChangesAsync();
            
            return Ok(readableWord);
        }
        [HttpGet("state/{playerId}")]
        public async Task<ActionResult<GameState>> GetGameState(string playerId)
        {
            var gameState = await _dbc.GameStates
                .AsNoTracking()
                .Include(gs => gs.BuildingMap)
                .ThenInclude(m => m.Buildings)
                .ThenInclude(mb => mb.Building)
                .ThenInclude(b => b.Levels)
                .Include(gs => gs.BuildingMap)
                .ThenInclude(m => m.Tiles)
                .ThenInclude(mt => mt.Tile)
                .FirstOrDefaultAsync(gs => gs.PlayerId == playerId);
            if (gameState == null)
            {
                return NotFound("Game state not found for the given player ID.");
            }
            return Ok(gameState);
        }
        [HttpGet("sheep/{playerId}/{amount}")]
        public async Task<IActionResult> AddSheep(string playerId, int amount)
        {
            if (string.IsNullOrEmpty(playerId)) return BadRequest("Nebyl zadán žádný ID hráče.");

            GameState? gameState = await _dbc.GameStates
                .FirstOrDefaultAsync(gs => gs.PlayerId == playerId);

            if (gameState == null) return NotFound("Game state not found for the given player ID.");

            gameState.Sheep += amount;
            await _dbc.SaveChangesAsync();
            return Ok(gameState);
        }
        [HttpGet("advance/{playerId}")]
        public async Task<IActionResult> AdvanceGame(string playerId)
        {
            if (string.IsNullOrEmpty(playerId)) return BadRequest("Nebyl zadán žádný ID hráče.");
            GameState? gameState = await _dbc.GameStates
                .Include(gs => gs.BuildingMap)
                .ThenInclude(m => m.Buildings)
                .ThenInclude(mb => mb.Building)
                .ThenInclude(b => b.Levels)
                .Include(gs => gs.BuildingMap)
                .ThenInclude(m => m.Tiles)
                .ThenInclude(mt => mt.Tile)
                .FirstOrDefaultAsync(gs => gs.PlayerId == playerId);
            if (gameState == null) return NotFound("Game state not found for the given player ID.");
            double SHEEP_MULTIPLIER = 1.05 + (gameState.Level * 0.1);
            double POPULATION_MULTIPLIER = 1.05 + (gameState.Level * 0.1);
            bool gameOver = gameState.Sheep <= 0;
            bool isStarving = gameState.Population > gameState.Sheep;
            if (isStarving && !gameOver) gameState.Sheep -= 5;
            if (gameState.Sheep < gameState.MaxSheep && !isStarving) gameState.Sheep = (int)(gameState.Sheep * SHEEP_MULTIPLIER);
            if (gameState.Sheep > gameState.MaxSheep) gameState.Sheep = gameState.MaxSheep;
            if (gameState.Population < gameState.MaxPopulation && !isStarving) gameState.Population = (int)(gameState.Population * POPULATION_MULTIPLIER);
            if (gameState.Population > gameState.MaxPopulation) gameState.Population = gameState.MaxPopulation;
            if (gameState.Sheep < 0) gameState.Sheep = 0;
            if (gameState.Level < 10)
            {
                double delta = (DateTime.UtcNow - gameState.LastUpdated).TotalSeconds;
                if (delta > 0 && delta <= 5) gameState.PlayTimeSeconds += delta;
            }
            gameState.LastUpdated = DateTime.UtcNow;
            await _dbc.SaveChangesAsync();
            return Ok(gameState);
        }
        [HttpGet("time/{playerId}")]
        public async Task<IActionResult> GetPlayTime(string playerId)
        {
            if (string.IsNullOrEmpty(playerId)) return BadRequest("Nebyl zadán žádný ID hráče.");
            GameState? gameState = await _dbc.GameStates
                .AsNoTracking()
                .FirstOrDefaultAsync(gs => gs.PlayerId == playerId);
            if (gameState == null) return NotFound("Game state not found.");
            return Ok(new { timeInSeconds = gameState.PlayTimeSeconds });
        }
        [HttpGet("leaderboard")]
        public async Task<IActionResult> GetLeaderboard()
        {
            var entries = await _dbc.LeaderboardEntries
                .AsNoTracking()
                .OrderBy(e => e.TimeInSeconds)
                .Select(e => new { e.Nickname, e.TimeInSeconds, e.CompletedAt, e.PlayerId })
                .ToListAsync();
            return Ok(entries);
        }
        [HttpPost("leaderboard")]
        public async Task<IActionResult> SubmitLeaderboard([FromBody] LeaderboardSubmitDto dto)
        {
            if (dto == null || string.IsNullOrWhiteSpace(dto.Nickname) || string.IsNullOrWhiteSpace(dto.PlayerId))
                return BadRequest("Nickname a PlayerId jsou povinné.");
            string nickname = dto.Nickname.Trim();
            if (nickname.Length < 2 || nickname.Length > 16)
                return BadRequest("Přezdívka musí mít 2-16 znaků.");
            GameState? gameState = await _dbc.GameStates
                .FirstOrDefaultAsync(gs => gs.PlayerId == dto.PlayerId);
            if (gameState == null) return NotFound("Hra nenalezena.");
            if (gameState.Level < 10) return BadRequest("Hra nebyla dokončena.");
            bool alreadySubmitted = await _dbc.LeaderboardEntries
                .AnyAsync(e => e.PlayerId == dto.PlayerId);
            if (alreadySubmitted) return BadRequest("Skóre pro tuto hru již bylo uloženo.");
            var entry = new LeaderboardEntry
            {
                Nickname = nickname,
                TimeInSeconds = (int)gameState.PlayTimeSeconds,
                CompletedAt = DateTime.UtcNow,
                PlayerId = dto.PlayerId
            };
            _dbc.LeaderboardEntries.Add(entry);
            await _dbc.SaveChangesAsync();
            return Ok(new { entry.Nickname, entry.TimeInSeconds, entry.CompletedAt });
        }
    }
    public class LeaderboardSubmitDto
    {
        public string Nickname { get; set; } = string.Empty;
        public string PlayerId { get; set; } = string.Empty;
    }
}