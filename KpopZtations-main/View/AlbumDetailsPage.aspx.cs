using KpopZtations.Controller;
using KpopZtations.Handler;
using KpopZtations.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtations.View
{
    public partial class AlbumDetailsPage : System.Web.UI.Page
    {
        public Album CurrentAlbum { get; set; }
        AlbumHandler ah = new AlbumHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"].ToString());

            CurrentAlbum = ah.searchAlbum(id);
            addToCartBtn.DataBind();
            qtyLbl.DataBind();
            qtyTb.DataBind();
        }

        protected void addToCartBtn_Click(object sender, EventArgs e)
        {
            int albumId = Convert.ToInt32(Request.QueryString["id"].ToString());
            int userId = Convert.ToInt32(Session["userId"]);
            int qty = int.TryParse(qtyTb.Text, out qty) ? qty : -1;

            CartController cc = new CartController();

            lblError.Text = cc.doInsert(userId, albumId, qty);

            if (lblError.Text == "")
            {
                Response.Redirect("Home.aspx");
            }
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