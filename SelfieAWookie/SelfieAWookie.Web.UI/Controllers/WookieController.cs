using Microsoft.AspNetCore.Mvc;
using SelfieAWookie.Core.Models;

namespace SelfieAWookie.Web.UI.Controllers
{
    public class WookieController : Controller
    {
        public IActionResult Index()
        {
            List<Wookie> list = new()
            {
                new (1, new Planete() { Id = 1, Libelle = "Mustafar"}) { Prenom = "Chewie", Age = 30 },
                new (1, new Planete() { Id = 1, Libelle = "Mustafar"}) { Prenom = "Chewie", Age = 30, Ami = new Wookie(3) }
            };

            return View("List", list);
        }
    }
}
