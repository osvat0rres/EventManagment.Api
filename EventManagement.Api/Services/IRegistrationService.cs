using EventManagement.Api.Models;
using EventManagement.Api.Repositories;

public interface IRegistrationService
{
    Task<Registration> CreateAsync(int eventId, int userId);
}