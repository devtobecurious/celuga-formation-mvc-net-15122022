using Microsoft.AspNetCore.Mvc;
using SelfieAWookie.Web.UI.Models;

namespace SelfieAWookie.Web.UI.Controllers
{
    public class SelfieController : Controller
    {
        public IActionResult Index()
        {
            List<Selfie> list = new()
            {
                //new () { Id = 1, Titre = "Wow trop bien moustafar"},
                //new () { Id = 2, Titre = "Ta vu je suis avec Luke" }
            };

            this.ViewBag.CeQueLonVeut = "Filtres";
            var listAnnees = new List<int>()
            {
                2020, 2021, 2022, 2023, 2024
            };
            this.ViewBag.Annees = listAnnees;

            // return View(list);
            return View("Index", list);
        }
    }
}
