using FoodWizardAPI.Data;
using FoodWizardAPI.Models;
using FoodWizardAPI.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace FoodWizardAPI.Repositories.Implementation
{
    public class PersonalizedIngredientRepository : PersonalizedIngredientIRepository
    {
        private readonly DatabaseContext context;
        private DbSet<PersonalizedIngredient> PersonalizedIngredients;

        public PersonalizedIngredientRepository(DatabaseContext context)
        {
            this.context = context;
            PersonalizedIngredients = context.Set<PersonalizedIngredient>();
        }
        public PersonalizedIngredient Delete(PersonalizedIngredient entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            PersonalizedIngredients.Remove(entity);
            context.SaveChanges();
            return entity;

        }

        public PersonalizedIngredient Get(Guid? id)
        {
            return PersonalizedIngredients.First(s => s.Id == id);
        }

        public IEnumerable<PersonalizedIngredient> GetAll()
        {
            return PersonalizedIngredients.AsEnumerable();
        }

        public PersonalizedIngredient Insert(PersonalizedIngredient entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            PersonalizedIngredients.Add(entity);
            context.SaveChanges();
            return entity;

        }

        public List<PersonalizedIngredient> InsertMany(List<PersonalizedIngredient> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entities");
            }
            PersonalizedIngredients.AddRange(entities);
            context.SaveChanges();
            return entities;

        }

        public PersonalizedIngredient Update(PersonalizedIngredient entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            PersonalizedIngredients.Update(entity);
            context.SaveChanges();
            return entity;
        }
    }
}
