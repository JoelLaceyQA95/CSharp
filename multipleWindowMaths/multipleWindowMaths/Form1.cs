using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multipleWindowMaths
{
    public partial class Form1 : Form
    {
        displayResult resultsWindow;
        public Form1()
        {
            InitializeComponent();
            resultsWindow = new displayResult();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            int a, b, c;

            a = Int32.Parse(numOne.Text);
            b = Int32.Parse(numTwo.Text);

            if (addRadio.Checked)
            {
                c = a + b;
            }else if (minusRadio.Checked)
            {
                c = a - b;
            }else if (multiplyRadio.Checked)
            {
                c = a * b;
            }else
            {
                c = a / b;
            }

            resultsWindow.showMe(c);
            
        }
    }
}
