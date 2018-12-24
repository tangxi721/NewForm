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
            this.MiniMizeBox = new System.Windows.Forms.PictureBox();
            this.CloseBox = new System.Windows.Forms.PictureBox();
            this.MaxMizeBox = new System.Windows.Forms.PictureBox();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).BeginInit();
            this.skinSplitContainer1.Panel2.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MiniMizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxMizeBox)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.skinSplitContainer1.Size = new System.Drawing.Size(694, 497);
            this.skinSplitContainer1.SplitterDistance = 180;
            this.skinSplitContainer1.SplitterWidth = 8;
            this.skinSplitContainer1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 497);
            this.panel2.TabIndex = 1;
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.TitlePanel.Controls.Add(this.MiniMizeBox);
            this.TitlePanel.Controls.Add(this.CloseBox);
            this.TitlePanel.Controls.Add(this.MaxMizeBox);
            this.TitlePanel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.DownBack = null;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.MouseBack = null;
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.NormlBack = null;
            this.TitlePanel.Size = new System.Drawing.Size(747, 34);
            this.TitlePanel.TabIndex = 15;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseDown_1);
            this.TitlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseMove_1);
            this.TitlePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseUp_1);
            // 
            // MiniMizeBox
            // 
            this.MiniMizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MiniMizeBox.BackColor = System.Drawing.Color.Transparent;
            this.MiniMizeBox.BackgroundImage = global::NewForm.Properties.Resources.减;
            this.MiniMizeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MiniMizeBox.Location = new System.Drawing.Point(672, 3);
            this.MiniMizeBox.Name = "MiniMizeBox";
            this.MiniMizeBox.Size = new System.Drawing.Size(20, 20);
            this.MiniMizeBox.TabIndex = 8;
            this.MiniMizeBox.TabStop = false;
            this.MiniMizeBox.Click += new System.EventHandler(this.MiniMizeBox_MouseHover);
            // 
            // CloseBox
            // 
            this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBox.BackColor = System.Drawing.Color.Transparent;
            this.CloseBox.BackgroundImage = global::NewForm.Properties.Resources.开关;
            this.CloseBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseBox.Location = new System.Drawing.Point(724, 3);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(20, 20);
            this.CloseBox.TabIndex = 10;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_MouseHover);
            this.CloseBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseBox_MouseDown);
            this.CloseBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CloseBox_MouseUp);
            // 
            // MaxMizeBox
            // 
            this.MaxMizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxMizeBox.BackColor = System.Drawing.Color.Transparent;
            this.MaxMizeBox.BackgroundImage = global::NewForm.Properties.Resources.复选框__2_;
            this.MaxMizeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MaxMizeBox.Location = new System.Drawing.Point(698, 3);
            this.MaxMizeBox.Name = "MaxMizeBox";
            this.MaxMizeBox.Size = new System.Drawing.Size(20, 20);
            this.MaxMizeBox.TabIndex = 9;
            this.MaxMizeBox.TabStop = false;
            this.MaxMizeBox.Click += new System.EventHandler(this.MaxMizeBox_MouseHover);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(0, 34);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Palace = true;
            this.skinPanel1.Size = new System.Drawing.Size(52, 498);
            this.skinPanel1.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.skinSplitContainer1);
            this.panel1.Location = new System.Drawing.Point(52, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 497);
            this.panel1.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 532);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.skinPanel1);
            this.Controls.Add(this.TitlePanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.NewForm_Load);
            this.Resize += new System.EventHandler(this.NewForm_Resize);
            this.skinSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).EndInit();
            this.skinSplitContainer1.ResumeLayout(false);
            this.TitlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MiniMizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxMizeBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox MiniMizeBox;
        private System.Windows.Forms.PictureBox MaxMizeBox;
        private System.Windows.Forms.PictureBox CloseBox;
        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer1;
        private CCWin.SkinControl.SkinPanel TitlePanel;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

