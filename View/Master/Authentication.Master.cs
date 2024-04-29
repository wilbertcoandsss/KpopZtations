using KpopZtations.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtations.View
{
    public partial class Authentication : System.Web.UI.MasterPage
    {
        CustomerController cc = new CustomerController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loginPanelGuest.DataBind();
                loginPanelCustomer.DataBind();
                loginPanelAdmin.DataBind();
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
        
        protected void logout_Click(object sender, EventArgs e)
        {
            cc.logout();
            Response.Redirect("Login.aspx");
        }

        protected void homeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void cartBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("CartPage.aspx");
        }

        protected void updateProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProfilePage.aspx");
        }

        protected void trReportBtn_Click(object sender, EventArgs e)
        {

        }

        protected void trHistoryBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionHistoryPage.aspx");
        }
    }
}