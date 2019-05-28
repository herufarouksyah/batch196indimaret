using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repo.Indimaret;
using Service.Indimaret;
using Model.Indimaret;

namespace Web.Indimaret.Controllers
{
    public class HomeController : Controller //, BarangServiceInterface
    {
        // GET: Home
        
        public  ActionResult Index()
        {
            
            return View(BarangRepo.GetAll());
        }

        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        [HttpPost]
        public JsonResult Save(Barang barang)
        {
            if (BarangRepo.Createbarang(barang))
            {
                return Json(new {Simpan="Berhasil"},JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Simpan = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
            //return View();
        }

        [HttpPost]
        public ActionResult Delete(int ID)
        {
            return View();
        }
    }
}