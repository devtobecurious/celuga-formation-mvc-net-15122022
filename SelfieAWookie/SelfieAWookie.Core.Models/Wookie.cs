

namespace SelfieAWookie.Core.Models
{
    public class Wookie
    {
        #region Constructors
        public Wookie(int id, Planete planete = null)
        {
            this.Id = id;
            this.Planete = planete;

            //Rang rang = new Rang() { Libelle = "Chef" };
            //Rang rang2 = new Rang() { Libelle = "Chef" };

            //Rang rang = new Rang(1, "Chef");
            //Rang rang2 = new Rang(1, "Chef");

            //bool rangsEgaux = rang == rang2; // true
        }
        #endregion

        #region Properties
        public int Id { get; set; }

        public string Prenom { get; set; } = string.Empty;

        public int Age { get; set; } = 20;

        public Wookie? Ami { get; set; } = null;

        public Planete Planete { get; set; }

        public Rang Rang { get; set; }
        #endregion
    }
}
