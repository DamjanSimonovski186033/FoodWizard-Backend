using FoodWizardAPI.Data;
using FoodWizardAPI.Models;
using FoodWizardAPI.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace FoodWizardAPI.Repositories.Implementation
{
    public class IngredientRepository : IngredientIRepository
    {

        private readonly DatabaseContext context;
        private DbSet<Ingredient> Ingredients;

        public IngredientRepository(DatabaseContext context)
        {
            this.context = context;
            Ingredients = context.Set<Ingredient>();
        }
        public Ingredient Delete(Ingredient entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            Ingredients.Remove(entity);
            context.SaveChanges();
            return entity;

        }

        public Ingredient Get(Guid? id)
        {
             return Ingredients.First(s => s.Id == id);
        }

        public IEnumerable<Ingredient> GetAll()
        {
            return Ingredients.AsEnumerable();
        }

        public Ingredient Insert(Ingredient entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            Ingredients.Add(entity);
            context.SaveChanges();
            return entity;

        }

        public List<Ingredient> InsertMany(List<Ingredient> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entities");
            }
            Ingredients.AddRange(entities);
            context.SaveChanges();
            return entities;

        }

        public Ingredient Update(Ingredient entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            Ingredients.Update(entity);
            context.SaveChanges();
            return entity;

        }
    }
}
