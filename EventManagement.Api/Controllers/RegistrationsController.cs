using Microsoft.AspNetCore.Mvc;
using EventManagement.Api.Models;
using EventManagement.Api.Services;



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
    public async Task<ActionResult> Create(int eventId, [FromBody] int userId)
    {
        var registration = await _service.CreateAsync(eventId, userId);

        return StatusCode(201, registration);
    }
}