using Microsoft.AspNetCore.Mvc;
using SelfieAWookie.Core.Models;
using SelfieAWookie.Core.Services;

namespace SelfieAWookie.Web.UI.Controllers
{
    public class WookieController : Controller
    {
        private IWookieeService wookieeService;


        public WookieController(IWookieeService wookieeService)
		{
            this.wookieeService = wookieeService;
        }

        public IActionResult Index()
        {
            var list = this.wookieeService.GetList();

            //List<Wookie> list = new()
            //{
            //    new (1, new Planete() { Id = 1, Libelle = "Mustafar"}) { Prenom = "Chewie", Age = 30 },
            //    new (1, new Planete() { Id = 1, Libelle = "Mustafar"}) { Prenom = "Chewie", Age = 30, Ami = new Wookie(3) }
            //};

            return View("List", list);
        }
    }
}
