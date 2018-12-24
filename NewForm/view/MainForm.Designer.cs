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
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TitlePanel = new CCWin.SkinControl.SkinPanel();
            this.TitletableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchpanel = new System.Windows.Forms.Panel();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.Allpanel = new System.Windows.Forms.Panel();
            this.MiniMizeBox = new System.Windows.Forms.PictureBox();
            this.MaxMizeBox = new System.Windows.Forms.PictureBox();
            this.CloseBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).BeginInit();
            this.skinSplitContainer1.Panel2.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.TitletableLayoutPanel.SuspendLayout();
            this.searchpanel.SuspendLayout();
            this.Allpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MiniMizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxMizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            this.SuspendLayout();
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.LineBack = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.skinSplitContainer1.LineBack2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.skinSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.skinSplitContainer1.Panel1.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // skinSplitContainer1.Panel2
            // 
            this.skinSplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.skinSplitContainer1.Panel2.Controls.Add(this.panel2);
            this.skinSplitContainer1.Size = new System.Drawing.Size(786, 539);
            this.skinSplitContainer1.SplitterDistance = 138;
            this.skinSplitContainer1.SplitterWidth = 8;
            this.skinSplitContainer1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 539);
            this.panel2.TabIndex = 1;
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
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
            this.TitletableLayoutPanel.ColumnCount = 9;
            this.TitletableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TitletableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TitletableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TitletableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TitletableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.TitletableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TitletableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.TitletableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TitletableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.TitletableLayoutPanel.Controls.Add(this.MiniMizeBox, 3, 1);
            this.TitletableLayoutPanel.Controls.Add(this.searchpanel, 1, 1);
            this.TitletableLayoutPanel.Controls.Add(this.MaxMizeBox, 5, 1);
            this.TitletableLayoutPanel.Controls.Add(this.CloseBox, 7, 1);
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
            // searchpanel
            // 
            this.searchpanel.BackColor = System.Drawing.Color.White;
            this.searchpanel.Controls.Add(this.searchtextBox);
            this.searchpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchpanel.Location = new System.Drawing.Point(308, 8);
            this.searchpanel.Margin = new System.Windows.Forms.Padding(0);
            this.searchpanel.Name = "searchpanel";
            this.searchpanel.Size = new System.Drawing.Size(308, 30);
            this.searchpanel.TabIndex = 0;
            // 
            // searchtextBox
            // 
            this.searchtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchtextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchtextBox.Font = new System.Drawing.Font("华文彩云", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchtextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.searchtextBox.Location = new System.Drawing.Point(3, 6);
            this.searchtextBox.Margin = new System.Windows.Forms.Padding(0);
            this.searchtextBox.Multiline = true;
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(303, 22);
            this.searchtextBox.TabIndex = 0;
            this.searchtextBox.TabStop = false;
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(0, 47);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Palace = true;
            this.skinPanel1.Size = new System.Drawing.Size(76, 540);
            this.skinPanel1.TabIndex = 14;
            // 
            // Allpanel
            // 
            this.Allpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Allpanel.BackColor = System.Drawing.SystemColors.Control;
            this.Allpanel.Controls.Add(this.skinSplitContainer1);
            this.Allpanel.Location = new System.Drawing.Point(74, 47);
            this.Allpanel.Name = "Allpanel";
            this.Allpanel.Size = new System.Drawing.Size(786, 539);
            this.Allpanel.TabIndex = 18;
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
            this.Controls.Add(this.skinPanel1);
            this.Controls.Add(this.TitlePanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(861, 587);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.NewForm_Load);
            this.skinSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).EndInit();
            this.skinSplitContainer1.ResumeLayout(false);
            this.TitlePanel.ResumeLayout(false);
            this.TitletableLayoutPanel.ResumeLayout(false);
            this.searchpanel.ResumeLayout(false);
            this.searchpanel.PerformLayout();
            this.Allpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MiniMizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxMizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox MiniMizeBox;
        private System.Windows.Forms.PictureBox MaxMizeBox;
        private System.Windows.Forms.PictureBox CloseBox;
        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer1;
        private CCWin.SkinControl.SkinPanel TitlePanel;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private System.Windows.Forms.Panel Allpanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel searchpanel;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.TableLayoutPanel TitletableLayoutPanel;
    }
}

