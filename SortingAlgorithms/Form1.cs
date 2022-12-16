using Algorithm;
using SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SortingAlgorithmsView
{
    public partial class Form1 : Form
    {
        List<SortedItem> items = new List<SortedItem>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FillTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(AddTextBox.Text, out int value))
            {
                var item = new SortedItem(value);
                items.Add(item);
                Controls.Add(item.progressBar);
                Controls.Add(item.label);
            }
            AddTextBox.Text = "";
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(FillTextBox.Text, out int value))
            {
                var random = new Random();

                for (int i = 0; i < value; i++)
                {
                    var item = new SortedItem(random.Next(0, 100));
                    items.Add(item);
                    Controls.Add(item.progressBar);
                    Controls.Add(item.label);
                }
                FillTextBox.Text = "";
            } 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
