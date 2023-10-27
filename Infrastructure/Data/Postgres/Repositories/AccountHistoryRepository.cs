using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Repositories
{
	public class AccountHistoryRepository : Repository<AccountHistory, int>, IAccountHistoryRepository
	{
		public AccountHistoryRepository(PostgresContext postgresContext) : base(postgresContext)
		{
		}
		public async Task<IList<AccountHistory>> GetAllAsync(Expression<Func<AccountHistory, bool>>? filter = null)
		{
			IQueryable<AccountHistory> messageQuery = PostgresContext.Set<AccountHistory>();

			if (filter != null)
			{
				messageQuery = messageQuery.Where(filter);
			}

			//İlişkiler arasındaki iletişimi sağlar
			var message = await messageQuery
				.Include(r => r.Customer)
				.Include(r => r.Receiver)

				.ToListAsync();

			return message;
		}
	}
}
