using KpopZtations.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtations.View
{
    public partial class RemoveCartItems : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CartHandler ch = new CartHandler();
            int albumId = Convert.ToInt32(Request.QueryString["id"]);
            int userId = Convert.ToInt32(Session["userId"]);
            ch.deleteCart(userId, albumId);
            Response.Redirect("CartPage.aspx");
        }
    }
}