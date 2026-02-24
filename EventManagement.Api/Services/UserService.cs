using EventManagement.Api.Models;
using EventManagement.Api.Repositories;

namespace EventManagement.Api.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<User>> GetAllAsync()
            => _repository.GetAllAsync();

        public Task<User?> GetByIdAsync(int id)
            => _repository.GetByIdAsync(id);

        public Task<User> CreateAsync(User user)
            => _repository.AddAsync(user);
    }
}