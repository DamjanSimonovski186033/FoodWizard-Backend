using FoodWizardAPI.Data;
using FoodWizardAPI.Repositories.Implementation;
using Microsoft.EntityFrameworkCore;
using FoodWizardAPI.Services.Implementation;
using Microsoft.AspNetCore.Identity;
using FoodWizardAPI.Models;

namespace FoodWizardAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddControllers();

            builder.Services.AddDbContext<DatabaseContext>(options =>
            {
                options.UseSqlServer("Data Source=MARKO\\SQLEXPRESS; Database=FoodwizardDb; Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            });

            builder.Services.AddScoped<IngredientRepository>();
            builder.Services.AddScoped<PersonalizedIngredientRepository>();
            builder.Services.AddScoped<RecepieRepository>();
            builder.Services.AddScoped<UserRepository>();

            builder.Services.AddTransient<IngredientService>();
            builder.Services.AddTransient<PersonalizedIngredientService>();
            builder.Services.AddTransient<RecepieService>();
            builder.Services.AddTransient<UserService>();

            builder.Services.AddIdentity<User, IdentityRole>(options =>
            {
                // Configure identity options if needed
            })
            .AddEntityFrameworkStores<DatabaseContext>()
            .AddDefaultTokenProviders();

            var app = builder.Build();


            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();
            app.MapRazorPages();

            app.Run();
        }
    }
}
