using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
	public class CreateUserDto
	{
		public string Email { get; set; } = default!;
		public string Password { get; set; } = default!;
		public string FullName { get; set; } = default!;
	}
}
