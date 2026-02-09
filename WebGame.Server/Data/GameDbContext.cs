using Microsoft.EntityFrameworkCore;
using WebGame.Server.Models;
using WebGame.Server.Utils;

namespace WebGame.Server.Data
{
    public class GameDbContext : DbContext
    {
        // Models
        public GameDbContext(DbContextOptions<GameDbContext> options) : base(options) { }
        public DbSet<Building> Buildings { get; set; } = null!;
        public DbSet<GameState> GameStates { get; set; }
        public DbSet<Tile> Tiles { get; set; } = null!;
        public DbSet<Map> Maps { get; set; } = null!;
        public DbSet<MapTile> MapTiles { get; set; } = null!;
        public DbSet<MapBuilding> MapBuildings { get; set; } = null!;
        public DbSet<BuildingLevel> BuildingLevels { get; set; } = null!;
        public DbSet<Resource> Resources { get; set; } = null!;
        // Data
        private void SeedResources(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Resource>().HasData(
              new Resource { ResourceId = 1, Name = "Ovce", Description = "Popis ovce" },
              new Resource { ResourceId = 2, Name = "Populace", Description = "Popis populace" },
              new Resource { ResourceId = 3, Name = "Vojsko", Description = "Popis vojska" }
            );
        }
        private void SeedBuildings(ModelBuilder modelBuilder)
        {
            Building[] buildings = [
                new Building { BuildingId = 1, Name = "Radnice", Description = "Popis radnice", IsTownHall = true, Width = 10, Height = 7, ResourceId = 2, BaseHeight=6, BaseWidth=10},
                new Building { BuildingId = 2, Name = "Domek", Description = "Popis domu", Width = 4, Height = 6, InitialCost = 5, ResourceId = 2, BaseHeight=3, BaseWidth=4 },
                new Building { BuildingId = 3, Name = "Kostel", Description = "Popis kostelu", Width = 6, Height = 9, InitialCost = 12, ResourceId = 2, BaseHeight=5, BaseWidth=6 },
                new Building { BuildingId = 4, Name = "Střelnice", Description = "Popis střelnice", Width = 6, Height = 7, InitialCost = 10, ResourceId = 3, BaseHeight=5, BaseWidth=6 },
                new Building { BuildingId = 5, Name = "Zbrojírna", Description = "Popis zbrojírny", Width = 6, Height = 7, InitialCost = 15, ResourceId = 3, BaseHeight=5, BaseWidth=6 },
                new Building { BuildingId = 6, Name = "Věž", Description = "Popis věže", Width = 4, Height = 7, InitialCost = 8, ResourceId = 3, BaseHeight=3, BaseWidth=4 }
            ];
            modelBuilder.Entity<Building>().HasData(buildings);

            // Generate building levels from buildings array
            List<BuildingLevel> levels = new List<BuildingLevel>();
            foreach (var building in buildings)
            {
                for (int level = 1; level <= 10; level++)
                {
                    int populationRequirement = 0;
                    if (building.IsTownHall)
                    {
                        if (level == 1) populationRequirement = 100;
                        else populationRequirement = 100 + level * 25;
                    } 
                    levels.Add(new BuildingLevel
                    {
                        BuildingId = building.BuildingId,
                        Level = level,
                        UpgradeCost = 5 + (level * 3),  
                        Capacity = (building.BaseWidth * building.BaseHeight / 4) + (level * 2),  
                        PopulationCost = populationRequirement
                    });
                }
            }
            modelBuilder.Entity<BuildingLevel>().HasData(levels);
        }
        private void SeedTiles(ModelBuilder modelBuilder)
        {
            List<Tile> tiles = new List<Tile>();
            int highestId = 107;
            int[] idsToSkip = {4, 13, 22, 31, 40, 49, 58, 67, 76, 85, 94, 103, 91, 92, 100, 101, 37, 38, 46, 47};
            int[] nonPlacableTiles = {32, 33, 34, 35, 36, 45, 50, 51, 52, 53, 39, 48, 86, 87, 88, 89, 90, 99, 93, 102, 104, 105, 106, 107};

            int[] northEdges = {55,54,56,59,60,61,6,7,82,83,81,84};
            int[] eastEdges = {56,65,74,7,16,25,70,79,61,25,11,83,75,84};
            int[] westEdges = {72,63,72,54,14,23,9,59,68,77,75,81,84};
            int[] southEdges = {72,73,74,24,23,25,77,78,79,82,83,75,81,84};

            for (int id = 1; id <= highestId; id++)
            {
                if (idsToSkip.Contains(id)) continue;
                tiles.Add(new Tile
                {
                    TileId = id,
                    IsEdgeNorth = northEdges.Contains(id),
                    IsEdgeSouth = southEdges.Contains(id),
                    IsEdgeEast = eastEdges.Contains(id),
                    IsEdgeWest = westEdges.Contains(id),
                    IsPlaceable = !nonPlacableTiles.Contains(id)
                });
            }
            modelBuilder.Entity<Tile>().HasData(tiles);
        }
        private void SeedDefaultMaps(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Map>().HasData(
                new Map { MapId = 1, Title = "Default ground layer" }
            );

            List<MapTile> mapTiles = new List<MapTile>();
            // order of csvs represents map layers from bottom to top
            List<string> csvPaths = [
                Path.Combine("wwwroot", "1.csv"),
                Path.Combine("wwwroot", "2.csv"),
                Path.Combine("wwwroot", "3.csv"),
                Path.Combine("wwwroot", "4.csv"),
                Path.Combine("wwwroot", "5.csv"),
            ];

            for (int layerIndex = 0; layerIndex < csvPaths.Count; layerIndex++)
            {
                string csvPath = csvPaths[layerIndex];
                int zIndex = layerIndex + 1;
            
                ReadCsv.RunForEachValue(csvPath, (value, x, y) =>
                {
                    if (int.TryParse(value, out int tileId))
                    {
                        if (tileId == -1) return;
                        mapTiles.Add(new MapTile
                        {
                            MapTileId = mapTiles.Count + 1,
                            TileId = tileId,
                            MapId = 1,
                            ZIndex = zIndex,
                            X = x,
                            Y = y
                        });
                    }
                }); 
            }
            modelBuilder.Entity<MapTile>().HasData(mapTiles);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedResources(modelBuilder);
            SeedBuildings(modelBuilder);
            SeedTiles(modelBuilder);
            SeedDefaultMaps(modelBuilder);
        }
    }
}