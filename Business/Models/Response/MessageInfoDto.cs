using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
	public class MessageInfoDto
	{
		public int Id { get; set; } = default!;
		public int FirstUserId { get; set; } = default!;
		public int SecondUserId { get; set; } = default!;
		public string MyMessage { get; set; } = default!;
		public DateTime CreatedAt { get; set; }
		public UserProfileDto FirstUser { get; set; }
		public UserProfileDto SecondUser { get; set; }
	}
}
