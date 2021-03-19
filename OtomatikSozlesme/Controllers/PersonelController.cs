using Microsoft.AspNetCore.Mvc;
using ModelLibrary.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DataLibrary.BusinessLogic.PersonelProcessor;

namespace OtomatikSozlesme.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult ViewPersonelKalanSaat()
        {
            ViewBag.Message = "Sözleşme Listesi";
            var data = LoadPersonelView();
            List<AdamSaatGorunum> AdamSaat = new List<AdamSaatGorunum>();

            foreach (var row in data)
            {
                AdamSaat.Add(new AdamSaatGorunum
                {
                    PERSONEL_ID = row.PERSONEL_ID,
                    FIRMA = row.FIRMA,
                    ADAMSAAT = row.ADAMSAAT,
                    KALAN = row.KALAN,
                    UZMANLIK = row.UZMANLIK,
                    TOPLAM = row.TOPLAM,
                    ISIM = row.ISIM
                });
            }
            return View(AdamSaat);
        }

        [HttpGet]
        public JsonResult UpdateAylikSaat(int id)
        {
            dynamic model = new System.Dynamic.ExpandoObject();

            model = LoadPersonelAylikSaatWithId(id);
            string output = JsonConvert.SerializeObject(model);

            return Json(output);

        }
        [HttpPost]
        public IActionResult UpdateAylikSaat(PersonelAylikSaat gerceklesen,PlanlananPersonelAylikSaat planlanan,FaturalananPersonelAylikSaat faturalanan)
        {
            UpdatePersonelAylikSaat(gerceklesen,planlanan,faturalanan);
           
           return RedirectToAction("ViewPersonelKalanSaat");

        }

        [HttpPost]
        public IActionResult UpdateAylikSaatWithComboBox(AylikSaatComboBox model)
        {
            
            UpdatePersonelAylikSaatWithComboBox(model);

            return RedirectToAction("ViewPersonelKalanSaat");

        }
    }
}
