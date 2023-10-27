using Infrastructure.Data.Postgres.Entities;

namespace Business.Models.Response;

public class UserProfileDto
{
    public int Id { get; set; } = default!;
    public string FullName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public double Balance { get; set; }
    public UserType UserType { get; set; }
    public DateTime CreatedAt { get; set; }
}