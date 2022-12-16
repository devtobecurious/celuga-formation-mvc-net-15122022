using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieAWookie.Core.Models
{
	public class Annee
	{
		// public List<AnneeItem> List { get; set; }

		public List<AnneeItem> LoadFromDatabase()
		{
			return new List<AnneeItem>();
		}
	}

	public class AnneeItem
	{
		public int Valeur { get; set; }
	}
}
