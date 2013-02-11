﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obtravel.Arabic.UserContorls
{
    public partial class Services : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBLayer db = new DBLayer();
            uiRepeaterCurrentServices.DataSource = db.GetArabicServices();
            uiRepeaterCurrentServices.DataBind();
        }
    }
}