using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Functional
{
	public class ChangeBalanceDto
	{
		public int Id { get; set; }
		public double AmountOfMoney { get; set; }
	}
}
