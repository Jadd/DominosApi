namespace DominosApi.Client.Controls {
    partial class StoreFinderControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.LocationColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StoreList = new System.Windows.Forms.ListView();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.PanelSplitter = new System.Windows.Forms.Splitter();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RightTopPanel = new System.Windows.Forms.Panel();
            this.RegionFilterComboBox = new System.Windows.Forms.ComboBox();
            this.RegionFilterLabel = new System.Windows.Forms.Label();
            this.StoreNumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RightPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.RightTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LocationColumn
            // 
            this.LocationColumn.DisplayIndex = 1;
            this.LocationColumn.Text = "Location";
            this.LocationColumn.Width = 200;
            // 
            // StoreList
            // 
            this.StoreList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LocationColumn,
            this.StoreNumberColumn});
            this.StoreList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StoreList.FullRowSelect = true;
            this.StoreList.GridLines = true;
            this.StoreList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.StoreList.HideSelection = false;
            this.StoreList.Location = new System.Drawing.Point(0, 0);
            this.StoreList.Name = "StoreList";
            this.StoreList.Size = new System.Drawing.Size(322, 248);
            this.StoreList.TabIndex = 0;
            this.StoreList.UseCompatibleStateImageBehavior = false;
            this.StoreList.View = System.Windows.Forms.View.Details;
            this.StoreList.SelectedIndexChanged += new System.EventHandler(this.StoreList_SelectedIndexChanged);
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.RightTopPanel);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanel.Location = new System.Drawing.Point(326, 0);
            this.RightPanel.MinimumSize = new System.Drawing.Size(227, 248);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(227, 248);
            this.RightPanel.TabIndex = 2;
            // 
            // PanelSplitter
            // 
            this.PanelSplitter.Location = new System.Drawing.Point(322, 0);
            this.PanelSplitter.Name = "PanelSplitter";
            this.PanelSplitter.Size = new System.Drawing.Size(4, 248);
            this.PanelSplitter.TabIndex = 1;
            this.PanelSplitter.TabStop = false;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.StoreList);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(322, 248);
            this.LeftPanel.TabIndex = 4;
            // 
            // RightTopPanel
            // 
            this.RightTopPanel.Controls.Add(this.RegionFilterComboBox);
            this.RightTopPanel.Controls.Add(this.RegionFilterLabel);
            this.RightTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RightTopPanel.Location = new System.Drawing.Point(0, 0);
            this.RightTopPanel.Name = "RightTopPanel";
            this.RightTopPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.RightTopPanel.Size = new System.Drawing.Size(227, 48);
            this.RightTopPanel.TabIndex = 0;
            // 
            // RegionFilterComboBox
            // 
            this.RegionFilterComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RegionFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RegionFilterComboBox.FormattingEnabled = true;
            this.RegionFilterComboBox.Location = new System.Drawing.Point(0, 19);
            this.RegionFilterComboBox.Name = "RegionFilterComboBox";
            this.RegionFilterComboBox.Size = new System.Drawing.Size(227, 21);
            this.RegionFilterComboBox.TabIndex = 3;
            this.RegionFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.RegionFilterComboBox_SelectedIndexChanged);
            // 
            // RegionFilterLabel
            // 
            this.RegionFilterLabel.AutoSize = true;
            this.RegionFilterLabel.Location = new System.Drawing.Point(0, 0);
            this.RegionFilterLabel.Name = "RegionFilterLabel";
            this.RegionFilterLabel.Size = new System.Drawing.Size(66, 13);
            this.RegionFilterLabel.TabIndex = 2;
            this.RegionFilterLabel.Text = "Region Filter";
            // 
            // StoreNumberColumn
            // 
            this.StoreNumberColumn.DisplayIndex = 0;
            this.StoreNumberColumn.Text = "Store Number";
            this.StoreNumberColumn.Width = 100;
            // 
            // StoreFinderControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.PanelSplitter);
            this.Controls.Add(this.LeftPanel);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "StoreFinderControl";
            this.Size = new System.Drawing.Size(553, 248);
            this.RightPanel.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.RightTopPanel.ResumeLayout(false);
            this.RightTopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader LocationColumn;
        private System.Windows.Forms.ListView StoreList;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel RightTopPanel;
        private System.Windows.Forms.ComboBox RegionFilterComboBox;
        private System.Windows.Forms.Label RegionFilterLabel;
        private System.Windows.Forms.Splitter PanelSplitter;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.ColumnHeader StoreNumberColumn;
    }
}
