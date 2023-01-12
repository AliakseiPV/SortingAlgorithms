using Algorithm;
using Algorithm.DataStructures;
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

        private void BtnClick(AlgorithmBase<SortedItem> sort)
        {
            RefreshItems();

            for (int i = 0; i < sort.Items.Count; i++)
            {
                sort.Items[i].SetPosition(i);
            }
            panel3.Refresh();

            sort.CompareEvent += Sort_CompareEvent;
            sort.SwapEvent += Sort_SwapEvent;
            var time = sort.Sort();

            TimeLabel.Text = $"Time: {time.Milliseconds} milliseconds";
            CompareLabel.Text = "Number of comparison: " + sort.ComparisonCount;
            SwapLabel.Text = "Number of exchanges: " + sort.SwapCount;
        }

        private void BubbleSort_Click(object sender, EventArgs e)
        {
            var bubble = new BubbleSort<SortedItem>(items);
            BtnClick(bubble);
        }

        private void CocktailSort_Click(object sender, EventArgs e)
        {
            var coctail = new CocktailSort<SortedItem>(items);
            BtnClick(coctail);
        }

        private void InsertionSort_Click(object sender, EventArgs e)
        {
            var insert = new InsertionSort<SortedItem>(items);
            BtnClick(insert);
        }

        private void ShellSort_Click(object sender, EventArgs e)
        {
            var shell = new ShellSort<SortedItem>(items);
            BtnClick(shell);
        }

        private void TreeSort_Click(object sender, EventArgs e)
        {
            var tree = new TreeSort<SortedItem>(items);
            BtnClick(tree);
        }

        private void HeapSort_Click(object sender, EventArgs e)
        {
            var heap = new Heap<SortedItem>(items);
            BtnClick(heap);
        }

        private void SelectionSort_Click(object sender, EventArgs e)
        {
            var select = new SelectionSort<SortedItem>(items);
            BtnClick(select);
        }

        private void Sort_SwapEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            var temp = e.Item1.Number;
            e.Item1.SetPosition(e.Item2.Number);
            e.Item2.SetPosition(temp);

            panel3.Refresh();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Sort_CompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Yellow);
            panel3.Refresh();
            Thread.Sleep(50);

            e.Item1.SetColor(Color.WhiteSmoke);
            e.Item2.SetColor(Color.WhiteSmoke);
            panel3.Refresh();
        }

        
    }
}
