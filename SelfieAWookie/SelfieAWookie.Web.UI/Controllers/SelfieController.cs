using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SelfieAWookie.Core.Models;
using SelfieAWookie.Core.Services.Selfies;
using SelfieAWookie.Web.UI.AppCode;
using SelfieAWookie.Web.UI.AppCode.Models;
using SelfieAWookie.Web.UI.Models;
using System.ComponentModel.DataAnnotations;

namespace SelfieAWookie.Web.UI.Controllers
{
    
    public class SelfieController : Controller
    {
        private readonly ILoggerCustom logger;
        private readonly ISelfieService selfieService;
        private readonly DefaultDbContext context;
        private readonly IWebHostEnvironment environment;

        public SelfieController(ILoggerCustom logger, 
                                ISelfieService selfieService, 
                                DefaultDbContext context,
                                IWebHostEnvironment environment,
                                IConfiguration configuration)
		{
            this.logger = logger;
            this.selfieService = selfieService;
            this.context = context;
            this.environment = environment;
		}

        [AllowAnonymous]
        public IActionResult Index()
        {
            

            // var model = this.selfieService.GetList();
            // var model = this.context.Selfies.ToList();
            var query = from item in this.context.Selfies
                        select item;

            //if (true)
            //{
            //    query = query.Where(item => item.Titre.StartsWith("H"));
            //}

            var model = query.ToList();

            // l'accès à la base est fermée
            //foreach (var item in this.context.Selfies)
            //{

            //}

            return this.View( new SelfieListViewModel(model, new List<int>()));
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


        [Authorize(Roles = "User")]
        // [HttpGet]
        public IActionResult Create()
		{
            return View();
		}

        //[HttpPost]
        //public IActionResult Create(string[] titre, string Shabala)
        //{
        //    var titeR = this.Request.Form["Titre"];

        //    return View();
        //}

        [HttpPost]
        public IActionResult Create(TestClass test)
        {
            if (ModelState.IsValid)
            {
                var titeR = this.Request.Form["Titre"];
            }

            return View();
        }



        //public List<int> Annees { get; set; }
    }

    public class TestClass
    {
        [Required(AllowEmptyStrings = true)]
        public string? Titre { get; set; }

        public int Shabala { get; set; }

        // public string[] Titre2 { get; set; }
    }
}
