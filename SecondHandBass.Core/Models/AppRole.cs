using Microsoft.AspNetCore.Identity;
using SecondHandBass.Core.Enums;

namespace SecondHandBass.Core.Models
{
    public class AppRole : IdentityRole
    {
        public string? RoleName { get; set; }
        public RoleType RoleType { get; set; }
    }
}
