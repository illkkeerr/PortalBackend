using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
	public class UserUpdateDto
	{
		public string FullName { get; set; } = default!;
		public string Email { get; set; } = default!;
		public double Balance { get; set; }=default!;
		public UserType UserType { get; set; }
	}
}
