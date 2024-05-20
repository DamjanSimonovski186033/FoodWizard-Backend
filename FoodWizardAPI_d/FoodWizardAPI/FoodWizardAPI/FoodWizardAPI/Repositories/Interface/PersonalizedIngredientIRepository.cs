using FoodWizardAPI.Models;

namespace FoodWizardAPI.Repositories.Interface
{
    public interface PersonalizedIngredientIRepository
    {
        IEnumerable<PersonalizedIngredient> GetAll();
        PersonalizedIngredient Get(Guid? id);
        PersonalizedIngredient Insert(PersonalizedIngredient entity);
        List<PersonalizedIngredient> InsertMany(List<PersonalizedIngredient> entities);
        PersonalizedIngredient Update(PersonalizedIngredient entity);
        PersonalizedIngredient Delete(PersonalizedIngredient entity);
    }
}
