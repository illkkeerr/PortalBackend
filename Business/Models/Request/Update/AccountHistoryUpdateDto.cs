using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
	public class AccountHistoryUpdateDto
	{
		public int CustomerId { get; set; } = default!;
		public int ReceiverId { get; set; } = default!;
		public ProcessType ProcessType { get; set; } = default!;
		public double AmountOfMoney { get; set; } = default!;
	}
}
