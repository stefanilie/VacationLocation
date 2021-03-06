﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VacationLocation
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

        public string relief { get; set; }

        public string likes { get; set; }

        public string rating { get; set; }

        public string photoLink { get; set; }

        public DestinationsClass() { }

        public DestinationsClass(string city, string country, string population,
            string climate, string suitableForFamilies, string suitableForCouples, 
            string minAge, string maxAge, string relief, string likes, /*string rating,*/ string photoLink)
        {
            this.city = city;
            this.country = country;
            this.population = population;
            this.climate = climate;
            this.suitableForCouples = suitableForCouples;
            this.suitableForFamilies = suitableForFamilies;
            this.minAge = minAge;
            this.maxAge = maxAge;
            this.relief = relief;
            this.likes = likes;
           // this.rating = rating;
            this.photoLink = photoLink;
        }

        public DestinationsClass(string id, string city, string country, string population,
            string climate, string suitableForFamilies, string suitableForCouples, 
            string minAge, string maxAge, string relief, string likes,/* string rating,*/ string photoLink)
        {
            this.id = id;
            this.city = city;
            this.country = country;
            this.population = population;
            this.climate = climate;
            this.suitableForCouples = suitableForCouples;
            this.suitableForFamilies = suitableForFamilies;
            this.minAge = minAge;
            this.maxAge = maxAge;
            this.relief = relief;
            this.likes = likes;
          //  this.rating = rating;
            this.photoLink = photoLink;
        }

        //Create a method that generates dynamically the query depending on what can be found in the form.
        private static string createQueryFromFormInfo(string age, string status, string kids,
            string birth, string residence, string climate, string destination, string relief)
        {
            string strQuery = "select * from destinatii WHERE city != '" + birth + "' AND city != '" + residence + /*"' AND climate = '" + climate + */"' AND " + age
                + " BETWEEN minAge AND maxAge";
            if(climate!="anyClimate")
            { strQuery +=" AND climate = '" + climate+"'"; }
            if (kids == "Yes")
            /*  {
                  strQuery += " AND suitableForFamilies = no";
              }
              else*/
            {
                strQuery += " And suitableForFamilies = 'yes'";
            }

            if (status == "In o relatie/Casatorit(a)")
            {
                strQuery += " AND suitableForCouples = 'yes'";
            }
           
            if (destination != "anyDest")
            {
                if (destination == "bigCity")
                {
                    strQuery += " AND population > 800000";
                }
                if (destination == "smallDest")
                {
                    strQuery += " AND population between 100000 AND 800000 ";
                }
                if (destination == "tinyDest")
                {
                    strQuery += " AND population < 100000 ";
                }
            }

            if (relief != "anyRel")
            { strQuery += " AND relief = '" + relief+"'"; }

            return strQuery;
        }


           
            
        public static List<DestinationsClass> recommendShite(string age, string status, string kids,
            string birth, string residence, string climate, string destination, string tipRelief)
        {
 
            List<DestinationsClass> arrDestinations = new List<DestinationsClass>();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connectionString);
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand("", conn);
            string strQuery = createQueryFromFormInfo(age, status, kids, birth, residence, climate, destination, tipRelief);

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
                    string strPopulation = sqlReader.GetInt32(3).ToString();
                    string strClimate = sqlReader.GetString(4).ToString();
                    string strSuitableForFamilies = sqlReader.GetString(5).ToString();
                    string strSuitableForCouples = sqlReader.GetString(6).ToString();
                    string strMinAge = sqlReader.GetInt32(7).ToString();
                    string strMaxAge = sqlReader.GetInt32(8).ToString();
                    string relief = sqlReader.GetString(9).ToString();
                    string likes = sqlReader.GetInt32(10).ToString();
                   // string rating = sqlReader.GetInt32(11).ToString();
                    string strPhotoLink = sqlReader.GetString(12);

                    DestinationsClass objArticle = new DestinationsClass(id, strCity, strCountry, strPopulation, 
                        strClimate, strSuitableForFamilies, strSuitableForCouples, 
                        strMinAge, strMaxAge, relief, likes, strPhotoLink);

                    arrDestinations.Add(objArticle);
                }

                // add algorithm below



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