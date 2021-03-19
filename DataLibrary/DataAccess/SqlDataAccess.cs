using Dapper;
using DataLibrary.Models;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace DataLibrary.DataAccess
{
    public class SqlDataAccess
    {

        public static string GetConnectionString()
        {
            string ConnectionString = "DATA SOURCE=localhost:1521/xe;USER ID=HOMEDB;Password=qweasd";
            return ConnectionString;
        }

        
        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cnn = new OracleConnection(GetConnectionString()))

            {
                return cnn.Query<T>(sql).ToList();
            }
        }
        public static T LoadDatawithId<T>(string sql,int id)
        {
            using (IDbConnection cnn = new OracleConnection(GetConnectionString()))

            {
                return cnn.Query<T>(sql,new { ID = id } ).First();
            }
        }
        public static SPDatabaseModel LoadDataWithId(string sql, string sqlP, int Id)
        {
            using (IDbConnection cnn = new OracleConnection(GetConnectionString()))

            {
                SPDatabaseModel model = new SPDatabaseModel();
                model.Sozlesme = cnn.Query<SozlesmeDatabaseModel>(sql, new { ID = Id }).First();
                model.Personels = cnn.Query<PersonelDatabaseModel>(sqlP, new { ID = Id }).ToList();

                return model;
            }
        }

        public static int SaveDataWithId<T>(string sql, T data)
        {

            using (IDbConnection cnn = new OracleConnection(GetConnectionString()))
            {
                cnn.Execute(sql, data);
                return cnn.QuerySingle<int>("SELECT max(SOZLESME_ID) from SOZLESME");
            };
        }
        public static int SaveDataPersonelWithId<T>(string sql, T data)
        {

            using (IDbConnection cnn = new OracleConnection(GetConnectionString()))
            {
                cnn.Execute(sql, data);
                return cnn.QuerySingle<int>("SELECT max(PERSONEL_ID) from PERSONEL");
            };
        }
        public static int SaveData<T>(string sql, T data)
        {

            using (IDbConnection cnn = new OracleConnection(GetConnectionString()))
            {
                
                return cnn.Execute(sql, new { ID = data });

            };
        }
        public static int DeleteData<T>(string sql, T Id)
        {
            using (IDbConnection cnn = new OracleConnection(GetConnectionString()))
            {
                return cnn.Execute(sql, new { ID = Id });
            }

        }
        public static int DeleteData<T>(string sql,string sql2, T Id)
        {
            using (IDbConnection cnn = new OracleConnection(GetConnectionString()))
            {
                cnn.Execute(sql, new { ID = Id });
                return cnn.Execute(sql2, new { ID = Id });
            }

        }
        public static int UpdateData(SozlesmeDatabaseModel SDM,List<PersonelDatabaseModel> PDM, string SozlesmeSql,string PersonelSql)
        {
            using (IDbConnection cnn = new OracleConnection(GetConnectionString()))
            {
                cnn.Execute(SozlesmeSql, SDM);
                foreach(PersonelDatabaseModel model in PDM)
                {
                    cnn.Execute(PersonelSql, model);
                }
                return 1;
            }
        }
        public static int UpdateData<T>(T model,string sql)
        {
            using (IDbConnection cnn = new OracleConnection(GetConnectionString()))
            {
                return cnn.Execute(sql, model);
      
            }
        }




    }
}
