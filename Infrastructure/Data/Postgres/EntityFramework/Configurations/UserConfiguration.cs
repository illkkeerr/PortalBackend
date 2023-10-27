using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
	public void Configure(EntityTypeBuilder<User> builder)
	{
		builder.HasKey(x => x.Id);
		builder.Property(x => x.Email).IsRequired();
		builder.HasIndex(x => x.Email).IsUnique();
		builder.Property(x => x.FullName).IsRequired();
		builder.Property(x => x.PasswordHash).IsRequired();
		builder.Property(x => x.PasswordSalt).IsRequired();
		builder.Property(x => x.CreatedAt).IsRequired();
		builder.Property(x => x.IsDeleted).IsRequired();
		builder.Property(x => x.Balance).IsRequired();


		builder.HasMany(u => u.MyMessages)
			.WithOne(m => m.FirstUser)
			.HasForeignKey(m => m.FirstUserId);

		builder.HasMany(u => u.ComingMessages)
		   .WithOne(m => m.SecondUser)
		   .HasForeignKey(m => m.SecondUserId);

		builder.HasMany(u => u.MyAccountHistory)
			.WithOne(a => a.Customer)
			.HasForeignKey(a => a.CustomerId);

		builder.HasMany(u => u.ReceiverAccountHistory)
	.WithOne(a => a.Receiver)
	.HasForeignKey(a => a.ReceiverId);


	}
}