using SıstemTicket.Areas.Admin.Models.Attr;
using SıstemTicket.Areas.Admin.Models.DTO;
using SıstemTicket.Models.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SıstemTicket.Areas.Admin.Controllers
{
    public class BirimController : BaseController
    {

        // GET: Admin/Birim
        [LoginControl]
        public ActionResult Index(int id)
        {
            List<BirimVM> model = DB.Birimler.Where(x => x.ID == id)
                .OrderBy(x => x.EklenmeTarihi)
                .Select(x => new BirimVM()
            {
                BirimAdi = x.BirimAdi,
                Aciklamasi = x.BirimAciklamasi,
                ID = x.ID
            }).ToList();
            return View(model);
        }


        public ActionResult BirimEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BirimEkle(BirimVM model)
        {
            if (ModelState.IsValid)
            {
                Birimler birimler = new Birimler();
                birimler.BirimAdi = model.BirimAdi;
                birimler.BirimAciklamasi = model.Aciklamasi;
                DB.Birimler.Add(birimler);
                DB.SaveChanges();
                ViewBag.islemDurum = 1;
                return View();
            }
            else
            {
                ViewBag.islemDurum = 2;
                return View();
            }
        }


        public ActionResult Guncelle(int id)
        {
            //güncellenecek birimi bulup
            Birimler birimler = DB.Birimler.FirstOrDefault(x => x.ID == id);
            BirimVM model = new BirimVM();
            model.BirimAdi = birimler.BirimAdi;
            model.Aciklamasi = birimler.BirimAciklamasi;


            return View(model);
        }

        [HttpPost]
        public ActionResult Guncelle(BirimVM model)
        {
            //güncellenecek kategori yakalanır ve yeni verilerie update edilir
            if (ModelState.IsValid)
            {
                Birimler birimler = DB.Birimler.FirstOrDefault(x => x.ID == model.ID);
                birimler.BirimAdi = model.BirimAdi;
                birimler.BirimAciklamasi = model.Aciklamasi;

                DB.SaveChanges();
                ViewBag.IslemDurum = 1;
                return View();
            }
            else
            {
                ViewBag.IslemDurum = 1;
                return View();
            }
        }

        public JsonResult BirimSil(int id)
        {
            Birimler birimler = DB.Birimler.FirstOrDefault(x => x.ID == id);
            birimler.IsDeleted = true;
            birimler.SilinmeTarihi = DateTime.Now;
            DB.SaveChanges();

            return Json("");
        }   

    }
}