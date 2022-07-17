namespace ITMO_CSharp_DesktopApps_FinalProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabDirectory = new System.Windows.Forms.TabControl();
            this.tabShares = new System.Windows.Forms.TabPage();
            this.listViewShares = new System.Windows.Forms.ListView();
            this.ShareDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShareTickerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CurrentPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripShares = new System.Windows.Forms.ToolStrip();
            this.tsbtnShow = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnClear = new System.Windows.Forms.ToolStripButton();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.tabDirectory.SuspendLayout();
            this.tabShares.SuspendLayout();
            this.toolStripShares.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDirectory
            // 
            this.tabDirectory.Controls.Add(this.tabShares);
            this.tabDirectory.Controls.Add(this.tabCustomers);
            this.tabDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDirectory.Location = new System.Drawing.Point(0, 0);
            this.tabDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.tabDirectory.Name = "tabDirectory";
            this.tabDirectory.SelectedIndex = 0;
            this.tabDirectory.Size = new System.Drawing.Size(533, 292);
            this.tabDirectory.TabIndex = 0;
            // 
            // tabShares
            // 
            this.tabShares.Controls.Add(this.listViewShares);
            this.tabShares.Controls.Add(this.toolStripShares);
            this.tabShares.Location = new System.Drawing.Point(4, 22);
            this.tabShares.Margin = new System.Windows.Forms.Padding(2);
            this.tabShares.Name = "tabShares";
            this.tabShares.Padding = new System.Windows.Forms.Padding(2);
            this.tabShares.Size = new System.Drawing.Size(525, 266);
            this.tabShares.TabIndex = 0;
            this.tabShares.Text = "Shares";
            this.tabShares.UseVisualStyleBackColor = true;
            // 
            // listViewShares
            // 
            this.listViewShares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewShares.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ShareDesc,
            this.ShareTickerID,
            this.CurrentPrice});
            this.listViewShares.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewShares.HideSelection = false;
            this.listViewShares.Location = new System.Drawing.Point(2, 41);
            this.listViewShares.Margin = new System.Windows.Forms.Padding(2);
            this.listViewShares.Name = "listViewShares";
            this.listViewShares.Size = new System.Drawing.Size(521, 223);
            this.listViewShares.TabIndex = 1;
            this.listViewShares.UseCompatibleStateImageBehavior = false;
            this.listViewShares.View = System.Windows.Forms.View.Details;
            // 
            // ShareDesc
            // 
            this.ShareDesc.Text = "Share description";
            this.ShareDesc.Width = 174;
            // 
            // ShareTickerID
            // 
            this.ShareTickerID.Text = "Share Ticker ID";
            this.ShareTickerID.Width = 169;
            // 
            // CurrentPrice
            // 
            this.CurrentPrice.Text = "Current Price";
            this.CurrentPrice.Width = 171;
            // 
            // toolStripShares
            // 
            this.toolStripShares.AutoSize = false;
            this.toolStripShares.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnShow,
            this.toolStripSeparator1,
            this.tsbtnFind,
            this.toolStripSeparator2,
            this.tsbtnAdd,
            this.tsbtnDelete,
            this.toolStripSeparator3,
            this.tsbtnClear});
            this.toolStripShares.Location = new System.Drawing.Point(2, 2);
            this.toolStripShares.Name = "toolStripShares";
            this.toolStripShares.Size = new System.Drawing.Size(521, 39);
            this.toolStripShares.TabIndex = 0;
            this.toolStripShares.Text = "toolStrip1";
            // 
            // tsbtnShow
            // 
            this.tsbtnShow.AutoSize = false;
            this.tsbtnShow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnShow.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnShow.Image")));
            this.tsbtnShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnShow.Name = "tsbtnShow";
            this.tsbtnShow.Size = new System.Drawing.Size(57, 57);
            this.tsbtnShow.Text = "Show all";
            this.tsbtnShow.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbtnFind
            // 
            this.tsbtnFind.AutoSize = false;
            this.tsbtnFind.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnFind.Image")));
            this.tsbtnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFind.Name = "tsbtnFind";
            this.tsbtnFind.Size = new System.Drawing.Size(57, 57);
            this.tsbtnFind.Text = "Find";
            this.tsbtnFind.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.AutoSize = false;
            this.tsbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAdd.Image")));
            this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(70, 57);
            this.tsbtnAdd.Text = "Add";
            this.tsbtnAdd.Click += new System.EventHandler(this.tsbtnAdd_Click);
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.AutoSize = false;
            this.tsbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDelete.Image")));
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(70, 57);
            this.tsbtnDelete.Text = "Delete";
            this.tsbtnDelete.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbtnClear
            // 
            this.tsbtnClear.AutoSize = false;
            this.tsbtnClear.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnClear.Image")));
            this.tsbtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClear.Name = "tsbtnClear";
            this.tsbtnClear.Size = new System.Drawing.Size(80, 57);
            this.tsbtnClear.Text = "Clear table";
            this.tsbtnClear.Click += new System.EventHandler(this.tsbtnClear_Click);
            // 
            // tabCustomers
            // 
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(2);
            this.tabCustomers.Size = new System.Drawing.Size(525, 266);
            this.tabCustomers.TabIndex = 1;
            this.tabCustomers.Text = "Customers";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.tabDirectory);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Directory Management";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabDirectory.ResumeLayout(false);
            this.tabShares.ResumeLayout(false);
            this.toolStripShares.ResumeLayout(false);
            this.toolStripShares.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDirectory;
        private System.Windows.Forms.TabPage tabShares;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.ListView listViewShares;
        private System.Windows.Forms.ColumnHeader ShareDesc;
        private System.Windows.Forms.ColumnHeader ShareTickerID;
        private System.Windows.Forms.ColumnHeader CurrentPrice;
        private System.Windows.Forms.ToolStrip toolStripShares;
        private System.Windows.Forms.ToolStripButton tsbtnShow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnFind;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnClear;
    }
}