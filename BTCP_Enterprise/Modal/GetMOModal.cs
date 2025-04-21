using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTCP_Enterprise.Class;

namespace BTCP_Enterprise.Modal
{
    public partial class GetMOModal : Form
    {
        public event Action<string> SerialScanned; // Event for scanned serial

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
            this.Close();
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            SerialScanned?.Invoke(txt_serial.Text);
            this.Close();
        }
    }
}
