using KpopZtations.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtations.View
{
    public partial class InsertAlbumPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            String name = albumsNameTb.Text;
            String desc = albumsDescriptionTb.Text;

            int price = int.TryParse(albumsPriceTb.Text, out price) ? price : -1;

            int stock = int.TryParse(albumsStockTb.Text, out stock) ? stock : -1;

            int artistId = Convert.ToInt32(Request.QueryString["id"]);

            AlbumController ac = new AlbumController();

            lblError.Text = ac.doInsert(name, desc, price, stock, albums, artistId);

            if (lblError.Text == "")
            {
                Response.Redirect("ArtistsDetailsPage.aspx?id="+artistId);
            }
        }
    }
}