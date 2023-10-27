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
	public class MessageConfiguration : IEntityTypeConfiguration<Message>
	{
		public void Configure(EntityTypeBuilder<Message> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.FirstUserId).IsRequired();
			builder.Property(x => x.SecondUserId).IsRequired();

			builder.HasOne(m => m.FirstUser)
				.WithMany(u => u.MyMessages)
				.HasForeignKey(m => m.FirstUserId);

			builder.HasOne(m => m.SecondUser)
				.WithMany(u => u.ComingMessages)
				.HasForeignKey(m => m.SecondUserId);



		}
	}
}
