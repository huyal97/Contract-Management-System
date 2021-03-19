using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class SPDatabaseModel
    {
        
        public SozlesmeDatabaseModel Sozlesme { get; set; }
        public List<PersonelDatabaseModel> Personels { get; set; }

    }
}
