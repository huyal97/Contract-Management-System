using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DataAccess;
using DataLibrary.Models;



namespace DataLibrary.BusinessLogic
{
    public static class SozlesmeProcessor
    {

        public static int CreateSozlesme(string firma, DateTime tarih, DateTime tarihBitis, int arti_eksilis, string baslik, DateTime talep_tarihi, DateTime tamamlanma_tarihi, string Bolge, string Faturalama_Durum, string Sorumlu)
        {
            SozlesmeDatabaseModel data = new SozlesmeDatabaseModel
            {
                Firma = firma,
                Tarih = tarih,
                TarihBitis = tarihBitis,
                Arti_Eksilis = arti_eksilis,
                Baslik = baslik,
                Talep_Tarihi= talep_tarihi,
                Tamamlanma_Tarihi = tamamlanma_tarihi,
                Bolge = Bolge,
                Faturalama_Durum = Faturalama_Durum,
                Sorumlu = Sorumlu

            };
            string sql = @"INSERT INTO SOZLESME (ARTI_EKSILIS, BASLIK, FIRMA, TALEP_TARIHI, TAMAMLANMA_TARIHI,TARIH,TARIHBITIS,BOLGE,FATURALAMA_DURUM,SORUMLU) VALUES (:ARTI_EKSILIS,:BASLIK,:FIRMA, :TALEP_TARIHI,:TAMAMLANMA_TARIHI, :TARIH,:TARIHBITIS,:BOLGE,:FATURALAMA_DURUM,:SORUMLU)";
            return SqlDataAccess.SaveDataWithId<SozlesmeDatabaseModel>(sql, data);
            
        }
        
        public static int CreatePersonel(int Adamsaat,string Sorumluyonetici,int Rate,string Uzmanlik, string Kaynaktipi,string Isim,int Sozlesme_Id)
        {
            PersonelDatabaseModel data = new PersonelDatabaseModel
            {
                KaynakTipi = Kaynaktipi,              
                AdamSaat = Adamsaat,
                SorumluYonetici = Sorumluyonetici,
                Rate = Rate,
                Uzmanlik = Uzmanlik,
                Isim = Isim,               
                Sozlesme_Id = Sozlesme_Id

            };
            string sql = @"INSERT INTO PERSONEL (KAYNAKTIPI,ADAMSAAT,SORUMLUYONETICI,RATE,SOZLESME_ID,ISIM,UZMANLIK) VALUES (:KaynakTipi,:AdamSaat,:SorumluYonetici,:Rate,:Sozlesme_Id,:Isim,:Uzmanlik)";
            string sqlAylikSaat = @"INSERT INTO AYLIKSAAT (PERSONEL_ID) VALUES (:ID)";
            string sqlFaturalananSaat = @"INSERT INTO FATURALANANAYLIKSAAT (PERSONEL_ID) VALUES (:ID)";
            string sqlPlanlananSaat = @"INSERT INTO PLANLANANAYLIKSAAT (PERSONEL_ID) VALUES (:ID)";
            int PersonelId = SqlDataAccess.SaveDataPersonelWithId<PersonelDatabaseModel>(sql, data);
            SqlDataAccess.SaveData<int>(sqlPlanlananSaat, PersonelId);
            SqlDataAccess.SaveData<int>(sqlFaturalananSaat, PersonelId);
            return SqlDataAccess.SaveData<int>(sqlAylikSaat, PersonelId);

            

        }
        
        public static int DeleteSozlesme(int ID)
        {
            int Id = ID;
            string sql = @"DELETE FROM SOZLESME WHERE SOZLESME_ID=:ID";
            string sql2 = @"DELETE FROM PERSONEL WHERE SOZLESME_ID=:ID";
            

            return SqlDataAccess.DeleteData<int>(sql,sql2, Id);


        }

        public static List<SozlesmeDatabaseModel> LoadSozlesme()
        {
            string sql = @"select * FROM SOZLESME";

            return SqlDataAccess.LoadData<SozlesmeDatabaseModel>(sql);
        }

        //public static List<SozlesmeDatabaseModel> LoadSozlesmeWithId(int ID)
        //{

        //    string sql = @"select * FROM SOZLESME WHERE SOZLESME_ID=:ID";

        //    return SqlDataAccess.LoadDataWithId<SozlesmeDatabaseModel>(sql, ID);
        //}
        public static SPDatabaseModel LoadSozlesmeWithId(int ID)
        {

            string sql = "SELECT * FROM SOZLESME WHERE SOZLESME_ID = :ID ";
            string sqlP = "SELECT * FROM PERSONEL WHERE SOZLESME_ID = :ID";
            return SqlDataAccess.LoadDataWithId(sql,sqlP, ID);
        }
        public static int UpdateSozlesmePersonel(SozlesmeDatabaseModel SDM,List<PersonelDatabaseModel> PDM)
        {
            string SozlesmeSql = "UPDATE SOZLESME SET FIRMA = :FIRMA, TARIH= :TARIH,ARTI_EKSILIS = :ARTI_EKSILIS, BASLIK=:BASLIK,TALEP_TARIHI=:TALEP_TARIHI,TAMAMLANMA_TARIHI =:TAMAMLANMA_TARIHI WHERE SOZLESME_ID = :SOZLESME_ID";
            string PersonelSql = "UPDATE PERSONEL SET ADAMSAAT = :ADAMSAAT,RATE= :RATE, SORUMLUYONETICI= :SORUMLUYONETICI, BOLGE=:BOLGE, KAYNAKTIPI=:KAYNAKTIPI WHERE SOZLESME_ID = :Sozlesme_Id AND PERSONEL_ID = :PERSONEL_ID ";

           
            return SqlDataAccess.UpdateData(SDM,PDM, SozlesmeSql,PersonelSql);
        }
    }
}

    

