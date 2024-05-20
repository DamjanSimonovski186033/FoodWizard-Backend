using FoodWizardAPI.Models;

namespace FoodWizardAPI.Repositories.Interface
{
    public interface IngredientIRepository
    {
        IEnumerable<Ingredient> GetAll();
        Ingredient Get(Guid? id);
        Ingredient Insert(Ingredient entity);
        List<Ingredient> InsertMany(List<Ingredient> entities);
        Ingredient Update(Ingredient entity);
        Ingredient Delete(Ingredient entity);
    }

}
