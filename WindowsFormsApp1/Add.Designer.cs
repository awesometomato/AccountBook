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
            this.SuspendLayout();
            // 
            // momolabel
            // 
            this.momolabel.AutoSize = true;
            this.momolabel.Location = new System.Drawing.Point(77, 131);
            this.momolabel.Name = "momolabel";
            this.momolabel.Size = new System.Drawing.Size(37, 15);
            this.momolabel.TabIndex = 11;
            this.momolabel.Text = "메모";
            // 
            // memotextBox
            // 
            this.memotextBox.Location = new System.Drawing.Point(144, 121);
            this.memotextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memotextBox.Name = "memotextBox";
            this.memotextBox.Size = new System.Drawing.Size(191, 25);
            this.memotextBox.TabIndex = 12;
            // 
            // moneytextBox
            // 
            this.moneytextBox.Location = new System.Drawing.Point(372, 121);
            this.moneytextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moneytextBox.Name = "moneytextBox";
            this.moneytextBox.Size = new System.Drawing.Size(100, 25);
            this.moneytextBox.TabIndex = 13;
            // 
            // moneylabel
            // 
            this.moneylabel.AutoSize = true;
            this.moneylabel.Location = new System.Drawing.Point(506, 131);
            this.moneylabel.Name = "moneylabel";
            this.moneylabel.Size = new System.Drawing.Size(22, 15);
            this.moneylabel.TabIndex = 14;
            this.moneylabel.Text = "원";
            // 
            // yearlabel
            // 
            this.yearlabel.AutoSize = true;
            this.yearlabel.Location = new System.Drawing.Point(170, 80);
            this.yearlabel.Name = "yearlabel";
            this.yearlabel.Size = new System.Drawing.Size(27, 15);
            this.yearlabel.TabIndex = 15;
            this.yearlabel.Text = " 년";
            // 
            // monthlabel
            // 
            this.monthlabel.AutoSize = true;
            this.monthlabel.Location = new System.Drawing.Point(340, 80);
            this.monthlabel.Name = "monthlabel";
            this.monthlabel.Size = new System.Drawing.Size(22, 15);
            this.monthlabel.TabIndex = 16;
            this.monthlabel.Text = "월";
            // 
            // daylabel
            // 
            this.daylabel.AutoSize = true;
            this.daylabel.Location = new System.Drawing.Point(506, 80);
            this.daylabel.Name = "daylabel";
            this.daylabel.Size = new System.Drawing.Size(22, 15);
            this.daylabel.TabIndex = 17;
            this.daylabel.Text = "일";
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(556, 166);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 23);
            this.addbutton.TabIndex = 18;
            this.addbutton.Text = "추가";
            this.addbutton.UseVisualStyleBackColor = true;
            // 
            // yearcomboBox
            // 
            this.yearcomboBox.FormattingEnabled = true;
            this.yearcomboBox.Location = new System.Drawing.Point(43, 77);
            this.yearcomboBox.Name = "yearcomboBox";
            this.yearcomboBox.Size = new System.Drawing.Size(121, 23);
            this.yearcomboBox.TabIndex = 24;
            // 
            // monthcomboBox
            // 
            this.monthcomboBox.FormattingEnabled = true;
            this.monthcomboBox.Location = new System.Drawing.Point(203, 77);
            this.monthcomboBox.Name = "monthcomboBox";
            this.monthcomboBox.Size = new System.Drawing.Size(121, 23);
            this.monthcomboBox.TabIndex = 25;
            // 
            // daycomboBox
            // 
            this.daycomboBox.FormattingEnabled = true;
            this.daycomboBox.Location = new System.Drawing.Point(372, 77);
            this.daycomboBox.Name = "daycomboBox";
            this.daycomboBox.Size = new System.Drawing.Size(121, 23);
            this.daycomboBox.TabIndex = 26;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 201);
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
    }
}