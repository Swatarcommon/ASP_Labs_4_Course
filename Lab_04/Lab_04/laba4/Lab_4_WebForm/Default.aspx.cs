﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_4_WebForm
{
    public partial class _Default : Page
    {
        private SimpleClass simpleClass;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.simpleClass = new SimpleClass();
        }

        protected void Sum_Click(object sender, EventArgs e)
        {
            int x, y;
            if (int.TryParse(first.Text.ToString(), out x) && int.TryParse(second.Text.ToString(), out y))
            {
                result.Text = simpleClass.Add(x, y).ToString();
            }
            else
            {
                result.Text = "Error!";
            }
        }
    }
}