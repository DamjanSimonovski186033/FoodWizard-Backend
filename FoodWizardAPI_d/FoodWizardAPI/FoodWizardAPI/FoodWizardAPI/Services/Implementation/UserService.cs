using FoodWizardAPI.Models;
using FoodWizardAPI.Repositories.Implementation;
using FoodWizardAPI.Repositories.Interface;
using FoodWizardAPI.Services.Interface;

namespace FoodWizardAPI.Services.Implementation
{
    public class UserService : UserIService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> CreateUser(User user)
        {
            var existingUser = await _userRepository.GetUserByEmail(user.Email);
            if (existingUser != null)
            {
                throw new InvalidOperationException("User with this email already exists.");
            }

            var newUser = new User
            {
                Email = user.Email,
            };
            await _userRepository.CreateUser(newUser);

            return newUser;
        }

        public async Task DeleteUser(string id)
        {
            var userToDelete = await _userRepository.GetUserById(id);
            if (userToDelete == null)
            {
                throw new KeyNotFoundException("User not found.");
            }

            await _userRepository.DeleteUser(id);
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await _userRepository.GetUserByEmail(email);
        }

        public async Task<User> GetUserById(string id)
        {
            return await _userRepository.GetUserById(id);
        }

        public async Task<User> UpdateUser(User user)
        {
            var existingUser = await _userRepository.GetUserById(user.Id);
            if (existingUser == null)
            {
                throw new KeyNotFoundException("User not found.");
            }

            return await _userRepository.UpdateUser(user);
        }
    }
}
