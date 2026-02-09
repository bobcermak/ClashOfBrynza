using System.ComponentModel.DataAnnotations;

namespace WebGame.Server.Models
{
    public class Tile
    {
        [Key]
        public int TileId { get; set; }
        public bool IsPlaceable { get; set; } = false;
        public string ImageUrl => $"/images/tiles/{TileId}.png";

        // edge detection
        public bool IsEdgeNorth { get; set; }
        public bool IsEdgeSouth { get; set; }
        public bool IsEdgeEast { get; set; }
        public bool IsEdgeWest { get; set; }
    }
}