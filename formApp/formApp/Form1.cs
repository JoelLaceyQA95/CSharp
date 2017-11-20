using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formApp
{
    public partial class QAC : Form
    {
        int startingWidth;
        Boolean decrease;
    
        string currentNum = "";
        int firstNum;
        int secondNum;
        string currentOperator = "";

        public Boolean validInput()
        {
            if(t1.Text == "")
            {
                MessageBox.Show("First input invalid");
                t1.Focus();
                return false;
            }else if(t2.Text == "")
            {
                MessageBox.Show("Second input invalid");
                t2.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public void SetNum(string value)
        {
            currentNum += value;
            displayNum();
        }

        public void displayNum()
        {
            sumBox.Text = currentNum.ToString();
        }

        public void storeFirstNum(string num)
        {
            if(num == "")
            {
                MessageBox.Show("please first enter number");
                zeroBtn.Focus();
                return;
            }
            firstNum = Int32.Parse(num);
            currentNum = "";
            sumBox.Text = "";
        }

        public void storeSecondNum(string num)
        {
            if (num == "")
            {
                MessageBox.Show("please second enter number");
                zeroBtn.Focus();
                return;
            }
            secondNum = Int32.Parse(num);
            currentNum = "";
        }

        private void numPress(Object O, EventArgs E)
        {
            Button B = (Button)O;
            sumBox.Text += B.Text;
            SetNum(B.Text);
        }

        private void operatorPress(Object O, EventArgs E)
        {
            Button B = (Button)O;
            string value = B.Text;
            currentOperator = value;
            storeFirstNum(currentNum);
        }

        public QAC()
        {
            InitializeComponent();
            startingWidth = this.t4.Width;
        }

        //ADD TWO NUMBERS FROM TWO TEXTBOXES
        private void btn_Click(object sender, EventArgs e)
        {
            int a, b, c;

            if (validInput()) { 

            a = Int32.Parse(t1.Text);
            b = Int32.Parse(t2.Text);
            c = a + b;
            t3.Text = c.ToString();
        }
        }

        //INCREASE TEXTBOX WIDTH BASED ON FORM WIDTH
        private void btn2_Click(object sender, EventArgs e)
        {
 
            if (!decrease)
            {
                btn2.Text = "increase";
                t4.Width = t4.Width + 10;
                if(t4.Width > this.Width - 100)
                {
                    decrease = true;
                }

            }
            else if (decrease)
            {
                this.Text = "max width reached";
                btn2.Text = "decrease";
                t4.Width = t4.Width - 10;
                if (t4.Width == startingWidth)
                {
                    decrease = false;
                }
            }
        }

        //EQUALS BTN FOR CALCULATOR
        private void equalsBtn_Click(object sender, EventArgs e)
        {
            storeSecondNum(currentNum);

            if(currentOperator == "+")
            {
                int ans = firstNum + secondNum;
                sumBox.Text = ans.ToString();
            }else if(currentOperator == "-")
            {
                int ans = firstNum - secondNum;
                sumBox.Text = ans.ToString();
            }else if(currentOperator == "*")
            {
                int ans = firstNum * secondNum;
                sumBox.Text = ans.ToString();
            }else if(currentOperator == "/")
            {
                if (secondNum == 0)
                {
                    MessageBox.Show("cannont divide by zero!");
                    zeroBtn.Focus();
                    return;
                }
                else
                {
                    int ans = firstNum / secondNum;
                    sumBox.Text = ans.ToString();
                }
            }

            firstNum = 0;
            secondNum = 0;
        }

        //BTN TO CLEAR CALCULATOR SCREEN
        private void clearBtn_Click(object sender, EventArgs e)
        {
            currentNum = "";
            firstNum = 0;
            secondNum = 0;
            sumBox.Text = "";

            
        }
    }
}
