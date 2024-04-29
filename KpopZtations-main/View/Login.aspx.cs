using KpopZtations.Controller;
using KpopZtations.Factory;
using KpopZtations.Model;
using KpopZtations.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtations.View
{
    public partial class Login : System.Web.UI.Page
    {
        CustomerController cc = new CustomerController();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie userCookie = Request.Cookies["UserData"];

                if (userCookie != null)
                {
                    string username = userCookie.Values["email"];
                    string password = userCookie.Values["password"];

                    Debug.WriteLine(username, password);
                    if (cc.doRemember(username, password) == true)
                    {
                        Response.Redirect("Home.aspx");
                    }

                    else
                    {
                        Response.Redirect("Login.aspx");
                    }
                }
            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbPassword.Text;
            Debug.WriteLine(email, password);

            lbError.Text = cc.doLogin(email, password, cbRemember);

            if (lbError.Text == "")
            {
                Response.Redirect("Home.aspx");
            }
        }
    }
}