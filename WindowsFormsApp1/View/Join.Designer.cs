namespace WindowsFormsApp1
{
    partial class Join
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
            this.idlabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.Joinlabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.agelabel = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.passwordchecklabel = new System.Windows.Forms.Label();
            this.passwordCheckBox = new System.Windows.Forms.TextBox();
            this.womenRadio = new System.Windows.Forms.RadioButton();
            this.menRadio = new System.Windows.Forms.RadioButton();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(122, 186);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(52, 15);
            this.idlabel.TabIndex = 1;
            this.idlabel.Text = "아이디";
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Location = new System.Drawing.Point(122, 228);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(67, 15);
            this.passwordlabel.TabIndex = 2;
            this.passwordlabel.Text = "비밀번호";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(240, 96);
            this.nameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 25);
            this.nameBox.TabIndex = 3;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(240, 176);
            this.idBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(175, 25);
            this.idBox.TabIndex = 4;
            // 
            // Joinlabel
            // 
            this.Joinlabel.AutoSize = true;
            this.Joinlabel.Font = new System.Drawing.Font("굴림", 20F);
            this.Joinlabel.Location = new System.Drawing.Point(38, 28);
            this.Joinlabel.Name = "Joinlabel";
            this.Joinlabel.Size = new System.Drawing.Size(151, 34);
            this.Joinlabel.TabIndex = 19;
            this.Joinlabel.Text = "회원가입";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(122, 99);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(37, 15);
            this.namelabel.TabIndex = 20;
            this.namelabel.Text = "이름";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(240, 218);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(175, 25);
            this.passwordBox.TabIndex = 21;
            // 
            // agelabel
            // 
            this.agelabel.AutoSize = true;
            this.agelabel.Location = new System.Drawing.Point(122, 144);
            this.agelabel.Name = "agelabel";
            this.agelabel.Size = new System.Drawing.Size(37, 15);
            this.agelabel.TabIndex = 22;
            this.agelabel.Text = "나이";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(391, 308);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 22);
            this.cancelBtn.TabIndex = 26;
            this.cancelBtn.Text = "취소";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // passwordchecklabel
            // 
            this.passwordchecklabel.AutoSize = true;
            this.passwordchecklabel.Location = new System.Drawing.Point(122, 265);
            this.passwordchecklabel.Name = "passwordchecklabel";
            this.passwordchecklabel.Size = new System.Drawing.Size(102, 15);
            this.passwordchecklabel.TabIndex = 27;
            this.passwordchecklabel.Text = "비밀번호 확인";
            // 
            // passwordCheckBox
            // 
            this.passwordCheckBox.Location = new System.Drawing.Point(240, 255);
            this.passwordCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordCheckBox.Name = "passwordCheckBox";
            this.passwordCheckBox.Size = new System.Drawing.Size(175, 25);
            this.passwordCheckBox.TabIndex = 28;
            // 
            // womenRadio
            // 
            this.womenRadio.AutoSize = true;
            this.womenRadio.Location = new System.Drawing.Point(372, 102);
            this.womenRadio.Name = "womenRadio";
            this.womenRadio.Size = new System.Drawing.Size(58, 19);
            this.womenRadio.TabIndex = 29;
            this.womenRadio.TabStop = true;
            this.womenRadio.Text = "여자";
            this.womenRadio.UseVisualStyleBackColor = true;
            // 
            // menRadio
            // 
            this.menRadio.AutoSize = true;
            this.menRadio.Location = new System.Drawing.Point(448, 102);
            this.menRadio.Name = "menRadio";
            this.menRadio.Size = new System.Drawing.Size(58, 19);
            this.menRadio.TabIndex = 30;
            this.menRadio.TabStop = true;
            this.menRadio.Text = "남자";
            this.menRadio.UseVisualStyleBackColor = true;
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(240, 134);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(100, 25);
            this.ageBox.TabIndex = 31;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(240, 308);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 22);
            this.submitBtn.TabIndex = 5;
            this.submitBtn.Text = "확인";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // Join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 362);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.menRadio);
            this.Controls.Add(this.womenRadio);
            this.Controls.Add(this.passwordCheckBox);
            this.Controls.Add(this.passwordchecklabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.agelabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.Joinlabel);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.idlabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Join";
            this.Text = "Join";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label Joinlabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label agelabel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label passwordchecklabel;
        private System.Windows.Forms.TextBox passwordCheckBox;
        private System.Windows.Forms.RadioButton womenRadio;
        private System.Windows.Forms.RadioButton menRadio;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Button submitBtn;
    }
}