using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithms
{
    internal class SortedItem
    {
        public ProgressBar progressBar { get;private set; }
        public Label label { get;private set; }
        public int Value { get; set; }

        public SortedItem(int value)
        {
            Value = value;
            progressBar = new ProgressBar();
            label = new Label();

            progressBar.Location = new System.Drawing.Point(20, 11);
            progressBar.Name = "progressBar1";
            progressBar.Size = new System.Drawing.Size(21, 149);
            progressBar.TabIndex = 7;
            progressBar.Value = Value;
            // 
            // label3
            // 
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(16, 163);
            label.Name = "label3";
            label.Size = new System.Drawing.Size(27, 20);
            label.TabIndex = 8;
            label.Text = Value.ToString();
            //label.Click += new System.EventHandler(this.label3_Click);
        }
    }
}
