using ASM1.IService;
using ASM1.Models;
using ASM1.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASM1.Controllers
{
    public class VatLieuController : Controller
    {
        ISupplier_Service _supplier;

        public VatLieuController()
        {
            _supplier = new Supplier_service();
        }

        // GET: SupplierController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowVatLieu()
        {
            List<Supplier> suppliers = _supplier.GetAllSP();
            return View(suppliers);
        }

        // GET: SupplierController/Details/5
        public ActionResult Details(Guid id)
        {
            Supplier x = _supplier.GetSupplierByID(id);
            return View(x);
        }

        // GET: SupplierController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SupplierController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Supplier s)
        {

            if (_supplier.AddSP(s))
            {
                return RedirectToAction("ShowVatLieu");
            }
            return BadRequest();

        }

		// GET: SupplierController/Edit/5
		[HttpGet]

		public ActionResult Edit(Guid id)
        {
            Supplier ex = _supplier.GetAllSP().FirstOrDefault(c=>c.IdSupplier == id);
            return View(ex);
        }

        // POST: SupplierController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Supplier s)
        {
            if (s.Quantity <=1)
            {
                return Content("So luong phai lon hon 1");
            }
            if (s.Status <= 1)
            {
                return Content("Status phai lon hon 1");
            }
            if (_supplier.UpdateSP(s))
            {
                return RedirectToAction("ShowVatLieu");
            }
            return BadRequest();
        }

        // GET: SupplierController/Delete/5
        public ActionResult Delete(Guid id)
        {
            if (_supplier.DeleteSP(id))
            {
                return RedirectToAction("ShowVatLieu");
            }
            return BadRequest();

        }

        // POST: SupplierController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

	}
}
