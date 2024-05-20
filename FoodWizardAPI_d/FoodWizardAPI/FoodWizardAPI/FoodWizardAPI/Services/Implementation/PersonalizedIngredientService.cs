using FoodWizardAPI.Models;
using FoodWizardAPI.Repositories.Implementation;
using FoodWizardAPI.Repositories.Interface;
using FoodWizardAPI.Services.Interface;

namespace FoodWizardAPI.Services.Implementation
{
    public class PersonalizedIngredientService : PersonalizedIngredientIService
    {
        private PersonalizedIngredientRepository _personalizedIngredientRepository;

        public PersonalizedIngredientService(PersonalizedIngredientRepository personalizedIngredientRepository)
        {
            _personalizedIngredientRepository = personalizedIngredientRepository;
        }

        public PersonalizedIngredient CreateNewRecepie(PersonalizedIngredient personalizedIngredient)
        {
            return _personalizedIngredientRepository.Insert(personalizedIngredient);
        }

        public PersonalizedIngredient DeleteRecepie(Guid id)
        {
            var personalized_ingredient_to_delete = this.GetRecepieById(id);
            return _personalizedIngredientRepository.Delete(personalized_ingredient_to_delete);
        }

        public List<PersonalizedIngredient> GetAllRecepies()
        {
            return _personalizedIngredientRepository.GetAll().ToList();
        }

        public PersonalizedIngredient GetRecepieById(Guid? id)
        {
            return _personalizedIngredientRepository.Get(id);
        }

        public PersonalizedIngredient UpdateRecepie(PersonalizedIngredient personalizedIngredient)
        {
            return _personalizedIngredientRepository.Update(personalizedIngredient);
        }
    }
}
