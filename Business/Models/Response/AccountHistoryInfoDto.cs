using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
	public class AccountHistoryInfoDto
	{
		public int Id { get; set; }
		public int CustomerId { get; set; } = default!;
		public string ReceiverId { get; set; } = default!;
		public ProcessType ProcessType { get; set; } = default!;
		public double AmountOfMoney { get; set; } = default!;
		public DateTime CreatedAt { get; set; }
		public UserProfileDto Customer { get; set; }
		public UserProfileDto Receiver { get; set; }
	}
}
