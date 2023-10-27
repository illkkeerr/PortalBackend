using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class User : Entity<int>
{
    public string Email { get; set; } = default!;
    public string FullName { get; set; } = default!;
    public byte[] PasswordSalt { get; set; } = default!;
    public byte[] PasswordHash { get; set; } = default!;
    public UserType UserType { get; set; } = UserType.Customer;
    public string? Profession { get; set; }
    public double Balance { get; set; } = 0;

    public IList<Message> MyMessages { get; set; }
    public IList<Message> ComingMessages { get; set; }
    public IList <AccountHistory> MyAccountHistory  { get; set; }
    public IList <AccountHistory> ReceiverAccountHistory  { get; set; }

}

public enum UserType
{
    Admin,
    Employee,
    Customer    
}