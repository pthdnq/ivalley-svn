﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TouchMediaGUI
{
    public partial class JobOrders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Master.PageTitle = GetLocalResourceObject("PageTitle").ToString();
            }
        }
    }
}