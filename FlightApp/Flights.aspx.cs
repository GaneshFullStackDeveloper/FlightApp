using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlightApp
{
    public partial class Flights : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FlightDbConnection flightDbConnection = new FlightDbConnection();
                DataTable dtResult = flightDbConnection.SelectFlights();
                gvflights.DataSource = dtResult;
                gvflights.DataBind();
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            FlightDbConnection flightDbConnection = new FlightDbConnection();
          string msg=  flightDbConnection.InsertFlight(txtflightname.Text, txtflighttype.Text, txtcountry.Text);
        if(msg!="")
            {
                lblErrMsg.Visible = false;
                lblSuccessMsg.Visible = true;
                lblSuccessMsg.Text = msg;
                DataTable dtResult = flightDbConnection.SelectFlights();
                gvflights.DataSource = dtResult;
                gvflights.DataBind();
            }
            else
            {
                lblSuccessMsg.Visible = false;
                lblErrMsg.Visible = true;
                lblErrMsg.Text = "Not Inserted";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            FlightDbConnection flightDbConnection = new FlightDbConnection();
            string msg = flightDbConnection.DeleteFlightByid(Convert.ToInt32(txtflightid.Text));
            if (msg != "")
            {
                lblErrMsg.Visible = false;
                lblSuccessMsg.Visible = true;
                lblSuccessMsg.Text = msg;
                DataTable dtResult = flightDbConnection.SelectFlights();
                gvflights.DataSource = dtResult;
                gvflights.DataBind();
            }
            else
            {
                lblSuccessMsg.Visible = false;
                lblErrMsg.Visible = true;
                lblErrMsg.Text = "Not Deleted";
            }
        }
    }
}