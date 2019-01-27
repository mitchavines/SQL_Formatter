namespace Demo
{
    partial class Form1
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdFormat = new System.Windows.Forms.ToolStripButton();
            this.txtExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtOptions = new System.Windows.Forms.ToolStripTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtFormatted = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdFormat,
            this.txtExit,
            this.toolStripLabel1,
            this.txtOptions});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(803, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdFormat
            // 
            this.cmdFormat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdFormat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmdFormat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdFormat.Name = "cmdFormat";
            this.cmdFormat.Size = new System.Drawing.Size(51, 22);
            this.cmdFormat.Text = "Format";
            this.cmdFormat.Click += new System.EventHandler(this.cmdFormat_Click);
            // 
            // txtExit
            // 
            this.txtExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.txtExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(32, 22);
            this.txtExit.Text = "Exit";
            this.txtExit.Click += new System.EventHandler(this.txtExit_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(51, 22);
            this.toolStripLabel1.Text = "Options:";
            this.toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOptions
            // 
            this.txtOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOptions.Name = "txtOptions";
            this.txtOptions.Size = new System.Drawing.Size(500, 25);
            this.txtOptions.Text = "LeadingCommas=False;LeadingJoins=True;RemoveComments=False";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtSource);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtFormatted);
            this.splitContainer1.Size = new System.Drawing.Size(803, 415);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.TabIndex = 1;
            // 
            // txtSource
            // 
            this.txtSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSource.Location = new System.Drawing.Point(0, 0);
            this.txtSource.MaxLength = 0;
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSource.Size = new System.Drawing.Size(267, 415);
            this.txtSource.TabIndex = 0;
            this.txtSource.WordWrap = false;
            // 
            // txtFormatted
            // 
            this.txtFormatted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFormatted.Location = new System.Drawing.Point(0, 0);
            this.txtFormatted.MaxLength = 0;
            this.txtFormatted.Multiline = true;
            this.txtFormatted.Name = "txtFormatted";
            this.txtFormatted.ReadOnly = true;
            this.txtFormatted.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFormatted.Size = new System.Drawing.Size(532, 415);
            this.txtFormatted.TabIndex = 1;
            this.txtFormatted.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 440);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "SQL Formatter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton cmdFormat;
        private System.Windows.Forms.ToolStripButton txtExit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtFormatted;
        private System.Windows.Forms.ToolStripTextBox txtOptions;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

