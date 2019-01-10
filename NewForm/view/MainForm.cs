using NewForm.view.userControl;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MonoTorrent.BEncoding;
using MonoTorrent.Common;
using MonoTorrent.Client;
using MonoTorrent.Client.Encryption;
using MonoTorrent.Client.Tracker;
using MonoTorrent.Dht;
using MonoTorrent.Dht.Listeners;
using MonoTorrent;
using System.IO;
using System.Net;

namespace NewForm
{
    public partial class MainForm : Form
    {
        # region 字段及属性,enum

        private const int WM_NCLBUTTONDBLCLK = 163;
        private const int WM_NCHITTEST = 132;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        bool formMove = false;
        Point formPoint ;

        private enum FormMove
        {
            MouseDown,
            MouseMove,
            MouseUp
        }
        #endregion
       
        #region 初始化

        public MainForm()
        {
            InitializeComponent();            
            InitializeParam();
        }

        private void NewForm_Load(object sender, EventArgs e)
        {
            AllSplitContainer.SplitterDistance = Allpanel.Width/2-20;       
        }

        private void InitializeParam()
        {
            this.StartPosition= FormStartPosition.CenterScreen;   
        }
        #endregion

        #region 窗体移动，关闭，缩小，放大
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
                MaxMizeBox.BackgroundImage = Image.FromFile(fullName + @"\Resources\maxForm.png");
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                string fullName = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\bin"));
                MaxMizeBox.BackgroundImage = Image.FromFile(fullName + @"\Resources\minFrom.png");
            }
        }

        private void CloseBox_MouseHover(object sender, EventArgs e)
        {          
            this.Close();
        }
      
        private void searchpictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            string fullName = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\bin"));
            searchpictureBox.BackgroundImage = Image.FromFile(fullName + @"\Resources\search.png");
        }

        private void searchpictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            string fullName = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\bin"));
            searchpictureBox.BackgroundImage = Image.FromFile(fullName + @"\Resources\w_search.png");
        }

        private void TitletableLayoutPanel_DoubleClick(object sender, EventArgs e)
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

        private void TitletableLayoutPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(FormMove.MouseDown.ToString(), e);
        }

        private void TitletableLayoutPanel_MouseMove(object sender, MouseEventArgs e)
        {
            MoveForm(FormMove.MouseMove.ToString(), e);
        }

        private void TitletableLayoutPanel_MouseUp(object sender, MouseEventArgs e)
        {
            MoveForm(FormMove.MouseUp.ToString(), e);
        }  

        private void MoveForm(string mouseAction, MouseEventArgs e)
        {
            if (mouseAction == FormMove.MouseDown.ToString())
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
            else if (mouseAction == FormMove.MouseMove.ToString())
            {
                if (formMove == true)
                {
                    Point mousePos = Control.MousePosition;
                    mousePos.Offset(formPoint.X, formPoint.Y);
                    Location = mousePos;
                }            
            }
            else if (mouseAction == FormMove.MouseUp.ToString())
            {
                if (e.Button == MouseButtons.Left)
                {
                    formMove = false;
                }
            }    
        }

        private void ClosetableLayoutPanel_MouseEnter(object sender, EventArgs e)
        {
            Closepanel.BackColor = Color.Red;
        }

        private void ClosetableLayoutPanel_MouseLeave(object sender, EventArgs e)
        {
            Closepanel.BackColor = Color.FromArgb(27, 45, 83);
        }

        private void MinitableLayoutPanel_MouseEnter(object sender, EventArgs e)
        {
            Minipanel.BackColor = Color.FromArgb(0, 60, 108);
        }

        private void MinitableLayoutPanel_MouseLeave(object sender, EventArgs e)
        {
            Minipanel.BackColor = Color.FromArgb(27, 45, 83);
        }

        private void MaxMitableLayoutPanel_MouseEnter(object sender, EventArgs e)
        {
            MaxMipanel.BackColor = Color.FromArgb(0, 60, 108);
        }

        private void MaxMitableLayoutPanel_MouseLeave(object sender, EventArgs e)
        {
            MaxMipanel.BackColor = Color.FromArgb(27, 45, 83);
        }
        #endregion

        #region 窗体拉伸放大与缩小
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCLBUTTONDBLCLK:
                    if (this.MaximizeBox)
                    {
                        base.WndProc(ref m);
                        this.Invalidate();
                    }
                    return;
                case WM_NCHITTEST:
                    base.WndProc(ref m);   
                    if (WindowState != FormWindowState.Maximized)
                    {
                        Point p2 = this.PointToClient(MousePosition);                
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
        #endregion

        #region 左侧菜单栏事件
        private void VDuslControl_Click(object sender, EventArgs e)
        {
            SetMenuActive(VDuslControl, false);
        }

        private void STuslControl_Click(object sender, EventArgs e)
        {
            SetMenuActive(STuslControl, true);
        }

        private void BKuslControl_Click(object sender, EventArgs e)
        {
            SetMenuActive(BKuslControl, false);
        }

        private void MSuslControl_Click(object sender, EventArgs e)
        {
            SetMenuActive(MSuslControl, false);
        }

        private void SetMenuActive(USLControl uSLControl, bool isST)
        {
            uSLControl.IsActive = true;
            uSLControl.SetBackColor = Color.FromArgb(0, 60, 108);
            if (isST == true)
            {
                uSLControl.SetActive = Color.FromArgb(0, 60, 108);
            }
            else
            {
                uSLControl.SetActive = Color.White;
            }

            foreach (Control control in LEFTtableLayoutPanel.Controls)
            {
                if (control is USLControl && !control.Equals(uSLControl))
                {
                    USLControl uslControl = (USLControl)control;
                    if (uslControl.IsActive == true)
                    {
                        uslControl.SetActive = LEFTpanel.BackColor;
                        uslControl.IsActive = false;
                        uslControl.SetBackColor = LEFTpanel.BackColor;
                    }
                }
            }
        }

        private void VDuslControl_MouseEnter(object sender, EventArgs e)
        {
            SetMenuHover(VDuslControl, true);
        }

        private void VDuslControl_MouseLeave(object sender, EventArgs e)
        {
            SetMenuHover(VDuslControl, false);
            
        }

        private void MSuslControl_MouseEnter(object sender, EventArgs e)
        {
            SetMenuHover(MSuslControl, true);
        }

        private void MSuslControl_MouseLeave(object sender, EventArgs e)
        {
            SetMenuHover(MSuslControl, false);
        }

        private void BKuslControl_MouseEnter(object sender, EventArgs e)
        {
            SetMenuHover(BKuslControl, true);
        }

        private void BKuslControl_MouseLeave(object sender, EventArgs e)
        {
            SetMenuHover(BKuslControl, false);
        }

        private void STuslControl_MouseEnter(object sender, EventArgs e)
        {
            SetMenuHover(STuslControl, true);
        }

        private void STuslControl_MouseLeave(object sender, EventArgs e)
        {
            SetMenuHover(STuslControl, false);
        }

        private void SetMenuHover(USLControl uSLControl, bool isEnter)
        {
            if (uSLControl.IsActive != true)
            {
                if (isEnter == true)
                {
                    uSLControl.BackColor = Color.FromArgb(0, 60, 108);
                    uSLControl.SetActive = Color.FromArgb(0, 60, 108);
                }
                else
                {
                    uSLControl.BackColor = LEFTpanel.BackColor;
                    uSLControl.SetActive = LEFTpanel.BackColor;
                }
            }
        }








        #endregion

        private void searchpictureBox_Click(object sender, EventArgs e)
        {
            string magnet = searchtextBox.Text.ToString().Trim();
            MagnetLink link = new MagnetLink(magnet);
            EngineSettings settings = new EngineSettings
            {
                AllowedEncryption = EncryptionTypes.All,
                SavePath = Path.Combine(Environment.CurrentDirectory, "Downloads")
            };

            string torrentFilePath = Path.Combine(Environment.CurrentDirectory, "TorrentFiles");
            if (!Directory.Exists(settings.SavePath))
                Directory.CreateDirectory(settings.SavePath);

            if (!Directory.Exists(torrentFilePath))
                Directory.CreateDirectory(torrentFilePath);

            //Create a new engine, give it some settings and use it.
            ClientEngine engine = new ClientEngine(settings);
            engine.ChangeListenEndpoint(new IPEndPoint(IPAddress.Any, 6969));

            TorrentManager manager = new TorrentManager(link, engine.Settings.SavePath, new TorrentSettings(), torrentFilePath);
            engine.Register(manager);
            manager.Start();
        }
    }
}
