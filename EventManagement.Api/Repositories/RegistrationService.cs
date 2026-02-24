using EventManagement.Api.Data;
using EventManagement.Api.Models;
using Microsoft.EntityFrameworkCore;

public class RegistrationService : IRegistrationService
{
    private readonly IRegistrationRepository _repository;

    public RegistrationService(IRegistrationRepository repository)
    {
        _repository = repository;
    }

    public async Task<Registration> CreateAsync(int eventId, int userId)
    {
        var registration = new Registration
        {
            EventId = eventId,
            UserId = userId
        };

        await _repository.AddAsync(registration);
        await _repository.SaveChangesAsync();

        return registration;
    }
}