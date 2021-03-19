using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelLibrary.Models
{
    public class PlanlananPersonelAylikSaat
    {
        public int PERSONEL_ID { get; set; }
        [Display(Name = "Ocak")]
        public int POCAK { get; set; }
        [Display(Name = "Şubat")]
        public int PSUBAT { get; set; }
        [Display(Name = "Mart")]
        public int PMART { get; set; }
        [Display(Name = "Nisan")]
        public int PNISAN { get; set; }
        [Display(Name = "Mayıs")]
        public int PMAYIS { get; set; }
        [Display(Name = "Haziran")]
        public int PHAZIRAN { get; set; }
        [Display(Name = "Temmuz")]
        public int PTEMMUZ { get; set; }
        [Display(Name = "Ağustos")]
        public int PAGUSTOS { get; set; }
        [Display(Name = "Eylul")]
        public int PEYLUL { get; set; }
        [Display(Name = "Ekim")]
        public int PEKIM { get; set; }
        [Display(Name = "Kasım")]
        public int PKASIM { get; set; }
        [Display(Name = "Aralık")]
        public int PARALIK { get; set; }
    }
}
