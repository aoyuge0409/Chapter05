using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter05Project02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateTimeInfo()
        {
            int days;
            DateTime myTime = new DateTime();
            myTime = DateTime.Now;
            DateTime newYears = new DateTime(myTime.Year, 12, 31);

            txtCompleteDateAndTime.Text = myTime.ToString("f");
            txtLongDate.Text = myTime.ToString("D");
            txtShortDate.Text = myTime.ToString("d");
            txtGeneralDateAndTime.Text = myTime.ToString("g");
            txtLongTime.Text = myTime.ToString("T");
            txtShortTime.Text = myTime.ToString("t");

            days = newYears.DayOfYear - myTime.DayOfYear;
            txtNewYears.Text = days.ToString();
        }

            
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateTimeInfo();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}

