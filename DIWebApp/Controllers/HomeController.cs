using DIWebApp.Interfaces;
using DIWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DIWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHelloWorldService _helloWorldService;
        private readonly IProductCatalogService _ProductCatalogService;

        public HomeController(IHelloWorldService helloWorldService, IProductCatalogService productCatalogService)
        {
            Console.WriteLine("Home controller instance is initiated.....");
           this._helloWorldService = helloWorldService;
            this._ProductCatalogService = productCatalogService;
        }

        public IActionResult Index()
        {
            Console.WriteLine("HomeController index method is invoked...");
            string message=this._helloWorldService.SayHello();
            ViewData["Message"] = message;
            bool status = this._ProductCatalogService.Insert();
            return View();
        }

        public IActionResult Privacy()
        {
            Console.WriteLine("HomeController privacy method is invoked...");
            string message = this._helloWorldService.SayHello();
            ViewData["Message"] = message;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}