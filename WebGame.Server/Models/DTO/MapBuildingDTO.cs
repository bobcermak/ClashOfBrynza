namespace WebGame.Server.Models
{
    public class MapBuildingDTO
    {
        public string PlayerId { get; set; }
        public int BuildingId { get; set; }
        public int BottomLeftX { get; set; }
        public int BottomLeftY { get; set; }
    }
}