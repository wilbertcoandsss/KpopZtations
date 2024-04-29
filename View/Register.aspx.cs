using KpopZtations.Controller;
using KpopZtations.Handler;
using KpopZtations.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtations.View.Master
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string email = tbEmail.Text;
            string address = tbAddress.Text;
            string password = tbPassword.Text;

            CustomerController cc = new CustomerController();
            lbError.Text = cc.doRegister(name, email, address, rbMale, rbFemale, password);

            if (lbError.Text == "")
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}