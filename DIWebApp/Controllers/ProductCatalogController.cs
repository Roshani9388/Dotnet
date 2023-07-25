using DIWebApp.Interfaces;
using DIWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DIWebApp.Controllers
{
    public class ProductCatalogController : Controller
    {
        private readonly    IProductCatalogService _IProductCatalogService;

        public ProductCatalogController(IProductCatalogService _IProductCatalogService)
        {
                this._IProductCatalogService = _IProductCatalogService;
        }            
        public IActionResult Insert()
        {
            bool status=this._IProductCatalogService.Insert();
            ViewData["message"] = "New Product Is inserted status "+status;
                return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
