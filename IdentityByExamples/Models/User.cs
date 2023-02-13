using Microsoft.AspNetCore.Identity;

namespace Test.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string BirthDate { get; set; }
    }
}
