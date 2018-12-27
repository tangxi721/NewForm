﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewForm.view.userControl
{
    public partial class USLControl : UserControl
    {
        public bool IsActive { get; set; }
        public bool SetActive { get => USpanel.Visible; set => USpanel.Visible = value; }
        public Color SetBackColor { get => this.BackColor; set => this.BackColor = value; }

        public USLControl()
        {
            InitializeComponent();
            SetStyle(
                     ControlStyles.OptimizedDoubleBuffer
                     | ControlStyles.ResizeRedraw
                     | ControlStyles.Selectable
                     | ControlStyles.AllPaintingInWmPaint
                     | ControlStyles.UserPaint
                     | ControlStyles.SupportsTransparentBackColor,
                     true);
        }
      
        [Browsable(true)]
        [Description("设置控件图片"), Category("setPic"), DefaultValue(" ")]
        public Bitmap Setpic
        {
            get { return (Bitmap)USpictureBox.BackgroundImage; }
            set { USpictureBox.BackgroundImage = value; }
        }

        [Browsable(true)]
        [Description("设置控件名称"), Category("setName"), DefaultValue(" ")]
        public string Setname
        {
            get { return USlabel.Text.ToString(); }
            set { USlabel.Text = value; }        
        }

        private void UStableLayoutPanel_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }

        private void USpictureBox_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }

        private void USlabel_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }

        private void USpanel_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }
    }
}
