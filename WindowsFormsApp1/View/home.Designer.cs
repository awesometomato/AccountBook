namespace WindowsFormsApp1
{
    partial class home
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
            this.yearlabel = new System.Windows.Forms.Label();
            this.monthlabel = new System.Windows.Forms.Label();
            this.daylabel = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.comparebutton = new System.Windows.Forms.Button();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.changebutton = new System.Windows.Forms.Button();
            this.exelbutton = new System.Windows.Forms.Button();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.monthBox = new System.Windows.Forms.ComboBox();
            this.dayBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.expensecategorycomboBox = new System.Windows.Forms.ComboBox();
            this.incomecategorycomboBox = new System.Windows.Forms.ComboBox();
            this.balancelabel = new System.Windows.Forms.Label();
            this.balancebox = new System.Windows.Forms.TextBox();
            this.expensecheck = new System.Windows.Forms.CheckBox();
            this.incomecheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // yearlabel
            // 
            this.yearlabel.AutoSize = true;
            this.yearlabel.Location = new System.Drawing.Point(162, 90);
            this.yearlabel.Name = "yearlabel";
            this.yearlabel.Size = new System.Drawing.Size(27, 15);
            this.yearlabel.TabIndex = 2;
            this.yearlabel.Text = " 년";
            // 
            // monthlabel
            // 
            this.monthlabel.AutoSize = true;
            this.monthlabel.Location = new System.Drawing.Point(329, 90);
            this.monthlabel.Name = "monthlabel";
            this.monthlabel.Size = new System.Drawing.Size(22, 15);
            this.monthlabel.TabIndex = 4;
            this.monthlabel.Text = "월";
            // 
            // daylabel
            // 
            this.daylabel.AutoSize = true;
            this.daylabel.Location = new System.Drawing.Point(486, 90);
            this.daylabel.Name = "daylabel";
            this.daylabel.Size = new System.Drawing.Size(22, 15);
            this.daylabel.TabIndex = 5;
            this.daylabel.Text = "일";
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(562, 92);
            this.addbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 22);
            this.addbutton.TabIndex = 12;
            this.addbutton.Text = "추가";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // comparebutton
            // 
            this.comparebutton.Location = new System.Drawing.Point(562, 12);
            this.comparebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comparebutton.Name = "comparebutton";
            this.comparebutton.Size = new System.Drawing.Size(208, 22);
            this.comparebutton.TabIndex = 17;
            this.comparebutton.Text = "비교";
            this.comparebutton.UseVisualStyleBackColor = true;
            this.comparebutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.Location = new System.Drawing.Point(14, 15);
            this.logoutbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(86, 29);
            this.logoutbutton.TabIndex = 18;
            this.logoutbutton.Text = "로그아웃";
            this.logoutbutton.UseVisualStyleBackColor = true;
            this.logoutbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(562, 139);
            this.searchbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 22);
            this.searchbutton.TabIndex = 19;
            this.searchbutton.Text = "검색";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(673, 139);
            this.deletebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 22);
            this.deletebutton.TabIndex = 20;
            this.deletebutton.Text = "삭제";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // changebutton
            // 
            this.changebutton.Location = new System.Drawing.Point(673, 92);
            this.changebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changebutton.Name = "changebutton";
            this.changebutton.Size = new System.Drawing.Size(75, 22);
            this.changebutton.TabIndex = 21;
            this.changebutton.Text = "수정";
            this.changebutton.UseVisualStyleBackColor = true;
            this.changebutton.Click += new System.EventHandler(this.changebutton_Click);
            // 
            // exelbutton
            // 
            this.exelbutton.Location = new System.Drawing.Point(562, 39);
            this.exelbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exelbutton.Name = "exelbutton";
            this.exelbutton.Size = new System.Drawing.Size(208, 22);
            this.exelbutton.TabIndex = 22;
            this.exelbutton.Text = "엑셀로다운받기";
            this.exelbutton.UseVisualStyleBackColor = true;
            // 
            // yearBox
            // 
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Location = new System.Drawing.Point(35, 88);
            this.yearBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(121, 23);
            this.yearBox.TabIndex = 23;
            // 
            // monthBox
            // 
            this.monthBox.FormattingEnabled = true;
            this.monthBox.Location = new System.Drawing.Point(195, 89);
            this.monthBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(121, 23);
            this.monthBox.TabIndex = 24;
            // 
            // dayBox
            // 
            this.dayBox.FormattingEnabled = true;
            this.dayBox.Location = new System.Drawing.Point(357, 90);
            this.dayBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(121, 23);
            this.dayBox.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 194);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(735, 228);
            this.dataGridView1.TabIndex = 26;
            // 
            // expensecategorycomboBox
            // 
            this.expensecategorycomboBox.FormattingEnabled = true;
            this.expensecategorycomboBox.Items.AddRange(new object[] {
            "식비",
            "교통비",
            "문화생활",
            "생필품",
            "의류",
            "미용",
            "의료/건강",
            "교육",
            "통신비",
            "회비",
            "경조사",
            "저축",
            "가전",
            "공과금",
            "카드대금"});
            this.expensecategorycomboBox.Location = new System.Drawing.Point(234, 12);
            this.expensecategorycomboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expensecategorycomboBox.Name = "expensecategorycomboBox";
            this.expensecategorycomboBox.Size = new System.Drawing.Size(138, 23);
            this.expensecategorycomboBox.TabIndex = 27;
            // 
            // incomecategorycomboBox
            // 
            this.incomecategorycomboBox.FormattingEnabled = true;
            this.incomecategorycomboBox.Items.AddRange(new object[] {
            "월급",
            "용돈",
            "이월",
            "기타",
            "자산인출"});
            this.incomecategorycomboBox.Location = new System.Drawing.Point(234, 45);
            this.incomecategorycomboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.incomecategorycomboBox.Name = "incomecategorycomboBox";
            this.incomecategorycomboBox.Size = new System.Drawing.Size(138, 23);
            this.incomecategorycomboBox.TabIndex = 28;
            // 
            // balancelabel
            // 
            this.balancelabel.AutoSize = true;
            this.balancelabel.Location = new System.Drawing.Point(283, 146);
            this.balancelabel.Name = "balancelabel";
            this.balancelabel.Size = new System.Drawing.Size(37, 15);
            this.balancelabel.TabIndex = 29;
            this.balancelabel.Text = "잔액";
            // 
            // balancebox
            // 
            this.balancebox.Location = new System.Drawing.Point(323, 142);
            this.balancebox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.balancebox.Name = "balancebox";
            this.balancebox.ReadOnly = true;
            this.balancebox.Size = new System.Drawing.Size(114, 25);
            this.balancebox.TabIndex = 30;
            // 
            // expensecheck
            // 
            this.expensecheck.AutoSize = true;
            this.expensecheck.Location = new System.Drawing.Point(149, 15);
            this.expensecheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expensecheck.Name = "expensecheck";
            this.expensecheck.Size = new System.Drawing.Size(59, 19);
            this.expensecheck.TabIndex = 31;
            this.expensecheck.Text = "지출";
            this.expensecheck.UseVisualStyleBackColor = true;
            // 
            // incomecheck
            // 
            this.incomecheck.AutoSize = true;
            this.incomecheck.Location = new System.Drawing.Point(149, 45);
            this.incomecheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.incomecheck.Name = "incomecheck";
            this.incomecheck.Size = new System.Drawing.Size(59, 19);
            this.incomecheck.TabIndex = 32;
            this.incomecheck.Text = "수입";
            this.incomecheck.UseVisualStyleBackColor = true;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.incomecheck);
            this.Controls.Add(this.expensecheck);
            this.Controls.Add(this.balancebox);
            this.Controls.Add(this.balancelabel);
            this.Controls.Add(this.incomecategorycomboBox);
            this.Controls.Add(this.expensecategorycomboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.exelbutton);
            this.Controls.Add(this.changebutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.comparebutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.daylabel);
            this.Controls.Add(this.monthlabel);
            this.Controls.Add(this.yearlabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label yearlabel;
        private System.Windows.Forms.Label monthlabel;
        private System.Windows.Forms.Label daylabel;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button comparebutton;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button changebutton;
        private System.Windows.Forms.Button exelbutton;
        private System.Windows.Forms.ComboBox yearBox;
        private System.Windows.Forms.ComboBox monthBox;
        private System.Windows.Forms.ComboBox dayBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox expensecategorycomboBox;
        private System.Windows.Forms.ComboBox incomecategorycomboBox;
        private System.Windows.Forms.Label balancelabel;
        private System.Windows.Forms.TextBox balancebox;
        private System.Windows.Forms.CheckBox expensecheck;
        private System.Windows.Forms.CheckBox incomecheck;
    }
}