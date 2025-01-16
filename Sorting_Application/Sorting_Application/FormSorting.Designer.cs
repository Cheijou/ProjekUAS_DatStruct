﻿namespace Sorting_Application
{
    partial class FormSorting
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonQuick = new System.Windows.Forms.RadioButton();
            this.radioButtonMerge = new System.Windows.Forms.RadioButton();
            this.radioButtonSelection = new System.Windows.Forms.RadioButton();
            this.radioButtonInsertion = new System.Windows.Forms.RadioButton();
            this.radioButtonBubble = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelDurasiSorting = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBanyakData = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonVisualize = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 146);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(214, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sorting Application";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonQuick);
            this.groupBox1.Controls.Add(this.radioButtonMerge);
            this.groupBox1.Controls.Add(this.radioButtonSelection);
            this.groupBox1.Controls.Add(this.radioButtonInsertion);
            this.groupBox1.Controls.Add(this.radioButtonBubble);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(454, 173);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(376, 273);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorting Operation";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonQuick
            // 
            this.radioButtonQuick.AutoSize = true;
            this.radioButtonQuick.Location = new System.Drawing.Point(32, 217);
            this.radioButtonQuick.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonQuick.Name = "radioButtonQuick";
            this.radioButtonQuick.Size = new System.Drawing.Size(174, 34);
            this.radioButtonQuick.TabIndex = 4;
            this.radioButtonQuick.TabStop = true;
            this.radioButtonQuick.Text = "Quick Sort";
            this.radioButtonQuick.UseVisualStyleBackColor = true;
            // 
            // radioButtonMerge
            // 
            this.radioButtonMerge.AutoSize = true;
            this.radioButtonMerge.Location = new System.Drawing.Point(32, 177);
            this.radioButtonMerge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonMerge.Name = "radioButtonMerge";
            this.radioButtonMerge.Size = new System.Drawing.Size(181, 34);
            this.radioButtonMerge.TabIndex = 3;
            this.radioButtonMerge.TabStop = true;
            this.radioButtonMerge.Text = "Merge Sort";
            this.radioButtonMerge.UseVisualStyleBackColor = true;
            // 
            // radioButtonSelection
            // 
            this.radioButtonSelection.AutoSize = true;
            this.radioButtonSelection.Location = new System.Drawing.Point(32, 137);
            this.radioButtonSelection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonSelection.Name = "radioButtonSelection";
            this.radioButtonSelection.Size = new System.Drawing.Size(217, 34);
            this.radioButtonSelection.TabIndex = 2;
            this.radioButtonSelection.TabStop = true;
            this.radioButtonSelection.Text = "Selection Sort";
            this.radioButtonSelection.UseVisualStyleBackColor = true;
            // 
            // radioButtonInsertion
            // 
            this.radioButtonInsertion.AutoSize = true;
            this.radioButtonInsertion.Location = new System.Drawing.Point(32, 96);
            this.radioButtonInsertion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonInsertion.Name = "radioButtonInsertion";
            this.radioButtonInsertion.Size = new System.Drawing.Size(209, 34);
            this.radioButtonInsertion.TabIndex = 1;
            this.radioButtonInsertion.TabStop = true;
            this.radioButtonInsertion.Text = "Insertion Sort";
            this.radioButtonInsertion.UseVisualStyleBackColor = true;
            // 
            // radioButtonBubble
            // 
            this.radioButtonBubble.AutoSize = true;
            this.radioButtonBubble.Location = new System.Drawing.Point(32, 54);
            this.radioButtonBubble.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonBubble.Name = "radioButtonBubble";
            this.radioButtonBubble.Size = new System.Drawing.Size(188, 34);
            this.radioButtonBubble.TabIndex = 0;
            this.radioButtonBubble.TabStop = true;
            this.radioButtonBubble.Text = "Bubble Sort";
            this.radioButtonBubble.UseVisualStyleBackColor = true;
            this.radioButtonBubble.CheckedChanged += new System.EventHandler(this.radioButtonBubble_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Result :";
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 25;
            this.listBoxResult.Location = new System.Drawing.Point(30, 317);
            this.listBoxResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(374, 279);
            this.listBoxResult.TabIndex = 6;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(698, 504);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(182, 46);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonGo
            // 
            this.buttonGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGo.Location = new System.Drawing.Point(452, 508);
            this.buttonGo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(168, 46);
            this.buttonGo.TabIndex = 8;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(452, 562);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(168, 46);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelDurasiSorting
            // 
            this.labelDurasiSorting.AutoSize = true;
            this.labelDurasiSorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDurasiSorting.Location = new System.Drawing.Point(766, 460);
            this.labelDurasiSorting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDurasiSorting.Name = "labelDurasiSorting";
            this.labelDurasiSorting.Size = new System.Drawing.Size(77, 25);
            this.labelDurasiSorting.TabIndex = 10;
            this.labelDurasiSorting.Text = "HASIL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(420, 456);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Executed Time Calculation :";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(696, 560);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(180, 48);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(337, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "Generate Column Length :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxBanyakData
            // 
            this.textBoxBanyakData.Location = new System.Drawing.Point(142, 215);
            this.textBoxBanyakData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBanyakData.Name = "textBoxBanyakData";
            this.textBoxBanyakData.Size = new System.Drawing.Size(288, 31);
            this.textBoxBanyakData.TabIndex = 14;
            this.textBoxBanyakData.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 223);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Length :";
            // 
            // buttonVisualize
            // 
            this.buttonVisualize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVisualize.Location = new System.Drawing.Point(575, 625);
            this.buttonVisualize.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVisualize.Name = "buttonVisualize";
            this.buttonVisualize.Size = new System.Drawing.Size(168, 46);
            this.buttonVisualize.TabIndex = 16;
            this.buttonVisualize.Text = "Visualize";
            this.buttonVisualize.UseVisualStyleBackColor = true;
            this.buttonVisualize.Click += new System.EventHandler(this.buttonVisualize_Click);
            // 
            // FormSorting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(932, 684);
            this.Controls.Add(this.buttonVisualize);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxBanyakData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelDurasiSorting);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSorting";
            this.Text = "Aplikasi Sorting ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonBubble;
        private System.Windows.Forms.RadioButton radioButtonQuick;
        private System.Windows.Forms.RadioButton radioButtonMerge;
        private System.Windows.Forms.RadioButton radioButtonSelection;
        private System.Windows.Forms.RadioButton radioButtonInsertion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelDurasiSorting;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBanyakData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonVisualize;
    }
}

