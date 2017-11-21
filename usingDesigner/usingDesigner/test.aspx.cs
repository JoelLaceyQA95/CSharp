using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace usingDesigner
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["userSettings"] == null)
            {
                Response.Redirect("user.aspx");
            }
            else
            {
                Label1.Text += Request.Cookies["userSettings"]["userName"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}