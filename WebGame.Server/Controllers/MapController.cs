using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebGame.Server.Data;
using WebGame.Server.Models;

namespace WebGame.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MapController : ControllerBase
    {
        private readonly GameDbContext _dbc;
        public MapController(GameDbContext context)
        {
            _dbc = context;
        }
        //EndPoints
        [HttpGet("buildings")]
        public async Task<ActionResult<IEnumerable<Building>>> GetBuildings()
        {
            Building[] buildings = await _dbc.Buildings.AsNoTracking().Include(b => b.Levels).ToArrayAsync();
            if (buildings == null || buildings.Length == 0) return NotFound("No buildings found.");
            return Ok(buildings);
        }
        [HttpGet("ground")]
        public async Task<ActionResult<Map>> GetGroundMaps()
        {
            Map? map = await _dbc.Maps.AsNoTracking().Include(m => m.Tiles).ThenInclude(mt => mt.Tile).Include(m => m.Buildings).ThenInclude(mb => mb.Building).Where(m => m.Title.StartsWith("Default ground layer")).SingleOrDefaultAsync();
            if (map == null) return NotFound("No ground map found.");
            return Ok(map);
        }

        [HttpPost("building")]
        public async Task<ActionResult<GameState>> CreateBuilding([FromBody] MapBuildingDTO request)
        {
            GameState? gameState = await _dbc.GameStates
                .Include(gs => gs.BuildingMap)
                .ThenInclude(m => m.Buildings)
                .ThenInclude(mb => mb.Building)
                .ThenInclude(b => b.Levels)
                .Include(gs => gs.BuildingMap)
                .ThenInclude(m => m.Tiles)
                .ThenInclude(mt => mt.Tile)
                .FirstOrDefaultAsync(gs => gs.PlayerId == request.PlayerId);

            Building? buildingType = await _dbc.Buildings.AsNoTracking().Include(b => b.Levels).FirstOrDefaultAsync(b => b.BuildingId == request.BuildingId);
            Map? map = await _dbc.Maps.AsNoTracking().Include(t => t.Tiles).ThenInclude(mt => mt.Tile).FirstOrDefaultAsync(m => m.MapId == 1);

            if (gameState == null) return NotFound("Game state not found for the given player ID.");
            if (buildingType == null) return NotFound("Building type not found for the given building ID.");
            if (buildingType.InitialCost > gameState.Sheep) return NotFound("Not enough resources to build this building.");

            // check for collisions
            bool isColiding = !MapUtils.CanPlaceBuilding(
                new MapBuilding
                {
                    Building = buildingType,
                    BottomLeftX = request.BottomLeftX,
                    BottomLeftY = request.BottomLeftY
                },
                gameState.BuildingMap.Buildings.ToArray(),
                map.Tiles.ToArray()
            );
            if (isColiding) return BadRequest("Zde budova nejde postavit");

            MapBuilding mapBuilding = new MapBuilding
            {
                BuildingId = request.BuildingId,
                MapId = gameState.BuildingMapId,
                BottomLeftX = request.BottomLeftX,
                BottomLeftY = request.BottomLeftY
            };

            _dbc.MapBuildings.Add(mapBuilding);

            // deduct resources
            gameState.Sheep -= buildingType.InitialCost;
            gameState.FreeSpace -= buildingType.BaseHeight * buildingType.BaseWidth;
            gameState.MaxPopulation += buildingType.Levels.FirstOrDefault(l => l.Level == 1)?.Capacity ?? 0;
            if (gameState.Sheep > gameState.MaxSheep) gameState.Sheep = gameState.MaxSheep;
            _dbc.GameStates.Update(gameState);

            await _dbc.SaveChangesAsync();

            GameState? UpdatedGameState = await _dbc.GameStates
                .AsNoTracking()
                .Include(gs => gs.BuildingMap)
                .ThenInclude(m => m.Buildings)
                .ThenInclude(mb => mb.Building)
                .ThenInclude(b => b.Levels)
                .Include(gs => gs.BuildingMap)
                .ThenInclude(m => m.Tiles)
                .ThenInclude(mt => mt.Tile)
                .FirstOrDefaultAsync(gs => gs.PlayerId == request.PlayerId);

            return Ok(UpdatedGameState);
        }
    
        
        [HttpPut("building/upgrade/{mapId}/{bottomLeftX}/{bottomLeftY}")]
        public async Task<IActionResult> UpgradeBuilding(int mapId, int bottomLeftX, int bottomLeftY)
        {
            MapBuilding? mapBuilding = await _dbc.MapBuildings
                .Include(mb => mb.Building)
                .ThenInclude(b => b.Levels)
                .FirstOrDefaultAsync(mb => mb.MapId == mapId && mb.BottomLeftX == bottomLeftX && mb.BottomLeftY == bottomLeftY);

            if (mapBuilding == null) return NotFound("Building not found.");

            GameState? gameState = await _dbc.GameStates.FirstOrDefaultAsync(gs => gs.BuildingMapId == mapId);
            if (gameState == null) return NotFound("Game state not found.");


            int currentLevel = mapBuilding.Level;
            int nextLevel = currentLevel + 1;

            BuildingLevel? currentLevelData = mapBuilding.Building.Levels.FirstOrDefault(l => l.Level == currentLevel);
            BuildingLevel? nextLevelData = mapBuilding.Building.Levels.FirstOrDefault(l => l.Level == nextLevel);

            if (gameState.Population < currentLevelData?.PopulationCost) return BadRequest("Není dostatek obyvatel na vylepšení této budovy.");
            if (nextLevel > gameState.Level && !mapBuilding.Building.IsTownHall) return BadRequest("Nejprve musíte vylepšit radnici.");
            if (nextLevelData == null) return BadRequest("Budova je již na maximální úrovni.");
            if (gameState.Sheep < nextLevelData.UpgradeCost) return BadRequest("Není dostatek prostředků na vylepšení této budovy.");

            // deduct upgrade cost
            gameState.Sheep -= nextLevelData.UpgradeCost;

            // update MaxPopulation
            int oldCapacity = currentLevelData?.Capacity ?? 0;
            int newCapacity = nextLevelData.Capacity;
            gameState.MaxPopulation = gameState.MaxPopulation - oldCapacity + newCapacity;

            // update game state level
            if (mapBuilding.Building.IsTownHall)
            {
                gameState.Level = nextLevel;
            }

            // update building level
            mapBuilding.Level = nextLevel;

            _dbc.GameStates.Update(gameState);
            _dbc.MapBuildings.Update(mapBuilding);
            await _dbc.SaveChangesAsync();

            GameState? updatedGameState = await _dbc.GameStates
                .AsNoTracking()
                .Include(gs => gs.BuildingMap)
                .ThenInclude(m => m.Buildings)
                .ThenInclude(mb => mb.Building)
                .ThenInclude(b => b.Levels)
                .Include(gs => gs.BuildingMap)
                .ThenInclude(m => m.Tiles)
                .ThenInclude(mt => mt.Tile)
                .FirstOrDefaultAsync(gs => gs.PlayerId == gameState.PlayerId);

            return Ok(updatedGameState);
        }

        [HttpDelete("building/{mapId}/{bottomLeftX}/{bottomLeftY}")]
        public async Task<IActionResult> DeleteBuilding(int mapId, int bottomLeftX, int bottomLeftY)
        {
            MapBuilding? mapBuilding = await _dbc.MapBuildings.FindAsync(mapId, bottomLeftX, bottomLeftY);
            
            if (mapBuilding == null) return NotFound("Building not found.");

            await _dbc.Entry(mapBuilding).Reference(mb => mb.Building).LoadAsync();
            if (mapBuilding.Building != null)
            {
                await _dbc.Entry(mapBuilding.Building).Collection(b => b.Levels).LoadAsync();
            }

            // Restore free space
            GameState? gameState = await _dbc.GameStates.FirstOrDefaultAsync(gs => gs.BuildingMapId == mapId);
            if (gameState != null)
            {
                gameState.FreeSpace += mapBuilding.Building.BaseWidth * mapBuilding.Building.BaseHeight;
                gameState.MaxPopulation -= mapBuilding.Building.Levels.FirstOrDefault(l => l.Level == mapBuilding.Level)?.Capacity ?? 0;
                if (gameState.Population > gameState.MaxPopulation) gameState.Population = gameState.MaxPopulation;
                _dbc.GameStates.Update(gameState);
            }

            _dbc.MapBuildings.Remove(mapBuilding);
            await _dbc.SaveChangesAsync();
            _dbc.ChangeTracker.Clear();
            GameState? UpdatedGameState = await _dbc.GameStates
                .AsNoTracking()
                .Include(gs => gs.BuildingMap)
                .ThenInclude(m => m.Buildings)
                .ThenInclude(mb => mb.Building)
                .ThenInclude(b => b.Levels)
                .Include(gs => gs.BuildingMap)
                .ThenInclude(m => m.Tiles)
                .ThenInclude(mt => mt.Tile)
                .FirstOrDefaultAsync(gs => gs.PlayerId == gameState.PlayerId);
            return Ok(UpdatedGameState);
        }
    }
}