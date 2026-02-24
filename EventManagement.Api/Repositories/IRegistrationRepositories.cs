using EventManagement.Api.Data;
using EventManagement.Api.Models;
using Microsoft.EntityFrameworkCore;


namespace EventManagement.Api.Repositories
{
    public interface IRegistrationRepository
    {
        Task<Registration> AddAsync(Registration registration);
    }
}