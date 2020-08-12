namespace cmd_gui
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.GroupBoxControls = new System.Windows.Forms.GroupBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParameter = new System.Windows.Forms.TextBox();
            this.txtExecutable = new System.Windows.Forms.TextBox();
            this.BtnCopy = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.PnlTop.SuspendLayout();
            this.GroupBoxControls.SuspendLayout();
            this.PnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(607, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(38, 22);
            this.toolStripMenuItem1.Text = "Exit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(47, 22);
            this.toolStripMenuItem2.Text = "Copy";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(24, 22);
            this.toolStripMenuItem3.Text = "?";
            // 
            // PnlTop
            // 
            this.PnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlTop.Controls.Add(this.GroupBoxControls);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.ImeMode = System.Windows.Forms.ImeMode.On;
            this.PnlTop.Location = new System.Drawing.Point(0, 24);
            this.PnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(607, 107);
            this.PnlTop.TabIndex = 1;
            // 
            // GroupBoxControls
            // 
            this.GroupBoxControls.Controls.Add(this.BtnBrowse);
            this.GroupBoxControls.Controls.Add(this.label2);
            this.GroupBoxControls.Controls.Add(this.label1);
            this.GroupBoxControls.Controls.Add(this.txtParameter);
            this.GroupBoxControls.Controls.Add(this.txtExecutable);
            this.GroupBoxControls.Controls.Add(this.BtnCopy);
            this.GroupBoxControls.Controls.Add(this.BtnStart);
            this.GroupBoxControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxControls.Location = new System.Drawing.Point(3, 3);
            this.GroupBoxControls.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBoxControls.Name = "GroupBoxControls";
            this.GroupBoxControls.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBoxControls.Size = new System.Drawing.Size(600, 111);
            this.GroupBoxControls.TabIndex = 0;
            this.GroupBoxControls.TabStop = false;
            this.GroupBoxControls.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(551, 13);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(40, 23);
            this.BtnBrowse.TabIndex = 6;
            this.BtnBrowse.Text = "...";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parameter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Command";
            // 
            // txtParameter
            // 
            this.txtParameter.Location = new System.Drawing.Point(101, 41);
            this.txtParameter.Margin = new System.Windows.Forms.Padding(2);
            this.txtParameter.Name = "txtParameter";
            this.txtParameter.Size = new System.Drawing.Size(80, 24);
            this.txtParameter.TabIndex = 3;
            this.txtParameter.Text = "-ano";
            this.txtParameter.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtExecutable
            // 
            this.txtExecutable.Location = new System.Drawing.Point(102, 13);
            this.txtExecutable.Margin = new System.Windows.Forms.Padding(2);
            this.txtExecutable.Name = "txtExecutable";
            this.txtExecutable.Size = new System.Drawing.Size(420, 24);
            this.txtExecutable.TabIndex = 2;
            this.txtExecutable.Text = "netstat.exe";
            this.txtExecutable.TextChanged += new System.EventHandler(this.txtExecutable_TextChanged);
            // 
            // BtnCopy
            // 
            this.BtnCopy.Location = new System.Drawing.Point(4, 69);
            this.BtnCopy.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCopy.Name = "BtnCopy";
            this.BtnCopy.Size = new System.Drawing.Size(171, 27);
            this.BtnCopy.TabIndex = 1;
            this.BtnCopy.Text = "Copy to Clipboard";
            this.BtnCopy.UseVisualStyleBackColor = true;
            this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(441, 69);
            this.BtnStart.Margin = new System.Windows.Forms.Padding(2);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(150, 30);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Execute";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // PnlBottom
            // 
            this.PnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBottom.Controls.Add(this.webBrowser1);
            this.PnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBottom.Location = new System.Drawing.Point(0, 131);
            this.PnlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(607, 415);
            this.PnlBottom.TabIndex = 2;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(13, 13);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(605, 413);
            this.webBrowser1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 546);
            this.Controls.Add(this.PnlBottom);
            this.Controls.Add(this.PnlTop);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CMD-GUI";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PnlTop.ResumeLayout(false);
            this.GroupBoxControls.ResumeLayout(false);
            this.GroupBoxControls.PerformLayout();
            this.PnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Panel PnlBottom;
        private System.Windows.Forms.GroupBox GroupBoxControls;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParameter;
        private System.Windows.Forms.TextBox txtExecutable;
        private System.Windows.Forms.Button BtnCopy;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button BtnBrowse;
    }
}

