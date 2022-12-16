using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeVaisAuTravail
{
	public class Voiture : IMoyenDeDeplacement
	{
		public void Deplacer(Salarie salarie)
		{
			Console.WriteLine("Vroom vroom");
		}
	}
}
