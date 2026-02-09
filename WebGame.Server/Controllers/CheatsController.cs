using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebGame.Server.Data;
using WebGame.Server.Models;

namespace WebGame.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CheatsController : ControllerBase
    {
        private readonly GameDbContext _dbc;
        public CheatsController(GameDbContext context)
        {
            _dbc = context;
        }

        [HttpGet("getMoney/{playerId}/{amount}")]
        public async Task<ActionResult<GameState>> GetMoney(string playerId, int amount)
        {
            var gameState = await _dbc.GameStates.FirstOrDefaultAsync(gs => gs.PlayerId == playerId);
            if (gameState == null)
            {
                return NotFound("Nebyl nalezen žádný herní stav pro dané ID hráče.");
            }

            gameState.Sheep += amount;
            await _dbc.SaveChangesAsync();

            return Ok(gameState);
        }
    }
}