using FoodWizardAPI.Models;

namespace FoodWizardAPI.Services.Interface
{
    public interface IngredientIService
    {
        public List<Ingredient> GetAllRecepies();
        public Ingredient GetRecepieById(Guid? id);
        public Ingredient CreateNewRecepie(Ingredient ingredient);
        public Ingredient UpdateRecepie(Ingredient ingredient);
        public Ingredient DeleteRecepie(Guid id);

    }
}
