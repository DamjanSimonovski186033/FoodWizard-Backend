using Microsoft.AspNetCore.Identity;

namespace FoodWizardAPI.Models
{
    public class Login : IdentityUser
    {
        public String Password { get; set; }
        public String Email { get; set; }
        public bool RememberMe { get; set; }
    }
}
