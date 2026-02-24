using EventManagement.Api.Models;
using EventManagement.Api.Repositories;


public interface IUserService
{
    Task<IEnumerable<User>> GetAllAsync();
    Task<User?> GetByIdAsync(int id);
    Task<User> CreateAsync(User user);
}