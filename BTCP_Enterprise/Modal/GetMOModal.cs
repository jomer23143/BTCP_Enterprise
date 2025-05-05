using System;
using System.Drawing;
using System.Windows.Forms;
using BTCP_Enterprise.Class;
using BTCP_Enterprise.Forms;

namespace BTCP_Enterprise.Modal
{
    public partial class GetMOModal : Form
    {
        public event Action<string> SerialScanned;

        public GetMOModal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            btn_cancel.TextAlign = ContentAlignment.MiddleCenter;
            Corners corners = new Corners();
            corners.RoundedFormsDocker(this, 8);
        }

        private void GetMOModal_Load(object sender, EventArgs e)
        {


        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            MainDashboard main = new MainDashboard();
            this.Close();
            main.FormBorderStyle = FormBorderStyle.None;
        }







        private void txt_serial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SerialScanned?.Invoke(txt_serial.Text);
                this.Close();

            }
        }
    }
}
