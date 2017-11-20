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

namespace databaseTest
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = 'C:\\Users\\Admin\\source\\repos\\databaseTest\\databaseTest\\Database1.mdf'; Integrated Security = True";
            con.Open();
            cmd = con.CreateCommand();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select max(RegNo) + 1 as newRegNo from school";
            SqlDataReader R = cmd.ExecuteReader();
            if (R.Read())
            {
                string newRegNo = R["newRegNo"].ToString();
                R.Close();
                cmd.CommandText = "insert into school values("+newRegNo+",'"+nameBox+"', "+marksBox+")";
                cmd.ExecuteNonQuery();
                regNoBox.Text = newRegNo;

            }
            //string query = "insert into school values("+ regNoBox.Text +",'" + nameBox.Text + "'," + marksBox.Text + ")";
            //cmd.CommandText = query;
            //cmd.ExecuteNonQuery();
            MessageBox.Show("Database entry added!");

            //regNoBox.Text = "";
            nameBox.Text = "";
            marksBox.Text = "";
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            string query2 = "select * from school";
            cmd.CommandText = query2;
            SqlDataReader data = cmd.ExecuteReader();
            if (data.Read())
            {
                regNoBox2.Text = data["RegNo"].ToString();
                nameBox2.Text = data["Name"].ToString();
                marksBox2.Text = data["Marks"].ToString();
            }
        }
    }
}
