namespace SortingAlgorithmsView
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.FillButton = new System.Windows.Forms.Button();
            this.FillTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BubbleSort = new System.Windows.Forms.Button();
            this.CocktailSort = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.InsertionSort = new System.Windows.Forms.Button();
            this.ShellSort = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.CompareLabel = new System.Windows.Forms.Label();
            this.SwapLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.FillButton);
            this.panel2.Controls.Add(this.FillTextBox);
            this.panel2.Location = new System.Drawing.Point(12, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 74);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fill the array with random numbers";
            // 
            // FillButton
            // 
            this.FillButton.Location = new System.Drawing.Point(286, 34);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(115, 26);
            this.FillButton.TabIndex = 1;
            this.FillButton.Text = "Add";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // FillTextBox
            // 
            this.FillTextBox.Location = new System.Drawing.Point(3, 34);
            this.FillTextBox.Name = "FillTextBox";
            this.FillTextBox.Size = new System.Drawing.Size(264, 26);
            this.FillTextBox.TabIndex = 0;
            this.FillTextBox.TextChanged += new System.EventHandler(this.FillTextBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.AddTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 61);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add a number";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(286, 34);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(115, 26);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(3, 34);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(264, 26);
            this.AddTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(12, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(419, 399);
            this.panel3.TabIndex = 6;
            // 
            // BubbleSort
            // 
            this.BubbleSort.Location = new System.Drawing.Point(437, 146);
            this.BubbleSort.Name = "BubbleSort";
            this.BubbleSort.Size = new System.Drawing.Size(128, 31);
            this.BubbleSort.TabIndex = 7;
            this.BubbleSort.Text = "Bubble Sort";
            this.BubbleSort.UseVisualStyleBackColor = true;
            this.BubbleSort.Click += new System.EventHandler(this.BubbleSort_Click);
            // 
            // CocktailSort
            // 
            this.CocktailSort.Location = new System.Drawing.Point(437, 183);
            this.CocktailSort.Name = "CocktailSort";
            this.CocktailSort.Size = new System.Drawing.Size(128, 31);
            this.CocktailSort.TabIndex = 8;
            this.CocktailSort.Text = "Cocktail Sort";
            this.CocktailSort.UseVisualStyleBackColor = true;
            this.CocktailSort.Click += new System.EventHandler(this.CocktailSort_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // InsertionSort
            // 
            this.InsertionSort.Location = new System.Drawing.Point(437, 220);
            this.InsertionSort.Name = "InsertionSort";
            this.InsertionSort.Size = new System.Drawing.Size(128, 31);
            this.InsertionSort.TabIndex = 9;
            this.InsertionSort.Text = "Insertion Sort";
            this.InsertionSort.UseVisualStyleBackColor = true;
            this.InsertionSort.Click += new System.EventHandler(this.InsertionSort_Click);
            // 
            // ShellSort
            // 
            this.ShellSort.Location = new System.Drawing.Point(437, 257);
            this.ShellSort.Name = "ShellSort";
            this.ShellSort.Size = new System.Drawing.Size(128, 31);
            this.ShellSort.TabIndex = 10;
            this.ShellSort.Text = "Shell Sort";
            this.ShellSort.UseVisualStyleBackColor = true;
            this.ShellSort.Click += new System.EventHandler(this.ShellSort_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(15, 549);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(47, 20);
            this.TimeLabel.TabIndex = 11;
            this.TimeLabel.Text = "Time:";
            this.TimeLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // CompareLabel
            // 
            this.CompareLabel.AutoSize = true;
            this.CompareLabel.Location = new System.Drawing.Point(15, 569);
            this.CompareLabel.Name = "CompareLabel";
            this.CompareLabel.Size = new System.Drawing.Size(185, 20);
            this.CompareLabel.TabIndex = 12;
            this.CompareLabel.Text = "Number of comparsions: ";
            // 
            // SwapLabel
            // 
            this.SwapLabel.AutoSize = true;
            this.SwapLabel.Location = new System.Drawing.Point(15, 589);
            this.SwapLabel.Name = "SwapLabel";
            this.SwapLabel.Size = new System.Drawing.Size(168, 20);
            this.SwapLabel.TabIndex = 13;
            this.SwapLabel.Text = "Number of exchanges:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(729, 644);
            this.Controls.Add(this.SwapLabel);
            this.Controls.Add(this.CompareLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.ShellSort);
            this.Controls.Add(this.InsertionSort);
            this.Controls.Add(this.CocktailSort);
            this.Controls.Add(this.BubbleSort);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.TextBox FillTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BubbleSort;
        private System.Windows.Forms.Button CocktailSort;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button InsertionSort;
        private System.Windows.Forms.Button ShellSort;
        private System.Windows.Forms.Label CompareLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label SwapLabel;
    }
}

