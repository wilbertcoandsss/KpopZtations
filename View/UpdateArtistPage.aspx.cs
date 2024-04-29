using KpopZtations.Controller;
using KpopZtations.Handler;
using KpopZtations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtations.View
{
    public partial class UpdateArtistPage : System.Web.UI.Page
    {
        ArtistHandler ah = new ArtistHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            int id = Convert.ToInt32(Request.QueryString["id"]);
            Artist artist = ah.getArtist(id);
            artistNameTb.Attributes["placeholder"] = artist.ArtistName;
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            String name = artistNameTb.Text;

            ArtistController ac = new ArtistController();
            int id = Convert.ToInt32(Request.QueryString["id"]);

            lblError.Text = ac.doUpdate(id, name, artistImageFile);

            if (lblError.Text == "")
            {
                Response.Redirect("Home.aspx");
            }
        }
    }
}