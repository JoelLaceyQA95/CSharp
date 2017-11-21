using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace usingDesigner
{
    public partial class user : System.Web.UI.Page
    {
        HttpCookie cookie = new HttpCookie("userSettings");
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Cookies["userSettings"] != null)
            {
                Response.Redirect("test.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string userInput = TextBox1.Text;
            cookie["userName"] = userInput;
            cookie.Expires = DateTime.Now.AddDays(1d);
            Response.Cookies.Add(cookie);
            Response.Redirect("test.aspx");
        }
    }
}