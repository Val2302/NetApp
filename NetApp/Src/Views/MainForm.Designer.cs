namespace NetApp.Src.Views
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.menuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.imgPing = new System.Windows.Forms.PictureBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.urlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.imgClearAddress = new System.Windows.Forms.PictureBox();
            this.imgClearOutputList = new System.Windows.Forms.PictureBox();
            this.outputList = new System.Windows.Forms.ListBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.imgShowHostEntry = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPing)).BeginInit();
            this.urlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgClearAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClearOutputList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgShowHostEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.menuPanel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.outputList);
            this.splitContainer.Size = new System.Drawing.Size(715, 670);
            this.splitContainer.SplitterDistance = 36;
            this.splitContainer.TabIndex = 1;
            // 
            // menuPanel
            // 
            this.menuPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuPanel.ColumnCount = 6;
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.menuPanel.Controls.Add(this.imgPing, 0, 0);
            this.menuPanel.Controls.Add(this.imgShowHostEntry, 1, 0);
            this.menuPanel.Controls.Add(this.lblAddress, 2, 0);
            this.menuPanel.Controls.Add(this.urlPanel, 3, 0);
            this.menuPanel.Controls.Add(this.imgClearAddress, 4, 0);
            this.menuPanel.Controls.Add(this.imgClearOutputList, 5, 0);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.RowCount = 1;
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.menuPanel.Size = new System.Drawing.Size(715, 36);
            this.menuPanel.TabIndex = 3;
            // 
            // imgPing
            // 
            this.imgPing.BackColor = System.Drawing.Color.Transparent;
            this.imgPing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgPing.Image = ((System.Drawing.Image)(resources.GetObject("imgPing.Image")));
            this.imgPing.Location = new System.Drawing.Point(3, 3);
            this.imgPing.Name = "imgPing";
            this.imgPing.Size = new System.Drawing.Size(44, 30);
            this.imgPing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPing.TabIndex = 0;
            this.imgPing.TabStop = false;
            this.toolTip.SetToolTip(this.imgPing, "Ping (Ctrl+P)");
            this.imgPing.Click += new System.EventHandler(this.ImgPing_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddress.Location = new System.Drawing.Point(103, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(54, 36);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // urlPanel
            // 
            this.urlPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.urlPanel.ColumnCount = 1;
            this.urlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.urlPanel.Controls.Add(this.tbAddress, 0, 1);
            this.urlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urlPanel.Location = new System.Drawing.Point(160, 0);
            this.urlPanel.Margin = new System.Windows.Forms.Padding(0);
            this.urlPanel.Name = "urlPanel";
            this.urlPanel.RowCount = 3;
            this.urlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.urlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.urlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.urlPanel.Size = new System.Drawing.Size(495, 36);
            this.urlPanel.TabIndex = 0;
            // 
            // tbAddress
            // 
            this.tbAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAddress.Location = new System.Drawing.Point(0, 8);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(0);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(495, 20);
            this.tbAddress.TabIndex = 0;
            // 
            // imgClearAddress
            // 
            this.imgClearAddress.BackColor = System.Drawing.Color.Transparent;
            this.imgClearAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgClearAddress.Image = ((System.Drawing.Image)(resources.GetObject("imgClearAddress.Image")));
            this.imgClearAddress.Location = new System.Drawing.Point(658, 3);
            this.imgClearAddress.Name = "imgClearAddress";
            this.imgClearAddress.Size = new System.Drawing.Size(24, 30);
            this.imgClearAddress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgClearAddress.TabIndex = 3;
            this.imgClearAddress.TabStop = false;
            this.toolTip.SetToolTip(this.imgClearAddress, "Clear address (Ctrl+BkSp)");
            this.imgClearAddress.Click += new System.EventHandler(this.ImgClearAddress_Click);
            // 
            // imgClearOutputList
            // 
            this.imgClearOutputList.BackColor = System.Drawing.Color.Transparent;
            this.imgClearOutputList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgClearOutputList.Image = ((System.Drawing.Image)(resources.GetObject("imgClearOutputList.Image")));
            this.imgClearOutputList.Location = new System.Drawing.Point(688, 3);
            this.imgClearOutputList.Name = "imgClearOutputList";
            this.imgClearOutputList.Size = new System.Drawing.Size(24, 30);
            this.imgClearOutputList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgClearOutputList.TabIndex = 4;
            this.imgClearOutputList.TabStop = false;
            this.toolTip.SetToolTip(this.imgClearOutputList, "Clear output (Ctrl+Del)");
            this.imgClearOutputList.Click += new System.EventHandler(this.ImgCleanOutputList_Click);
            // 
            // outputList
            // 
            this.outputList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputList.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputList.ForeColor = System.Drawing.Color.Blue;
            this.outputList.FormattingEnabled = true;
            this.outputList.HorizontalScrollbar = true;
            this.outputList.ItemHeight = 15;
            this.outputList.Location = new System.Drawing.Point(0, 0);
            this.outputList.Name = "outputList";
            this.outputList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.outputList.Size = new System.Drawing.Size(715, 630);
            this.outputList.TabIndex = 0;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 0;
            // 
            // imgShowHostEntry
            // 
            this.imgShowHostEntry.BackColor = System.Drawing.Color.Transparent;
            this.imgShowHostEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgShowHostEntry.Image = ((System.Drawing.Image)(resources.GetObject("imgShowHostEntry.Image")));
            this.imgShowHostEntry.Location = new System.Drawing.Point(53, 3);
            this.imgShowHostEntry.Name = "imgShowHostEntry";
            this.imgShowHostEntry.Size = new System.Drawing.Size(44, 30);
            this.imgShowHostEntry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgShowHostEntry.TabIndex = 5;
            this.imgShowHostEntry.TabStop = false;
            this.toolTip.SetToolTip(this.imgShowHostEntry, "Show host entry (Ctrl+S)");
            this.imgShowHostEntry.Click += new System.EventHandler(this.ImgShowHostEntry_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 670);
            this.Controls.Add(this.splitContainer);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Net App";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPing)).EndInit();
            this.urlPanel.ResumeLayout(false);
            this.urlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgClearAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClearOutputList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgShowHostEntry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel menuPanel;
        private System.Windows.Forms.PictureBox imgPing;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TableLayoutPanel urlPanel;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.PictureBox imgClearAddress;
        private System.Windows.Forms.PictureBox imgClearOutputList;
        private System.Windows.Forms.ListBox outputList;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox imgShowHostEntry;
    }
}

