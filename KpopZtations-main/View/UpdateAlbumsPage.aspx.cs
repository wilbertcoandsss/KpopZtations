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
    public partial class UpdateAlbumsPage1 : System.Web.UI.Page
    {
        AlbumHandler alh = new AlbumHandler();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            int albumId = Convert.ToInt32(Request.QueryString["id"].ToString());

            Album a = alh.searchAlbum(albumId);



            String name = albumsNameTb.Text;
            String desc = albumsDescriptionTb.Text;

            int price = int.TryParse(albumsPriceTb.Text, out price) ? price : -1;

            int stock = int.TryParse(albumsStockTb.Text, out stock) ? stock : -1;

            int artistId = a.ArtistID;

            AlbumController ac = new AlbumController();

            lblError.Text = ac.doUpdate(name, desc, price, stock, albums, artistId, albumId);

            if (lblError.Text == "")
            {
                Response.Redirect("ArtistsDetailsPage.aspx?id=" + artistId);
            }
        }
    }
}