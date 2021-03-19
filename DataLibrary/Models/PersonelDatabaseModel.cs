using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class PersonelDatabaseModel
    {
        public int Personel_Id { get; set; }
        public int AdamSaat { get; set; }
        public string SorumluYonetici { get; set; }
        public int Rate { get; set; }        
        public string Uzmanlik { get; set; }
        public string Isim { get; set; }
        public string Bolge { get; set; }
        public string KaynakTipi { get; set; }
        public int Sozlesme_Id { get; set; }
    }
}
