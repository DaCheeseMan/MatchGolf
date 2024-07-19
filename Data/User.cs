using Microsoft.AspNetCore.Identity;

namespace MatchGolf.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class User : IdentityUser
    {
        [PersonalData]
        public string? Name { get; set; }

        [PersonalData]
        public Team? Team { get; set; }
    }
}
