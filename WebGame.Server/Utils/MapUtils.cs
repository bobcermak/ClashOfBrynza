using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.StaticAssets;

namespace WebGame.Server.Models
{
    public static class MapUtils
    {   
        public static bool CanPlaceBuilding(MapBuilding buildingToPlace, MapBuilding[] buildings, MapTile[] tiles)
        {   
            foreach (MapBuilding building in buildings)
            {
                bool overlapX = (buildingToPlace.BottomLeftX + buildingToPlace.Building.BaseWidth > building.BottomLeftX) && (buildingToPlace.BottomLeftX < building.BottomLeftX + building.Building.BaseWidth);
                bool overlapY = (buildingToPlace.BottomLeftY + buildingToPlace.Building.BaseHeight > building.BottomLeftY) && (buildingToPlace.BottomLeftY < building.BottomLeftY + building.Building.BaseHeight);

                if (overlapX && overlapY) return false;
            }

            // check if all tiles under the building are placeable and don't cross edges
            int minX = buildingToPlace.BottomLeftX;
            int maxX = buildingToPlace.BottomLeftX + buildingToPlace.Building.BaseWidth - 1;
            int minY = buildingToPlace.BottomLeftY - buildingToPlace.Building.BaseHeight + 1;
            int maxY = buildingToPlace.BottomLeftY;

            for (int x = minX; x <= maxX; x++)
            {   
                for (int y = minY; y <= maxY; y++)
                {
                    // check if tile exist and it is placeable
                    var tilesAtLocation = tiles.Where(t => t.X == x && t.Y == y).ToArray();

                    if (tilesAtLocation.Length == 0 || tilesAtLocation.Any(t => !t.Tile.IsPlaceable))
                    {
                        return false;
                    }

                    // check if building cross an edge
                    var topTile = tilesAtLocation.OrderByDescending(t => t.ZIndex).First();
                    
                    if (topTile.Tile.IsEdgeNorth && y > minY) return false; 
                    if (topTile.Tile.IsEdgeSouth && y < maxY) return false; 
                    if (topTile.Tile.IsEdgeEast && x < maxX) return false;  
                    if (topTile.Tile.IsEdgeWest && x > minX) return false;  
                }
            }

            return true;
        }

        public static T[,] WriteRectTo2dArray<T>(T[,] array, int bottomLeftX, int bottomLeftY, int width, int height, T value)
        {
            for (int x = bottomLeftX; x < bottomLeftX + width; x++)
            {
                for (int y = bottomLeftY; y < bottomLeftY + height; y++)
                {
                    array[x, y] = value;
                }
            }
            return array;
        }
    }
}