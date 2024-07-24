﻿using System.ComponentModel.DataAnnotations;

namespace MatchGolf.Data
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; } = default!;
        
        public List<User> Users { get; set; } = default!;
        
        public List<Tournament> Tournaments { get; set; } = default!;
    }
}
