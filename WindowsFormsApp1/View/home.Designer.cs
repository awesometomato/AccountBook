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
            this.moneylistbox = new System.Windows.Forms.ListBox();
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
            // incomeBtn
            // 
            this.incomeBtn.AutoSize = true;
            this.incomeBtn.Location = new System.Drawing.Point(657, 90);
            this.incomeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incomeBtn.Name = "incomeBtn";
            this.incomeBtn.Size = new System.Drawing.Size(58, 19);
            this.incomeBtn.TabIndex = 6;
            this.incomeBtn.TabStop = true;
            this.incomeBtn.Text = "수입";
            this.incomeBtn.UseVisualStyleBackColor = true;
            // 
            // expenseBtn
            // 
            this.expenseBtn.AutoSize = true;
            this.expenseBtn.Location = new System.Drawing.Point(562, 90);
            this.expenseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.expenseBtn.Name = "expenseBtn";
            this.expenseBtn.Size = new System.Drawing.Size(58, 19);
            this.expenseBtn.TabIndex = 7;
            this.expenseBtn.TabStop = true;
            this.expenseBtn.Text = "지출";
            this.expenseBtn.UseVisualStyleBackColor = true;
            // 
            // moneyBox
            // 
            this.moneyBox.Location = new System.Drawing.Point(363, 132);
            this.moneyBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moneyBox.Name = "moneyBox";
            this.moneyBox.Size = new System.Drawing.Size(100, 25);
            this.moneyBox.TabIndex = 8;
            // 
            // moneylabel
            // 
            this.moneylabel.AutoSize = true;
            this.moneylabel.Location = new System.Drawing.Point(486, 142);
            this.moneylabel.Name = "moneylabel";
            this.moneylabel.Size = new System.Drawing.Size(22, 15);
            this.moneylabel.TabIndex = 9;
            this.moneylabel.Text = "원";
            // 
            // memolabel
            // 
            this.memolabel.AutoSize = true;
            this.memolabel.Location = new System.Drawing.Point(53, 132);
            this.memolabel.Name = "memolabel";
            this.memolabel.Size = new System.Drawing.Size(37, 15);
            this.memolabel.TabIndex = 10;
            this.memolabel.Text = "메모";
            // 
            // memoBox
            // 
            this.memoBox.Location = new System.Drawing.Point(113, 132);
            this.memoBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memoBox.Name = "memoBox";
            this.memoBox.Size = new System.Drawing.Size(191, 25);
            this.memoBox.TabIndex = 11;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(562, 125);
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
            this.logoutbutton.Location = new System.Drawing.Point(35, 12);
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
            this.searchbutton.Location = new System.Drawing.Point(562, 154);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 19;
            this.searchbutton.Text = "검색";
            this.searchbutton.UseVisualStyleBackColor = true;
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(657, 154);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 23);
            this.deletebutton.TabIndex = 20;
            this.deletebutton.Text = "삭제";
            this.deletebutton.UseVisualStyleBackColor = true;
            // 
            // changebutton
            // 
            this.changebutton.Location = new System.Drawing.Point(657, 124);
            this.changebutton.Name = "changebutton";
            this.changebutton.Size = new System.Drawing.Size(75, 23);
            this.changebutton.TabIndex = 21;
            this.changebutton.Text = "수정";
            this.changebutton.UseVisualStyleBackColor = true;
            // 
            // exelbutton
            // 
            this.exelbutton.Location = new System.Drawing.Point(562, 39);
            this.exelbutton.Name = "exelbutton";
            this.exelbutton.Size = new System.Drawing.Size(208, 23);
            this.exelbutton.TabIndex = 22;
            this.exelbutton.Text = "엑셀로다운받기";
            this.exelbutton.UseVisualStyleBackColor = true;
            // 
            // yearBox
            // 
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Location = new System.Drawing.Point(35, 87);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(121, 23);
            this.yearBox.TabIndex = 23;
            // 
            // monthBox
            // 
            this.monthBox.FormattingEnabled = true;
            this.monthBox.Location = new System.Drawing.Point(195, 89);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(121, 23);
            this.monthBox.TabIndex = 24;
            // 
            // dayBox
            // 
            this.dayBox.FormattingEnabled = true;
            this.dayBox.Location = new System.Drawing.Point(357, 90);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(121, 23);
            this.dayBox.TabIndex = 25;
            // 
            // moneylistbox
            // 
            this.moneylistbox.FormattingEnabled = true;
            this.moneylistbox.ItemHeight = 15;
            this.moneylistbox.Location = new System.Drawing.Point(25, 197);
            this.moneylistbox.Name = "moneylistbox";
            this.moneylistbox.Size = new System.Drawing.Size(745, 229);
            this.moneylistbox.TabIndex = 26;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moneylistbox);
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
        private System.Windows.Forms.ListBox moneylistbox;
    }
}