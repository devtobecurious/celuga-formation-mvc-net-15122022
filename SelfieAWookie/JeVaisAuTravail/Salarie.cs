using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeVaisAuTravail
{
	public class Salarie
	{
		#region Fields
		private ITempsQuiFait meteo;
		#endregion

		#region Constructors
		public Salarie(ITempsQuiFait meteo)
		{
			this.meteo = meteo;
		}
		#endregion

		#region Public methods
		public void AllerAuTravail()
		{
			var temps = this.meteo.Donner();

			IMoyenDeDeplacement moyenDeplacement = FabricMoyenDeDeplacement.Creer(temps);

			moyenDeplacement.Deplacer(this);
		}
		#endregion
	}
}
