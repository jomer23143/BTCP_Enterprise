using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTCP_Enterprise.Forms;

namespace BTCP_Enterprise.SideBar
{
    public partial class WarehouseKitingSidebar : Form
    {
        string modulename = "Material Inventory";
        string type;
        public WarehouseKitingSidebar()
        {
            InitializeComponent();
        }

        private void btn_ncticket_Click(object sender, EventArgs e)
        {
            Forms.TestForm s1frm = new Forms.TestForm();
            MainDashboard mainDashboard = (MainDashboard)Application.OpenForms["MainDashboard"];
            mainDashboard.LoadChildForm(s1frm);
        }

        private void btn_kitlist_Click(object sender, EventArgs e)
        {
            Forms.Login login = new Forms.Login(modulename, type);
            login.Show();
        }
    }
}
