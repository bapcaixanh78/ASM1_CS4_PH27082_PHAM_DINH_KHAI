using ASM1.IService;
using ASM1.Models;
using ASM1.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASM1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        IMaterial_Service _material_Service;
        ISupplier_Service _supplier_Service;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _material_Service = new Material_Service();
            _supplier_Service = new Supplier_service();
        }

        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Material()
        //{
        //    //List<Material> lst = _material_Service.GetAllMT();
        //    //return View("Views/Material/ShowMaterial.cshtml");
        //}

        public IActionResult VatLieu()
        {
            List<Supplier> lst = _supplier_Service.GetAllSP();
            return View(lst);
        }
        public IActionResult ShowVatlieu5()
        {
            List<Supplier> lst = _supplier_Service.GetSupplier5();
            return View(lst);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}