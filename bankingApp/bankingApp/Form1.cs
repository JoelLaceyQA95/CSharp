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
    public partial class Form1 : Form
    {
        private static SqlConnection con;
        private static SqlCommand cmd;

        createAccForm createAccWindow;
        DepositForm createDepositWindow;
        WithdrawForm createWithdrawWindow;

        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='c:\\users\\admin\\source\\repos\\bankingApp\\bankingApp\\bankDB.mdf';Integrated Security=True";
            con.Open();

            createAccWindow = new createAccForm();
            createDepositWindow = new DepositForm();
            createWithdrawWindow = new WithdrawForm();
        }

        public static SqlCommand connectToDB()
        {

            cmd = con.CreateCommand();
            return cmd;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void createNewAccoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createAccWindow.Show();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createDepositWindow.Show();
        }

        public static Int32 Balance(String accountNumber)
        {
            connectToDB();

            int balance = 0, totalWithdraws = 0, totalDeposit = 0;

            cmd.CommandText = "select isnull(sum(deposit), 0) as totalDeposites from Deposit where accno='" + accountNumber + "'";
            SqlDataReader Data4 = cmd.ExecuteReader();
            Data4.Read();
            totalDeposit = Int32.Parse(Data4["totalDeposites"].ToString());
            Data4.Close();

            cmd.CommandText = "select isnull(sum(withdraw), 0) as totalWithdraw from withdraw where accno='" + accountNumber + "'";
            SqlDataReader Data5 = cmd.ExecuteReader();
            Data5.Read();
            totalWithdraws = Int32.Parse(Data5["totalWithdraw"].ToString());
            Data5.Close();

            balance = totalDeposit - totalWithdraws;

            return balance;
        }


        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createWithdrawWindow.Show();
        }
    }
}
