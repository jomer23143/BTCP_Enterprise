using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTCP_Enterprise.Class;
using BTCP_Enterprise.Forms;
using BTCP_Enterprise.ProcessForm;

namespace BTCP_Enterprise.Modal
{
    public partial class Scanner : Form
    {
        public string serialnumber;
        public string id;
        public string processname;
        public string moid;
        public string segment;
        private Sub_assyfrm mysubass;
        public Scanner( string id, string processname, string moid, string segement, Sub_assyfrm subform)
        {
            InitializeComponent();
            mysubass = subform;
            this.StartPosition = FormStartPosition.CenterScreen;
            Corners corners = new Corners();
            corners.RoundedFormsDocker(this, 8);
            txt_serialnumber.TextAlign = HorizontalAlignment.Center;
            btn_cancel.TextAlign = ContentAlignment.MiddleCenter;
            txt_serialnumber.Select();
         
            this.id = id;
            this.processname = processname;
            this.moid = moid;
            this.segment = segement;
        }

        private void Scanner_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            mysubass.qrcodecontroller();
            mysubass.response();
            this.Close();

        }

        //private void imagechangeAsync()
        //{
        //    // ✅ Default image setup
        //    string defaultImagePath = Path.Combine(Application.StartupPath, "Assets", "scanneddone.gif");
        //    string imagePath = defaultImagePath;  // No image found in response

        //    pbimage.Image = File.Exists(imagePath) ? Image.FromFile(imagePath) : null;

          
        //}

        private async void txt_serialnumber_TextChange(object sender, EventArgs e)
        {
       
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Resources/scanneddone.gif");

            if (File.Exists(path))
            {
                using (var img = new Bitmap(path))
                {
                    pbimage.Image?.Dispose(); 
                    pbimage.Image = new Bitmap(img);
                }
            }
            await Task.Delay(1000);
            mysubass.qrcodecontroller();
            mysubass.response();
            this.Close();
            MainDashboard mainDashboard = (MainDashboard)Application.OpenForms["MainDashboard"];
            string serialnumber = txt_serialnumber.Text;
            string mo = moid;
            string toplvlipn = moid;
            string station = processname;
            //ProcessForm.Sub_assyfrm subasy = new ProcessForm.Sub_assyfrm(mo,serialnumber,toplvlipn,segment,station);
            //mainDashboard.LoadChildForm(subasy);

        }

    }
}
