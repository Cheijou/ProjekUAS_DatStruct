namespace Sorting_Application
{
    partial class FormSortingVisualizer
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
            this.labelAlgorithm = new System.Windows.Forms.Label();
            this.comboBoxSorting = new System.Windows.Forms.ComboBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelVisualization = new System.Windows.Forms.Panel();
            this.buttonStartSorting = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDurasiSorting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAlgorithm
            // 
            this.labelAlgorithm.AutoSize = true;
            this.labelAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlgorithm.Location = new System.Drawing.Point(12, 22);
            this.labelAlgorithm.Name = "labelAlgorithm";
            this.labelAlgorithm.Size = new System.Drawing.Size(138, 29);
            this.labelAlgorithm.TabIndex = 0;
            this.labelAlgorithm.Text = "Algorithm :";
            // 
            // comboBoxSorting
            // 
            this.comboBoxSorting.FormattingEnabled = true;
            this.comboBoxSorting.Items.AddRange(new object[] {
            "Bubble Sort",
            "Insertion Sort",
            "Selection Sort",
            "Merge Sort",
            "Quick Sort"});
            this.comboBoxSorting.Location = new System.Drawing.Point(156, 22);
            this.comboBoxSorting.Name = "comboBoxSorting";
            this.comboBoxSorting.Size = new System.Drawing.Size(254, 33);
            this.comboBoxSorting.TabIndex = 1;
            this.comboBoxSorting.SelectedIndexChanged += new System.EventHandler(this.comboBoxSorting_SelectedIndexChanged);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(450, 22);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(122, 46);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(1298, 721);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(98, 46);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelVisualization
            // 
            this.panelVisualization.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVisualization.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelVisualization.Location = new System.Drawing.Point(17, 100);
            this.panelVisualization.Name = "panelVisualization";
            this.panelVisualization.Size = new System.Drawing.Size(1379, 606);
            this.panelVisualization.TabIndex = 4;
            // 
            // buttonStartSorting
            // 
            this.buttonStartSorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartSorting.Location = new System.Drawing.Point(608, 22);
            this.buttonStartSorting.Name = "buttonStartSorting";
            this.buttonStartSorting.Size = new System.Drawing.Size(122, 46);
            this.buttonStartSorting.TabIndex = 5;
            this.buttonStartSorting.Text = "Start";
            this.buttonStartSorting.UseVisualStyleBackColor = true;
            this.buttonStartSorting.Click += new System.EventHandler(this.buttonStartSorting_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(789, 33);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(310, 26);
            this.labelTime.TabIndex = 12;
            this.labelTime.Text = "Executed Time Calculation :";
            // 
            // labelDurasiSorting
            // 
            this.labelDurasiSorting.AutoSize = true;
            this.labelDurasiSorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDurasiSorting.Location = new System.Drawing.Point(1116, 34);
            this.labelDurasiSorting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDurasiSorting.Name = "labelDurasiSorting";
            this.labelDurasiSorting.Size = new System.Drawing.Size(77, 25);
            this.labelDurasiSorting.TabIndex = 13;
            this.labelDurasiSorting.Text = "HASIL";
            // 
            // FormSortingVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 779);
            this.Controls.Add(this.labelDurasiSorting);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonStartSorting);
            this.Controls.Add(this.panelVisualization);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.comboBoxSorting);
            this.Controls.Add(this.labelAlgorithm);
            this.Name = "FormSortingVisualizer";
            this.Text = "FormSortingVisualizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlgorithm;
        private System.Windows.Forms.ComboBox comboBoxSorting;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelVisualization;
        private System.Windows.Forms.Button buttonStartSorting;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDurasiSorting;
    }
}