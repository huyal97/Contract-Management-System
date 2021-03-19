using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OtomatikSozlesme.Models;
using DataLibrary.Models;
using static DataLibrary.BusinessLogic.TaslakProcessor;

namespace OtomatikSozlesme.Controllers
{
    public class TaslakController : Controller
    {
        [HttpGet]
        public IActionResult TaslakCreator()
        {            
            return View("CreateTaslak");
        }


        [HttpPost]
        public IActionResult TaslakCreator(TaslakModel model)
        {
            
            TaslakDatabaseModel data = new TaslakDatabaseModel
            {
                SIRKETADI = model.SIRKETADI,
                SARTNAMEADI = model.SARTNAMEADI,
                IS_TANIM_1 = model.IS_TANIM_1,

                ALT_YUKLENICI_2 = model.ALT_YUKLENICI_2,

                GARANTI_SURESI_3 = model.GARANTI_SURESI_3,
                EGITIM_SARTLARI_4 = model.EGITIM_SARTLARI_4,

                ISIN_KAPSAMI_5 = model.ISIN_KAPSAMI_5,
                SOZLESME_BEDELINE_UNSURLARI_6 = model.SOZLESME_BEDELINE_UNSURLARI_6,
                ISIN_YERI_SURESI_7 = model.ISIN_YERI_SURESI_7,
                ISIN_TESLIM_KABUL_SARTLARI_8 = model.ISIN_TESLIM_KABUL_SARTLARI_8,
                YUKLENICI_PERSONEL_ARANAN_NITELIKLER_9 = model.YUKLENICI_PERSONEL_ARANAN_NITELIKLER_9,
                ISIN_IFASINDA_PERSONEL_10 = model.ISIN_IFASINDA_PERSONEL_10,
                FIYAT_FARKI_11 = model.FIYAT_FARKI_11,
                ISE_BASLAMA_12 = model.ISE_BASLAMA_12
            };
            CreateTaslak(data);
            return View();
            

            
        }
    }
}
