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
    public partial class ArtistsDetailsPage : System.Web.UI.Page
    {
        AlbumHandler ah = new AlbumHandler();
        ArtistHandler arh = new ArtistHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            List<Album> albumsList = ah.getAlbumsByArtist(id);
            Artist ar = arh.getArtist(id);

            albumRepeater.DataSource = albumsList;
            artistNameLbl.Text = ar.ArtistName;
            albumRepeater.DataBind();

            insertAlbum.DataBind();
        }

        protected void insertAlbum_Click(object sender, EventArgs e)
        {
            String id = Request.QueryString["id"].ToString();
            Response.Redirect("InsertAlbumPage.aspx?id="+id);
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
    }
}