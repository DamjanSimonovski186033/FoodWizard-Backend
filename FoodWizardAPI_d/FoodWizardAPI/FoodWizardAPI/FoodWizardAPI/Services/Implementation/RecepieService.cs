using FoodWizardAPI.Models;
using FoodWizardAPI.Repositories.Implementation;
using FoodWizardAPI.Services.Interface;

namespace FoodWizardAPI.Services.Implementation
{
    public class RecepieService : RecepieIService
    {
        private RecepieRepository _recepieRepository;

        public RecepieService(RecepieRepository recepieRepository)
        {
            _recepieRepository = recepieRepository;
        }

        public Recepie CreateNewRecepie(Recepie recepie)
        {
            return _recepieRepository.Insert(recepie);
        }

        public Recepie DeleteRecepie(Guid id)
        {
            var recepie_to_delete = this.GetRecepieById(id);
            return _recepieRepository.Delete(recepie_to_delete);

        }

        public IEnumerable<Recepie> GetAllRecepies()
        {
            return _recepieRepository.GetAll();
        }

        public Recepie GetRecepieById(Guid? id)
        {
            return _recepieRepository.Get(id);
        }

        public Recepie UpdateRecepie(Recepie recepie)
        {
            return _recepieRepository.Update(recepie);
        }
        public void AddToFavorites(Guid recipeId, string userId)
        {
            _recepieRepository.MarkAsFavorite(recipeId, userId);
        }

        public void RemoveFromFavorites(Guid recipeId, string userId)
        {
            _recepieRepository.RemoveFromFavorites(recipeId, userId);
        }

        public IEnumerable<Recepie> GetFavoriteRecipes(string userId)
        {
            return _recepieRepository.GetFavoriteRecipes(userId).Result;
        }

        public void RateRecepie(Guid id, int rating)
        {
            _recepieRepository.RateRecepie(id, rating);
        }
    }
}


    
