﻿using SelfieAWookie.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieAWookie.Core.Services
{
	public interface IWookieeService
	{
		List<Wookie> GetList();
	}
}
