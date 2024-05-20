using FoodWizardAPI.Models;

namespace FoodWizardAPI.Services.Interface
{
    public interface RecepieIService
    {
        public IEnumerable<Recepie> GetAllRecepies();
        public Recepie GetRecepieById(Guid? id);
        public Recepie CreateNewRecepie(Recepie recepie);
        public Recepie UpdateRecepie(Recepie recepie);
        public Recepie DeleteRecepie(Guid id);
        void AddToFavorites(Guid recipeId, string userId);
        void RemoveFromFavorites(Guid recipeId, string userId);
        IEnumerable<Recepie> GetFavoriteRecipes(string userId);
        void RateRecepie(Guid recipeId, int rating);

    }
}
