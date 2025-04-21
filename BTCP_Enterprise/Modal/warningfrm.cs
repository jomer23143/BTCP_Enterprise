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
    public partial class warningfrm : Form
    {
        public warningfrm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            Corners corners = new Corners();
            corners.RoundedFormsDocker(this, 8);

        }

        private void warningfrm_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
