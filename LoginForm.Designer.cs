namespace Withus
{
    partial class LoginForm
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
            this.UserLogin_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InputUserAccount_TextBox = new System.Windows.Forms.TextBox();
            this.InputUserPassword_TextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramClose_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpCenter_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.FeedBack_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserLogin_Button
            // 
            this.UserLogin_Button.Location = new System.Drawing.Point(339, 65);
            this.UserLogin_Button.Name = "UserLogin_Button";
            this.UserLogin_Button.Size = new System.Drawing.Size(73, 51);
            this.UserLogin_Button.TabIndex = 0;
            this.UserLogin_Button.TabStop = false;
            this.UserLogin_Button.Text = "로그인";
            this.UserLogin_Button.UseVisualStyleBackColor = true;
            this.UserLogin_Button.Click += new System.EventHandler(this.UserLogin_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "사용자 ID :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(121, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 20;
            // 
            // InputUserAccount_TextBox
            // 
            this.InputUserAccount_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.InputUserAccount_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputUserAccount_TextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.InputUserAccount_TextBox.Location = new System.Drawing.Point(121, 64);
            this.InputUserAccount_TextBox.Name = "InputUserAccount_TextBox";
            this.InputUserAccount_TextBox.Size = new System.Drawing.Size(166, 14);
            this.InputUserAccount_TextBox.TabIndex = 0;
            this.InputUserAccount_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputUserAccount_TextBox.TextChanged += new System.EventHandler(this.IDInputKeys_Event);
            // 
            // InputUserPassword_TextBox
            // 
            this.InputUserPassword_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.InputUserPassword_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputUserPassword_TextBox.Location = new System.Drawing.Point(121, 99);
            this.InputUserPassword_TextBox.Name = "InputUserPassword_TextBox";
            this.InputUserPassword_TextBox.PasswordChar = '*';
            this.InputUserPassword_TextBox.Size = new System.Drawing.Size(166, 14);
            this.InputUserPassword_TextBox.TabIndex = 1;
            this.InputUserPassword_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputUserPassword_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordInputKeys_Event);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(121, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "사용자 암호 :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_Menu,
            this.Help_Menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(463, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File_Menu
            // 
            this.File_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgramClose_Menu});
            this.File_Menu.Name = "File_Menu";
            this.File_Menu.Size = new System.Drawing.Size(43, 20);
            this.File_Menu.Text = "파일";
            // 
            // ProgramClose_Menu
            // 
            this.ProgramClose_Menu.Name = "ProgramClose_Menu";
            this.ProgramClose_Menu.Size = new System.Drawing.Size(150, 22);
            this.ProgramClose_Menu.Text = "프로그램 종료";
            this.ProgramClose_Menu.Click += new System.EventHandler(this.ProgramKill_ClickEvent);
            // 
            // Help_Menu
            // 
            this.Help_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpCenter_Menu,
            this.FeedBack_Menu});
            this.Help_Menu.Name = "Help_Menu";
            this.Help_Menu.Size = new System.Drawing.Size(55, 20);
            this.Help_Menu.Text = "도움말";
            // 
            // HelpCenter_Menu
            // 
            this.HelpCenter_Menu.Name = "HelpCenter_Menu";
            this.HelpCenter_Menu.Size = new System.Drawing.Size(150, 22);
            this.HelpCenter_Menu.Text = "도움말 보기";
            this.HelpCenter_Menu.Click += new System.EventHandler(this.HelpCenterView_ClickEvent);
            // 
            // FeedBack_Menu
            // 
            this.FeedBack_Menu.Name = "FeedBack_Menu";
            this.FeedBack_Menu.Size = new System.Drawing.Size(150, 22);
            this.FeedBack_Menu.Text = "피드백 보내기";
            this.FeedBack_Menu.Click += new System.EventHandler(this.FeedBack_ClickEvent);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 159);
            this.Controls.Add(this.InputUserPassword_TextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputUserAccount_TextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserLogin_Button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "데이터 관리 프로그램";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_Closing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UserLogin_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox InputUserAccount_TextBox;
        private System.Windows.Forms.TextBox InputUserPassword_TextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File_Menu;
        private System.Windows.Forms.ToolStripMenuItem ProgramClose_Menu;
        private System.Windows.Forms.ToolStripMenuItem Help_Menu;
        private System.Windows.Forms.ToolStripMenuItem HelpCenter_Menu;
        private System.Windows.Forms.ToolStripMenuItem FeedBack_Menu;
    }
}

