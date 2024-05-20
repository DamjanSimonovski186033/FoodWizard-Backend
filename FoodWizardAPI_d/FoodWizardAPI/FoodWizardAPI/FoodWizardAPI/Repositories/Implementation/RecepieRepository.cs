    using FoodWizardAPI.Data;
    using FoodWizardAPI.Models;
    using FoodWizardAPI.Repositories.Interface;
    using FoodWizardAPI.Services.Implementation;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace FoodWizardAPI.Repositories.Implementation
    {
        public class RecepieRepository : RecepieIRepository
        {
            private readonly DatabaseContext _context;
            private DbSet<Recepie> _recipes;
            private readonly UserService userService;

            public RecepieRepository(DatabaseContext context, UserService _userService)
            {
                _context = context;
                _recipes = context.Set<Recepie>();
                userService = _userService;
            }

            public Recepie Delete(Recepie entity)
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity));
                }
                _recipes.Remove(entity);
                _context.SaveChanges();
                return entity;
            }

            public Recepie Get(Guid? id)
            {
                return _recipes
                    .Include(r => r.PersonalizedIngredients)
                    .FirstOrDefault(r => r.Id == id);
            }

        public List<Recepie> GetAll()
        {   
            return _recipes
                .Include(r => r.PersonalizedIngredients)
                .ToList();
        }

        public Recepie Insert(Recepie entity)
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity));
                }
                _recipes.Add(entity);
                _context.SaveChanges();
                return entity;
            }

            public List<Recepie> InsertMany(List<Recepie> entities)
            {
                if (entities == null)
                {
                    throw new ArgumentNullException(nameof(entities));
                }
                _recipes.AddRange(entities);
                _context.SaveChanges();
                return entities;
            }

            public Recepie Update(Recepie entity)
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity));
                }
                _recipes.Update(entity);
                _context.SaveChanges();
                return entity;
            }

            public async void MarkAsFavorite(Guid recipeId, string userId)
            {
                var user = await userService.GetUserById(userId);
                var recipe = Get(recipeId);
                if (recipe != null)
                {
                    if(user.FavoriteRecepies == null)
                    {
                        user.FavoriteRecepies = new List<Recepie>();
                    }
                    user.FavoriteRecepies.Add(recipe);
                    _context.SaveChanges();
                }
            }

            public async void RemoveFromFavorites(Guid recipeId, string userId)
            {
                var user = await userService.GetUserById(userId);
                var recipe = Get(recipeId);
                if (recipe != null)
                {
                    if (user.FavoriteRecepies == null)
                    {
                        user.FavoriteRecepies = new List<Recepie>();
                    }
                    user.FavoriteRecepies.Remove(recipe);
                    _context.SaveChanges();
                }
            }

            public async Task<IEnumerable<Recepie>> GetFavoriteRecipes(string userId)
            {
                var user = await userService.GetUserById(userId);
                return user.FavoriteRecepies;

            }
            public void RateRecepie(Guid recipeId, int rating)
            {
                var recipe = _recipes.FirstOrDefault(r => r.Id == recipeId);
                if (recipe != null)
                {
                    recipe.Rating = rating;
                    _context.SaveChanges();
                }
                else
                {
                    throw new ArgumentException("Recipe not found");
                }
            }
        }
    }
