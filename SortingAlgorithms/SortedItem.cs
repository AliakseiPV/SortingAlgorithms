using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithms
{
    internal class SortedItem : IComparable
    {
        public ProgressBar progressBar { get; private set; }
        public Label label { get; private set; }
        public int Value { get; private set; }

        public SortedItem(int value, int number)
        {
            Value = value;
            progressBar = new ProgressBar();
            label = new Label();

            var y = number * 20;

            progressBar.Location = new System.Drawing.Point(42, y);
            progressBar.Name = "progressBar" + number;
            progressBar.Size = new System.Drawing.Size(300, 18);
            progressBar.TabIndex = number;
            progressBar.Value = Value;
            // 
            // label3
            // 
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(9, y);
            label.Name = "label" + number;
            label.Size = new System.Drawing.Size(27, 20);
            label.TabIndex = number;
            label.BackColor = System.Drawing.Color.WhiteSmoke;
            label.Text = Value.ToString();

        }

        public void SetColor(Color color )
        {
            label.BackColor = color;
        }

        public void SetValue(int value)
        {
            Value = value;
            progressBar.Value = value;
            label.Text = value.ToString();
        }

        public int CompareTo(object obj)
        {
            if (obj is SortedItem item)
            {
                return Value.CompareTo(item.Value);
            }
            else
            {
                throw new ArgumentException($"obj is not {nameof(SortedItem)}", nameof(obj));
            }
        }

    }
}
