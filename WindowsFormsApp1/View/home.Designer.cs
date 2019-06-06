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
            this.incomeBtn = new System.Windows.Forms.RadioButton();
            this.expenseBtn = new System.Windows.Forms.RadioButton();
            this.moneyBox = new System.Windows.Forms.TextBox();
            this.moneylabel = new System.Windows.Forms.Label();
            this.memolabel = new System.Windows.Forms.Label();
            this.memoBox = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // yearlabel
            // 
            this.yearlabel.AutoSize = true;
            this.yearlabel.Location = new System.Drawing.Point(142, 72);
            this.yearlabel.Name = "yearlabel";
            this.yearlabel.Size = new System.Drawing.Size(21, 12);
            this.yearlabel.TabIndex = 2;
            this.yearlabel.Text = " 년";
            // 
            // monthlabel
            // 
            this.monthlabel.AutoSize = true;
            this.monthlabel.Location = new System.Drawing.Point(288, 72);
            this.monthlabel.Name = "monthlabel";
            this.monthlabel.Size = new System.Drawing.Size(17, 12);
            this.monthlabel.TabIndex = 4;
            this.monthlabel.Text = "월";
            // 
            // daylabel
            // 
            this.daylabel.AutoSize = true;
            this.daylabel.Location = new System.Drawing.Point(425, 72);
            this.daylabel.Name = "daylabel";
            this.daylabel.Size = new System.Drawing.Size(17, 12);
            this.daylabel.TabIndex = 5;
            this.daylabel.Text = "일";
            // 
            // incomeBtn
            // 
            this.incomeBtn.AutoSize = true;
            this.incomeBtn.Location = new System.Drawing.Point(575, 72);
            this.incomeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incomeBtn.Name = "incomeBtn";
            this.incomeBtn.Size = new System.Drawing.Size(47, 16);
            this.incomeBtn.TabIndex = 6;
            this.incomeBtn.TabStop = true;
            this.incomeBtn.Text = "수입";
            this.incomeBtn.UseVisualStyleBackColor = true;
            // 
            // expenseBtn
            // 
            this.expenseBtn.AutoSize = true;
            this.expenseBtn.Location = new System.Drawing.Point(492, 72);
            this.expenseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.expenseBtn.Name = "expenseBtn";
            this.expenseBtn.Size = new System.Drawing.Size(47, 16);
            this.expenseBtn.TabIndex = 7;
            this.expenseBtn.TabStop = true;
            this.expenseBtn.Text = "지출";
            this.expenseBtn.UseVisualStyleBackColor = true;
            // 
            // moneyBox
            // 
            this.moneyBox.Location = new System.Drawing.Point(318, 106);
            this.moneyBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moneyBox.Name = "moneyBox";
            this.moneyBox.Size = new System.Drawing.Size(88, 21);
            this.moneyBox.TabIndex = 8;
            // 
            // moneylabel
            // 
            this.moneylabel.AutoSize = true;
            this.moneylabel.Location = new System.Drawing.Point(425, 114);
            this.moneylabel.Name = "moneylabel";
            this.moneylabel.Size = new System.Drawing.Size(17, 12);
            this.moneylabel.TabIndex = 9;
            this.moneylabel.Text = "원";
            // 
            // memolabel
            // 
            this.memolabel.AutoSize = true;
            this.memolabel.Location = new System.Drawing.Point(46, 106);
            this.memolabel.Name = "memolabel";
            this.memolabel.Size = new System.Drawing.Size(29, 12);
            this.memolabel.TabIndex = 10;
            this.memolabel.Text = "메모";
            // 
            // memoBox
            // 
            this.memoBox.Location = new System.Drawing.Point(99, 106);
            this.memoBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memoBox.Name = "memoBox";
            this.memoBox.Size = new System.Drawing.Size(168, 21);
            this.memoBox.TabIndex = 11;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(492, 100);
            this.addbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(66, 18);
            this.addbutton.TabIndex = 12;
            this.addbutton.Text = "추가";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // comparebutton
            // 
            this.comparebutton.Location = new System.Drawing.Point(492, 10);
            this.comparebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comparebutton.Name = "comparebutton";
            this.comparebutton.Size = new System.Drawing.Size(182, 18);
            this.comparebutton.TabIndex = 17;
            this.comparebutton.Text = "비교";
            this.comparebutton.UseVisualStyleBackColor = true;
            this.comparebutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.Location = new System.Drawing.Point(31, 10);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(75, 23);
            this.logoutbutton.TabIndex = 18;
            this.logoutbutton.Text = "로그아웃";
            this.logoutbutton.UseVisualStyleBackColor = true;
            this.logoutbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(492, 123);
            this.searchbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(66, 18);
            this.searchbutton.TabIndex = 19;
            this.searchbutton.Text = "검색";
            this.searchbutton.UseVisualStyleBackColor = true;
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(575, 123);
            this.deletebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(66, 18);
            this.deletebutton.TabIndex = 20;
            this.deletebutton.Text = "삭제";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // changebutton
            // 
            this.changebutton.Location = new System.Drawing.Point(575, 99);
            this.changebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changebutton.Name = "changebutton";
            this.changebutton.Size = new System.Drawing.Size(66, 18);
            this.changebutton.TabIndex = 21;
            this.changebutton.Text = "수정";
            this.changebutton.UseVisualStyleBackColor = true;
            this.changebutton.Click += new System.EventHandler(this.changebutton_Click);
            // 
            // exelbutton
            // 
            this.exelbutton.Location = new System.Drawing.Point(492, 31);
            this.exelbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exelbutton.Name = "exelbutton";
            this.exelbutton.Size = new System.Drawing.Size(182, 18);
            this.exelbutton.TabIndex = 22;
            this.exelbutton.Text = "엑셀로다운받기";
            this.exelbutton.UseVisualStyleBackColor = true;
            // 
            // yearBox
            // 
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Location = new System.Drawing.Point(31, 70);
            this.yearBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(106, 20);
            this.yearBox.TabIndex = 23;
            // 
            // monthBox
            // 
            this.monthBox.FormattingEnabled = true;
            this.monthBox.Location = new System.Drawing.Point(171, 71);
            this.monthBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(106, 20);
            this.monthBox.TabIndex = 24;
            // 
            // dayBox
            // 
            this.dayBox.FormattingEnabled = true;
            this.dayBox.Location = new System.Drawing.Point(312, 72);
            this.dayBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(106, 20);
            this.dayBox.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(643, 182);
            this.dataGridView1.TabIndex = 26;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 360);
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
            this.Controls.Add(this.memoBox);
            this.Controls.Add(this.memolabel);
            this.Controls.Add(this.moneylabel);
            this.Controls.Add(this.moneyBox);
            this.Controls.Add(this.expenseBtn);
            this.Controls.Add(this.incomeBtn);
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
        private System.Windows.Forms.RadioButton incomeBtn;
        private System.Windows.Forms.RadioButton expenseBtn;
        private System.Windows.Forms.TextBox moneyBox;
        private System.Windows.Forms.Label moneylabel;
        private System.Windows.Forms.Label memolabel;
        private System.Windows.Forms.TextBox memoBox;
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
    }
}