namespace Withus
{
    partial class EditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.EditTarget_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserAccount_TextBox = new System.Windows.Forms.TextBox();
            this.UserPassword_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UserName_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UserPhone_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UserEmail_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EditCommit_Button = new System.Windows.Forms.Button();
            this.DeleteCommit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "PK :";
            // 
            // EditTarget_Label
            // 
            this.EditTarget_Label.AutoSize = true;
            this.EditTarget_Label.Location = new System.Drawing.Point(54, 13);
            this.EditTarget_Label.Name = "EditTarget_Label";
            this.EditTarget_Label.Size = new System.Drawing.Size(0, 12);
            this.EditTarget_Label.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "UserAccount :";
            // 
            // UserAccount_TextBox
            // 
            this.UserAccount_TextBox.Location = new System.Drawing.Point(113, 33);
            this.UserAccount_TextBox.Name = "UserAccount_TextBox";
            this.UserAccount_TextBox.Size = new System.Drawing.Size(148, 21);
            this.UserAccount_TextBox.TabIndex = 3;
            // 
            // UserPassword_TextBox
            // 
            this.UserPassword_TextBox.Location = new System.Drawing.Point(372, 33);
            this.UserPassword_TextBox.Name = "UserPassword_TextBox";
            this.UserPassword_TextBox.Size = new System.Drawing.Size(148, 21);
            this.UserPassword_TextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "UserPassword :";
            // 
            // UserName_TextBox
            // 
            this.UserName_TextBox.Location = new System.Drawing.Point(113, 60);
            this.UserName_TextBox.Name = "UserName_TextBox";
            this.UserName_TextBox.Size = new System.Drawing.Size(148, 21);
            this.UserName_TextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "UserName :";
            // 
            // UserPhone_TextBox
            // 
            this.UserPhone_TextBox.Location = new System.Drawing.Point(372, 60);
            this.UserPhone_TextBox.Name = "UserPhone_TextBox";
            this.UserPhone_TextBox.Size = new System.Drawing.Size(148, 21);
            this.UserPhone_TextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "UserPhone :";
            // 
            // UserEmail_TextBox
            // 
            this.UserEmail_TextBox.Location = new System.Drawing.Point(113, 87);
            this.UserEmail_TextBox.Name = "UserEmail_TextBox";
            this.UserEmail_TextBox.Size = new System.Drawing.Size(148, 21);
            this.UserEmail_TextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "UserEmail :";
            // 
            // EditCommit_Button
            // 
            this.EditCommit_Button.Location = new System.Drawing.Point(399, 90);
            this.EditCommit_Button.Name = "EditCommit_Button";
            this.EditCommit_Button.Size = new System.Drawing.Size(121, 43);
            this.EditCommit_Button.TabIndex = 12;
            this.EditCommit_Button.Text = "수정";
            this.EditCommit_Button.UseVisualStyleBackColor = true;
            this.EditCommit_Button.Click += new System.EventHandler(this.EditCommit_Button_Click);
            // 
            // DeleteCommit_Button
            // 
            this.DeleteCommit_Button.Location = new System.Drawing.Point(274, 91);
            this.DeleteCommit_Button.Name = "DeleteCommit_Button";
            this.DeleteCommit_Button.Size = new System.Drawing.Size(119, 40);
            this.DeleteCommit_Button.TabIndex = 13;
            this.DeleteCommit_Button.Text = "삭제";
            this.DeleteCommit_Button.UseVisualStyleBackColor = true;
            this.DeleteCommit_Button.Click += new System.EventHandler(this.DeleteCommit_Button_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 142);
            this.Controls.Add(this.DeleteCommit_Button);
            this.Controls.Add(this.EditCommit_Button);
            this.Controls.Add(this.UserEmail_TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UserPhone_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UserName_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserPassword_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserAccount_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EditTarget_Label);
            this.Controls.Add(this.label1);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EditTarget_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserAccount_TextBox;
        private System.Windows.Forms.TextBox UserPassword_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserName_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UserPhone_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UserEmail_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button EditCommit_Button;
        private System.Windows.Forms.Button DeleteCommit_Button;
    }
}