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

                <div class='img-result'>
                    <img class=""img-circle2"" alt='Circular Image' src='{0}'/>
                    <p>Locatie: {1}</p>
                    <p>Tara: {2}</p>
                </div>

                <tr>
                    <th><h3>Locatie:</h3></th>
                    <td><h3>{1}</h3></td>
                </tr>
            
                <tr>
                    <th><h3>Tara:</h3></th>
                    <td><h3>{2}</h3></td>
                </tr>
      
                </table><br><br>", deal.photoLink, deal.city.ToString(), deal.country.ToString()));
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