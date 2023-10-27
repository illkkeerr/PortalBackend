using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
	public class AccountHistoryConfiguration : IEntityTypeConfiguration<AccountHistory>
	{
		public void Configure(EntityTypeBuilder<AccountHistory> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.CustomerId).IsRequired();
			builder.Property(x=>x.ProcessType).IsRequired();
			builder.Property(x=>x.AmountOfMoney).IsRequired();
			builder.Property(x=>x.CustomerId).IsRequired();

			builder.HasOne(a => a.Customer)
				.WithMany(u => u.MyAccountHistory)
				.HasForeignKey(a => a.CustomerId);
			
			builder.HasOne(a => a.Receiver)
			.WithMany(u => u.ReceiverAccountHistory)
			.HasForeignKey(a => a.ReceiverId);



		}
	}
}
