using EventManagement.Api.Models;
using EventManagement.Api.Repositories;

namespace EventManagement.Api.Services
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IRegistrationRepository _repository;

        public RegistrationService(IRegistrationRepository repository)
        {
            _repository = repository;
        }

        public async Task<Registration> RegisterAsync(int eventId, int userId)
        {
            var registration = new Registration
            {
                EventId = eventId,
                UserId = userId
            };

            return await _repository.AddAsync(registration);
        }
    }
}