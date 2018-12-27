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
            this.USpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.USpanel.Location = new System.Drawing.Point(0, 0);
            this.USpanel.Margin = new System.Windows.Forms.Padding(0);
            this.USpanel.Name = "USpanel";
            this.USpanel.Size = new System.Drawing.Size(13, 150);
            this.USpanel.TabIndex = 0;
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
            this.UStableLayoutPanel.Location = new System.Drawing.Point(13, 0);
            this.UStableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.UStableLayoutPanel.Name = "UStableLayoutPanel";
            this.UStableLayoutPanel.RowCount = 4;
            this.UStableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UStableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.UStableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.UStableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UStableLayoutPanel.Size = new System.Drawing.Size(184, 150);
            this.UStableLayoutPanel.TabIndex = 1;
            // 
            // USpictureBox
            // 
            this.USpictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.USpictureBox.Location = new System.Drawing.Point(77, 50);
            this.USpictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.USpictureBox.Name = "USpictureBox";
            this.USpictureBox.Size = new System.Drawing.Size(30, 30);
            this.USpictureBox.TabIndex = 0;
            this.USpictureBox.TabStop = false;
            // 
            // USlabel
            // 
            this.USlabel.AutoSize = true;
            this.USlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.USlabel.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.USlabel.Location = new System.Drawing.Point(77, 80);
            this.USlabel.Margin = new System.Windows.Forms.Padding(0);
            this.USlabel.Name = "USlabel";
            this.USlabel.Size = new System.Drawing.Size(30, 20);
            this.USlabel.TabIndex = 1;
            this.USlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // USLControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UStableLayoutPanel);
            this.Controls.Add(this.USpanel);
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
