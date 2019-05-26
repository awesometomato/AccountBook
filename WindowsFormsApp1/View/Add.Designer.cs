namespace WindowsFormsApp1
{
    partial class Add
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
            this.momolabel = new System.Windows.Forms.Label();
            this.memotextBox = new System.Windows.Forms.TextBox();
            this.moneytextBox = new System.Windows.Forms.TextBox();
            this.moneylabel = new System.Windows.Forms.Label();
            this.yearlabel = new System.Windows.Forms.Label();
            this.monthlabel = new System.Windows.Forms.Label();
            this.daylabel = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.yearcomboBox = new System.Windows.Forms.ComboBox();
            this.monthcomboBox = new System.Windows.Forms.ComboBox();
            this.daycomboBox = new System.Windows.Forms.ComboBox();
            this.expenseradiobutton = new System.Windows.Forms.RadioButton();
            this.incomeradiobutton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // momolabel
            // 
            this.momolabel.AutoSize = true;
            this.momolabel.Location = new System.Drawing.Point(67, 105);
            this.momolabel.Name = "momolabel";
            this.momolabel.Size = new System.Drawing.Size(29, 12);
            this.momolabel.TabIndex = 11;
            this.momolabel.Text = "메모";
            // 
            // memotextBox
            // 
            this.memotextBox.Location = new System.Drawing.Point(126, 97);
            this.memotextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memotextBox.Name = "memotextBox";
            this.memotextBox.Size = new System.Drawing.Size(168, 21);
            this.memotextBox.TabIndex = 12;
            // 
            // moneytextBox
            // 
            this.moneytextBox.Location = new System.Drawing.Point(326, 97);
            this.moneytextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moneytextBox.Name = "moneytextBox";
            this.moneytextBox.Size = new System.Drawing.Size(88, 21);
            this.moneytextBox.TabIndex = 13;
            // 
            // moneylabel
            // 
            this.moneylabel.AutoSize = true;
            this.moneylabel.Location = new System.Drawing.Point(443, 105);
            this.moneylabel.Name = "moneylabel";
            this.moneylabel.Size = new System.Drawing.Size(17, 12);
            this.moneylabel.TabIndex = 14;
            this.moneylabel.Text = "원";
            // 
            // yearlabel
            // 
            this.yearlabel.AutoSize = true;
            this.yearlabel.Location = new System.Drawing.Point(149, 64);
            this.yearlabel.Name = "yearlabel";
            this.yearlabel.Size = new System.Drawing.Size(21, 12);
            this.yearlabel.TabIndex = 15;
            this.yearlabel.Text = " 년";
            // 
            // monthlabel
            // 
            this.monthlabel.AutoSize = true;
            this.monthlabel.Location = new System.Drawing.Point(298, 64);
            this.monthlabel.Name = "monthlabel";
            this.monthlabel.Size = new System.Drawing.Size(17, 12);
            this.monthlabel.TabIndex = 16;
            this.monthlabel.Text = "월";
            // 
            // daylabel
            // 
            this.daylabel.AutoSize = true;
            this.daylabel.Location = new System.Drawing.Point(443, 64);
            this.daylabel.Name = "daylabel";
            this.daylabel.Size = new System.Drawing.Size(17, 12);
            this.daylabel.TabIndex = 17;
            this.daylabel.Text = "일";
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(486, 133);
            this.addbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(66, 18);
            this.addbutton.TabIndex = 18;
            this.addbutton.Text = "추가";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // yearcomboBox
            // 
            this.yearcomboBox.FormattingEnabled = true;
            this.yearcomboBox.Location = new System.Drawing.Point(38, 62);
            this.yearcomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yearcomboBox.Name = "yearcomboBox";
            this.yearcomboBox.Size = new System.Drawing.Size(106, 20);
            this.yearcomboBox.TabIndex = 24;
            // 
            // monthcomboBox
            // 
            this.monthcomboBox.FormattingEnabled = true;
            this.monthcomboBox.Location = new System.Drawing.Point(178, 62);
            this.monthcomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monthcomboBox.Name = "monthcomboBox";
            this.monthcomboBox.Size = new System.Drawing.Size(106, 20);
            this.monthcomboBox.TabIndex = 25;
            // 
            // daycomboBox
            // 
            this.daycomboBox.FormattingEnabled = true;
            this.daycomboBox.Location = new System.Drawing.Point(326, 62);
            this.daycomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.daycomboBox.Name = "daycomboBox";
            this.daycomboBox.Size = new System.Drawing.Size(106, 20);
            this.daycomboBox.TabIndex = 26;
            // 
            // expenseradiobutton
            // 
            this.expenseradiobutton.AutoSize = true;
            this.expenseradiobutton.Location = new System.Drawing.Point(38, 21);
            this.expenseradiobutton.Name = "expenseradiobutton";
            this.expenseradiobutton.Size = new System.Drawing.Size(47, 16);
            this.expenseradiobutton.TabIndex = 27;
            this.expenseradiobutton.TabStop = true;
            this.expenseradiobutton.Text = "지출";
            this.expenseradiobutton.UseVisualStyleBackColor = true;
            // 
            // incomeradiobutton
            // 
            this.incomeradiobutton.AutoSize = true;
            this.incomeradiobutton.Location = new System.Drawing.Point(97, 21);
            this.incomeradiobutton.Name = "incomeradiobutton";
            this.incomeradiobutton.Size = new System.Drawing.Size(47, 16);
            this.incomeradiobutton.TabIndex = 28;
            this.incomeradiobutton.TabStop = true;
            this.incomeradiobutton.Text = "수입";
            this.incomeradiobutton.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 161);
            this.Controls.Add(this.incomeradiobutton);
            this.Controls.Add(this.expenseradiobutton);
            this.Controls.Add(this.daycomboBox);
            this.Controls.Add(this.monthcomboBox);
            this.Controls.Add(this.yearcomboBox);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.daylabel);
            this.Controls.Add(this.monthlabel);
            this.Controls.Add(this.yearlabel);
            this.Controls.Add(this.moneylabel);
            this.Controls.Add(this.moneytextBox);
            this.Controls.Add(this.memotextBox);
            this.Controls.Add(this.momolabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Add";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label momolabel;
        private System.Windows.Forms.TextBox memotextBox;
        private System.Windows.Forms.TextBox moneytextBox;
        private System.Windows.Forms.Label moneylabel;
        private System.Windows.Forms.Label yearlabel;
        private System.Windows.Forms.Label monthlabel;
        private System.Windows.Forms.Label daylabel;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.ComboBox yearcomboBox;
        private System.Windows.Forms.ComboBox monthcomboBox;
        private System.Windows.Forms.ComboBox daycomboBox;
        private System.Windows.Forms.RadioButton expenseradiobutton;
        private System.Windows.Forms.RadioButton incomeradiobutton;
    }
}