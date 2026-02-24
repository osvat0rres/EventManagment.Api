using EventManagement.Api.Models;
using EventManagement.Api.Repositories;


public class UserService : IUserService
{
    private readonly IUserRepository _repository;

    public UserService(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<User?> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<User> CreateAsync(User user)
    {
        await _repository.AddAsync(user);
        await _repository.SaveChangesAsync();
        return user;
    }
}