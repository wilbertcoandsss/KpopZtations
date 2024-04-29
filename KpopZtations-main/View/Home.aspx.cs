using KpopZtations.Controller;
using KpopZtations.Handler;
using KpopZtations.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtations.View
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        CustomerController cc = new CustomerController();
        ArtistHandler ah = new ArtistHandler();

        public List<Artist> artist = new List<Artist>();

        protected void Page_Load(object sender, EventArgs e)
        {
            artist = ah.getAllArtist();

            artistRepeater.DataSource = artist;
            artistRepeater.DataBind();

            insertArtist.DataBind();

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            cc.logout();
            Response.Redirect("Login.aspx");
        }

        protected bool ShowElementByCustomer()
        {
            String role = Session["userRole"] as String;
            if (role == "Customer")
            {
                return true;
            }
            return false;
        }
        protected bool ShowElementByAdmin()
        {
            String role = Session["userRole"] as String;
            if (role == "Admin")
            {
                return true;
            }
            return false;
        }
        protected bool ShowElementByGuest()
        {
            String role = Session["userRole"] as String;
            if (role == null)
            {
                return true;
            }
            return false;
        }

        protected void insertArtist_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertArtistPage.aspx");
        }

        protected void updateArtistPageBtn_Click(object sender, EventArgs e)
        {

        }

        protected void deleteArtistBtn_Click(object sender, EventArgs e)
        {

        }
    }
}