using SelfieAWookie.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieAWookie.Core.Services
{
	public class WookieeMySQLService : IWookieeService
	{
		public List<Wookie> GetList()
		{
			return new List<Wookie>()
			{
				new Wookie(1)
			};
		}
	}
}
