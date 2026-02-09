using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebGame.Server.Models
{
    public class Building
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BuildingId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int? ResourceId { get; set; }
        [ForeignKey(nameof(ResourceId))]
        public Resource? Resource { get; set; }
        public bool IsTownHall { get; set; } = false;
        public int InitialCost { get; set; }
        public int Height { get; set; }
        public int BaseHeight { get; set; }
        public int Width { get; set; }
        public int BaseWidth { get; set; }
        public List<BuildingLevel> Levels { get; set; } = new List<BuildingLevel>();
        public string ImageUrl => $"/images/buildings/{BuildingId}.png";
    }
}
