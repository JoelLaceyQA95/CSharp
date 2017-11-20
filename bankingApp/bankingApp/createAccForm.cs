using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bankingApp
{
    public partial class createAccForm : Form
    {
        SqlCommand cmd;

        string accountType = "";
        string gender = "";

        public createAccForm()
        {
            InitializeComponent();
            cmd = Form1.connectToDB();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void createAccBtn_Click(object sender, EventArgs e)
        {
            accountType = currentAccRadio.Checked ? "C" : "S";
            gender = maleRadio.Checked ? "M" : "F";

            cmd.CommandText = "select concat('" + accountType + "', '" + gender + "', right(replicate('0', 3) + cast(isnull(max(substring(accNo, 3, 3)) + 1, '001')as varchar(15)), 3)) as newAccNo from Accounts where substring(accNo , 1, 1) = '" + accountType + "'";

            SqlDataReader R = cmd.ExecuteReader();
            R.Read();

            string newAccountNum = R["newAccNo"].ToString();
            R.Close();

            cmd.CommandText = "insert into Accounts values('"+newAccountNum+"', '"+nameBox.Text+"', '"+addressBox.Text+"', 'A')";
            cmd.ExecuteNonQuery();
        }
    }
}
