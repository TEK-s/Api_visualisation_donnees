using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using ApiPopStat.Models;

namespace ApiPopStat.Data
{
    internal class PopulationDAO
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDTNAPPIContext-d4b66555-e921-4b40-8df2-ad5e5727a47b;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public Population fetchAll_years(int Id)
        {
            Population returnList = new Population();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * from Population where id=" +Id;
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        Population population = new Population();

                        population.id = reader.GetInt32(0);
                        population.Country_Name = reader.GetString(1);
                        population.Country_Code = reader.GetString(2);

                        for (int i = 3; i < 56; i++)
                        {
                            population.Years.Add(reader.GetDouble(i));
                        }

                        returnList=population;
                    }
                }
            }
            return returnList;
        }
        public List<string> fetch_One_name(int Id)
        {
            List<string> returnList = new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT country_name from Population where id=" +Id;
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        Population population = new Population();

                        population.Country_Name = reader.GetString(0);


                        returnList.Add(population.Country_Name);
                    }
                }
            }
            return returnList;
        }
        public List<Population> fetchAll_name()
        {
            List<Population> returnList = new List<Population>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT id, country_name from Population ";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        Population population = new Population();

                        population.id = reader.GetInt32(0);
                        population.Country_Name = reader.GetString(1);


                        returnList.Add(population);
                    }
                }
            }
            return returnList;
        }
        public Population fetchOne(int id)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * from Population where id="+id;
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Population population = new Population();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {


                        population.id = reader.GetInt32(0);
                        population.Country_Name = reader.GetString(1);
                        population.Country_Code = reader.GetString(2);

                        for(int i = 5; i <16 ; i++)
                        {
                            

                            var test = reader.GetString(i);

                            var result = double.TryParse(test, System.Globalization.NumberStyles.AllowDecimalPoint, new CultureInfo("en-US"), out var resultParse);

                            population.Years.Add(resultParse);
                        }
                    }
                }
                return population;
            }


        }

        public Population fetch_All_Years(int id)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                string sqlQuery = "SELECT * from Population where id=" + id;
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                connection.Open();
                SqlDataReader readers = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(readers);
                int total_column = dataTable.Columns.Count;

                SqlDataReader reader = command.ExecuteReader();
                Population population = new Population();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {


                        population.id = reader.GetInt32(0);
                        population.Country_Name = reader.GetString(1);
                        population.Country_Code = reader.GetString(2);

                        for (int i = 5; i < total_column; i++)
                        {


                            var test = reader.GetString(i);

                            var result = double.TryParse(test, System.Globalization.NumberStyles.AllowDecimalPoint, new CultureInfo("en-US"), out var resultParse);

                            population.Years.Add(resultParse);
                        }
                    }
                }
                return population;
            }


        }



        public Population fetch_population_5_ans(int id)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from Population where id=" + id;
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                connection.Open();
                SqlDataReader readers = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(readers);
                int total_column = dataTable.Columns.Count;

                SqlDataReader reader = command.ExecuteReader();
                Population population = new Population();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {


                        population.id = reader.GetInt32(0);
                        population.Country_Name = reader.GetString(1);
                        population.Country_Code = reader.GetString(2);

                        for (int i = total_column-5; i <= total_column-1; i++)
                        {


                            var test = reader.GetString(i);

                            var result = double.TryParse(test, System.Globalization.NumberStyles.AllowDecimalPoint, new CultureInfo("en-US"), out var resultParse);

                            population.Years.Add(resultParse);
                        }
                    }
                }
                
                return population;
            }


        }

        public Population fetch_population_10_ans(int id)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from Population where id=" + id;
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                connection.Open();
                SqlDataReader readers = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(readers);
                int total_column = dataTable.Columns.Count;

                SqlDataReader reader = command.ExecuteReader();
                Population population = new Population();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {


                        population.id = reader.GetInt32(0);
                        population.Country_Name = reader.GetString(1);
                        population.Country_Code = reader.GetString(2);

                        for (int i = total_column - 10; i <= total_column - 1; i++)
                        {


                            var test = reader.GetString(i);

                            var result = double.TryParse(test, System.Globalization.NumberStyles.AllowDecimalPoint, new CultureInfo("en-US"), out var resultParse);

                            population.Years.Add(resultParse);
                        }
                    }
                }

                return population;
            }


        }
        public Population fetch_population_20_ans(int id)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from Population where id=" + id;
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                connection.Open();
                SqlDataReader readers = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(readers);
                int total_column = dataTable.Columns.Count;

                SqlDataReader reader = command.ExecuteReader();
                Population population = new Population();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {


                        population.id = reader.GetInt32(0);
                        population.Country_Name = reader.GetString(1);
                        population.Country_Code = reader.GetString(2);

                        for (int i = total_column - 20; i <= total_column - 1; i++)
                        {


                            var test = reader.GetString(i);

                            var result = double.TryParse(test, System.Globalization.NumberStyles.AllowDecimalPoint, new CultureInfo("en-US"), out var resultParse);

                            population.Years.Add(resultParse);
                        }
                    }
                }

                return population;
            }


        }
        public Population fetch_population_30_ans(int id)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from Population where id=" + id;
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                connection.Open();
                SqlDataReader readers = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(readers);
                int total_column = dataTable.Columns.Count;

                SqlDataReader reader = command.ExecuteReader();
                Population population = new Population();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {


                        population.id = reader.GetInt32(0);
                        population.Country_Name = reader.GetString(1);
                        population.Country_Code = reader.GetString(2);

                        for (int i = total_column - 30; i <= total_column - 1; i++)
                        {


                            var test = reader.GetString(i);

                            var result = double.TryParse(test, System.Globalization.NumberStyles.AllowDecimalPoint, new CultureInfo("en-US"), out var resultParse);

                            population.Years.Add(resultParse);
                        }
                    }
                }

                return population;
            }


        }
        public Population fetch_population_40_ans(int id)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from Population where id=" + id;
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                connection.Open();
                SqlDataReader readers = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(readers);
                int total_column = dataTable.Columns.Count;

                SqlDataReader reader = command.ExecuteReader();
                Population population = new Population();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {


                        population.id = reader.GetInt32(0);
                        population.Country_Name = reader.GetString(1);
                        population.Country_Code = reader.GetString(2);

                        for (int i = total_column - 40; i <= total_column - 1; i++)
                        {


                            var test = reader.GetString(i);

                            var result = double.TryParse(test, System.Globalization.NumberStyles.AllowDecimalPoint, new CultureInfo("en-US"), out var resultParse);

                            population.Years.Add(resultParse);
                        }
                    }
                }

                return population;
            }


        }
        public Population fetch_population_50_ans(int id)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from Population where id=" + id;
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                connection.Open();
                SqlDataReader readers = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(readers);
                int total_column = dataTable.Columns.Count;

                SqlDataReader reader = command.ExecuteReader();
                Population population = new Population();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {


                        population.id = reader.GetInt32(0);
                        population.Country_Name = reader.GetString(1);
                        population.Country_Code = reader.GetString(2);

                        for (int i = total_column - 50; i <= total_column - 1; i++)
                        {


                            var test = reader.GetString(i);

                            var result = double.TryParse(test, System.Globalization.NumberStyles.AllowDecimalPoint, new CultureInfo("en-US"), out var resultParse);

                            population.Years.Add(resultParse);
                        }
                    }
                }

                return population;
            }


        }
        public void Insert(int Id, string year, double croissance)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string requete_Add_Year = "ALTER TABLE Population ADD " +year+"NVARCHAR";
                SqlCommand command = new SqlCommand(requete_Add_Year, connection);

                string insert = "INSERT INTO Population (" + year + ")VALUES @croissance";
                command.Parameters.AddWithValue("@croissance", SqlDbType.NVarChar);
                command.Parameters["@croissance"].Value = croissance;
               

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();

            }

        }

        public int Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "Delete from dbo.population where id=" + id;
                connection.Open();
                int DeletedId = command.ExecuteNonQuery();
                return DeletedId;
            }
        }

        public void Update(string indicator_name, string indicator_code, int Id, string year, double croissance)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE dbo.population(Indicator_Name, Indicator_Code, "+year+")" +
                    "VALUES (@Indicator_Name, @Indicator_Code, @croissance) WHERE id = " + Id;

                command.Parameters.AddWithValue("@Indicator_Name", indicator_name);
                command.Parameters.AddWithValue("@Indicator_Code", indicator_code);
                command.Parameters.AddWithValue("@Indicator_Code", croissance);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
