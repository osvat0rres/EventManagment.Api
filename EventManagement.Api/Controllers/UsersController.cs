using Microsoft.AspNetCore.Mvc;
using EventManagement.Api.Models;
using EventManagement.Api.Services;


[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _service;

    public UsersController(IUserService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetAll()
    {
        var users = await _service.GetAllAsync();
        return Ok(users); // 200
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetById(int id)
    {
        var user = await _service.GetByIdAsync(id);

        if (user == null)
            return NotFound(); // 404

        return Ok(user); // 200
    }

    [HttpPost]
    public async Task<ActionResult<User>> Create(User user)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState); // 400

        var createdUser = await _service.CreateAsync(user);

        return CreatedAtAction(nameof(GetById), new { id = createdUser.Id }, createdUser); // 201
    }
}