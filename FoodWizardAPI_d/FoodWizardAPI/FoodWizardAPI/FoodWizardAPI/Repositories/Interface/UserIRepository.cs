using FoodWizardAPI.Models;

namespace FoodWizardAPI.Repositories.Interface
{
    public interface UserIRepository
    {
        Task<User> GetUserById(string id);
        Task<User> GetUserByEmail(string email);
        Task<User> CreateUser(User user);
        Task<User> UpdateUser(User user);
        Task DeleteUser(string id);
    }
}
