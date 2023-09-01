using Microsoft.AspNetCore.Identity;
using SecondHandBass.Core.Enums;

namespace SecondHandBass.Core.Models
{
    public class AppUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public Gender? Gender { get; set; }
        public int CityId { get; set; }
        public bool IsSuspended { get; set; } = false;
    }
}
