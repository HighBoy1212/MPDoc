namespace ArchiveExtract
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mnusMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvPageInfo = new System.Windows.Forms.DataGridView();
            this.PageNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Offset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtbPageText = new System.Windows.Forms.RichTextBox();
            this.ofdArchive = new System.Windows.Forms.OpenFileDialog();
            this.mnusMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPageInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // mnusMenu
            // 
            this.mnusMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnusMenu.Location = new System.Drawing.Point(0, 0);
            this.mnusMenu.Name = "mnusMenu";
            this.mnusMenu.Size = new System.Drawing.Size(464, 24);
            this.mnusMenu.TabIndex = 0;
            this.mnusMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.tsmiQuit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(180, 22);
            this.tsmiOpen.Text = "Open";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiQuit
            // 
            this.tsmiQuit.Name = "tsmiQuit";
            this.tsmiQuit.Size = new System.Drawing.Size(180, 22);
            this.tsmiQuit.Text = "Quit";
            this.tsmiQuit.Click += new System.EventHandler(this.tsmiQuit_Click);
            // 
            // dgvPageInfo
            // 
            this.dgvPageInfo.AllowUserToAddRows = false;
            this.dgvPageInfo.AllowUserToDeleteRows = false;
            this.dgvPageInfo.AllowUserToResizeColumns = false;
            this.dgvPageInfo.AllowUserToResizeRows = false;
            this.dgvPageInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPageInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPageInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PageNum,
            this.Length,
            this.Offset});
            this.dgvPageInfo.Location = new System.Drawing.Point(13, 28);
            this.dgvPageInfo.Name = "dgvPageInfo";
            this.dgvPageInfo.ReadOnly = true;
            this.dgvPageInfo.RowHeadersVisible = false;
            this.dgvPageInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPageInfo.Size = new System.Drawing.Size(439, 192);
            this.dgvPageInfo.TabIndex = 1;
            this.dgvPageInfo.Click += new System.EventHandler(this.dgvPageInfo_Click);
            // 
            // PageNum
            // 
            this.PageNum.FillWeight = 4F;
            this.PageNum.HeaderText = "Page";
            this.PageNum.Name = "PageNum";
            this.PageNum.ReadOnly = true;
            // 
            // Length
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Length.DefaultCellStyle = dataGridViewCellStyle1;
            this.Length.FillWeight = 1F;
            this.Length.HeaderText = "Length";
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            // 
            // Offset
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Offset.DefaultCellStyle = dataGridViewCellStyle2;
            this.Offset.FillWeight = 1F;
            this.Offset.HeaderText = "Offset";
            this.Offset.Name = "Offset";
            this.Offset.ReadOnly = true;
            // 
            // rtbPageText
            // 
            this.rtbPageText.Location = new System.Drawing.Point(13, 226);
            this.rtbPageText.Name = "rtbPageText";
            this.rtbPageText.ReadOnly = true;
            this.rtbPageText.Size = new System.Drawing.Size(439, 200);
            this.rtbPageText.TabIndex = 2;
            this.rtbPageText.Text = "";
            // 
            // ofdArchive
            // 
            this.ofdArchive.Filter = "MP Docs|*.mpdoc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 438);
            this.Controls.Add(this.rtbPageText);
            this.Controls.Add(this.dgvPageInfo);
            this.Controls.Add(this.mnusMenu);
            this.MainMenuStrip = this.mnusMenu;
            this.Name = "Form1";
            this.Text = "Document Viewer";
            this.mnusMenu.ResumeLayout(false);
            this.mnusMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPageInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnusMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuit;
        private System.Windows.Forms.DataGridView dgvPageInfo;
        private System.Windows.Forms.RichTextBox rtbPageText;
        private System.Windows.Forms.DataGridViewTextBoxColumn PageNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Offset;
        private System.Windows.Forms.OpenFileDialog ofdArchive;
    }
}

