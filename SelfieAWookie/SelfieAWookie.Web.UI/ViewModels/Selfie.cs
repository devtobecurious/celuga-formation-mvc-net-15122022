namespace SelfieAWookie.Web.UI.Models
{
    public class Selfie
    {
        public Selfie()
        {
            
        }

		#region Public methods
        public void LoadFromDatabase(int id)
		{
            this.Id = id;
            // Appel base
            //this.Titre = MonRecordSet("Titre");
		}
		#endregion

		#region Properties
		public int Id { get; set; }

        public string Titre { get; set; } = "";

        public string ImageUrl { get; set; } = "";
        #endregion
    }
}
