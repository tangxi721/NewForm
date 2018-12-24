using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewForm.view
{
    public partial class BaseForm : Form
    {
        bool formMove = false;
        Point formPoint;

        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseToppanel_MouseDown(object sender, MouseEventArgs e)
        {
            formPoint = new Point();
            int xOffset;
            int yOffset;
            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X;
                yOffset = -e.Y;
                formPoint = new Point(xOffset, yOffset);
                formMove = true;
            }
        }

        private void BaseToppanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove == true)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                Location = mousePos;
            }
        }

        private void BaseToppanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formMove = false;
            }
        }

        private void MiniMizeBox_MouseHover(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaxMizeBox_MouseHover(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                string fullName = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\bin"));
                MaxMizeBox.BackgroundImage = Image.FromFile(fullName + @"\Resources\复选框 (2).png");
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                string fullName = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\bin"));
                MaxMizeBox.BackgroundImage = Image.FromFile(fullName + @"\Resources\缩小屏幕.png");               
            }
        }

        private void CloseBox_MouseHover(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseBox_MouseHover_1(object sender, EventArgs e)
        {
            string fullName = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\bin"));
            CloseBox.BackgroundImage = Image.FromFile(fullName + @"\Resources\关机红.png");
        }

        private void CloseBox_MouseLeave(object sender, EventArgs e)
        {
            string fullName = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\bin"));
            CloseBox.BackgroundImage = Image.FromFile(fullName + @"\Resources\开关.png");
        }
    }
}
