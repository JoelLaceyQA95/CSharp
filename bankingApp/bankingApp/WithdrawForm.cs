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
    public partial class WithdrawForm : Form
    {
        SqlCommand cmd;
        Boolean correctAccNum = false;

        public WithdrawForm()
        {
            InitializeComponent();
            cmd = Form1.connectToDB();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string accNum = accNoBox.Text;
            cmd.CommandText = "select * from Accounts where accNo = '" + accNum + "'";
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
                    string gender = data["accNo"].ToString().Substring(1, 1);
                    string accTyp = data["accNo"].ToString().Substring(2, 2);
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
            if (withdrawAmountBox.Text == "" || !correctAccNum)
            {
                MessageBox.Show("Enter correct account number & amount to withdraw");
                return;
            }
            else
            {
                int withdrawAmount = Int32.Parse(withdrawAmountBox.Text);
                if (withdrawAmount > Int32.Parse(currentBalLabel.Text))
                {
                    MessageBox.Show("Insuficient funds!");
                    return;
                }
                else
                {
                    cmd.CommandText = "insert into withdraw values('" + accNoBox.Text + "', " + withdrawAmount + ", getdate())";
                    SqlDataReader data1 = cmd.ExecuteReader();
                    MessageBox.Show("£ " + withdrawAmount + "succefully withdrawn");
                    data1.Close();
                    int balance = Form1.Balance(accNoBox.Text);

                    currentBalLabel.Text = balance.ToString();
                    return;
                }
            }
        }
    }
}
