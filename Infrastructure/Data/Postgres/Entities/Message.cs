using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
	public class Message : Entity<int>
	{
		public int FirstUserId { get; set; } = default!;
		public int SecondUserId { get; set; } = default!;		
		public string MyMessage { get; set; }=default!;
		public User FirstUser { get; set; }
		public User SecondUser { get; set; }
	}
}
