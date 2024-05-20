using FoodWizardAPI.Models;

namespace FoodWizardAPI.Services.Interface
{
    public interface UserIService
    {
        Task<User> GetUserById(string id);
        Task<User> GetUserByEmail(string email);
        Task<User> CreateUser(User user);
        Task<User> UpdateUser(User user);
        Task DeleteUser(string id);
    }
}
