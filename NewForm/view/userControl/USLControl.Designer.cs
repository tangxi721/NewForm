namespace NewForm.view.userControl
{
    partial class USLControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.USpanel = new System.Windows.Forms.Panel();
            this.UStableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.USpictureBox = new System.Windows.Forms.PictureBox();
            this.USlabel = new System.Windows.Forms.Label();
            this.UStableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.USpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // USpanel
            // 
            this.USpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(45)))), ((int)(((byte)(83)))));
            this.USpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.USpanel.Location = new System.Drawing.Point(0, 0);
            this.USpanel.Margin = new System.Windows.Forms.Padding(0);
            this.USpanel.Name = "USpanel";
            this.USpanel.Size = new System.Drawing.Size(4, 150);
            this.USpanel.TabIndex = 0;
            this.USpanel.Click += new System.EventHandler(this.USpanel_Click);
            this.USpanel.MouseEnter += new System.EventHandler(this.USpanel_MouseEnter);
            this.USpanel.MouseLeave += new System.EventHandler(this.USpanel_MouseLeave);
            // 
            // UStableLayoutPanel
            // 
            this.UStableLayoutPanel.ColumnCount = 3;
            this.UStableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UStableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.UStableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UStableLayoutPanel.Controls.Add(this.USpictureBox, 1, 1);
            this.UStableLayoutPanel.Controls.Add(this.USlabel, 1, 2);
            this.UStableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UStableLayoutPanel.Location = new System.Drawing.Point(4, 0);
            this.UStableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.UStableLayoutPanel.Name = "UStableLayoutPanel";
            this.UStableLayoutPanel.RowCount = 4;
            this.UStableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UStableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.UStableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.UStableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UStableLayoutPanel.Size = new System.Drawing.Size(193, 150);
            this.UStableLayoutPanel.TabIndex = 1;
            this.UStableLayoutPanel.Click += new System.EventHandler(this.UStableLayoutPanel_Click);
            this.UStableLayoutPanel.MouseEnter += new System.EventHandler(this.UStableLayoutPanel_MouseEnter);
            this.UStableLayoutPanel.MouseLeave += new System.EventHandler(this.UStableLayoutPanel_MouseLeave);
            // 
            // USpictureBox
            // 
            this.USpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.USpictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.USpictureBox.Location = new System.Drawing.Point(81, 50);
            this.USpictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.USpictureBox.Name = "USpictureBox";
            this.USpictureBox.Size = new System.Drawing.Size(30, 30);
            this.USpictureBox.TabIndex = 0;
            this.USpictureBox.TabStop = false;
            this.USpictureBox.Click += new System.EventHandler(this.USpictureBox_Click);
            this.USpictureBox.MouseEnter += new System.EventHandler(this.USpictureBox_MouseEnter);
            this.USpictureBox.MouseLeave += new System.EventHandler(this.USpictureBox_MouseLeave);
            // 
            // USlabel
            // 
            this.USlabel.AutoSize = true;
            this.USlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.USlabel.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.USlabel.ForeColor = System.Drawing.Color.White;
            this.USlabel.Location = new System.Drawing.Point(81, 80);
            this.USlabel.Margin = new System.Windows.Forms.Padding(0);
            this.USlabel.Name = "USlabel";
            this.USlabel.Size = new System.Drawing.Size(30, 20);
            this.USlabel.TabIndex = 1;
            this.USlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.USlabel.Click += new System.EventHandler(this.USlabel_Click);
            this.USlabel.MouseEnter += new System.EventHandler(this.USlabel_MouseEnter);
            this.USlabel.MouseLeave += new System.EventHandler(this.USlabel_MouseLeave);
            // 
            // USLControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.UStableLayoutPanel);
            this.Controls.Add(this.USpanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "USLControl";
            this.Size = new System.Drawing.Size(197, 150);
            this.UStableLayoutPanel.ResumeLayout(false);
            this.UStableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.USpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel USpanel;
        private System.Windows.Forms.TableLayoutPanel UStableLayoutPanel;
        private System.Windows.Forms.PictureBox USpictureBox;
        private System.Windows.Forms.Label USlabel;
    }
}
