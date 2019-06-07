namespace WindowsFormsApp1
{
    partial class Compare
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
            this.daycomparebtn = new System.Windows.Forms.Button();
            this.monthcomparebtn = new System.Windows.Forms.Button();
            this.categorycomparebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // daycomparebtn
            // 
            this.daycomparebtn.Location = new System.Drawing.Point(58, 46);
            this.daycomparebtn.Name = "daycomparebtn";
            this.daycomparebtn.Size = new System.Drawing.Size(111, 75);
            this.daycomparebtn.TabIndex = 0;
            this.daycomparebtn.Text = "일별 비교";
            this.daycomparebtn.UseVisualStyleBackColor = true;
            this.daycomparebtn.Click += new System.EventHandler(this.daycomparebtn_Click);
            // 
            // monthcomparebtn
            // 
            this.monthcomparebtn.Location = new System.Drawing.Point(226, 46);
            this.monthcomparebtn.Name = "monthcomparebtn";
            this.monthcomparebtn.Size = new System.Drawing.Size(111, 75);
            this.monthcomparebtn.TabIndex = 1;
            this.monthcomparebtn.Text = "월별 비교";
            this.monthcomparebtn.UseVisualStyleBackColor = true;
            this.monthcomparebtn.Click += new System.EventHandler(this.monthcomparebtn_Click);
            // 
            // categorycomparebtn
            // 
            this.categorycomparebtn.Location = new System.Drawing.Point(395, 46);
            this.categorycomparebtn.Name = "categorycomparebtn";
            this.categorycomparebtn.Size = new System.Drawing.Size(111, 75);
            this.categorycomparebtn.TabIndex = 2;
            this.categorycomparebtn.Text = "카테고리별 비교";
            this.categorycomparebtn.UseVisualStyleBackColor = true;
            this.categorycomparebtn.Click += new System.EventHandler(this.categorycomparebtn_Click);
            // 
            // Compare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 176);
            this.Controls.Add(this.categorycomparebtn);
            this.Controls.Add(this.monthcomparebtn);
            this.Controls.Add(this.daycomparebtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Compare";
            this.Text = "Compare";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button daycomparebtn;
        private System.Windows.Forms.Button monthcomparebtn;
        private System.Windows.Forms.Button categorycomparebtn;
    }
}