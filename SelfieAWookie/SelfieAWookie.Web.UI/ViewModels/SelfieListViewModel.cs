using Microsoft.AspNetCore.Mvc.Rendering;
using SelfieAWookie.Web.UI.Controllers;

namespace SelfieAWookie.Web.UI.Models
{
	public class SelfieListViewModel
	{
		public SelfieListViewModel(List<Selfie> selfies, List<int> annees)
		{
			this.SelfieList = selfies;
			this.Annees = annees;
		}

		public List<Selfie> SelfieList { get; set; }

		public IEnumerable<SelectListItem> AnneeListItem { get; private set; }

		private List<int> _annees;
		public List<int> Annees 
		{
			get => _annees;
			set
			{
				_annees = value;
				this.AnneeListItem = _annees.Select(item => new SelectListItem() { Value = item.ToString(), Text = item.ToString() });
			}
		}
	}
}
