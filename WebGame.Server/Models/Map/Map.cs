using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebGame.Server.Models
{
    public class Map
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MapId { get; set; }
        public string Title { get; set; } = string.Empty;

        public List<MapBuilding> Buildings { get; set; } = new List<MapBuilding>();
        public List<MapTile> Tiles { get; set; } = new List<MapTile>();
    }
}