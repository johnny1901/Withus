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
            this.InputRowCount_Button = new System.Windows.Forms.Button();
            this.RowCounting_Label = new System.Windows.Forms.Label();
            this.InputRowCount_TextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1139, 410);
            this.dataGridView1.TabIndex = 0;
            // 
            // InputRowCount_Button
            // 
            this.InputRowCount_Button.Location = new System.Drawing.Point(130, 453);
            this.InputRowCount_Button.Name = "InputRowCount_Button";
            this.InputRowCount_Button.Size = new System.Drawing.Size(75, 23);
            this.InputRowCount_Button.TabIndex = 1;
            this.InputRowCount_Button.Text = "조회";
            this.InputRowCount_Button.UseVisualStyleBackColor = true;
            // 
            // RowCounting_Label
            // 
            this.RowCounting_Label.AutoSize = true;
            this.RowCounting_Label.Location = new System.Drawing.Point(22, 460);
            this.RowCounting_Label.Name = "RowCounting_Label";
            this.RowCounting_Label.Size = new System.Drawing.Size(40, 12);
            this.RowCounting_Label.TabIndex = 2;
            this.RowCounting_Label.Text = "ROW :";
            // 
            // InputRowCount_TextBox
            // 
            this.InputRowCount_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.InputRowCount_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputRowCount_TextBox.Location = new System.Drawing.Point(69, 461);
            this.InputRowCount_TextBox.Name = "InputRowCount_TextBox";
            this.InputRowCount_TextBox.Size = new System.Drawing.Size(49, 14);
            this.InputRowCount_TextBox.TabIndex = 3;
            this.InputRowCount_TextBox.Text = "10";
            this.InputRowCount_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(69, 473);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 1);
            this.panel1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InputRowCount_TextBox);
            this.Controls.Add(this.RowCounting_Label);
            this.Controls.Add(this.InputRowCount_Button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button InputRowCount_Button;
        private System.Windows.Forms.Label RowCounting_Label;
        private System.Windows.Forms.TextBox InputRowCount_TextBox;
        private System.Windows.Forms.Panel panel1;
    }
}