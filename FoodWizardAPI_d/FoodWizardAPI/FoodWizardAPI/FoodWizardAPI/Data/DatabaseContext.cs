using FoodWizardAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodWizardAPI.Data
{
    public class DatabaseContext : IdentityDbContext<User>
    {
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<PersonalizedIngredient> PersonalizedIngredients { get; set; }
        public DbSet<Recepie> Recepies { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
