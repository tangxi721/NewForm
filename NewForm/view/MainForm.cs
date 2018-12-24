using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NewForm
{
    public partial class MainForm : Form
    {
        # region 字段及属性

        private const int WM_NCLBUTTONDBLCLK = 163;
        private const int WM_NCHITTEST = 132;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        bool formMove = false;
        Point formPoint;
        #endregion

        #region 构造函数

        public MainForm()
        {
            InitializeComponent();          
            this.BackColor = Color.FromArgb(0, 60, 108);
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
        }
        #endregion

        #region 基本功能事件

        private void NewForm_Resize(object sender, EventArgs e)
        {
            //SetWindowRegion();
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
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void CloseBox_MouseHover(object sender, EventArgs e)
        {          
            this.Close();
        }

        private void TitlePanel_MouseDown_1(object sender, MouseEventArgs e)
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

        private void TitlePanel_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (formMove == true)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                Location = mousePos;
            }
        }

        private void TitlePanel_MouseUp_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formMove = false;
            }
        }

        private void CloseBox_MouseDown(object sender, MouseEventArgs e)
        {
            string fullName = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\bin"));
            CloseBox.BackgroundImage = Image.FromFile(fullName + @"\Resources\关机红.png");
        }

        private void CloseBox_MouseUp(object sender, MouseEventArgs e)
        {
            string fullName = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\bin"));
            CloseBox.BackgroundImage = Image.FromFile(fullName + @"\Resources\开关.png");
        }
        #endregion

        # region 重绘窗体，擦出背景闪烁

        public void SetWindowRegion()
        {
            GraphicsPath FormPath;
            FormPath = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            FormPath = GetRoundedRectPath(rect, 10);
            this.Region = new Region(FormPath);
        }


        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();
            // 左上角  
            path.AddArc(arcRect, 180, 90);
            // 右上角  
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);
            // 右下角  
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);
            // 左下角  
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();//闭合曲线  
            return path;
        }      
                               
        // 边框改变大小      
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCLBUTTONDBLCLK://WM_NCLBUTTONDBLCLK=163 <0xA3>拦截鼠标非客户区左键双击消息,决定窗体是否最大化显示
                    if (this.MaximizeBox)
                    {
                        base.WndProc(ref m);
                        this.Invalidate();
                    }
                    return;
                case WM_NCHITTEST://WM_NCHITTEST=132 <0x84> 
                    base.WndProc(ref m);//如果去掉这一行代码,窗体将失去MouseMove..等事件
                    //Point lpint = new Point((int)m.LParam);//可以得到鼠标坐标,这样就可以决定怎么处理这个消息了,是移动窗体,还是缩放,以及向哪向的缩放
                    //if (lpint.Y < 30)
                    //    m.Result = (IntPtr)0x2;//托动HTCAPTION=2 <0x2>
                    if (WindowState != FormWindowState.Maximized)
                    {                      
                        Point p2 = this.PointToClient(MousePosition);//鼠标相对于窗体的坐标
                       
                        //label1.Text = p2.X + "," + p2.Y;
                        //HTLEFT=10 <0xA> 左边框                      
                        if (p2.X < 5 && p2.Y > 5 && p2.Y < this.Height - 5)
                            m.Result = (IntPtr)0xA;
                        else if (p2.Y < 5 && p2.X > 5 && p2.X < this.Width - 5)
                            m.Result = (IntPtr)0xC;
                        //HTTOP=12 <0xC> 上边框                   
                        else if (p2.X < 5 && p2.Y < 5)
                            m.Result = (IntPtr)0xD;
                        //HTTOPLEFT=13 <0xD>
                        else if (p2.X >= this.Width - 5 && p2.Y < 5)
                            m.Result = (IntPtr)0xE;
                        //HTTOPRIGHT=14 <0xE> 
                        else if (p2.X > this.Width - 5 && p2.Y > 5 && p2.Y < this.Height - 5)
                            m.Result = (IntPtr)0xB;
                        //HTRIGHT=11 <0xB>
                        else if (p2.Y >= this.Height - 5 && p2.X > 5 && p2.X < this.Width - 5)
                            m.Result = (IntPtr)0xF;
                        //HTBOTTOM=15 <0xF>
                        else if (p2.X < 5 && p2.Y >= this.Height - 5)
                            m.Result = (IntPtr)0x10;
                        //HTBOTTOMLEFT=16 <0x10>
                        else if (p2.X > this.Width - 5 && p2.Y >= this.Height - 5)
                            m.Result = (IntPtr)0x11;
                        if ((int)m.Result == HTCLIENT)
                            m.Result = (IntPtr)HTCAPTION;                        
                    }
                    return;              
                default:
                    base.WndProc(ref m);
                    return;
            }
        }
     
        // 重载基类的背景擦除函数，解决窗口刷新，放大，图像闪烁      
        protected override void OnPaintBackground(PaintEventArgs e)
        {          
            return;
        }

        // 重载基类的OnPaint事件，使用双缓冲，背景重绘移动到拉伸位置       
        protected override void OnPaint(PaintEventArgs e)
        {           
            this.DoubleBuffered = true;           
            if (this.BackgroundImage != null)
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                e.Graphics.DrawImage(
                    this.BackgroundImage,
                    new Rectangle(0, 0, this.Width, this.Height),
                    0,
                    0,
                    this.BackgroundImage.Width,
                    this.BackgroundImage.Height,
                    GraphicsUnit.Pixel);
            }
            base.OnPaint(e);
        }

        #endregion      



        private UserControl1 userControl1;
        private UserControl2 userControl2;
        private UserControl3 userControl3;
        private void button1_Click(object sender, EventArgs e)
        {
            userControl1.Show();
            userControl1.Dock=DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl2.Show();
            userControl2.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl3.Show();
            userControl3.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl3);
        }

        private void NewForm_Load(object sender, EventArgs e)
        {
            userControl1 = new UserControl1();
            userControl2 = new UserControl2();
            userControl3 = new UserControl3();
        }
    }
}
