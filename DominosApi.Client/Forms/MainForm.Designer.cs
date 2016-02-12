namespace DominosApi.Client.Forms {
    partial class MainForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusStrip_StoreLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip_RequestsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip_CurrentVoucherId = new System.Windows.Forms.ToolStripStatusLabel();
            this.StartButton = new System.Windows.Forms.Button();
            this.CouponList = new System.Windows.Forms.ListView();
            this.CouponDescriptionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CouponCodeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CouponDisclaimerColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UpdateRequestsTimer = new System.Windows.Forms.Timer(this.components);
            this.StartCodeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EndCodeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ThreadsNumeric = new System.Windows.Forms.NumericUpDown();
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartCodeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndCodeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreadsNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStrip_StoreLabel,
            this.StatusStrip_RequestsLabel,
            this.StatusStrip_CurrentVoucherId});
            this.StatusStrip.Location = new System.Drawing.Point(0, 250);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(547, 22);
            this.StatusStrip.TabIndex = 0;
            // 
            // StatusStrip_StoreLabel
            // 
            this.StatusStrip_StoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusStrip_StoreLabel.Name = "StatusStrip_StoreLabel";
            this.StatusStrip_StoreLabel.Size = new System.Drawing.Size(69, 17);
            this.StatusStrip_StoreLabel.Text = "Store: None";
            // 
            // StatusStrip_RequestsLabel
            // 
            this.StatusStrip_RequestsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.StatusStrip_RequestsLabel.Name = "StatusStrip_RequestsLabel";
            this.StatusStrip_RequestsLabel.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.StatusStrip_RequestsLabel.Size = new System.Drawing.Size(96, 17);
            this.StatusStrip_RequestsLabel.Text = "Requests: 0/sec";
            this.StatusStrip_RequestsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StatusStrip_CurrentVoucherId
            // 
            this.StatusStrip_CurrentVoucherId.BackColor = System.Drawing.SystemColors.Control;
            this.StatusStrip_CurrentVoucherId.Name = "StatusStrip_CurrentVoucherId";
            this.StatusStrip_CurrentVoucherId.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.StatusStrip_CurrentVoucherId.Size = new System.Drawing.Size(77, 17);
            this.StatusStrip_CurrentVoucherId.Text = "Checking: 0";
            this.StatusStrip_CurrentVoucherId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(423, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(112, 23);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // CouponList
            // 
            this.CouponList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CouponDescriptionColumn,
            this.CouponCodeColumn,
            this.CouponDisclaimerColumn});
            this.CouponList.FullRowSelect = true;
            this.CouponList.GridLines = true;
            this.CouponList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CouponList.HideSelection = false;
            this.CouponList.Location = new System.Drawing.Point(12, 41);
            this.CouponList.Name = "CouponList";
            this.CouponList.Size = new System.Drawing.Size(523, 196);
            this.CouponList.TabIndex = 3;
            this.CouponList.UseCompatibleStateImageBehavior = false;
            this.CouponList.View = System.Windows.Forms.View.Details;
            // 
            // CouponDescriptionColumn
            // 
            this.CouponDescriptionColumn.DisplayIndex = 1;
            this.CouponDescriptionColumn.Text = "Description";
            this.CouponDescriptionColumn.Width = 200;
            // 
            // CouponCodeColumn
            // 
            this.CouponCodeColumn.DisplayIndex = 0;
            this.CouponCodeColumn.Text = "Code";
            this.CouponCodeColumn.Width = 100;
            // 
            // CouponDisclaimerColumn
            // 
            this.CouponDisclaimerColumn.Text = "Disclaimer";
            this.CouponDisclaimerColumn.Width = 200;
            // 
            // UpdateRequestsTimer
            // 
            this.UpdateRequestsTimer.Interval = 1000;
            this.UpdateRequestsTimer.Tick += new System.EventHandler(this.UpdateRequestsTimer_Tick);
            // 
            // StartCodeNumeric
            // 
            this.StartCodeNumeric.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.StartCodeNumeric.Location = new System.Drawing.Point(52, 12);
            this.StartCodeNumeric.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.StartCodeNumeric.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.StartCodeNumeric.Name = "StartCodeNumeric";
            this.StartCodeNumeric.Size = new System.Drawing.Size(67, 23);
            this.StartCodeNumeric.TabIndex = 0;
            this.StartCodeNumeric.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "End:";
            // 
            // EndCodeNumeric
            // 
            this.EndCodeNumeric.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.EndCodeNumeric.Location = new System.Drawing.Point(171, 12);
            this.EndCodeNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.EndCodeNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.EndCodeNumeric.Name = "EndCodeNumeric";
            this.EndCodeNumeric.Size = new System.Drawing.Size(67, 23);
            this.EndCodeNumeric.TabIndex = 1;
            this.EndCodeNumeric.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Threads:";
            // 
            // ThreadsNumeric
            // 
            this.ThreadsNumeric.Location = new System.Drawing.Point(311, 12);
            this.ThreadsNumeric.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.ThreadsNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ThreadsNumeric.Name = "ThreadsNumeric";
            this.ThreadsNumeric.Size = new System.Drawing.Size(59, 23);
            this.ThreadsNumeric.TabIndex = 7;
            this.ThreadsNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(547, 272);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ThreadsNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EndCodeNumeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartCodeNumeric);
            this.Controls.Add(this.CouponList);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StatusStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "Dominos API Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartCodeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndCodeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreadsNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip_StoreLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ListView CouponList;
        private System.Windows.Forms.ColumnHeader CouponDescriptionColumn;
        private System.Windows.Forms.ColumnHeader CouponCodeColumn;
        private System.Windows.Forms.ColumnHeader CouponDisclaimerColumn;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip_RequestsLabel;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip_CurrentVoucherId;
        private System.Windows.Forms.Timer UpdateRequestsTimer;
        private System.Windows.Forms.NumericUpDown StartCodeNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown EndCodeNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ThreadsNumeric;
    }
}