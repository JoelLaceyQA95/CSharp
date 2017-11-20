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
    public partial class displayResult : Form
    {
        public displayResult()
        {
            InitializeComponent();
        }

        public void showMe(int result)
        {
            resultBox.Text = result.ToString();
            this.Show();
        }

        private void displayResult_Load(object sender, EventArgs e)
        {

        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
