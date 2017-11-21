using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace addressBook
{
    public partial class homePage : System.Web.UI.Page
    {
        private static SqlConnection con;
        private static SqlCommand cmd;

        public homePage()
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Admin\\C#Work\\CSharp\\addressBook\\addressBook\\App_Data\\addressBook.mdf';Integrated Security=True";
            con.Open();
        }

        public static SqlCommand connectToDB()
        {
            cmd = con.CreateCommand();
            return cmd;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}