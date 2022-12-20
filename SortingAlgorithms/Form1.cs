using Algorithm;
using SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
                var item = new SortedItem(value, items.Count);
                items.Add(item);
                panel3.Controls.Add(item.progressBar);
                panel3.Controls.Add(item.label);
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
                    var item = new SortedItem(random.Next(0, 100), items.Count);
                    items.Add(item);
                    panel3.Controls.Add(item.progressBar);
                    panel3.Controls.Add(item.label);
                }
                FillTextBox.Text = "";
            } 
        }

        private void BubbleSort_Click(object sender, EventArgs e)
        {
            var bubble = new BubbleSort<SortedItem>(items);
            bubble.CompareEvent += Bubble_CompareEvent;
            bubble.SwapEvent += Bubble_SwapEvent;
            bubble.Sort();

        }

        private void Bubble_SwapEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            var temp = e.Item1.Value;
            e.Item1.SetValue(e.Item2.Value);
            e.Item1.SetColor(Color.Yellow);

            e.Item2.SetValue(temp);
            e.Item2.SetColor(Color.Red);

            
            panel3.Refresh();
        }

        private void Bubble_CompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Yellow);
        }

        private void Swap(SortedItem firstTool, SortedItem secondTool)
        {
            

        }

    }
}
