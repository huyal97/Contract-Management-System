using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtomatikSozlesme.Models
{
    public class SozlesmePersonelModel
    {
        public SozlesmePersonelModel()
        {
            Sozlesme = new SozlesmeModel();
            Personels = new List<PersonelModel>();
        }
        public SozlesmeModel Sozlesme { get; set; }
        public List<PersonelModel> Personels { get; set; }
        
    }
}
