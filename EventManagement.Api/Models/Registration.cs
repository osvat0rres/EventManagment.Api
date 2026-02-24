namespace EventManagement.Api.Models;

public class Registration
{
    public Guid Id { get; set; }
    public Guid EventId { get; set; }
    public Guid UserId { get; set; }
    public DateTime RegisteredAt { get; set; }
    public string Status { get; set; }  = string.Empty;
    public Event? Event { get; set; }
    public User? User { get; set; }
}

// I added this code 

public class Registration
{
    public int Id { get; set; }

    public int EventId { get; set; }
    public Event Event { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

    public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;
}