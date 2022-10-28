using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using ApiPopStat.Models;

namespace ApiPopStat.Data
{
    internal class PaysDAO
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDTNAPPIContext-d4b66555-e921-4b40-8df2-ad5e5727a47b;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
            public List<Pays> fetchAll()
            {
            List<Pays> returnList = new List<Pays>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * from Pays where region is not null";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                connection.Open();
              SqlDataReader reader =  command.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                       
                        Pays pays = new Pays();
                        pays.id = reader.GetInt32(0);
                        pays.Country_Name = reader.GetString(1);
                        pays.Country_Code = reader.GetString(2);
                        pays.Region = reader.GetString(3);
                        pays.Income_Group = reader.GetString(4);
                        
                        returnList.Add(pays);
                    }
                }
            }
            return returnList;  
            }
        public List<String> fetchIncome()
        {
            List<String> returnList = new List<String>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT DISTINCT Income_Group from Pays";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        String pays;
                     
                        pays= reader.GetString(0);
                      

                        returnList.Add(pays);
                    }
                }
            }
            return returnList;
        }
        public List<String> fetch_Region()
        {
            List<String> returnList = new List<String>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT Region from Pays where Region is not null group by Region ";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        String pays;

                        pays = reader.GetString(0);


                        returnList.Add(pays);
                    }
                }
            }
            return returnList;
        }
        public List<int> fetch_count_income()
        {
            List<int> returnList = new List<int>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "select count(Income_Group) from Pays group by Income_Group";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Pays pays = new Pays();

                        pays.count = reader.GetInt32(0);


                        returnList.Add(pays.count);
                    }
                }
            }
            return returnList;
        }
        public List<int> fetch_count_Region()
        {
            List<int> returnList = new List<int>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "select count(Region) from Pays group by Region";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Pays pays = new Pays();

                        pays.count = reader.GetInt32(0);


                        returnList.Add(pays.count);
                    }
                }
            }
            return returnList;
        }
        public Pays fetchOneCountry(int id)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * from Pays where id=@id";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Pays pays = new Pays();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                  
                        pays.id = reader.GetInt32(0);
                        pays.Country_Name = reader.GetString(1);
                        pays.Country_Code = reader.GetString(2);
                        pays.Region = reader.GetString(3);
                        pays.Income_Group = reader.GetString(4);

                    }
                }
                return pays;
            }

            
        }

        internal int Delete(int id)
        {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlQuery = "Delete from dbo.Pays where id=@id";
                   
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.Add("@id", System.Data.SqlDbType.VarChar).Value = id;
                   
                    connection.Open();
                    int DeletedId = command.ExecuteNonQuery();
                    return DeletedId;
                }

            
        }

        public  int create(Pays pays)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "";
                if (pays.id <= 0)
                {
                    sqlQuery = "Insert into dbo.Pays values(@Country_Name,@Country_Code,@Region,@Income_Group)";
                }
                else
                {
                    sqlQuery = "UPDATE dbo.Pays SET Country_Name=@Country_Name,Country_Code=@Country_Code,Region=@Region,Income_Group=@Income_Group where id=@id";
                }
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@id", System.Data.SqlDbType.VarChar).Value = pays.id;
                command.Parameters.Add("@Country_Name", System.Data.SqlDbType.VarChar).Value = pays.Country_Name;
                command.Parameters.Add("@Country_Code", System.Data.SqlDbType.VarChar).Value = pays.Country_Code;
                command.Parameters.Add("@Region", System.Data.SqlDbType.VarChar).Value = pays.Region;
                command.Parameters.Add("@Income_Group", System.Data.SqlDbType.VarChar).Value = pays.Income_Group;
                connection.Open();
                int newId= command.ExecuteNonQuery();
                return newId;
            }

        }

    }
}