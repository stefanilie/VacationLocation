using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VacationLocation.Scripts
{
    public class DestinationsClass
    {
        public string id { get; set; }

        public string city { get; set; }

        public string country { get; set; }

        public string population { get; set; }

        public string climate { get; set; }

        public string suitableForFamilies { get; set; }

        public string suitableForCouples { get; set; }

        public string minAge { get; set; }

        public string  maxAge { get; set; }

        public DestinationsClass(string city, string country, string population,
            string climate, string suitableForFamilies, string suitableForCouples, string minAge, string maxAge)
        {
            this.city = city;
            this.country = country;
            this.population = population;
            this.climate = climate;
            this.suitableForCouples = suitableForCouples;
            this.suitableForFamilies = suitableForFamilies;
            this.minAge = minAge;
            this.maxAge = maxAge;
        }

        public List<DestinationsClass> recommendShite(string age, string status, string kids,
            string birth, string residence, string climate, string destination)
        {
 
            List<DestinationsClass> arrDestinations = new List<DestinationsClass>();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConexiuneaLuiDumnezeu"].ToString();
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connectionString);
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand("", conn);
            string strQuery;

            //Create a method that generates dynamically the query depending on what can be found in the form.
                strQuery = "SELECT * FROM Destinatii WHERE climate = "+climate;  //MODIFICA AICI

            try
            {
                conn.Open();
                command.CommandText = strQuery;
                System.Data.SqlClient.SqlDataReader sqlReader = command.ExecuteReader();

                while (sqlReader.Read())
                {
                    //Guid id = new Guid(sqlReader.GetGuid(0).ToString());
                    string id = sqlReader.GetInt32(0).ToString();
                    string strCity = sqlReader.GetValue(1).ToString();
                    string strCountry = sqlReader.GetValue(2).ToString();
                    string strPopulation = sqlReader.GetString(3).ToString();
                    string strClimate = sqlReader.GetString(4).ToString();
                    string strSuitableForFamilies = sqlReader.GetString(5).ToString();
                    string strSuitableForCouples = sqlReader.GetString(6).ToString();
                    string strMinAge = sqlReader.GetString(7).ToString();
                    string strMaxAge = sqlReader.GetString(8).ToString();


                    DestinationsClass objArticle = new DestinationsClass(strCity, strCountry, strPopulation, 
                        strClimate, strSuitableForFamilies, strSuitableForCouples, strMinAge, strMaxAge);

                    arrDestinations.Add(objArticle);
                }
            }
            finally
            {
                conn.Close();
                command.Parameters.Clear();
            }

            return arrDestinations;
        }
    }
}