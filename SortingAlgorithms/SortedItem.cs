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
        public int Number { get; private set; }
        public int StartNumber { get; private set; }

        public SortedItem(int value, int number)
        {
            Value = value;
            Number = number;
            StartNumber = number;
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

        public void SetPosition(int number)
        {
            Number = number;
            var y = number * 20;

            progressBar.Location = new Point(42, y);
            progressBar.Name = "progressBar" + number;
            label.Location = new Point(9, y);
            label.Name = "label" + number;

        }

        public void Refresh()
        {
            Number = StartNumber;
            var y = Number * 20;

            progressBar.Location = new Point(42, y);
            progressBar.Name = "progressBar" + Number;
            label.Location = new Point(9, y);
            label.Name = "label" + Number;
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

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
