using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTCP_Enterprise.Class;
namespace BTCP_Enterprise.Modal
{
    public partial class CustomeAlert : Form
    {
        
        public enum Alertype
        {
            Success,
            Warning,
            confirm,
            Logout
        }
        public CustomeAlert(string Atitle,string message, Alertype type)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Corners corners = new Corners();
            corners.RoundedFormsDocker(this, 8);
            lbl_alertTitle.Text = Atitle;
            lblMessage.Text = message;
            CustomizeAlert(type);
        }


             private void CustomizeAlert(Alertype type)
        {
            switch (type)
            {
                case Alertype.Success:
                   // this.BackColor = Color.FromArgb(72, 201, 176); // Green
                   this.BackColor = Color.White;
                    string defaultImagePath = Path.Combine(Application.StartupPath, "Resources", "success_icon.png");
                    string imagePath = defaultImagePath;  // No image found in response
                    picIcon.Image = File.Exists(imagePath) ? Image.FromFile(imagePath) : null;
                    break;
                case Alertype.Warning:
                    // this.BackColor = Color.FromArgb(241, 196, 15); // Yellow
                    this.BackColor = Color.White;
                    string wariningIcon = Path.Combine(Application.StartupPath, "Resources", "warning_icon.png");
                    string IconPath = wariningIcon;  // No image found in response
                    picIcon.Image = File.Exists(IconPath) ? Image.FromFile(IconPath) : null;
                    break;

                case Alertype.confirm:
                   // this.BackColor = Color.FromArgb(231, 76, 60); // Red
                    this.BackColor = Color.White;
                    string confirmIcon = Path.Combine(Application.StartupPath, "Resources", "confirm_icon.png");
                    string CiconPath = confirmIcon;  // No image found in response
                    picIcon.Image = File.Exists(CiconPath) ? Image.FromFile(CiconPath) : null;
                    break;

                case Alertype.Logout:
                   // this.BackColor = Color.FromArgb(231, 76, 60); // Red
                    this.BackColor = Color.White;
                    string LogoutIcon = Path.Combine(Application.StartupPath, "Resources", "logout_icon.png");
                    string LiconPath = LogoutIcon;  // No image found in response
                    picIcon.Image = File.Exists(LiconPath) ? Image.FromFile(LiconPath) : null;

                    break;
            }
            this.Opacity = 0;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick_1;
            timer1.Start();
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            else timer1.Stop();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
