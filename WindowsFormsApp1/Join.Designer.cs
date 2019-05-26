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
            this.submitBtn = new System.Windows.Forms.Button();
            this.Joinlabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.agelabel = new System.Windows.Forms.Label();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.passwordchecklabel = new System.Windows.Forms.Label();
            this.joinpasswordchecktextBox = new System.Windows.Forms.TextBox();
            this.womenradio = new System.Windows.Forms.RadioButton();
            this.menradio = new System.Windows.Forms.RadioButton();
            this.ageBox = new System.Windows.Forms.TextBox();
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
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(240, 308);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 22);
            this.submitBtn.TabIndex = 5;
            this.submitBtn.Text = "확인";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.button1_Click);
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
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(391, 308);
            this.cancelbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 22);
            this.cancelbutton.TabIndex = 26;
            this.cancelbutton.Text = "취소";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.button3_Click);
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
            // joinpasswordchecktextBox
            // 
            this.joinpasswordchecktextBox.Location = new System.Drawing.Point(240, 255);
            this.joinpasswordchecktextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.joinpasswordchecktextBox.Name = "joinpasswordchecktextBox";
            this.joinpasswordchecktextBox.Size = new System.Drawing.Size(175, 25);
            this.joinpasswordchecktextBox.TabIndex = 28;
            // 
            // womenradio
            // 
            this.womenradio.AutoSize = true;
            this.womenradio.Location = new System.Drawing.Point(372, 102);
            this.womenradio.Name = "womenradio";
            this.womenradio.Size = new System.Drawing.Size(58, 19);
            this.womenradio.TabIndex = 29;
            this.womenradio.TabStop = true;
            this.womenradio.Text = "여자";
            this.womenradio.UseVisualStyleBackColor = true;
            // 
            // menradio
            // 
            this.menradio.AutoSize = true;
            this.menradio.Location = new System.Drawing.Point(448, 102);
            this.menradio.Name = "menradio";
            this.menradio.Size = new System.Drawing.Size(58, 19);
            this.menradio.TabIndex = 30;
            this.menradio.TabStop = true;
            this.menradio.Text = "남자";
            this.menradio.UseVisualStyleBackColor = true;
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(240, 134);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(100, 25);
            this.ageBox.TabIndex = 31;
            // 
            // Join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 362);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.menradio);
            this.Controls.Add(this.womenradio);
            this.Controls.Add(this.joinpasswordchecktextBox);
            this.Controls.Add(this.passwordchecklabel);
            this.Controls.Add(this.cancelbutton);
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
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label Joinlabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label agelabel;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Label passwordchecklabel;
        private System.Windows.Forms.TextBox joinpasswordchecktextBox;
        private System.Windows.Forms.RadioButton womenradio;
        private System.Windows.Forms.RadioButton menradio;
        private System.Windows.Forms.TextBox ageBox;
    }
}