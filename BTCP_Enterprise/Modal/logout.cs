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
    public partial class logout : Form
    {
        public logout()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Corners corners = new Corners();
            corners.RoundedFormsDocker(this, 8);
            btn_no.TextAlign = ContentAlignment.MiddleCenter;
            btn_yes.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void logout_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
