﻿using KpopZtations.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtations.View
{
    public partial class UpdateAlbumsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"].ToString());
            AlbumController alc = new AlbumController();
            alc.doDelete(id);

            Response.Redirect("Home.aspx");
        }
    }
}