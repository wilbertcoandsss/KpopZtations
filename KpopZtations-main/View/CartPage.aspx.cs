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
    public partial class CartPage : System.Web.UI.Page
    {
        public List<Cart> carts = new List<Cart>();
        
        CartHandler ch = new CartHandler();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(Session["userId"].ToString());
            carts = ch.getUserCart(userId);

        }

        protected void checkOutBtn_Click(object sender, EventArgs e)
        {

            CartController cc = new CartController();
            lblError.Text = cc.checkOut();

            if (lblError.Text == "")
            {
                Response.Redirect(Request.RawUrl);
            }
        }
    }
}