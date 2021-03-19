using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelLibrary.Models
{
    public class PersonelAylikSaat
    {
        public int PERSONEL_ID { get; set; }
        [Display(Name = "Ocak")]
        public int OCAK { get; set; }
        [Display(Name = "Şubat")]
        public int SUBAT { get; set; }
        [Display(Name = "Mart")]
        public int MART { get; set; }
        [Display(Name = "Nisan")]
        public int NISAN { get; set; }
        [Display(Name = "Mayıs")]
        public int MAYIS { get; set; }
        [Display(Name = "Haziran")]
        public int HAZIRAN { get; set; }
        [Display(Name = "Temmuz")]
        public int TEMMUZ { get; set; }
        [Display(Name = "Ağustos")]
        public int AGUSTOS { get; set; }
        [Display(Name = "Eylül")]
        public int EYLUL { get; set; }
        [Display(Name = "Ekim")]
        public int EKIM{ get; set; }
        [Display(Name = "Kasım")]
        public int KASIM { get; set; }
        [Display(Name = "Aralık")]
        public int ARALIK { get; set; }

    }
}
