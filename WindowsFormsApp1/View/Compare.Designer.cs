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
            this.monthcomparebtn = new System.Windows.Forms.Button();
            this.categorycomparebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthcomparebtn
            // 
            this.monthcomparebtn.Location = new System.Drawing.Point(101, 58);
            this.monthcomparebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.monthcomparebtn.Name = "monthcomparebtn";
            this.monthcomparebtn.Size = new System.Drawing.Size(127, 94);
            this.monthcomparebtn.TabIndex = 1;
            this.monthcomparebtn.Text = "월별 비교";
            this.monthcomparebtn.UseVisualStyleBackColor = true;
            this.monthcomparebtn.Click += new System.EventHandler(this.monthcomparebtn_Click);
            // 
            // categorycomparebtn
            // 
            this.categorycomparebtn.Location = new System.Drawing.Point(429, 58);
            this.categorycomparebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.categorycomparebtn.Name = "categorycomparebtn";
            this.categorycomparebtn.Size = new System.Drawing.Size(127, 94);
            this.categorycomparebtn.TabIndex = 2;
            this.categorycomparebtn.Text = "카테고리별 비교";
            this.categorycomparebtn.UseVisualStyleBackColor = true;
            this.categorycomparebtn.Click += new System.EventHandler(this.categorycomparebtn_Click);
            // 
            // Compare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 220);
            this.Controls.Add(this.categorycomparebtn);
            this.Controls.Add(this.monthcomparebtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Compare";
            this.Text = "Compare";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button monthcomparebtn;
        private System.Windows.Forms.Button categorycomparebtn;
    }
}