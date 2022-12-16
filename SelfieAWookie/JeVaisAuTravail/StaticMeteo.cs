using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeVaisAuTravail
{
	public enum TempsQuiFait
	{
		BeauTemps,
		Pluie,
		Grele
	}

	internal class StaticMeteo : ITempsQuiFait
	{
		public TempsQuiFait Donner()
		{
			return TempsQuiFait.Grele;
		}
	}
}
