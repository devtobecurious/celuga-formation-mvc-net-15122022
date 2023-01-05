using System.ComponentModel.DataAnnotations;

namespace SelfieAWookie.Core.Models
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
        [Key]
		public int Id { get; set; }

        [StringLength(255)]
        public string Titre { get; set; } = "";

        public string ImageUrl { get; set; } = "";
        #endregion
    }
}
