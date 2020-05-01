namespace Withus
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TableLookUp_Button = new System.Windows.Forms.Button();
            this.RowCounting_Label = new System.Windows.Forms.Label();
            this.InputRowCount_TextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FirstPage_Button = new System.Windows.Forms.Button();
            this.PrePage_Button = new System.Windows.Forms.Button();
            this.PageState_Label = new System.Windows.Forms.Label();
            this.NextPage_Button = new System.Windows.Forms.Button();
            this.LastPage_Button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramClose_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataAdd_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.DataEdit_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.DataDelete_Menu = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(718, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // TableLookUp_Button
            // 
            this.TableLookUp_Button.Location = new System.Drawing.Point(120, 332);
            this.TableLookUp_Button.Name = "TableLookUp_Button";
            this.TableLookUp_Button.Size = new System.Drawing.Size(75, 23);
            this.TableLookUp_Button.TabIndex = 1;
            this.TableLookUp_Button.Text = "조회";
            this.TableLookUp_Button.UseVisualStyleBackColor = true;
            this.TableLookUp_Button.Click += new System.EventHandler(this.TableLookUpButton_ClickEvent);
            // 
            // RowCounting_Label
            // 
            this.RowCounting_Label.AutoSize = true;
            this.RowCounting_Label.Location = new System.Drawing.Point(12, 339);
            this.RowCounting_Label.Name = "RowCounting_Label";
            this.RowCounting_Label.Size = new System.Drawing.Size(40, 12);
            this.RowCounting_Label.TabIndex = 2;
            this.RowCounting_Label.Text = "ROW :";
            // 
            // InputRowCount_TextBox
            // 
            this.InputRowCount_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.InputRowCount_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputRowCount_TextBox.Location = new System.Drawing.Point(59, 340);
            this.InputRowCount_TextBox.Name = "InputRowCount_TextBox";
            this.InputRowCount_TextBox.Size = new System.Drawing.Size(49, 14);
            this.InputRowCount_TextBox.TabIndex = 3;
            this.InputRowCount_TextBox.Text = "10";
            this.InputRowCount_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(59, 352);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 1);
            this.panel1.TabIndex = 4;
            // 
            // FirstPage_Button
            // 
            this.FirstPage_Button.Location = new System.Drawing.Point(278, 331);
            this.FirstPage_Button.Name = "FirstPage_Button";
            this.FirstPage_Button.Size = new System.Drawing.Size(75, 23);
            this.FirstPage_Button.TabIndex = 5;
            this.FirstPage_Button.Text = "첫 페이지";
            this.FirstPage_Button.UseVisualStyleBackColor = true;
            this.FirstPage_Button.Click += new System.EventHandler(this.FirstPageButton_ClickEvent);
            // 
            // PrePage_Button
            // 
            this.PrePage_Button.Location = new System.Drawing.Point(359, 331);
            this.PrePage_Button.Name = "PrePage_Button";
            this.PrePage_Button.Size = new System.Drawing.Size(93, 23);
            this.PrePage_Button.TabIndex = 6;
            this.PrePage_Button.Text = "이전 페이지";
            this.PrePage_Button.UseVisualStyleBackColor = true;
            this.PrePage_Button.Click += new System.EventHandler(this.PrePageButton_ClickEvent);
            // 
            // PageState_Label
            // 
            this.PageState_Label.AutoSize = true;
            this.PageState_Label.Location = new System.Drawing.Point(496, 337);
            this.PageState_Label.Name = "PageState_Label";
            this.PageState_Label.Size = new System.Drawing.Size(15, 12);
            this.PageState_Label.TabIndex = 7;
            this.PageState_Label.Text = " /";
            // 
            // NextPage_Button
            // 
            this.NextPage_Button.Location = new System.Drawing.Point(557, 331);
            this.NextPage_Button.Name = "NextPage_Button";
            this.NextPage_Button.Size = new System.Drawing.Size(93, 23);
            this.NextPage_Button.TabIndex = 8;
            this.NextPage_Button.Text = "다음 페이지";
            this.NextPage_Button.UseVisualStyleBackColor = true;
            this.NextPage_Button.Click += new System.EventHandler(this.NextPageButton_ClickEvent);
            // 
            // LastPage_Button
            // 
            this.LastPage_Button.Location = new System.Drawing.Point(657, 331);
            this.LastPage_Button.Name = "LastPage_Button";
            this.LastPage_Button.Size = new System.Drawing.Size(75, 23);
            this.LastPage_Button.TabIndex = 9;
            this.LastPage_Button.Text = "끝 페이지";
            this.LastPage_Button.UseVisualStyleBackColor = true;
            this.LastPage_Button.Click += new System.EventHandler(this.LastPageButton_ClickEvent);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgramClose_Menu});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // ProgramClose_Menu
            // 
            this.ProgramClose_Menu.Name = "ProgramClose_Menu";
            this.ProgramClose_Menu.Size = new System.Drawing.Size(180, 22);
            this.ProgramClose_Menu.Text = "프로그램 종료";
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataAdd_Menu,
            this.DataEdit_Menu,
            this.DataDelete_Menu});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.편집ToolStripMenuItem.Text = "편집";
            // 
            // DataAdd_Menu
            // 
            this.DataAdd_Menu.Name = "DataAdd_Menu";
            this.DataAdd_Menu.Size = new System.Drawing.Size(180, 22);
            this.DataAdd_Menu.Text = "데이터 등록";
            // 
            // DataEdit_Menu
            // 
            this.DataEdit_Menu.Name = "DataEdit_Menu";
            this.DataEdit_Menu.Size = new System.Drawing.Size(180, 22);
            this.DataEdit_Menu.Text = "데이터 수정";
            // 
            // DataDelete_Menu
            // 
            this.DataDelete_Menu.Name = "DataDelete_Menu";
            this.DataDelete_Menu.Size = new System.Drawing.Size(180, 22);
            this.DataDelete_Menu.Text = "데이터 삭제";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 363);
            this.Controls.Add(this.LastPage_Button);
            this.Controls.Add(this.NextPage_Button);
            this.Controls.Add(this.PageState_Label);
            this.Controls.Add(this.PrePage_Button);
            this.Controls.Add(this.FirstPage_Button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InputRowCount_TextBox);
            this.Controls.Add(this.RowCounting_Label);
            this.Controls.Add(this.TableLookUp_Button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "데이터 관리 프로그램";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button TableLookUp_Button;
        private System.Windows.Forms.Label RowCounting_Label;
        private System.Windows.Forms.TextBox InputRowCount_TextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FirstPage_Button;
        private System.Windows.Forms.Button PrePage_Button;
        private System.Windows.Forms.Label PageState_Label;
        private System.Windows.Forms.Button NextPage_Button;
        private System.Windows.Forms.Button LastPage_Button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProgramClose_Menu;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataAdd_Menu;
        private System.Windows.Forms.ToolStripMenuItem DataEdit_Menu;
        private System.Windows.Forms.ToolStripMenuItem DataDelete_Menu;
    }
}