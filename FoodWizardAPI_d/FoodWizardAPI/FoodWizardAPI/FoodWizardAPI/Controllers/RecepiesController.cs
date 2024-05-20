using FoodWizardAPI.Services.Implementation;
using FoodWizardAPI.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FoodWizardAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RecepiesController : ControllerBase
    {
        private readonly RecepieService _recepieService;

        public RecepiesController(RecepieService recepieService)
        {
            _recepieService = recepieService;
        }

        [HttpGet]
        public IActionResult GetAllRecepies()
        {
            var recipes = _recepieService.GetAllRecepies();
            if (recipes == null)
            {
                return NotFound();
            }

            return Ok(recipes);
        }
        [HttpGet("{id}")]
        public IActionResult GetRecepieById(Guid? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var recipe = _recepieService.GetRecepieById(id);

            if (recipe == null)
            {
                return NotFound();
            }

            return Ok(recipe);
        }

        [HttpGet("{id}")]
        public IActionResult MarkAsFavorite(Guid id, [FromQuery] string userId)
        {
            _recepieService.AddToFavorites(id,userId);
            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult RemoveFromFavorites(Guid id, [FromQuery] string userId)
        {
            _recepieService.RemoveFromFavorites(id, userId);
            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult GetFavoriteRecipes(string id)
        {
            var favoriteRecipes = _recepieService.GetFavoriteRecipes(id);
            return Ok(favoriteRecipes);
        }

        [HttpGet("{id}")]
        public IActionResult RateRecipe(Guid id, [FromQuery] int rating)
        {
            _recepieService.RateRecepie(id, rating);
            return Ok();
        }
    }
}