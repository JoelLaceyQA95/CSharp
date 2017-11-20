using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messageForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (messageBox.Text == "")
            {
                MessageBox.Show("input your message");
                messageBox.Focus();
                return;
            }
            else
            {
                if (countWordsRadio.Checked)
                {
                    int wordCount = 1;
                    for (int i = 0; i <= messageBox.Text.Length - 1; i++)
                    {
                        if (messageBox.Text[i] == ' ')
                        {
                            wordCount++;
                        }
                    }
                    outputBox.Text = wordCount.ToString();
                }else if (UpperCaseLettersRadio.Checked)
                {
                    string outputString = "";
                    for (int i = 0; i <= messageBox.Text.Length - 1; i++)
                    {
                        if (char.IsUpper(messageBox.Text[i]))
                        {
                            outputString += messageBox.Text[i];
                        }
                    }
                    outputBox.Text = outputString;
                }else if (lowerCaseLettersRadio.Checked)
                {
                    string outputString = "";
                    for (int i = 0; i <= messageBox.Text.Length - 1; i++)
                    {
                        if (char.IsLower(messageBox.Text[i]))
                        {
                            outputString += messageBox.Text[i];
                        }
                    }
                    outputBox.Text = outputString;
                }else if (numbersRadio.Checked)
                {
                    string outputString = "";
                    for (int i = 0; i <= messageBox.Text.Length - 1; i++)
                    {
                        if (char.IsDigit(messageBox.Text[i]))
                        {
                            outputString += messageBox.Text[i];
                        }
                    }
                    outputBox.Text = outputString;
                }else if (specialCharactersRadio.Checked)
                {
                    string outputString = "";
                    for (int i = 0; i <= messageBox.Text.Length - 1; i++)
                    {
                        if (!char.IsLetterOrDigit(messageBox.Text[i]))
                        {
                            outputString += messageBox.Text[i];
                        }
                    }
                    outputBox.Text = outputString;
                } 
            }
        }
    }
}
