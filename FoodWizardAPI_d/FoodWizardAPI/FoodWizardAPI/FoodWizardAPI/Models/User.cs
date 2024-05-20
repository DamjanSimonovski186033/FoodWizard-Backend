using FoodWizardAPI.Enums;
using Microsoft.AspNetCore.Identity;

namespace FoodWizardAPI.Models
{
    public class User : IdentityUser
    {
        public String? Name { get; set; }
        public String? Surname { get; set; }
        public int? Age { get; set; }
        public Gender? Gender { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public IList<Recepie>? FavoriteRecepies { get; set; }
    }
}
