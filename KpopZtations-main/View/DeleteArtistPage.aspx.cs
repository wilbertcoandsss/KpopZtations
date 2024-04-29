using KpopZtations.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtations.View
{
    public partial class DeleteArtistPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"].ToString());
            ArtistController ac = new ArtistController();
            ac.doDelete(id);

            Response.Redirect("Home.aspx");
        }
    }
}