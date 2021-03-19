using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace ModelLibrary.Models
{
    public class AylikSaatComboBox
    {
        public int combobox_id { get; set; }
        public Months ListMonths { get; set; }

        [Display(Name = "Eklemek Istediginiz Saati Girin")]
        public int Value { get; set; }

        public enum Months
        {
            OCAK,
            SUBAT,
            MART,
            NISAN,
            MAYIS,
            HAZIRAN,
            TEMMUZ,
            AGUSTOS,
            EYLUL,
            EKIM,
            KASIM,
            ARALIK
        }
    }
}
