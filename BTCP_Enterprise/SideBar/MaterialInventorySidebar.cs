using BTCP_Enterprise.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTCP_Enterprise.SideBar
{
    public partial class MaterialInventorySidebar : Form
    {
        string modulename = "Material Inventory";
        string type;
        public MaterialInventorySidebar()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            btn_kitlist.TextAlign = ContentAlignment.MiddleCenter;
            btn_ncticket.TextAlign = ContentAlignment.MiddleCenter;
            btn_abi.TextAlign = ContentAlignment.MiddleCenter;

        }

        private void MaterialInventorySidebar_Load(object sender, EventArgs e)
        {

        }

        private void btn_kitlist_Click(object sender, EventArgs e)
        {
            //Forms.Login login = new Forms.Login(modulename,type);
            //login.Show();
            MainDashboard mainDashboard = (MainDashboard)Application.OpenForms["MainDashboard"];
            Forms.Kitlist kitlist = new Forms.Kitlist();
            mainDashboard.LoadChildForm(kitlist);
        }
    }
}
