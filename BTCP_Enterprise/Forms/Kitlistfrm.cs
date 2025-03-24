using BTCP_Enterprise.Class;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTCP_Enterprise.Forms
{
    public partial class Kitlistfrm: Form
    {
        private Dictionary<String, Dictionary<String, String>> dbConnectionSettings = new Dictionary<String, Dictionary<String, String>>();
        public Point downPoint = Point.Empty;
        public Kitlistfrm()
        {
            InitializeComponent();
        }
        private void Kitlistfrm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = new Point(e.X, e.Y);
        }

        private void Kitlistfrm_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint != Point.Empty)
                Location = new Point(Left + e.X - downPoint.X, Top + e.Y - downPoint.Y);
        }

        private void Kitlistfrm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = Point.Empty;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint != Point.Empty)
                Location = new Point(Left + e.X - downPoint.X, Top + e.Y - downPoint.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = Point.Empty;
        }

        private void Kitlistfrm_Load(object sender, EventArgs e)
        {
            Connection.InitializeConnection();
            dbConnectionSettings = Utils.DBConnection;
        }
        DataTable dtMoDetails = new DataTable();
        DataTable dtMoHeader = new DataTable();
        private async  void txtmo_number_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dtMoHeader = new DataTable();
                DataTable dtMoDetails = new DataTable();
                txtmo_number.Focus();
                await Task.Run(() =>
                {
                    dtMoHeader = KitList.GetMoh(txtmo_number.Text);
                    dtMoDetails = KitList.GetMoDetails(txtmo_number.Text);
                });
                dataGridView1.DataSource = dtMoDetails;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            dtMoHeader = KitList.GetMoh(txtmo_number.Text);
            dtMoDetails = KitList.GetMoDetails(txtmo_number.Text);
            object res = JsonConvert.SerializeObject(dtMoDetails);
            List<Model.kitlist.item> item = (List<Model.kitlist.item>)JsonConvert.DeserializeObject(res.ToString(),typeof(List<Model.kitlist.item>));
            
            Model.kitlist.manufacturing_order man = new Model.kitlist.manufacturing_order
            {
                mo_id = dtMoHeader.Rows[0][0].ToString(),
                pcn_number = dtMoHeader.Rows[0][1].ToString(),
                description = dtMoHeader.Rows[0][2].ToString(),
                location = dtMoHeader.Rows[0][3].ToString(),
                bom_item = dtMoHeader.Rows[0][4].ToString(),
                bom_revision_number = dtMoHeader.Rows[0][5].ToString(),
                order_quantity = dtMoHeader.Rows[0][6].ToString(),
                order_date = dtMoHeader.Rows[0][7].ToString(),
                kit_date = dtMoHeader.Rows[0][8].ToString(),
                start_date = dtMoHeader.Rows[0][9].ToString(),
                end_date = dtMoHeader.Rows[0][10].ToString(),
                manufacturing_order_items = item

            };
           
            string res1 = JsonConvert.SerializeObject(man);
            //string res =  await Utilities.WebRequestApi.PostData("https://app.btcp-enterprise.com/api/manufacturing-order",res1);
            string res3 = await Utilities.WebRequestApi.PostData_httpclient("https://app.btcp-enterprise.com/api/manufacturing-order", res1);
            string res2 = await Utilities.WebRequestApi.GetData_httpclient("https://app.btcp-enterprise.com/api/manufacturing-order");
            Model.kitlist.manufacturing_order data = JsonConvert.DeserializeObject<Model.kitlist.manufacturing_order>(res2);
            dataGridView1.DataSource = res2;
        }
    }

}
