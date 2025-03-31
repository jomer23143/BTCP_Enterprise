using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTCP_Enterprise.Class;

namespace BTCP_Enterprise.Forms
{
    public partial class MainDashboard : Form
    {
        private FormManager formManager;

        public MainDashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            formManager = new FormManager(panel_menubar, panel_sidebar);

            DateTime localDate = DateTime.Now;
            DateTime utcDate = DateTime.UtcNow;
            String[] cultureNames = { "en-US", "en-GB", "fr-FR",
                                "de-DE", "ru-RU" };

            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
                Console.WriteLine("{0}:", culture.NativeName);
                Console.WriteLine("   Local date and time: {0}, {1:G}",localDate.ToString(culture), localDate.Kind);
                lbl_time.Text = localDate.ToString(culture);
                Console.WriteLine("   UTC date and time: {0}, {1:G}\n",
                                  utcDate.ToString(culture), utcDate.Kind);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            DragDropForm.ReleaseCapture();
            DragDropForm.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


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





        private void MainDashboard_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 1 second
            timer1.Tick += timer1_Tick;
            timer1.Start();
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
            if (this.panel_main_form.Controls.Count > 0)
                this.panel_main_form.Controls.Clear(); 
            formManager.OpenChildForm(new SideBar.PreAss_Sidebar(), sender);
        }

        private void btn_warehousekiting_Click(object sender, EventArgs e)
        {
            if (this.panel_main_form.Controls.Count > 0)
                this.panel_main_form.Controls.Clear();
            formManager.OpenChildForm(new SideBar.WarehouseKitingSidebar(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }
            
      

    }
    }

