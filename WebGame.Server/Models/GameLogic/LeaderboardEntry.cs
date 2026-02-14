using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebGame.Server.Models
{
    public class LeaderboardEntry
    {
        [Key]
        public int LeaderboardEntryId { get; set; }
        [Required]
        [MaxLength(16)]
        public string Nickname { get; set; } = string.Empty;
        public int TimeInSeconds { get; set; }
        public DateTime CompletedAt { get; set; } = DateTime.UtcNow;
        [Required]
        public string PlayerId { get; set; } = string.Empty;
        [ForeignKey(nameof(PlayerId))]
        public GameState? GameState { get; set; }
    }
}