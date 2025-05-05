using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BTCP_Enterprise.Class;
using BTCP_Enterprise.Modal;



namespace BTCP_Enterprise.Forms
{
    public partial class MainDashboard : Form
    {
        // private readonly string PROJECT_LATEST_VERSIONS_FOLDER = @"C:\Users\GlynnDelaCruz\Desktop\BTCP_Enterprise Test Location";
        //   private readonly string PROJECT_CURRENT_VERSIONS_FOLDER = @"C:\BTC-IT Application\BTCP_Enterprise Desktop";
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
            this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            btn_logout.TextAlign = ContentAlignment.MiddleCenter;
            formManager = new FormManager(panel_menubar, panel_sidebar);
            this.Padding = new Padding(borderSize);
            realTimeClock();


        }


        #region
        //private void checkUpadate()
        //{
        //    try
        //    {
        //        string currentVersionPath = Path.Combine(PROJECT_CURRENT_VERSIONS_FOLDER, "Version.ini");
        //        string latestVersionPath = Path.Combine(PROJECT_LATEST_VERSIONS_FOLDER, "Version.ini");

        //      //  Console.WriteLine($"Current Version Path: {currentVersionPath}");
        //      //  Console.WriteLine($"Latest Version Path: {latestVersionPath}");
        //        Console.WriteLine($"File.Exists current: {File.Exists(currentVersionPath)}");
        //        Console.WriteLine($"File.Exists latest: {File.Exists(latestVersionPath)}");


        //        if (File.Exists(currentVersionPath) && File.Exists(latestVersionPath))
        //        {
        //            string currentVersion = File.ReadAllText(currentVersionPath).Replace("v", "").Trim();
        //            string latestVersion = File.ReadAllText(latestVersionPath).Replace("v", "").Trim();

        //            Console.WriteLine($"Current Version: '{currentVersion}'");
        //            Console.WriteLine($"Latest Version: '{latestVersion}'");

        //            if (currentVersion != latestVersion)
        //            {
        //                Console.WriteLine("Update available!");
        //                Lbl_versionControl.Text = $"Update available: Current V{currentVersion}, Latest V{latestVersion}";
        //                PromptForUpdate(latestVersion);
        //            }
        //            else
        //            {
        //                Console.WriteLine("App is up to date.");
        //                Lbl_versionControl.Text = $"App V{currentVersion} .";
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Version files missing.");
        //            Lbl_versionControl.Text = "Version files missing.";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error: " + ex.Message);
        //        Lbl_versionControl.Text = $"Error checking version: {ex.Message}";
        //    }
        //}


        //private void PromptForUpdate(string latestVersion)
        //{
        //    DialogResult result = MessageBox.Show(
        //        $"A new version (V{latestVersion}) is available. Do you want to update now?",
        //        "Update Available",
        //        MessageBoxButtons.YesNo,
        //        MessageBoxIcon.Information
        //    );

        //    if (result == DialogResult.Yes)
        //    {
        //        //    Start update logic
        //     //   StartUpdate();
        //    }
        //}
        #endregion
        //private void StartUpdate()
        //{
        //    try
        //    {
        //        // Ensure the latest version folder exists
        //        if (!Directory.Exists(PROJECT_LATEST_VERSIONS_FOLDER))
        //        {
        //            Directory.CreateDirectory(PROJECT_LATEST_VERSIONS_FOLDER);
        //            MessageBox.Show("Created missing latest version folder.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }

        //        // Verify the current installation folder exists
        //        if (!Directory.Exists(PROJECT_CURRENT_VERSIONS_FOLDER))
        //        {
        //            Directory.CreateDirectory(PROJECT_CURRENT_VERSIONS_FOLDER);
        //        }

        //        // Copy all files from latest to current (overwrite if needed)
        //        string[] files = Directory.GetFiles(PROJECT_LATEST_VERSIONS_FOLDER);
        //        foreach (string file in files)
        //        {
        //            string fileName = Path.GetFileName(file);
        //            string destFile = Path.Combine(PROJECT_CURRENT_VERSIONS_FOLDER, fileName);
        //            File.Copy(file, destFile, overwrite: true); // Overwrites existing files
        //        }

        //        // Update version.ini in current folder to match latest
        //        string latestVersionPath = Path.Combine(PROJECT_LATEST_VERSIONS_FOLDER, "Version.ini");
        //        string currentVersionPath = Path.Combine(PROJECT_CURRENT_VERSIONS_FOLDER, "Version.ini");
        //        if (File.Exists(latestVersionPath))
        //        {
        //            File.Copy(latestVersionPath, currentVersionPath, overwrite: true);
        //        }

        //        MessageBox.Show("Update completed successfully! Restart the application.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        Application.Restart(); // Graceful restart
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Update failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void CopyDirectory(string sourceDir, string targetDir)
        //{
        //    Directory.CreateDirectory(targetDir);
        //    foreach (string file in Directory.GetFiles(sourceDir))
        //    {
        //        File.Copy(file, Path.Combine(targetDir, Path.GetFileName(file)), overwrite: true);
        //    }
        //    foreach (string dir in Directory.GetDirectories(sourceDir))
        //    {
        //        CopyDirectory(dir, Path.Combine(targetDir, Path.GetFileName(dir)));
        //    }
        //}




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

        }

        private void btn_warehousekiting_Click(object sender, EventArgs e)
        {
            if (this.panel_main_form.Controls.Count > 0)
                this.panel_main_form.Controls.Clear();

            if (this.panel_sidebar.Controls.Count > 0)
                this.panel_sidebar.Controls.Clear();
            formManager.OpenChildForm(new SideBar.WarehouseKitingSidebar(), sender);
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





        #region
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
        #endregion
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
        #endregion


        private void btn_processflow_Click(object sender, EventArgs e)
        {
            if (this.panel_main_form.Controls.Count > 0)
                this.panel_main_form.Controls.Clear();
            if (this.panel_sidebar.Controls.Count > 0)
                this.panel_sidebar.Controls.Clear();

            Modal.GetMOModal getmo = new Modal.GetMOModal();
            var scannedMO = string.Empty;
            object[] responsedata;
            string boomid = string.Empty;
            // Create an instance of GetBoomItem
            GetBoomItem getBoomItemInstance = new GetBoomItem();

            // Subscribe to event
            getmo.SerialScanned += async (serial) =>
            {
                scannedMO = Convert.ToString(serial);
                responsedata = await getBoomItemInstance.getBoomID(scannedMO);
                Console.WriteLine($"Boom ID: {responsedata[0]}");
                if (responsedata.Length > 0)
                {
                    boomid = responsedata[0].ToString();
                }
                Console.WriteLine($"Boom Data Pass:", boomid);
                Forms.ProductionSegmentFrm prdsegment = new Forms.ProductionSegmentFrm(boomid);
                prdsegment.TopLevel = false;
                this.FormBorderStyle = FormBorderStyle.None;
                prdsegment.Dock = DockStyle.Fill;

                MainDashboard mainDashboard = (MainDashboard)Application.OpenForms["MainDashboard"];
                mainDashboard.LoadChildForm(prdsegment);

            };
            this.FormBorderStyle = FormBorderStyle.None;
            getmo.ShowDialog(this);

        }

        private void btn_template_Click(object sender, EventArgs e)
        {
            if (this.panel_main_form.Controls.Count > 0)
                this.panel_main_form.Controls.Clear();
            if (this.panel_sidebar.Controls.Count > 0)
                this.panel_sidebar.Controls.Clear();

            MainDashboard mainDashboard = (MainDashboard)Application.OpenForms["MainDashboard"];
            Forms.TemplateFrm template = new Forms.TemplateFrm();
            mainDashboard.LoadChildForm(template);
        }


    }
}

