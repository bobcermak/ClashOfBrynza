using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebGame.Server.Models
{
    [PrimaryKey(nameof(MapId), nameof(BottomLeftX), nameof(BottomLeftY))]
    public class MapBuilding
    {
        public int BuildingId { get; set; }
        [ForeignKey(nameof(BuildingId))]
        public Building Building{ get; set; } = null!;
        public int MapId { get; set; }
        public int BottomLeftX { get; set; }
        public int BottomLeftY { get; set; }
        public int Level { get; set; } = 1; 
    }
}