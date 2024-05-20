using FoodWizardAPI.Enums;
using FoodWizardAPI.Models;

namespace FoodWizardAPI.NewFolder
{
        public class RecepieRequest
        {
        public string? Name { get; set; }
        public RecepieType? Type { get; set; }
        public int? EstimatedTimeInMins { get; set; }
        public byte[]? Photo { get; set; }
        public string? VideoUrl { get; set; }
        public String? Instructions { get; set; }
        public IList<String>? Comments { get; set; }
        public IList<PersonalizedIngredient>? PersonalizedIngredients { get; set; }
    }
}
