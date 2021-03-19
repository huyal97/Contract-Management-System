using DataLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OtomatikSozlesme.Models;
using System;
using System.Collections.Generic;

using static DataLibrary.BusinessLogic.SozlesmeProcessor;

using System.Web;

namespace OtomatikSozlesme.Controllers
{
    public class SozlesmeController : Controller
    {
        private readonly ILogger<SozlesmeController> _logger;

        public SozlesmeController(ILogger<SozlesmeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult SignUp()
        {

            return View();


        }
        
        
        [HttpPost]
        public IActionResult SignUp(IFormCollection model)
        {

            List<PersonelModel> personels = new List<PersonelModel>();
            PersonelModel personel = new PersonelModel();
            SozlesmeModel sozlesme = new SozlesmeModel();
            sozlesme.Firma = Request.Form["Firma"];
            sozlesme.Tarih = Convert.ToDateTime(Request.Form["Tarih"]);
            sozlesme.Arti_Eksilis = Convert.ToInt32(Request.Form["Arti_Eksilis"]);
            sozlesme.Baslik = Request.Form["Baslik"];
            sozlesme.Talep_Tarihi = Convert.ToDateTime(Request.Form["Talep_Tarihi"]);
            sozlesme.Tamamlanma_Tarihi = Convert.ToDateTime(Request.Form["Tamamlanma_Tarihi"]);
            sozlesme.Bolge = Request.Form["Bolge"];
            sozlesme.Faturalama_Durum = Request.Form["Faturalama_Durum"];
            sozlesme.Sorumlu = Request.Form["Sorumlu"];
            sozlesme.Sorumlu = Request.Form["Sorumlu"];
            sozlesme.TarihBitis = Convert.ToDateTime(Request.Form["TarihBitis"]);



            int recordsCreated = CreateSozlesme(sozlesme.Firma, sozlesme.Tarih,sozlesme.TarihBitis, sozlesme.Arti_Eksilis, sozlesme.Baslik, sozlesme.Talep_Tarihi, sozlesme.Tamamlanma_Tarihi, sozlesme.Bolge, sozlesme.Faturalama_Durum, sozlesme.Sorumlu);
            for (int x = 1; x < 5; x++)
            {
                if (!String.IsNullOrEmpty(Request.Form[$"adamsaat{x}"]))
                {
                    personel.AdamSaat = Convert.ToInt32(Request.Form[$"Adamsaat{x}"]);
                    personel.SorumluYonetici = Request.Form[$"Sorumluyonetici{x}"];
                    personel.Bolge = Request.Form[$"Bolge{x}"];
                    personel.Rate = Convert.ToInt32(Request.Form[$"Rate{x}"]);
                    personel.Uzmanlik = Request.Form[$"Uzmanlik{x}"];
                    personel.Isim = Request.Form[$"Isim{x}"];
                    personel.KaynakTipi = Request.Form[$"Kaynaktipi{x}"];
                    personel.Sozlesme_Id = recordsCreated;
                    personels.Add(personel);

                    CreatePersonel(personel.AdamSaat, personel.SorumluYonetici,personel.Rate,personel.KaynakTipi, personel.Uzmanlik, personel.Isim, personel.Sozlesme_Id);
                }

            }

            return RedirectToAction("ViewSozlesmeData");

        }
        [HttpPost]
        public IActionResult UpdateSozlesme(IFormCollection model)
        {
            List<PersonelDatabaseModel> PDM = new List<PersonelDatabaseModel>();
            SozlesmeDatabaseModel SDM = new SozlesmeDatabaseModel();
            SozlesmePersonelModel Sozlesmeler = new SozlesmePersonelModel();

            Sozlesmeler.Sozlesme.Id = Convert.ToInt32(Request.Form["Sozlesme.Id"]);
            Sozlesmeler.Sozlesme.Firma = Request.Form["Sozlesme.Firma"];
            Sozlesmeler.Sozlesme.Baslik = Request.Form["Sozlesme.Baslik"];
            Sozlesmeler.Sozlesme.Arti_Eksilis = Convert.ToInt32(Request.Form["Sozlesme.Arti_Eksilis"]);
            Sozlesmeler.Sozlesme.Tarih = Convert.ToDateTime(Request.Form["Sozlesme.Tarih"]);
            Sozlesmeler.Sozlesme.Talep_Tarihi = Convert.ToDateTime(Request.Form["Sozlesme.Talep_Tarihi"]);
            Sozlesmeler.Sozlesme.Tamamlanma_Tarihi = Convert.ToDateTime(Request.Form["Sozlesme.Tamamlanma_Tarihi"]);

            string Id = model["item.Id"];
            string AdamSaat = model["item.AdamSaat"];
            string SorumluYonetici = model["item.SorumluYonetici"];
            string Rate = model["item.Rate"];
            string Bolge = model["item.Bolge"];
            string KaynakTipi = model["item.Kaynaktipi"];
            string Sozlesme_Id = model["item.Sozlesme_Id"];

            string[] IdArray = Id.Split(',');
            string[] AdamSaatArray = AdamSaat.Split(',');
            string[] SorumluYoneticiArray = SorumluYonetici.Split(',');
            string[] RateArray = Rate.Split(',');
            string[] BolgeArray = Bolge.Split(',');
            string[] KaynakTipiArray = KaynakTipi.Split(',');
            string[] Sozlesme_IdArray = Sozlesme_Id.Split(','); ;
            
            int x = 0;
            int lenght = IdArray.Length;
            while(x<=lenght-1)
            {
                Sozlesmeler.Personels.Add(new PersonelModel
                {
                    Personel_Id = Convert.ToInt32(IdArray[x]),
                    AdamSaat = Convert.ToInt32(AdamSaatArray[x]),
                    SorumluYonetici = SorumluYoneticiArray[x],
                    Rate = Convert.ToInt32(RateArray[x]),
                    Bolge = BolgeArray[x],
                    KaynakTipi = KaynakTipiArray[x],
                    Sozlesme_Id = Convert.ToInt32(Sozlesme_IdArray[x])
                });
                x++;
            }
            
            

            foreach (PersonelModel person in Sozlesmeler.Personels)
            {
                PDM.Add(new PersonelDatabaseModel
                {
                    Personel_Id = person.Personel_Id,
                    AdamSaat = person.AdamSaat,
                    SorumluYonetici = person.SorumluYonetici,
                    Rate = person.Rate,
                    Isim = person.Isim,
                    Uzmanlik = person.Uzmanlik,
                    Sozlesme_Id = person.Sozlesme_Id
                });
            }

            SDM.Arti_Eksilis = Sozlesmeler.Sozlesme.Arti_Eksilis;
            SDM.Firma= Sozlesmeler.Sozlesme.Firma;
            SDM.Baslik = Sozlesmeler.Sozlesme.Baslik;
            SDM.Tarih = Sozlesmeler.Sozlesme.Tarih;
            SDM.Sozlesme_Id = Sozlesmeler.Sozlesme.Id;           
            SDM.Talep_Tarihi = Sozlesmeler.Sozlesme.Talep_Tarihi;
            SDM.Tamamlanma_Tarihi = Sozlesmeler.Sozlesme.Tamamlanma_Tarihi;

            UpdateSozlesmePersonel(SDM,PDM);

            return RedirectToAction("ViewSozlesmeData");
        }
        public IActionResult UpdateSozlesme(int Id)
        {
            SPDatabaseModel data = LoadSozlesmeWithId(Id);
            SozlesmePersonelModel Sozlesmeler = new SozlesmePersonelModel();

            SozlesmeModel sozlesme = new SozlesmeModel();




            sozlesme.Firma = data.Sozlesme.Firma;
            sozlesme.Baslik = data.Sozlesme.Baslik;
            sozlesme.Arti_Eksilis = data.Sozlesme.Arti_Eksilis;
            sozlesme.Tarih = data.Sozlesme.Tarih;
            sozlesme.Talep_Tarihi = data.Sozlesme.Talep_Tarihi;
            sozlesme.Tamamlanma_Tarihi = data.Sozlesme.Tamamlanma_Tarihi;
            sozlesme.Id = data.Sozlesme.Sozlesme_Id;
            Sozlesmeler.Sozlesme = sozlesme;
            foreach (PersonelDatabaseModel person in data.Personels)
            {
                Sozlesmeler.Personels.Add(new PersonelModel
                {
                    Personel_Id = person.Personel_Id,
                    AdamSaat = person.AdamSaat,
                    SorumluYonetici = person.SorumluYonetici,
                    Rate = person.Rate,
                    Isim = person.Isim,
                    Uzmanlik = person.Uzmanlik,

                    Sozlesme_Id = person.Sozlesme_Id
                });
            }

            return View(Sozlesmeler);
        }


        public IActionResult ViewSozlesmeData()
        {
            ViewBag.Message = "Sözleşme Listesi";
            var data = LoadSozlesme();
            List<SozlesmeModel> Sozlesmeler = new List<SozlesmeModel>();

            foreach (var row in data)
            {
                Sozlesmeler.Add(new SozlesmeModel
                {
                    Id = row.Sozlesme_Id,
                    Firma = row.Firma,
                    Baslik = row.Baslik,
                    Arti_Eksilis = row.Arti_Eksilis,
                    Tarih = row.Tarih,
                    Talep_Tarihi = row.Talep_Tarihi,
                    Tamamlanma_Tarihi = row.Tamamlanma_Tarihi,
                    Bolge = row.Bolge,
                    Sorumlu = row.Sorumlu,
                    Faturalama_Durum = row.Faturalama_Durum,
                });
            }
            return View(Sozlesmeler);
        }
        public IActionResult SilSozlesmeData(int id)
        {
            int recordsDeleted = DeleteSozlesme(id);
            return RedirectToAction("ViewSozlesmeData");

        }
    }
}
