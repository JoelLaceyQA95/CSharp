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
    public partial class DepositForm : Form
    {
        SqlCommand cmd;
        Boolean correctAccNum = false;

        public DepositForm()
        {
            InitializeComponent();
            cmd = Form1.connectToDB();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string accNum = accNoBox.Text;
            cmd.CommandText = "select * from Accounts where accNo = '"+accNum+"'";
            SqlDataReader data = cmd.ExecuteReader();
            correctAccNum = data.Read();

            if (!correctAccNum)
            {
                MessageBox.Show("Invalid account number");
                return;
            }
            else
            {
                if (data["status"].ToString().Equals("D"))
                {
                    MessageBox.Show("Account has been deactivated");
                    return;
                }
                else
                {
                    nameLabel.Text += data["name"].ToString();
                    addressLabel.Text += data["address"].ToString();
                    string accTyp = data["accNo"].ToString().Substring(0, 1);
                    string gender = data["accNo"].ToString().Substring(1, 1);
                    if (gender == "M")
                    {
                        genderLabel.Text += "Male";
                    }
                    else
                    {
                        genderLabel.Text += "Female";
                    }

                    if (accTyp == "S")
                    {
                        accTypeLable.Text += "Savings";
                    }
                    else
                    {
                        accTypeLable.Text += "Current";
                    }
                    data.Close();
                    int balance = Form1.Balance(accNum);

                    currentBalLabel.Text = balance.ToString();
                }
            }

        }

        private void submitAmountBtn_Click(object sender, EventArgs e)
        {
            if (depositAmountBox.Text == "" || !correctAccNum)
            {
                MessageBox.Show("Enter correct account number & amount to deposit");
                return;
            }
            else
            {
                int depositAmount = Int32.Parse(depositAmountBox.Text);
                cmd.CommandText = "insert into Deposit values('" + accNoBox.Text + "', " + depositAmount + ", getdate())";
                SqlDataReader data1 = cmd.ExecuteReader();
                MessageBox.Show("£ " + depositAmount + "succefully deposited");
                data1.Close();
                int balance = Form1.Balance(accNoBox.Text);

                currentBalLabel.Text = balance.ToString();
                return;
            }
            
        }
    }
}
