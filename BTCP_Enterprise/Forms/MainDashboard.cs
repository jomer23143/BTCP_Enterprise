using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTCP_Enterprise.Class;
using BTCP_Enterprise.Modal;
using BTCP_Enterprise.Model;
using LiveChartsCore;
using Newtonsoft.Json;
using SkiaSharp;



namespace BTCP_Enterprise.Forms
{
    public partial class MainDashboard : Form
    {
        private FormManager formManager;
        //Fields
        private int borderSize = 2;
        private Size formSize;

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public MainDashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            btn_logout.TextAlign = ContentAlignment.MiddleCenter;
            formManager = new FormManager(panel_menubar, panel_sidebar);
            this.Padding = new Padding(borderSize);

            realTimeClock();

        }

        private void realTimeClock()
        {
            DateTime localDate = DateTime.Now;
            DateTime utcDate = DateTime.UtcNow;
            String[] cultureNames = { "en-US", "en-GB", "fr-FR",
                                "de-DE", "ru-RU" };

            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);  
                lbl_time.Text = localDate.ToString(culture);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            DragDropForm.ReleaseCapture();
            DragDropForm.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //this is for load main form
        public void LoadChildForm(Form childForm)
        {
            if (this.panel_main_form.Controls.Count > 0)
                this.panel_main_form.Controls.Clear(); // Remove existing controls

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_main_form.Controls.Add(childForm);
            this.panel_main_form.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //this is for load sidebar form
        public void LoadSideBar(Form Sidbar)
        {
            if (this.panel_sidebar.Controls.Count > 0)
                this.panel_sidebar.Controls.Clear(); // Remove existing controls

            Sidbar.TopLevel = false;
            Sidbar.FormBorderStyle = FormBorderStyle.None;
            Sidbar.Dock = DockStyle.Fill;
            this.panel_sidebar.Controls.Add(Sidbar);
            this.panel_sidebar.Tag = Sidbar;
            Sidbar.BringToFront();
            Sidbar.Show();
        }




        private void MainDashboard_Load(object sender, EventArgs e)
        {
            formSize = this.ClientSize;

            timer1.Interval = 1000; // 1 second
            timer1.Tick += timer1_Tick;
            timer1.Start();

        
            string apiUrl = "https://app.btcp-enterprise.com/api/kit-list-item"; 
     
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("hh:mm tt").ToUpper(); 
            lbl_currentdate.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy");
        }

        private void btn_material_recieving_Click(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modal.GetMOModal getmo = new Modal.GetMOModal();
            var scannedMO = string.Empty;
            // Subscribe to event
            getmo.SerialScanned += (serial) =>
            {

                scannedMO = serial; 
                
            };

           getmo.ShowDialog();

            if (this.panel_main_form.Controls.Count > 0)
                this.panel_main_form.Controls.Clear();
            formManager.OpenChildForm(new SideBar.PreAss_Sidebar(scannedMO), sender);
        }

        private void btn_warehousekiting_Click(object sender, EventArgs e)
        {
            if (this.panel_main_form.Controls.Count > 0)
                this.panel_main_form.Controls.Clear();
            formManager.OpenChildForm(new SideBar.WarehouseKitingSidebar(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modal.GetMOModal getmo = new Modal.GetMOModal();
            var scannedMO = string.Empty;
            // Subscribe to event
            getmo.SerialScanned += (serial) =>
            {

                scannedMO = serial;

            };

            getmo.ShowDialog();

            if (this.panel_main_form.Controls.Count > 0)
                this.panel_main_form.Controls.Clear();
            formManager.OpenChildForm(new SideBar.SubAssy_Sidebar(scannedMO), sender);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Modal.logout logout = new Modal.logout();
            logout.ShowDialog();
        }

        private void MainDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
           

        }


        //private void ViewChar()
        //{
        //   DataTable chartData = chartDataHelper.FetchChartData();
        //    Panel_Graph.Controls.Clear();

        //    var descriptions = chartData.AsEnumerable().Select(row => row.Field<string>("section")).ToArray();
        //    var counts = chartData.AsEnumerable().Select(row => (int)row.Field<long>("totalcount")).ToArray();

        //    var cartesianChart = new LiveCharts.WinForms.CartesianChart
        //    {
        //        Dock = DockStyle.Fill,
        //        AxisX = {
        //    new LiveCharts.Wpf.Axis
        //    {
        //        Title = "Section",
        //        Labels = descriptions
        //    }
        //},
        //        AxisY = {
        //    new LiveCharts.Wpf.Axis
        //    {
        //        Title = "Total Count"
        //    }
        //},
        //        Series = new LiveCharts.SeriesCollection
        //{
        //    new LiveCharts.Wpf.ColumnSeries
        //    {
        //        Title = "Total",
        //        Values = new LiveCharts.ChartValues<int>(counts)
        //    }
        //}
        //    };

        //    Panel_Graph.Controls.Add(cartesianChart);
        //}

        public class Root
        {
            public int current_page { get; set; }
            public List<KitItem> data { get; set; }
            // Add other properties if needed
        }

        public class KitItem
        {
            public int id { get; set; }
            public string mo_id { get; set; }
            public string item_number { get; set; }
            public List<Serial> serial { get; set; }
            public Status status { get; set; }
            // Add other fields as needed
        }

        public class Serial
        {
            public int id { get; set; }
            public int kit_list_item_id { get; set; }
            public string mo_id { get; set; } 
            public string kit_list_part_serial_number { get; set; }
            public bool is_scan { get; set; }
            public DateTime created_at { get; set; }
        }


        public class Status
        {
            public int id { get; set; }
            public string name { get; set; }
            public string color { get; set; }
        }
        public class SerialWithMO
        {
            public int id { get; set; }
            public int kit_list_item_id { get; set; }
            public string kit_list_part_serial_number { get; set; }
            public int is_scan { get; set; }
            public string created_at { get; set; }
            public string mo_id { get; set; } // Include mo_id here
        }

  

      


        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; 
            const int SC_RESTORE = 0xF120; 
            const int WM_NCHITTEST = 0x0084;
            const int resizeAreaSize = 10;

            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1;
            const int HTLEFT = 10; 
            const int HTRIGHT = 11;
            const int HTTOP = 12;   
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15; 
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;

            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)
                {
                    if ((int)m.Result == HTCLIENT)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());                           
                        Point clientPoint = this.PointToClient(screenPoint);                        

                        if (clientPoint.Y <= resizeAreaSize)
                        {
                            if (clientPoint.X <= resizeAreaSize) 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) 
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

           
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

       
            if (m.Msg == WM_SYSCOMMAND)
            {
               
                int wParam = (m.WParam.ToInt32() & 0xFFF0);

                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        //Private methods
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void CollapseMenu()
        {
            if (this.panel_menubar.Width > 200) //Collapse menu
            {
                panel_menubar.Width = 100;
                pictureBox1.Visible = false;
               // btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panel_menubar.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                panel_menubar.Width = 230;
                pictureBox1.Visible = true;
               // btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panel_menubar.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }


        protected override void OnResize(EventArgs e)
        {
            // base.OnResize(e);
            AdjustForm();
            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.Size;
            }
        }


        private void MainDashboard_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void btn_processflow_Click(object sender, EventArgs e)
        {
            if (this.panel_main_form.Controls.Count > 0)
                this.panel_main_form.Controls.Clear();
            if (this.panel_sidebar.Controls.Count > 0)
                this.panel_sidebar.Controls.Clear();
            Modal.GetMOModal getmo = new Modal.GetMOModal();
            var scannedMO = string.Empty;
            // Subscribe to event
            getmo.SerialScanned += (serial) =>
            {

                scannedMO = serial;

            };
            getmo.ShowDialog();
            MainDashboard mainDashboard = (MainDashboard)Application.OpenForms["MainDashboard"];
            string processId = string.Empty;
            string moid = string.Empty;
            Forms.ProductionSegmentFrm prdsegment = new Forms.ProductionSegmentFrm(moid);
            mainDashboard.LoadChildForm(prdsegment);

        }
    }
}

