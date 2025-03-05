using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFormsAppWithMessageBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fNameVal = textBox1.Text;
            string mNameVal = textBox2.Text;
            string lNameVal = textBox3.Text;
            string sNameVal = textBox4.Text;

            DialogResult result = MessageBox.Show("Are you sure you want to submit?", "Confirmation",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {



                MessageBox.Show($"Hello There! {fNameVal} {mNameVal} {lNameVal} {sNameVal}", "Greetings",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Cancelled", "Confirmation",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }     
            
private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
