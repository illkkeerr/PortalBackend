using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
	public class AccountHistory : Entity<int>
	{
		public int CustomerId { get; set; } = default!;
		public int ReceiverId { get; set; }= default!;
		public ProcessType ProcessType { get; set; } = default!;
		public double AmountOfMoney { get; set; } = default!;
		public User Customer { get; set; }
		public User Receiver { get; set; }



	}
	
}
public enum ProcessType
{
	withdrawMoney,
	depositMoney,
	sendingMoney
}
