using System.ComponentModel.DataAnnotations;

namespace MatchGolf.Data
{
    public class Tournament
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = default!;

        public List<Team> Teams { get; set; } = default!;

        public List<Match> Matches { get; set; } = default!;
    }
}
