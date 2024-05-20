using FoodWizardAPI.Models;

namespace FoodWizardAPI.Services.Interface
{
    public interface PersonalizedIngredientIService
    {
        public List<PersonalizedIngredient> GetAllRecepies();
        public PersonalizedIngredient GetRecepieById(Guid? id);
        public PersonalizedIngredient CreateNewRecepie(PersonalizedIngredient personalizedIngredient);
        public PersonalizedIngredient UpdateRecepie(PersonalizedIngredient personalizedIngredient);
        public PersonalizedIngredient DeleteRecepie(Guid id);
    }
}
