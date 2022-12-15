namespace SelfieAWookie.Web.UI.Models
{
    public class Selfie
    {
        public Selfie()
        {
            
        }

        #region Properties
        public int Id { get; set; }

        public string Titre { get; set; } = "";

        public string ImageUrl { get; set; } = "";
        #endregion
    }
}
