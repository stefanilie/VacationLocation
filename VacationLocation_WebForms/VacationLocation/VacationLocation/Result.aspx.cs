using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VacationLocation
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblResult.Text = Session["results"].ToString();
        }

        [WebMethod]
        public static void Rate(int rating)
        {
            string constr = ConfigurationManager.ConnectionStrings["ConexiuneaLuiDumnezeu"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Destinatii VALUES(@rating)"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@rating", rating);
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
        }

        [WebMethod]
        public static string GetRating()
        {
            string sql = "SELECT ROUND(ISNULL(CAST(SUM(rating) AS NUMERIC(5, 2)) / COUNT(rating), 0), 1) Average";
            sql += ", COUNT(rating) Total FROM Destinatii";
            string constr = ConfigurationManager.ConnectionStrings["ConexiuneaLuiDumnezeu"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sql))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    string json = string.Empty;
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        json += "[ {";
                        json += string.Format("Average: {0}, Total: {1}", sdr["Average"], sdr["Total"]);
                        json += "} ]";
                        sdr.Close();
                    }
                    con.Close();
                    return json;
                }
            }
        }
    }
}