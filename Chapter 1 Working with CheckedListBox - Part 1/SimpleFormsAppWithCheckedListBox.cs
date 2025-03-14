using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFormsAppWithCheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] movie = { "The Simpsons", "Rick And Morty", "Squid Game", "Venom", "The Avengers", "Spiderman", };
            movieMarathonCheckBoxList.Items.AddRange(movie);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var movie in movieMarathonCheckBoxList.Items)
            {
                bool isSelected = movieMarathonCheckBoxList.GetItemChecked(movieMarathonCheckBoxList.Items.IndexOf(movie));
                if (isSelected && !movieListBox.Items.Contains(movie))
                {
                    {
                        movieListBox.Items.Add(movie);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (movieListBox.Items.Count >= 1)
            {
                movieListBox.Items.Remove(movieListBox.SelectedItem);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            movieListBox.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
