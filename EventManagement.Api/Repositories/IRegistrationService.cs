using EventManagement.Api.Data;
using EventManagement.Api.Models;
using Microsoft.EntityFrameworkCore;

public interface IRegistrationService
{
    Task<Registration> CreateAsync(int eventId, int userId);
}