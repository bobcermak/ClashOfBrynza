using Microsoft.EntityFrameworkCore;

namespace WebGame.Server.Models
{
    [PrimaryKey(nameof(BuildingId), nameof(Level))]
    public class BuildingLevel
    {
        public int BuildingId { get; set; }
        public int Level { get; set; }
        public int UpgradeCost { get; set; }
        public int Capacity { get; set; }
        public int PopulationCost { get; set; }
    }
}