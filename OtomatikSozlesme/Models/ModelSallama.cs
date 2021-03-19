using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtomatikSozlesme.Models
{
    public class ModelSallama
    {
        public int Id { get; set; }
        public int AdamSaat { get; set; }
        public string SorumluYonetici { get; set; }
        public int Rate { get; set; }
        public string Bolge { get; set; }
        public string KaynakTipi { get; set; }
        public int Sozlesme_Id { get; set; }
    }

}
