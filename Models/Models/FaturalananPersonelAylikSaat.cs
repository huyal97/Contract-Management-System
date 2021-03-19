using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelLibrary.Models
{
    public class FaturalananPersonelAylikSaat
    {
        public int PERSONEL_ID { get; set; }
        [Display(Name = "Ocak")]
        public int FOCAK { get; set; }
        [Display(Name = "Şubat")]
        public int FSUBAT { get; set; }
        [Display(Name = "Mart")]
        public int FMART { get; set; }
        [Display(Name = "Nisan")]
        public int FNISAN { get; set; }
        [Display(Name = "Mayıs")]
        public int FMAYIS { get; set; }
        [Display(Name = "Haziran")]
        public int FHAZIRAN { get; set; }
        [Display(Name = "Temmuz")]
        public int FTEMMUZ { get; set; }
        [Display(Name = "Ağustos")]
        public int FAGUSTOS { get; set; }
        [Display(Name = "Eylül")]
        public int FEYLUL { get; set; }
        [Display(Name = "Ekim")]
        public int FEKIM { get; set; }
        [Display(Name = "Kasım")]
        public int FKASIM { get; set; }
        [Display(Name = "Ağustos")]
        public int FARALIK { get; set; }
    }
}
