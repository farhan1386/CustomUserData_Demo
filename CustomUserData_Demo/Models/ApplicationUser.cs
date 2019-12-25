using Microsoft.AspNetCore.Identity;

namespace CustomUserData_Demo.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
