using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool flag;
            int index;
            int start;
            int howMany;
            string temp;

            lblIndexOf.Text = "";
            // Find Length
            txtLenght.Text = txtInput.Text.Lenght.ToString();
            // Change cases
            txtToUpper.Text = txtInput.Text.ToUpper();
            txtToLower.Text = txtInput.Text.ToLower();

            // Index of
            Index = txtInput.text.IndexOf(txtSearchChar.Text, 0);
            lblIndexOf.Text = "txtInput.Text.IndexOf(\"" + txtSearchChar.Text +
                                    "\",0) = ";
            txtSearchIndex.Text = index.ToString();

            //LastIndexOf
            index = txtInout.Text.LastIndexOf(txtLastChar.Text);
            lblLastIndexOf.Text = "txtInout.Text.LastIndexOf(\"" + txtLastChar.Text + "\")
                                    = ";
            txtLastIndexOf.Text = index.ToString();

            //Substring
            flag = int.TryParse(txtStartIndex.Text, out start);
            if (flag == false)
            {
                MessageBox.Show(Improper numeric input.Re-enter.");
                    txtStartIndex.Focus();
                return;
                    
            }
            flag = int.TryParse(txtEndIndex.Text, out howMany);
            if (flag == false)
            {
                MessageBox.Show("Improper numeric input.Re-enter.");
                txtEndIndex.Focus();
            }
            lblSubstring.Text = "txtInput.Text.Substring(" + start.ToString() + ". " +
                            howMany.ToString() + ") = ";
            txtSubstringResult.Text = txtInput.Text.Substring(start, howMany);
            /
            //Remove
            temp = txtInput.Text;
            index = temp.IndexOf(txtRemove.Text);
            if (index > 0)
            {
                txtRemoveResult.Text = temp.Remove(Index, txtRemove.TextLenght);

            }



        }
    }
}
