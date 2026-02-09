using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebGame.Server.Models
{
    public class MapTile
    {
        [Key]
        public int MapTileId { get; set; }
        public int TileId { get; set; }
        [ForeignKey(nameof(TileId))]
        public Tile Tile { get; set; } = null!;
        public int MapId { get; set; }
        public int ZIndex { get; set; } = 1;
        public int X { get; set; }
        public int Y { get; set; }
    }
}