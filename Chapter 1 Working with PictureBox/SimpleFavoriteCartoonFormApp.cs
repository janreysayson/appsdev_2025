using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFavoriteCartoonFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            comboBox1.Items.Add("Bugs Bunny");
            comboBox1.Items.Add("Homer Simpson");
            comboBox1.Items.Add("Garfield");
            comboBox1.Items.Add("Goofy");
            comboBox1.Items.Add("Jimmy Neutron");

            

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCartoon = comboBox1.SelectedItem.ToString();

            switch (selectedCartoon)
            {
                case "Bugs Bunny":
                    pictureBox1.Image = Image.FromFile("C:/Users/OO142/Documents/images/bugs-bunny-3.jpg");
                    break;

                case "Homer Simpson":
                    pictureBox1.Image = Image.FromFile("C:/Users/OO142/Documents/images/c285c522f4c2cb3792250579370a24d0.jpg");
                    break;

                case "Garfield":
                    pictureBox1.Image = Image.FromFile("C:/Users/OO142/Documents/images/garfield-2_2024-06-03_10-18-12.jpg");
                    break;

                case "Goofy":
                    pictureBox1.Image = Image.FromFile("C:/Users/OO142/Documents/images/images.jpg");
                    break;

                case "Jimmy Neutron":
                    pictureBox1.Image = Image.FromFile("C:/Users/OO142/Documents/images/Jimmy-Neutron-Feature.jpg");
                    break;
            }
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            comboBox1.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
          
                    


    

