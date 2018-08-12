using JourneyService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ClientWebApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            JourneySearch journey = new JourneySearch();

            //call web method
            string[] results = journey.GetDistance(txtStation1.Text, txtStation2.Text);

            //check error message was not returned from method
            if(results[0] == "0" || results[1] == "0")
            {
                //clear results
                this.lblDistance.Text = "";
                this.lblTime.Text = "";
                this.lblChange.Text = "";

                //write error message
                this.lblError.Text = "One of the stations entered does not exist!";
            }
            else
            {
                //write results
                if (CbKm.Checked)
                {
                    double dist = Double.Parse(results[0]);

                    this.lblDistance.Text = "Distance: " + ((dist * 1.6) + " km");
                }
                else
                {
                    this.lblDistance.Text = "Distance: " + results[0] + " miles"; 
                }
                
                this.lblTime.Text = "Time: " + results[1];
                this.lblChange.Text = "Change at station: " + results[2];

                //clear error message
                this.lblError.Text = "";
            }
            
            
       
        }

        //button to clear form
        protected void BtnClear_Click(object sender, EventArgs e)
        {
            this.txtStation1.Text = "";
            this.txtStation2.Text = "";
            this.lblDistance.Text = "";
            this.lblTime.Text = "";
            this.lblChange.Text = "";
            this.lblError.Text = "";
        }
    }
}