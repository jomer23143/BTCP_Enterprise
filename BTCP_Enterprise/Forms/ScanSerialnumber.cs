using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTCP_Enterprise.Forms
{
    public partial class ScanSerialnumber: Form
    {
        Forms.Kitlistfrm Kitlistfrm;
        string id = "";
        public ScanSerialnumber(Kitlistfrm kitlist)
        {
            InitializeComponent();
            this.Kitlistfrm = kitlist;
        }

        private void ScanSerialnumber_Load(object sender, EventArgs e)
        {
            id = Forms.Kitlistfrm.kit_list_item_id.ToString();
            label1.Text = string.Format("IPN : {0}", Forms.Kitlistfrm.kit_list_item_ipn);
            label5.Text = string.Format("0 out of {0}", Forms.Kitlistfrm.total_pick_quantity);
            dgSerialnumber.DataSource = Forms.Kitlistfrm.list_serial;
            is_scan_initialize_datagridviewrows();
            txtserial_number.Focus();
        }
        private void is_scan_initialize_datagridviewrows()
        {
            for (int currenrow = 0; currenrow < dgSerialnumber.Rows.Count; currenrow++)
            {
                if (dgSerialnumber.Rows[currenrow].Cells[coliscan.Name].Value.ToString() == "1")
                {
                    dgSerialnumber.Rows[currenrow].Cells[colscan.Name].Value = 1;
                }
                else
                {
                    dgSerialnumber.Rows[currenrow].Cells[colscan.Name].Value = 0;
                }
            }
        }
        int scan_qty = 0;
        private void txtserial_number_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (DataGridViewRow row in dgSerialnumber.Rows)
                {
                    if (row.Cells[colpart_serial.Name].Value.ToString() == txtserial_number.Text)
                    {
                        if (Convert.ToBoolean(row.Cells[colscan.Name].Value) == false)
                        {
                            row.Cells[colscan.Name].Value = CheckState.Checked;
                            scan_qty = 1 + scan_qty;
                            label5.Text = string.Format("{0} of out {1}",scan_qty, Forms.Kitlistfrm.total_pick_quantity);
                            //foreach (DataGridViewRow item in Kitlistfrm.dataGridView1.Rows)
                            //{
                            //    if (item.Cells[26].Value.ToString() == id)
                            //    {
                            //        item.Cells[26].Value = scan_qty;
                            //    }
                            //}
                        }
                        else
                        {
                            MessageBox.Show("Already Scan");
                        }
                    }
                }
                txtserial_number.SelectAll();
            }
        }

        private async void btnsave_scan_Click(object sender, EventArgs e)
        {
            List<Model.kitlist.serial_details> list_serial_details = new List<Model.kitlist.serial_details>();
            foreach (DataGridViewRow row in dgSerialnumber.Rows)
            {
                Model.kitlist.serial_details data = new Model.kitlist.serial_details()
                {
                    id = Convert.ToInt32(row.Cells[colid.Name].Value.ToString()),
                    is_scan = Convert.ToBoolean(row.Cells[colscan.Name].Value) == true ? 1 : 0
                };
                list_serial_details.Add(data);
            }
            Model.kitlist.scan_serial scan_Serial = new Model.kitlist.scan_serial()
            {
                kit_list_item_serial = list_serial_details
            };
            string json = JsonConvert.SerializeObject(scan_Serial);
            //string responseData = "";
            //HttpResponseMessage response = new HttpResponseMessage();
            //using (HttpClient client = new HttpClient())
            //{
            //    var content = new StringContent(json, Encoding.UTF8, "application/json");

            //    response = await client.PostAsync($@"https://app.btcp-enterprise.com/api/kit-list-item-serial/scan-serial", content);
            //    responseData = await response.Content.ReadAsStringAsync();
            //}
            for (int i = 0; i < Kitlistfrm.dataGridView1.Rows.Count; i++) 
            {
                if (Kitlistfrm.dataGridView1.Rows[i].Cells[26].Value.ToString() == id)
                {
                    Kitlistfrm.dataGridView1.Rows[i].Cells[1].Value = 3;
                }
            } 
        }
        private async void refresh_modetails()
        {
            string url = $"https://app.btcp-enterprise.com/api/kit-list-item?mo_id={Kitlistfrm.mo_number}&per_row=9999";
            string modetails = await GetMohDetails(url);
            Model.kitlist.GetData model_modetails = JsonConvert.DeserializeObject<Model.kitlist.GetData>(modetails);
            string res3 = JsonConvert.SerializeObject(model_modetails.data);
            List<Model.kitlist.manufacturing_order_items> model = (List<Model.kitlist.manufacturing_order_items>)JsonConvert.DeserializeObject(res3, typeof(List<Model.kitlist.manufacturing_order_items>));
            Kitlistfrm.dataGridView1.DataSource = model;
        }
        private async Task<string> GetMohDetails(string url)
        {
            DataTable dt = new DataTable();
            string responseData = "";
            await Task.Run(async () => {

                using (HttpClient client = new HttpClient())
                {
                    var request = new HttpRequestMessage
                    {
                        Method = HttpMethod.Get,
                        RequestUri = new Uri(url),
                        //Content = new StringContent(data, Encoding.UTF8, "application/json")
                    };
                    HttpResponseMessage response = await client.SendAsync(request);
                    responseData = await response.Content.ReadAsStringAsync();
                }
            });
            return responseData;
        }
    }
}
