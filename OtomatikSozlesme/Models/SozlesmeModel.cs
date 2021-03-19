using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace OtomatikSozlesme.Models
{
    public class SozlesmeModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "yo need to give us your firme.")]
        public string Firma { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Tarih { get; set; }
        [Display(Name = "Artis Azalis Bilgisi")]
        public int Arti_Eksilis { get; set; }
        public string Baslik { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Talep_Tarihi { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Tamamlanma_Tarihi { get; set; }
        public string Bolge { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime TarihBitis { get; set; }
        public string Faturalama_Durum { get; set; }
        public string Sorumlu { get; set; }

        public int Taslak_ID { get; set; }

    }
}
