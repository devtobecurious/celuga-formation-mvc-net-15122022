using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeVaisAuTravail
{
	public class FabricMoyenDeDeplacement
	{
		public static IMoyenDeDeplacement Creer(TempsQuiFait tempsQuiFait)
		{
			IMoyenDeDeplacement moyenDeDeplacement = null;

			switch(tempsQuiFait)
			{
				case TempsQuiFait.Pluie:
					{
						moyenDeDeplacement = new Voiture();
					} break;

				case TempsQuiFait.BeauTemps:
					{
						moyenDeDeplacement = new Velo();
					}
					break;
			}

			return moyenDeDeplacement;
		}
	}
}
