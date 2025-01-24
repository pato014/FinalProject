using Microsoft.AspNetCore.Identity;

namespace FinalProject.Models
{
    public class Users: IdentityUser
    {
        public string FirstName { get; set; }
        public string FullName {  get; set; }

        public string IdNumber { get; set; }
    }
}
