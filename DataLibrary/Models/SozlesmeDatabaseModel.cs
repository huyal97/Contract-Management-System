using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class SozlesmeDatabaseModel
    {
        public int Sozlesme_Id { get; set; }
        public int Arti_Eksilis { get; set; }
        public string Baslik { get; set; }
        public string Firma { get; set; }
        public string Bolge { get; set; }
        public string Faturalama_Durum { get; set; }
        public string Sorumlu { get; set; }
        public DateTime Talep_Tarihi { get; set; }
        public DateTime Tamamlanma_Tarihi { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime TarihBitis { get; set; }


    }
}
