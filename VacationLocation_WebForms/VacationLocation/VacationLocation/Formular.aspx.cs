using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VacationLocation
{
    public partial class Formular : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string sprintStuff(List<DestinationsClass> arrDealer)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            foreach(DestinationsClass deal in arrDealer)
            {
                sb.Append(string.Format(@"<table class='dealTable'>
                
                <tr>
                    <th>id:</th>
                    <td>{0}</td>
                </tr>

                <tr>
                    <th>City:</th>
                    <td>{1}</td>
                </tr>
                
                <tr>
                    <th>Country:</th>
                    <td>{2}</td>
                </tr>

                <tr>
                    <th>Population:</th>
                    <td>{3}</td>
                </tr>   
                <tr>
                    <th>Climate:</th>
                    <td>{4}</td>
                </tr>
                <tr>
                    <th>Suitable for families:</th>
                    <td>{5}</td>
                </tr>
                <tr>
                    <th>Suitable for couples:</th>
                    <td>{6}</td>
                </tr>
                <tr>
                    <th>Min age:</th>
                    <td>{7}</td>
                </tr>  
                <tr>
                    <th>MaxAge:</th>
                    <td>{8}</td>
                </tr>        
                </table><br><br>", deal.id, deal.city.ToString(), deal.country.ToString(), deal.population, deal.climate.ToString(),
                                 deal.suitableForFamilies, deal.suitableForCouples, deal.minAge, deal.maxAge ));
            }
            return sb.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (rbNo.Checked)
            {
                var destination = DestinationsClass.recommendShite(txtAge.Text, ddStatus.SelectedValue, rbNo.Text, txtBirthPlace.Text,
                    txtLivingPlace.Text, ddClimate.SelectedValue, ddDestination.SelectedValue,ddRelief.SelectedValue);
                string results = this.sprintStuff(destination);
                Session["results"] = results;
                Response.Redirect("Result.aspx");
            }
            else if (rbYes.Checked)
            {
                var destination = DestinationsClass.recommendShite(txtAge.Text, ddStatus.SelectedValue, rbYes.Text, txtBirthPlace.Text,
                    txtLivingPlace.Text, ddClimate.SelectedValue, ddDestination.SelectedValue, ddRelief.SelectedValue);
                this.sprintStuff(destination);
                string results = this.sprintStuff(destination);
                Session["results"] = results;
                Response.Redirect("Result.aspx");
            }
                
        }
    }
}