using System.Collections.Generic;

namespace WindowsFormsApp1
{
    partial class Login
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.idlabel = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.loginlabel = new System.Windows.Forms.Label();
            this.joinbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(195, 110);
            this.idtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(177, 25);
            this.idtextBox.TabIndex = 4;
            this.idtextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(195, 170);
            this.passwordtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(177, 25);
            this.passwordtextBox.TabIndex = 5;
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Location = new System.Drawing.Point(103, 170);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(67, 15);
            this.passwordlabel.TabIndex = 11;
            this.passwordlabel.Text = "비밀번호";
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(103, 110);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(52, 15);
            this.idlabel.TabIndex = 12;
            this.idlabel.Text = "아이디";
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(195, 236);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(75, 22);
            this.loginbutton.TabIndex = 15;
            this.loginbutton.Text = "로그인";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(297, 236);
            this.cancelbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 22);
            this.cancelbutton.TabIndex = 16;
            this.cancelbutton.Text = "취소";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // loginlabel
            // 
            this.loginlabel.AutoSize = true;
            this.loginlabel.Font = new System.Drawing.Font("굴림", 20F);
            this.loginlabel.Location = new System.Drawing.Point(25, 18);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(117, 34);
            this.loginlabel.TabIndex = 19;
            this.loginlabel.Text = "로그인";
            this.loginlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // joinbutton
            // 
            this.joinbutton.Location = new System.Drawing.Point(409, 236);
            this.joinbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.joinbutton.Name = "joinbutton";
            this.joinbutton.Size = new System.Drawing.Size(75, 22);
            this.joinbutton.TabIndex = 20;
            this.joinbutton.Text = "회원가입";
            this.joinbutton.UseVisualStyleBackColor = true;
            this.joinbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 332);
            this.Controls.Add(this.joinbutton);
            this.Controls.Add(this.loginlabel);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.idtextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Label loginlabel;
        private System.Windows.Forms.Button joinbutton;
    }
}

