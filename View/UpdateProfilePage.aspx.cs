using KpopZtations.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtations.View
{
    public partial class UpdateProfilePage : System.Web.UI.Page
    {
        CustomerController cc = new CustomerController();
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Ini user id" + Session["userId"]);  
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string email = tbEmail.Text;
            string address = tbAddress.Text;
            string password = tbPassword.Text;

            lbError.Text = cc.doUpdate(name, email, address, rbMale, rbFemale, password);
            if (lbError.Text == "")
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["userId"].ToString());

            cc.deleteAccount(id);

            Response.Redirect("Home.aspx");
        }
    }
}