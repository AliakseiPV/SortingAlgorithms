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
            }
            RefreshItems();
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
                }
            }
            RefreshItems();
            FillTextBox.Text = "";
        }

        private void DrawItems(List<SortedItem> items)
        {
            panel3.Controls.Clear();

            foreach (var item in items)
            {
                panel3.Controls.Add(item.progressBar);
                panel3.Controls.Add(item.label);
            }
            panel3.Refresh();
        }

        private void RefreshItems()
        {
            foreach (var item in items)
            {
                item.Refresh();
            }
            DrawItems(items);
        }

        private void GetInfo(AlgorithmBase<SortedItem> sort)
        {
            var time = sort.Sort();
            TimeLabel.Text = $"Time: {time.Milliseconds} milliseconds";
            CompareLabel.Text = "Number of comparison: " + sort.ComparisonCount;
            SwapLabel.Text = "Number of exchanges: " + sort.SwapCount;
        }

        private void BubbleSort_Click(object sender, EventArgs e)
        {
            RefreshItems();

            var bubble = new BubbleSort<SortedItem>(items);
            bubble.CompareEvent += Sort_CompareEvent;
            bubble.SwapEvent += Sort_SwapEvent;
            GetInfo(bubble);
        }

        private void CocktailSort_Click(object sender, EventArgs e)
        {
            RefreshItems();

            var coctail = new CocktailSort<SortedItem>(items);
            coctail.CompareEvent += Sort_CompareEvent;
            coctail.SwapEvent += Sort_SwapEvent;
            coctail.Sort();
            GetInfo(coctail);
        }

        private void InsertionSort_Click(object sender, EventArgs e)
        {
            RefreshItems();

            var insert = new InsertionSort<SortedItem>(items);
            insert.CompareEvent += Sort_CompareEvent;
            insert.SwapEvent += Sort_SwapEvent;
            insert.Sort();
            GetInfo(insert);
        }

        private void ShellSort_Click(object sender, EventArgs e)
        {
            RefreshItems();

            var shell = new ShellSort<SortedItem>(items);
            shell.CompareEvent += Sort_CompareEvent;
            shell.SwapEvent += Sort_SwapEvent;
            shell.Sort();
            GetInfo(shell);
        }

        private void Sort_SwapEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            var temp = e.Item1.Number;
            e.Item1.SetPosition(e.Item2.Number);
            e.Item2.SetPosition(temp);

            panel3.Refresh();

            e.Item1.SetColor(Color.WhiteSmoke);
            e.Item2.SetColor(Color.WhiteSmoke);
            panel3.Refresh();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Sort_CompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Yellow);
        }

    }
}
