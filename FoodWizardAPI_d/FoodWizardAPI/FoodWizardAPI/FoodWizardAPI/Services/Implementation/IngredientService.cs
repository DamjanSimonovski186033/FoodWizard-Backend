using FoodWizardAPI.Models;
using FoodWizardAPI.Repositories.Implementation;
using FoodWizardAPI.Repositories.Interface;
using FoodWizardAPI.Services.Interface;

namespace FoodWizardAPI.Services.Implementation
{
    public class IngredientService : IngredientIService
    {
        private IngredientRepository _ingredeintRepository;

        public IngredientService(IngredientRepository ingredeintRepository)
        {
            _ingredeintRepository = ingredeintRepository;
        }

        public Ingredient CreateNewRecepie(Ingredient ingredient)
        {
            return _ingredeintRepository.Insert(ingredient);
        }

        public Ingredient DeleteRecepie(Guid id)
        {
            var ingredient_to_delete = this.GetRecepieById(id);
            return _ingredeintRepository.Delete(ingredient_to_delete);
        }

        public List<Ingredient> GetAllRecepies()
        {
            return _ingredeintRepository.GetAll().ToList();
        }

        public Ingredient GetRecepieById(Guid? id)
        {
            return _ingredeintRepository.Get(id);
        }

        public Ingredient UpdateRecepie(Ingredient ingredient)
        {
            return _ingredeintRepository.Update(ingredient);
        }
    }
}
