using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MatchGolf.Data
{
    public class Match
    {
        [Key]
        public int Id { get; set; }
        
        public Tournament? Tournament { get; set; } = null;
        
        public string Name { get; set; } = default!;
        
        public DateOnly Date { get; set; }
        
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Team Team1 { get; set; } = default!;

        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Team Team2 { get; set; } = default!;

        public Score Score { get; set; } = default!;
    }
}
