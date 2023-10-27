using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
	public class CreateMessageDto
	{
		public int FirstUserId { get; set; } = default!;
		public int SecondUserId { get; set; } = default!;
		public string MyMessage { get; set; } = default!;

	}
}
