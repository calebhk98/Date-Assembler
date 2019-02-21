using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birth_Date_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DateBtn_Click(object sender, EventArgs e)
        {
            DateLabel.Text = dayOfWeek.Text +", "+ NameOfMonth.Text + " " + numberOfMonth.Text + ", " + Year.Text;
            //This combines all the fields
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            DateLabel.Text = "";//this clears the label
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();//This closes the form
        }
    }
}
