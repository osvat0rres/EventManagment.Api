using Microsoft.AspNetCore.Mvc;
using EventManagement.Api.Services;

namespace EventManagement.Api.Controllers
{
    [ApiController]
    [Route("api/events/{eventId}/registrations")]
    public class RegistrationsController : ControllerBase
    {
        private readonly IRegistrationService _service;

        public RegistrationsController(IRegistrationService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Register(
            int eventId,
            [FromBody] int userId)
        {
            var registration =
                await _service.RegisterAsync(eventId, userId);

            return Created("", registration);
        }
    }
}