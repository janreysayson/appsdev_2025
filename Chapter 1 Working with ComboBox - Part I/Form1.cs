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

namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] foodGenra = { "Filipino", "Japanese", "Chinese", "Korean"};
            moviecomboBox.Items.AddRange(foodGenra);

            moviecomboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            moviecomboBox.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in foodscheckedListBox.Items)
            {
                bool isSelected = foodscheckedListBox.GetItemChecked(foodscheckedListBox.Items.IndexOf(item));
                if (isSelected && !foodslistBox.Items.Contains(item))
                {
                    foodslistBox.Items.Add(item);
                }
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] foodfilipinoList = { "Bulalo", "Kare-Kare", "Bicol Express", "Pinakbet" };
            string[] japanfoodList = { "Miso Soup", "Sushi", "Tempura", "Okonomiyaki", "Curry Rice" };
            string[] chinesefoodList = { "Sichuan", "Cantonese", "Shandong", "Huaiyang" };
            string[] koreanfoodlist = { "Kimchi", "Bulgogi", "Bibimbap", "Soju" };     

            foodscheckedListBox.Items.Clear();

            if (moviecomboBox.SelectedItem.ToString().Contains("Filipino")) 
            { 
                foodscheckedListBox.Items.AddRange(foodfilipinoList);

        } else if (moviecomboBox.SelectedItem.ToString().Contains("Japanese"))  
            {
                foodscheckedListBox.Items.AddRange(japanfoodList);
            }
            else if (moviecomboBox.SelectedItem.ToString().Contains("Chinese"))
            {
                foodscheckedListBox.Items.AddRange(chinesefoodList);

            }
             else if (moviecomboBox.SelectedItem.ToString().Contains("Korean")) {
                foodscheckedListBox.Items.AddRange(koreanfoodlist);
            }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            if (foodslistBox.Items.Count >= 1)
            {
                foodslistBox.Items.Remove(foodslistBox.SelectedItem);
         }
    }

        private void button4_Click(object sender, EventArgs e)
        {
             foodslistBox.Items.Clear();
        }

        private void moviecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

