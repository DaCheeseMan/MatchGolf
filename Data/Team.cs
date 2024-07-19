using System.ComponentModel.DataAnnotations;

namespace MatchGolf.Data
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = default!;
    }
}
