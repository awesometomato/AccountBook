namespace WindowsFormsApp1
{
    partial class Form3
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
            this.label5 = new System.Windows.Forms.Label();
            this.memotextBox = new System.Windows.Forms.TextBox();
            this.moneytextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.yearcomboBox = new System.Windows.Forms.ComboBox();
            this.monthcomboBox = new System.Windows.Forms.ComboBox();
            this.daycomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "메모";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "원";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = " 년";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "월";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "일";
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 201);
            this.Controls.Add(this.daycomboBox);
            this.Controls.Add(this.monthcomboBox);
            this.Controls.Add(this.yearcomboBox);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.moneytextBox);
            this.Controls.Add(this.memotextBox);
            this.Controls.Add(this.label5);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox memotextBox;
        private System.Windows.Forms.TextBox moneytextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.ComboBox yearcomboBox;
        private System.Windows.Forms.ComboBox monthcomboBox;
        private System.Windows.Forms.ComboBox daycomboBox;
    }
}