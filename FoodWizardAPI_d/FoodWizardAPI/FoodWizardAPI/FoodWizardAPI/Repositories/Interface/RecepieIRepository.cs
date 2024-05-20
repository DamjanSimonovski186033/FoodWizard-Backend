using FoodWizardAPI.Models;

namespace FoodWizardAPI.Repositories.Interface
{
    public interface RecepieIRepository
    {
        List<Recepie> GetAll();
        Recepie Get(Guid? id);
        Recepie Insert(Recepie entity);
        List<Recepie> InsertMany(List<Recepie> entities);
        Recepie Update(Recepie entity);
        Recepie Delete(Recepie entity);
        void MarkAsFavorite(Guid recipeId, string userId);
        void RemoveFromFavorites(Guid recipeId, string userId);
        Task<IEnumerable<Recepie>> GetFavoriteRecipes(string userId);
        void RateRecepie(Guid recipeId, int rating);
    }
}
