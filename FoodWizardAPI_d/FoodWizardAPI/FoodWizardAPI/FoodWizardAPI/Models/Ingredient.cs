
using FoodWizardAPI.Enums;

namespace FoodWizardAPI.Models
{
    public class Ingredient
    {
        public Guid Id { get; set; }
        public String? Name { get; set; }
        public Metric? Metric { get; set; }
        public IList<PersonalizedIngredient>? PersonalizedIngredients { get; set;}
    }
}

