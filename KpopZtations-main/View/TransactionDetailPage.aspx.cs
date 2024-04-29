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
    public partial class TransactionDetailPage : System.Web.UI.Page
    {
        public List<TransactionDetail> trdetail = new List<TransactionDetail>();

        public TransactionDetailHandler thh = new TransactionDetailHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            int trId = Convert.ToInt32(Request.QueryString["id"].ToString());
            trdetail = thh.getTrDetail(trId);
        }
    }
}