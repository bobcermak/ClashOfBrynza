using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebGame.Server.Models
{
    public class GameState
    {  
        [Key]
        public string PlayerId { get; set; }
        public int MaxSheep => FreeSpace / 10 + Level * 25;
        public int Sheep { get; set; }
        public int Population { get; set; }
        public int FreeSpace { get; set; }
        public int MaxPopulation { get; set; }
        public DateTime LastUpdated { get; set; }
        public int Level { get; set; } = 1;
        public int BuildingMapId { get; set; }
        [ForeignKey(nameof(BuildingMapId))]
        public Map BuildingMap { get; set; }
    }
}