﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Facebook.Samples.AspWebsite
{
    public partial class Token : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var app = new FacebookApp();
            TokenLabel.Text = app.AccessToken;
        }
    }
}