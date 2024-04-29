using KpopZtations.Handler;
using KpopZtations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtations.View
{
    public partial class TransactionHistoryPage : System.Web.UI.Page
    {
        public List<TransactionHeader> trheader = new List<TransactionHeader>();

        public TransactionHeaderHandler thh = new TransactionHeaderHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(Session["userId"].ToString());

            trheader = thh.getUserTh(userId);
        }
    }
}