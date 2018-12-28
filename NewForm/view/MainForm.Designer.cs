namespace NewForm
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AllSplitContainer = new CCWin.SkinControl.SkinSplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TitlePanel = new CCWin.SkinControl.SkinPanel();
            this.TitletableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LEFTpanel = new CCWin.SkinControl.SkinPanel();
            this.LEFTtableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Allpanel = new System.Windows.Forms.Panel();
            this.mynotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MSuslControl = new NewForm.view.userControl.USLControl();
            this.VDuslControl = new NewForm.view.userControl.USLControl();
            this.STuslControl = new NewForm.view.userControl.USLControl();
            this.BKuslControl = new NewForm.view.userControl.USLControl();
            this.searchpictureBox = new System.Windows.Forms.PictureBox();
            this.MiniMizeBox = new System.Windows.Forms.PictureBox();
            this.searchpanel = new System.Windows.Forms.Panel();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.MaxMizeBox = new System.Windows.Forms.PictureBox();
            this.CloseBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AllSplitContainer)).BeginInit();
            this.AllSplitContainer.Panel2.SuspendLayout();
            this.AllSplitContainer.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.TitletableLayoutPanel.SuspendLayout();
            this.LEFTpanel.SuspendLayout();
            this.LEFTtableLayoutPanel.SuspendLayout();
            this.Allpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiniMizeBox)).BeginInit();
            this.searchpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxMizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AllSplitContainer
            // 
            this.AllSplitContainer.ArroHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(136)))), ((int)(((byte)(228)))));
            this.AllSplitContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.AllSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllSplitContainer.LineBack = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(45)))), ((int)(((byte)(83)))));
            this.AllSplitContainer.LineBack2 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(45)))), ((int)(((byte)(83)))));
            this.AllSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.AllSplitContainer.Name = "AllSplitContainer";
            // 
            // AllSplitContainer.Panel1
            // 
            this.AllSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.AllSplitContainer.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AllSplitContainer.Panel1MinSize = 0;
            // 
            // AllSplitContainer.Panel2
            // 
            this.AllSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.AllSplitContainer.Panel2.Controls.Add(this.panel2);
            this.AllSplitContainer.Size = new System.Drawing.Size(795, 539);
            this.AllSplitContainer.SplitterDistance = 207;
            this.AllSplitContainer.SplitterWidth = 8;
            this.AllSplitContainer.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 539);
            this.panel2.TabIndex = 1;
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(45)))), ((int)(((byte)(83)))));
            this.TitlePanel.Controls.Add(this.TitletableLayoutPanel);
            this.TitlePanel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.DownBack = null;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.MouseBack = null;
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.NormlBack = null;
            this.TitlePanel.Size = new System.Drawing.Size(861, 47);
            this.TitlePanel.TabIndex = 15;
            // 
            // TitletableLayoutPanel
            // 
            this.TitletableLayoutPanel.ColumnCount = 11;
            this.TitletableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TitletableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TitletableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TitletableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TitletableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TitletableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TitletableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.TitletableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TitletableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.TitletableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TitletableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.TitletableLayoutPanel.Controls.Add(this.MiniMizeBox, 5, 1);
            this.TitletableLayoutPanel.Controls.Add(this.searchpanel, 1, 1);
            this.TitletableLayoutPanel.Controls.Add(this.MaxMizeBox, 7, 1);
            this.TitletableLayoutPanel.Controls.Add(this.CloseBox, 9, 1);
            this.TitletableLayoutPanel.Controls.Add(this.searchpictureBox, 3, 1);
            this.TitletableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitletableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TitletableLayoutPanel.Name = "TitletableLayoutPanel";
            this.TitletableLayoutPanel.RowCount = 3;
            this.TitletableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TitletableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TitletableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TitletableLayoutPanel.Size = new System.Drawing.Size(861, 47);
            this.TitletableLayoutPanel.TabIndex = 0;
            this.TitletableLayoutPanel.DoubleClick += new System.EventHandler(this.TitletableLayoutPanel_DoubleClick);
            this.TitletableLayoutPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitletableLayoutPanel_MouseDown);
            this.TitletableLayoutPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitletableLayoutPanel_MouseMove);
            this.TitletableLayoutPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitletableLayoutPanel_MouseUp);
            // 
            // LEFTpanel
            // 
            this.LEFTpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(45)))), ((int)(((byte)(83)))));
            this.LEFTpanel.Controls.Add(this.LEFTtableLayoutPanel);
            this.LEFTpanel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.LEFTpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LEFTpanel.DownBack = null;
            this.LEFTpanel.Location = new System.Drawing.Point(0, 47);
            this.LEFTpanel.Margin = new System.Windows.Forms.Padding(0);
            this.LEFTpanel.MouseBack = null;
            this.LEFTpanel.Name = "LEFTpanel";
            this.LEFTpanel.NormlBack = null;
            this.LEFTpanel.Palace = true;
            this.LEFTpanel.Size = new System.Drawing.Size(65, 540);
            this.LEFTpanel.TabIndex = 14;
            // 
            // LEFTtableLayoutPanel
            // 
            this.LEFTtableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.LEFTtableLayoutPanel.ColumnCount = 1;
            this.LEFTtableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LEFTtableLayoutPanel.Controls.Add(this.MSuslControl, 0, 0);
            this.LEFTtableLayoutPanel.Controls.Add(this.VDuslControl, 0, 1);
            this.LEFTtableLayoutPanel.Controls.Add(this.STuslControl, 0, 4);
            this.LEFTtableLayoutPanel.Controls.Add(this.BKuslControl, 0, 2);
            this.LEFTtableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LEFTtableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.LEFTtableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LEFTtableLayoutPanel.Name = "LEFTtableLayoutPanel";
            this.LEFTtableLayoutPanel.RowCount = 5;
            this.LEFTtableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.LEFTtableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.LEFTtableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.LEFTtableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LEFTtableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.LEFTtableLayoutPanel.Size = new System.Drawing.Size(65, 540);
            this.LEFTtableLayoutPanel.TabIndex = 0;
            // 
            // Allpanel
            // 
            this.Allpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Allpanel.BackColor = System.Drawing.SystemColors.Control;
            this.Allpanel.Controls.Add(this.AllSplitContainer);
            this.Allpanel.Location = new System.Drawing.Point(65, 47);
            this.Allpanel.Margin = new System.Windows.Forms.Padding(0);
            this.Allpanel.Name = "Allpanel";
            this.Allpanel.Size = new System.Drawing.Size(795, 539);
            this.Allpanel.TabIndex = 18;
            // 
            // mynotifyIcon
            // 
            this.mynotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("mynotifyIcon.Icon")));
            this.mynotifyIcon.Visible = true;
            // 
            // MSuslControl
            // 
            this.MSuslControl.BackColor = System.Drawing.Color.Transparent;
            this.MSuslControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MSuslControl.IsActive = false;
            this.MSuslControl.Location = new System.Drawing.Point(0, 0);
            this.MSuslControl.Margin = new System.Windows.Forms.Padding(0);
            this.MSuslControl.Name = "MSuslControl";
            this.MSuslControl.SetActive = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(45)))), ((int)(((byte)(83)))));
            this.MSuslControl.SetBackColor = System.Drawing.Color.Transparent;
            this.MSuslControl.Setname = "音乐";
            this.MSuslControl.Setpic = global::NewForm.Properties.Resources.MC;
            this.MSuslControl.Size = new System.Drawing.Size(65, 60);
            this.MSuslControl.TabIndex = 6;
            this.MSuslControl.Click += new System.EventHandler(this.MSuslControl_Click);
            // 
            // VDuslControl
            // 
            this.VDuslControl.BackColor = System.Drawing.Color.Transparent;
            this.VDuslControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VDuslControl.IsActive = false;
            this.VDuslControl.Location = new System.Drawing.Point(0, 60);
            this.VDuslControl.Margin = new System.Windows.Forms.Padding(0);
            this.VDuslControl.Name = "VDuslControl";
            this.VDuslControl.SetActive = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(45)))), ((int)(((byte)(83)))));
            this.VDuslControl.SetBackColor = System.Drawing.Color.Transparent;
            this.VDuslControl.Setname = "视频";
            this.VDuslControl.Setpic = global::NewForm.Properties.Resources.VD;
            this.VDuslControl.Size = new System.Drawing.Size(65, 60);
            this.VDuslControl.TabIndex = 3;
            this.VDuslControl.Click += new System.EventHandler(this.VDuslControl_Click);
            // 
            // STuslControl
            // 
            this.STuslControl.BackColor = System.Drawing.Color.Transparent;
            this.STuslControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STuslControl.IsActive = false;
            this.STuslControl.Location = new System.Drawing.Point(0, 480);
            this.STuslControl.Margin = new System.Windows.Forms.Padding(0);
            this.STuslControl.Name = "STuslControl";
            this.STuslControl.SetActive = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(45)))), ((int)(((byte)(83)))));
            this.STuslControl.SetBackColor = System.Drawing.Color.Transparent;
            this.STuslControl.Setname = "设置";
            this.STuslControl.Setpic = global::NewForm.Properties.Resources.ST;
            this.STuslControl.Size = new System.Drawing.Size(65, 60);
            this.STuslControl.TabIndex = 4;
            this.STuslControl.Click += new System.EventHandler(this.STuslControl_Click);
            // 
            // BKuslControl
            // 
            this.BKuslControl.BackColor = System.Drawing.Color.Transparent;
            this.BKuslControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BKuslControl.IsActive = false;
            this.BKuslControl.Location = new System.Drawing.Point(0, 120);
            this.BKuslControl.Margin = new System.Windows.Forms.Padding(0);
            this.BKuslControl.Name = "BKuslControl";
            this.BKuslControl.SetActive = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(45)))), ((int)(((byte)(83)))));
            this.BKuslControl.SetBackColor = System.Drawing.Color.Transparent;
            this.BKuslControl.Setname = "书籍";
            this.BKuslControl.Setpic = global::NewForm.Properties.Resources.BK;
            this.BKuslControl.Size = new System.Drawing.Size(65, 60);
            this.BKuslControl.TabIndex = 5;
            this.BKuslControl.Click += new System.EventHandler(this.BKuslControl_Click);
            // 
            // searchpictureBox
            // 
            this.searchpictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchpictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchpictureBox.BackgroundImage")));
            this.searchpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchpictureBox.Location = new System.Drawing.Point(523, 10);
            this.searchpictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.searchpictureBox.Name = "searchpictureBox";
            this.searchpictureBox.Size = new System.Drawing.Size(26, 25);
            this.searchpictureBox.TabIndex = 0;
            this.searchpictureBox.TabStop = false;
            this.searchpictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.searchpictureBox_MouseDown);
            this.searchpictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.searchpictureBox_MouseUp);
            // 
            // MiniMizeBox
            // 
            this.MiniMizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MiniMizeBox.BackColor = System.Drawing.Color.Transparent;
            this.MiniMizeBox.BackgroundImage = global::NewForm.Properties.Resources.min;
            this.MiniMizeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MiniMizeBox.Location = new System.Drawing.Point(773, 11);
            this.MiniMizeBox.Name = "MiniMizeBox";
            this.MiniMizeBox.Size = new System.Drawing.Size(19, 20);
            this.MiniMizeBox.TabIndex = 8;
            this.MiniMizeBox.TabStop = false;
            this.MiniMizeBox.Click += new System.EventHandler(this.MiniMizeBox_MouseHover);
            // 
            // searchpanel
            // 
            this.searchpanel.BackColor = System.Drawing.Color.White;
            this.searchpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchpanel.Controls.Add(this.searchtextBox);
            this.searchpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchpanel.Location = new System.Drawing.Point(219, 8);
            this.searchpanel.Margin = new System.Windows.Forms.Padding(0);
            this.searchpanel.Name = "searchpanel";
            this.searchpanel.Size = new System.Drawing.Size(292, 30);
            this.searchpanel.TabIndex = 0;
            // 
            // searchtextBox
            // 
            this.searchtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchtextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchtextBox.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchtextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.searchtextBox.Location = new System.Drawing.Point(4, 5);
            this.searchtextBox.Margin = new System.Windows.Forms.Padding(0);
            this.searchtextBox.Multiline = true;
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(286, 20);
            this.searchtextBox.TabIndex = 0;
            this.searchtextBox.TabStop = false;
            // 
            // MaxMizeBox
            // 
            this.MaxMizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxMizeBox.BackColor = System.Drawing.Color.Transparent;
            this.MaxMizeBox.BackgroundImage = global::NewForm.Properties.Resources.maxForm;
            this.MaxMizeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MaxMizeBox.ImageLocation = "";
            this.MaxMizeBox.Location = new System.Drawing.Point(803, 11);
            this.MaxMizeBox.Name = "MaxMizeBox";
            this.MaxMizeBox.Size = new System.Drawing.Size(19, 20);
            this.MaxMizeBox.TabIndex = 9;
            this.MaxMizeBox.TabStop = false;
            this.MaxMizeBox.Click += new System.EventHandler(this.MaxMizeBox_MouseHover);
            // 
            // CloseBox
            // 
            this.CloseBox.BackColor = System.Drawing.Color.Transparent;
            this.CloseBox.BackgroundImage = global::NewForm.Properties.Resources.close;
            this.CloseBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseBox.Location = new System.Drawing.Point(833, 11);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(19, 20);
            this.CloseBox.TabIndex = 10;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_MouseHover);
            this.CloseBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseBox_MouseDown);
            this.CloseBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CloseBox_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 587);
            this.Controls.Add(this.Allpanel);
            this.Controls.Add(this.LEFTpanel);
            this.Controls.Add(this.TitlePanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(861, 587);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.NewForm_Load);
            this.AllSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AllSplitContainer)).EndInit();
            this.AllSplitContainer.ResumeLayout(false);
            this.TitlePanel.ResumeLayout(false);
            this.TitletableLayoutPanel.ResumeLayout(false);
            this.LEFTpanel.ResumeLayout(false);
            this.LEFTtableLayoutPanel.ResumeLayout(false);
            this.Allpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiniMizeBox)).EndInit();
            this.searchpanel.ResumeLayout(false);
            this.searchpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxMizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox MiniMizeBox;
        private System.Windows.Forms.PictureBox MaxMizeBox;
        private System.Windows.Forms.PictureBox CloseBox;
        private CCWin.SkinControl.SkinSplitContainer AllSplitContainer;
        private CCWin.SkinControl.SkinPanel TitlePanel;
        private CCWin.SkinControl.SkinPanel LEFTpanel;
        private System.Windows.Forms.Panel Allpanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel searchpanel;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.TableLayoutPanel TitletableLayoutPanel;
        private System.Windows.Forms.NotifyIcon mynotifyIcon;
        private System.Windows.Forms.PictureBox searchpictureBox;
        private System.Windows.Forms.TableLayoutPanel LEFTtableLayoutPanel;
        private view.userControl.USLControl VDuslControl;
        private view.userControl.USLControl STuslControl;
        private view.userControl.USLControl BKuslControl;
        private view.userControl.USLControl MSuslControl;
    }
}

