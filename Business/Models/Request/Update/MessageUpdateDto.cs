using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
	public class MessageUpdateDto
	{
		public int FirstUserId { get; set; } = default!;
		public int SecondUserId { get; set; } = default!;
		public string MyMessage { get; set; } = default!;
	}
}
