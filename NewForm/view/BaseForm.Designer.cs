namespace NewForm.view
{
    partial class BaseForm
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
            this.BaseToppanel = new System.Windows.Forms.Panel();
            this.MiniMizeBox = new System.Windows.Forms.PictureBox();
            this.CloseBox = new System.Windows.Forms.PictureBox();
            this.MaxMizeBox = new System.Windows.Forms.PictureBox();
            this.BaseToppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MiniMizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxMizeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BaseToppanel
            // 
            this.BaseToppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.BaseToppanel.Controls.Add(this.MiniMizeBox);
            this.BaseToppanel.Controls.Add(this.CloseBox);
            this.BaseToppanel.Controls.Add(this.MaxMizeBox);
            this.BaseToppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BaseToppanel.Location = new System.Drawing.Point(0, 0);
            this.BaseToppanel.Name = "BaseToppanel";
            this.BaseToppanel.Size = new System.Drawing.Size(403, 29);
            this.BaseToppanel.TabIndex = 0;
            this.BaseToppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BaseToppanel_MouseDown);
            this.BaseToppanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BaseToppanel_MouseMove);
            this.BaseToppanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BaseToppanel_MouseUp);
            // 
            // MiniMizeBox
            // 
            this.MiniMizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MiniMizeBox.BackColor = System.Drawing.Color.Transparent;
            this.MiniMizeBox.BackgroundImage = global::NewForm.Properties.Resources.减;
            this.MiniMizeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MiniMizeBox.Location = new System.Drawing.Point(329, 3);
            this.MiniMizeBox.Name = "MiniMizeBox";
            this.MiniMizeBox.Size = new System.Drawing.Size(20, 20);
            this.MiniMizeBox.TabIndex = 11;
            this.MiniMizeBox.TabStop = false;
            this.MiniMizeBox.Click += new System.EventHandler(this.MiniMizeBox_MouseHover);
            // 
            // CloseBox
            // 
            this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBox.BackColor = System.Drawing.Color.Transparent;
            this.CloseBox.BackgroundImage = global::NewForm.Properties.Resources.开关;
            this.CloseBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseBox.Location = new System.Drawing.Point(381, 3);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(20, 20);
            this.CloseBox.TabIndex = 13;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_MouseHover);
            this.CloseBox.MouseLeave += new System.EventHandler(this.CloseBox_MouseLeave);
            this.CloseBox.MouseHover += new System.EventHandler(this.CloseBox_MouseHover_1);
            // 
            // MaxMizeBox
            // 
            this.MaxMizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxMizeBox.BackColor = System.Drawing.Color.Transparent;
            this.MaxMizeBox.BackgroundImage = global::NewForm.Properties.Resources.复选框__2_;
            this.MaxMizeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MaxMizeBox.Location = new System.Drawing.Point(355, 3);
            this.MaxMizeBox.Name = "MaxMizeBox";
            this.MaxMizeBox.Size = new System.Drawing.Size(20, 20);
            this.MaxMizeBox.TabIndex = 12;
            this.MaxMizeBox.TabStop = false;
            this.MaxMizeBox.Click += new System.EventHandler(this.MaxMizeBox_MouseHover);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 311);
            this.Controls.Add(this.BaseToppanel);
            this.Font = new System.Drawing.Font("幼圆", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.BaseToppanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MiniMizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxMizeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BaseToppanel;
        private System.Windows.Forms.PictureBox MiniMizeBox;
        private System.Windows.Forms.PictureBox CloseBox;
        private System.Windows.Forms.PictureBox MaxMizeBox;
    }
}