namespace Withus
{
    partial class AddForm
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
            this.Create_Button = new System.Windows.Forms.Button();
            this.UserAccount_TextBox = new System.Windows.Forms.TextBox();
            this.UserPassword_TextBox = new System.Windows.Forms.TextBox();
            this.UserName_TextBox = new System.Windows.Forms.TextBox();
            this.UserPhone_TextBox = new System.Windows.Forms.TextBox();
            this.UserEmail_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Create_Button
            // 
            this.Create_Button.Location = new System.Drawing.Point(60, 161);
            this.Create_Button.Name = "Create_Button";
            this.Create_Button.Size = new System.Drawing.Size(75, 23);
            this.Create_Button.TabIndex = 0;
            this.Create_Button.Text = "생성";
            this.Create_Button.UseVisualStyleBackColor = true;
            this.Create_Button.Click += new System.EventHandler(this.Create_ClickEvent);
            // 
            // UserAccount_TextBox
            // 
            this.UserAccount_TextBox.Location = new System.Drawing.Point(73, 18);
            this.UserAccount_TextBox.Name = "UserAccount_TextBox";
            this.UserAccount_TextBox.Size = new System.Drawing.Size(100, 21);
            this.UserAccount_TextBox.TabIndex = 1;
            this.UserAccount_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputKeyDown_Event);
            // 
            // UserPassword_TextBox
            // 
            this.UserPassword_TextBox.Location = new System.Drawing.Point(73, 45);
            this.UserPassword_TextBox.Name = "UserPassword_TextBox";
            this.UserPassword_TextBox.PasswordChar = '*';
            this.UserPassword_TextBox.Size = new System.Drawing.Size(100, 21);
            this.UserPassword_TextBox.TabIndex = 2;
            this.UserPassword_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputKeyDown_Event);
            // 
            // UserName_TextBox
            // 
            this.UserName_TextBox.Location = new System.Drawing.Point(73, 72);
            this.UserName_TextBox.Name = "UserName_TextBox";
            this.UserName_TextBox.Size = new System.Drawing.Size(100, 21);
            this.UserName_TextBox.TabIndex = 3;
            this.UserName_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputKeyDown_Event);
            // 
            // UserPhone_TextBox
            // 
            this.UserPhone_TextBox.Location = new System.Drawing.Point(73, 99);
            this.UserPhone_TextBox.Name = "UserPhone_TextBox";
            this.UserPhone_TextBox.Size = new System.Drawing.Size(100, 21);
            this.UserPhone_TextBox.TabIndex = 4;
            this.UserPhone_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputKeyDown_Event);
            // 
            // UserEmail_TextBox
            // 
            this.UserEmail_TextBox.Location = new System.Drawing.Point(73, 126);
            this.UserEmail_TextBox.Name = "UserEmail_TextBox";
            this.UserEmail_TextBox.Size = new System.Drawing.Size(100, 21);
            this.UserEmail_TextBox.TabIndex = 5;
            this.UserEmail_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputKeyDown_Event);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "계정 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "암호 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "성함 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "연락처 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "이메일 :";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 196);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserEmail_TextBox);
            this.Controls.Add(this.UserPhone_TextBox);
            this.Controls.Add(this.UserName_TextBox);
            this.Controls.Add(this.UserPassword_TextBox);
            this.Controls.Add(this.UserAccount_TextBox);
            this.Controls.Add(this.Create_Button);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputKeyDown_Event);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create_Button;
        private System.Windows.Forms.TextBox UserAccount_TextBox;
        private System.Windows.Forms.TextBox UserPassword_TextBox;
        private System.Windows.Forms.TextBox UserName_TextBox;
        private System.Windows.Forms.TextBox UserPhone_TextBox;
        private System.Windows.Forms.TextBox UserEmail_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}