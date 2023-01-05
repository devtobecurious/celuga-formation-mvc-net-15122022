using Microsoft.AspNetCore.Mvc;
using SelfieAWookie.Core.Models;
using SelfieAWookie.Core.Services.Selfies;
using SelfieAWookie.Web.UI.AppCode;
using SelfieAWookie.Web.UI.Models;

namespace SelfieAWookie.Web.UI.Controllers
{
    public class SelfieController : Controller
    {
        private readonly ILoggerCustom logger;
        private readonly ISelfieService selfieService;

        public SelfieController(ILoggerCustom logger, ISelfieService selfieService)
		{
            this.logger = logger;
            this.selfieService = selfieService;
		}

        public IActionResult Index()
        {
            var model = this.selfieService.GetList();

            return this.View(model);
        }


        // Ancienne version
        //     public IActionResult Index()
        //     {
        //         Selfie selfie = new Selfie();
        //         try
        //         {
        //             selfie.LoadFromDatabase(1);
        //         }
        //         catch(Exception ex)
        //{
        //             this.logger.Log("Erreur", ex);
        //}

        //         List<Selfie> list = new()
        //         {
        //             //new () { Id = 1, Titre = "Wow trop bien moustafar"},
        //             //new () { Id = 2, Titre = "Ta vu je suis avec Luke" }
        //         };

        //         //this.ViewBag.CeQueLonVeut = "Filtres";
        //         //var listAnnees = new List<int>()
        //         //{
        //         //    2020, 2021, 2022, 2023, 2024
        //         //};
        //         // this.ViewBag.Annees = listAnnees;


        //         // return View(list);
        //         return View("Index", new SelfieListViewModel(list, 
        //                                                      new Annee().LoadFromDatabase().Select(item => item.Valeur).ToList()));
        //     }


        [HttpGet]
        public IActionResult Create()
		{
            return View();
		}

        [HttpPost]
        public IActionResult Create(string[] titre, string Shabala)
        {
            var titeR = this.Request.Form["Titre"];

            return View();
        }



        //public List<int> Annees { get; set; }
    }
}
