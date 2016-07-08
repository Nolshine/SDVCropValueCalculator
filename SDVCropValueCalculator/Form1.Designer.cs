using System;

namespace SDVCropValueCalculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.moneyInputControlLabel = new System.Windows.Forms.Label();
            this.dayDropDown = new System.Windows.Forms.ComboBox();
            this.seasonDropDown = new System.Windows.Forms.ComboBox();
            this.moneyInputControl = new System.Windows.Forms.TextBox();
            this.cropLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.dayInputLabel = new System.Windows.Forms.Label();
            this.seasonInputLabel = new System.Windows.Forms.Label();
            this.prefCropLabel = new System.Windows.Forms.Label();
            this.radioGroup = new System.Windows.Forms.GroupBox();
            this.deluxeGro = new System.Windows.Forms.RadioButton();
            this.speedGro = new System.Windows.Forms.RadioButton();
            this.noGro = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.isAgriculturist = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.radioGroup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.37931F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.24138F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.65517F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.37931F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.moneyInputControlLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dayDropDown, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.seasonDropDown, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.moneyInputControl, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cropLabel, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.calcButton, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.dayInputLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.seasonInputLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.prefCropLabel, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.radioGroup, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.865169F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.865169F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.88764F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.96629F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.7191F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.58427F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(580, 356);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // moneyInputControlLabel
            // 
            this.moneyInputControlLabel.AutoSize = true;
            this.moneyInputControlLabel.Location = new System.Drawing.Point(32, 20);
            this.moneyInputControlLabel.Margin = new System.Windows.Forms.Padding(3);
            this.moneyInputControlLabel.Name = "moneyInputControlLabel";
            this.moneyInputControlLabel.Size = new System.Drawing.Size(84, 13);
            this.moneyInputControlLabel.TabIndex = 1;
            this.moneyInputControlLabel.Text = "Money on hand:";
            // 
            // dayDropDown
            // 
            this.dayDropDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.dayDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayDropDown.FormattingEnabled = true;
            this.dayDropDown.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28"});
            this.dayDropDown.Location = new System.Drawing.Point(127, 48);
            this.dayDropDown.Name = "dayDropDown";
            this.dayDropDown.Size = new System.Drawing.Size(94, 21);
            this.dayDropDown.TabIndex = 8;
            this.dayDropDown.SelectedIndexChanged += new System.EventHandler(this.dayDropDown_SelectedIndexChanged);
            // 
            // seasonDropDown
            // 
            this.seasonDropDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.seasonDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seasonDropDown.FormattingEnabled = true;
            this.seasonDropDown.Items.AddRange(new object[] {
            "Spring",
            "Summer",
            "Fall",
            "Winter"});
            this.seasonDropDown.Location = new System.Drawing.Point(127, 76);
            this.seasonDropDown.Name = "seasonDropDown";
            this.seasonDropDown.Size = new System.Drawing.Size(94, 21);
            this.seasonDropDown.TabIndex = 9;
            this.seasonDropDown.SelectedIndexChanged += new System.EventHandler(this.seasonDropDown_SelectedIndexChanged);
            // 
            // moneyInputControl
            // 
            this.moneyInputControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.moneyInputControl.HideSelection = false;
            this.moneyInputControl.Location = new System.Drawing.Point(127, 20);
            this.moneyInputControl.Name = "moneyInputControl";
            this.moneyInputControl.Size = new System.Drawing.Size(94, 20);
            this.moneyInputControl.TabIndex = 0;
            this.moneyInputControl.TextChanged += new System.EventHandler(this.moneyInputControl_TextChanged);
            // 
            // cropLabel
            // 
            this.cropLabel.AutoSize = true;
            this.cropLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cropLabel.Location = new System.Drawing.Point(399, 48);
            this.cropLabel.Margin = new System.Windows.Forms.Padding(3);
            this.cropLabel.Name = "cropLabel";
            this.tableLayoutPanel1.SetRowSpan(this.cropLabel, 4);
            this.cropLabel.Size = new System.Drawing.Size(147, 259);
            this.cropLabel.TabIndex = 7;
            this.cropLabel.Text = "Press calculate to determine.";
            // 
            // calcButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.calcButton, 4);
            this.calcButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calcButton.Location = new System.Drawing.Point(32, 313);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(514, 21);
            this.calcButton.TabIndex = 10;
            this.calcButton.Text = "Calculate!";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // dayInputLabel
            // 
            this.dayInputLabel.AutoSize = true;
            this.dayInputLabel.Location = new System.Drawing.Point(32, 48);
            this.dayInputLabel.Margin = new System.Windows.Forms.Padding(3);
            this.dayInputLabel.Name = "dayInputLabel";
            this.dayInputLabel.Size = new System.Drawing.Size(29, 13);
            this.dayInputLabel.TabIndex = 5;
            this.dayInputLabel.Text = "Day:";
            // 
            // seasonInputLabel
            // 
            this.seasonInputLabel.AutoSize = true;
            this.seasonInputLabel.Location = new System.Drawing.Point(32, 76);
            this.seasonInputLabel.Margin = new System.Windows.Forms.Padding(3);
            this.seasonInputLabel.Name = "seasonInputLabel";
            this.seasonInputLabel.Size = new System.Drawing.Size(46, 13);
            this.seasonInputLabel.TabIndex = 3;
            this.seasonInputLabel.Text = "Season:";
            // 
            // prefCropLabel
            // 
            this.prefCropLabel.AutoSize = true;
            this.prefCropLabel.Location = new System.Drawing.Point(399, 20);
            this.prefCropLabel.Margin = new System.Windows.Forms.Padding(3);
            this.prefCropLabel.Name = "prefCropLabel";
            this.prefCropLabel.Size = new System.Drawing.Size(78, 13);
            this.prefCropLabel.TabIndex = 6;
            this.prefCropLabel.Text = "Preferred Crop:";
            // 
            // radioGroup
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.radioGroup, 2);
            this.radioGroup.Controls.Add(this.deluxeGro);
            this.radioGroup.Controls.Add(this.speedGro);
            this.radioGroup.Controls.Add(this.noGro);
            this.radioGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioGroup.Location = new System.Drawing.Point(32, 129);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Size = new System.Drawing.Size(189, 90);
            this.radioGroup.TabIndex = 11;
            this.radioGroup.TabStop = false;
            this.radioGroup.Text = "fetilizer available";
            // 
            // deluxeGro
            // 
            this.deluxeGro.AutoSize = true;
            this.deluxeGro.Location = new System.Drawing.Point(7, 68);
            this.deluxeGro.Name = "deluxeGro";
            this.deluxeGro.Size = new System.Drawing.Size(112, 17);
            this.deluxeGro.TabIndex = 2;
            this.deluxeGro.Text = "Deluxe Speed-Gro";
            this.deluxeGro.UseVisualStyleBackColor = true;
            // 
            // speedGro
            // 
            this.speedGro.AutoSize = true;
            this.speedGro.Location = new System.Drawing.Point(7, 44);
            this.speedGro.Name = "speedGro";
            this.speedGro.Size = new System.Drawing.Size(76, 17);
            this.speedGro.TabIndex = 1;
            this.speedGro.Text = "Speed-Gro";
            this.speedGro.UseVisualStyleBackColor = true;
            // 
            // noGro
            // 
            this.noGro.AutoSize = true;
            this.noGro.Checked = true;
            this.noGro.Location = new System.Drawing.Point(7, 20);
            this.noGro.Name = "noGro";
            this.noGro.Size = new System.Drawing.Size(75, 17);
            this.noGro.TabIndex = 0;
            this.noGro.TabStop = true;
            this.noGro.Text = "no fertilizer";
            this.noGro.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.isAgriculturist);
            this.panel1.Location = new System.Drawing.Point(32, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 82);
            this.panel1.TabIndex = 13;
            // 
            // isAgriculturist
            // 
            this.isAgriculturist.AutoSize = true;
            this.isAgriculturist.Location = new System.Drawing.Point(7, 22);
            this.isAgriculturist.Name = "isAgriculturist";
            this.isAgriculturist.Size = new System.Drawing.Size(111, 17);
            this.isAgriculturist.TabIndex = 12;
            this.isAgriculturist.Text = "Agriculturist Perk?";
            this.isAgriculturist.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 356);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Crop Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.radioGroup.ResumeLayout(false);
            this.radioGroup.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label dayInputLabel;
        private System.Windows.Forms.Label seasonInputLabel;
        private System.Windows.Forms.TextBox moneyInputControl;
        private System.Windows.Forms.Label moneyInputControlLabel;
        private System.Windows.Forms.Label prefCropLabel;
        private System.Windows.Forms.Label cropLabel;
        private System.Windows.Forms.ComboBox dayDropDown;
        private System.Windows.Forms.ComboBox seasonDropDown;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.GroupBox radioGroup;
        private System.Windows.Forms.RadioButton deluxeGro;
        private System.Windows.Forms.RadioButton speedGro;
        private System.Windows.Forms.RadioButton noGro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox isAgriculturist;
    }
}

