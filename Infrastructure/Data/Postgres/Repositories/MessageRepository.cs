using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Repositories
{
	public class MessageRepository : Repository<Message, int>, IMessageRepository
	{
		public MessageRepository(PostgresContext postgresContext) : base(postgresContext)
		{
		}

		public async Task<IList<Message>> GetAllAsync(Expression<Func<Message, bool>>? filter = null)
		{
			IQueryable<Message> messageQuery = PostgresContext.Set<Message>();

			if (filter != null)
			{
				messageQuery = messageQuery.Where(filter);
			}

			//İlişkiler arasındaki iletişimi sağlar
			var message = await messageQuery
				.Include(r => r.FirstUser)
				.Include(r => r.SecondUser)

				.ToListAsync();

			return message;
		}
	}
}
