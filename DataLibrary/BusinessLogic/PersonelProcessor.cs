using DataLibrary.DataAccess;
using ModelLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.BusinessLogic
{
    public static class PersonelProcessor
    {
        public static List<AdamSaatGorunum> LoadPersonelView()
        {
            string sql = @"select * FROM personel_view";

            return SqlDataAccess.LoadData<AdamSaatGorunum>(sql);
        }
        public static int UpdatePersonelAylikSaat(PersonelAylikSaat gerceklesen,PlanlananPersonelAylikSaat planlanan,FaturalananPersonelAylikSaat faturalanan)
        {
            string sqlGerceklesen = @"UPDATE AYLIKSAAT SET OCAK = :OCAK,SUBAT=:SUBAT,MART=:MART,NISAN=:NISAN,MAYIS=:MAYIS,HAZIRAN=:HAZIRAN,TEMMUZ=:TEMMUZ,AGUSTOS=:AGUSTOS,EYLUL=:EYLUL,EKIM=:EKIM,KASIM=:KASIM,ARALIK=:ARALIK WHERE PERSONEL_ID = :PERSONEL_ID";
            string sqlPlanlanan = @"UPDATE PLANLANANAYLIKSAAT SET POCAK = :POCAK,PSUBAT=:PSUBAT,PMART=:PMART,PNISAN=:PNISAN,PMAYIS=:PMAYIS,PHAZIRAN=:PHAZIRAN,PTEMMUZ=:PTEMMUZ,PAGUSTOS=:PAGUSTOS,PEYLUL=:PEYLUL,PEKIM=:PEKIM,PKASIM=:PKASIM,PARALIK=:PARALIK WHERE PERSONEL_ID = :PERSONEL_ID";
            string sqlFaturalanan = @"UPDATE FATURALANANAYLIKSAAT SET FOCAK = :FOCAK,FSUBAT=:FSUBAT,FMART=:FMART,FNISAN=:FNISAN,FMAYIS=:FMAYIS,FHAZIRAN=:FHAZIRAN,FTEMMUZ=:FTEMMUZ,FAGUSTOS=:FAGUSTOS,FEYLUL=:FEYLUL,FEKIM=:FEKIM,FKASIM=:FKASIM,FARALIK=:FARALIK WHERE PERSONEL_ID = :PERSONEL_ID";


           SqlDataAccess.UpdateData<PersonelAylikSaat>(gerceklesen, sqlGerceklesen);
           SqlDataAccess.UpdateData<PlanlananPersonelAylikSaat>(planlanan, sqlPlanlanan);
           return SqlDataAccess.UpdateData<FaturalananPersonelAylikSaat>(faturalanan, sqlFaturalanan);



        }
        //public static PersonelAylikSaat LoadPersonelAylikSaatWithId(int id)
        //{
        //    string sql = @"select * FROM AYLIKSAAT WHERE PERSONEL_ID = :ID";
        //    return SqlDataAccess.LoadDatawithId<PersonelAylikSaat>(sql, id);

        //}

        public static dynamic LoadPersonelAylikSaatWithId(int id)
        {
            string sql = @"SELECT p.*, a.*, f.* FROM AYLIKSAAT a FULL OUTER JOIN PLANLANANAYLIKSAAT p ON a.PERSONEL_ID = p.PERSONEL_ID FULL OUTER JOIN FATURALANANAYLIKSAAT f ON p.PERSONEL_ID = f.PERSONEL_ID WHERE p.PERSONEL_ID = :ID";
            return SqlDataAccess.LoadDatawithId<dynamic>(sql, id);

        }


        public static int UpdatePersonelAylikSaatWithComboBox(AylikSaatComboBox model)
        {
            string month = Convert.ToString(model.ListMonths);
            string sql = $"UPDATE AYLIKSAAT SET {month} = :Value WHERE PERSONEL_ID = :id";


            dynamic output = new
            {
                id = model.combobox_id,
                Value = model.Value,
                

            };


            
            
            

           
            return SqlDataAccess.UpdateData<dynamic>(output, sql);


        }

    }
}
