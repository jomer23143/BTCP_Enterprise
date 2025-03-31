using BTCP_Enterprise.Class;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BTCP_Enterprise.Forms
{
    public partial class Kitlistfrm: Form
    {
        private Dictionary<String, Dictionary<String, String>> dbConnectionSettings = new Dictionary<String, Dictionary<String, String>>();
        string next_page = "";
        string prev_page = "";
        public Point downPoint = Point.Empty;
        DataSet GetMoheaderDetails = new DataSet();
        
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

            bunifuloading.Hide();
            btnnext.Enabled = false;
            btnprevious_page.Enabled = false;
            Connection.InitializeConnection();
            dbConnectionSettings = Utils.DBConnection;
        }

        private  void txtmo_number_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bunifuloading.Show();
                PostData();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            List<Model.kitlist.serial_number> list_serial_number = new List<Model.kitlist.serial_number>();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                Model.kitlist.serial_number data_serial_number = new Model.kitlist.serial_number { 
                    id = Convert.ToInt32(item.Cells[colid.Name].Value.ToString()),
                    part_serial = item.Cells[colpart_serial.Name].Value.ToString()
                };
                list_serial_number.Add(data_serial_number);
            }
            Model.kitlist.add_serial_number list = new Model.kitlist.add_serial_number
            {
                kit_list_items = list_serial_number
            };
            string res = JsonConvert.SerializeObject(list);
            string responseData = "";
            HttpResponseMessage response = new HttpResponseMessage();
            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(res, Encoding.UTF8, "application/json");

                response = await client.PostAsync("https://app.btcp-enterprise.com/api/kit-list-item/scan-bulk", content);
                responseData = await response.Content.ReadAsStringAsync();
                if (response.StatusCode.ToString() == "422")
                { 
                }
                else
                {
                    MessageBox.Show("Saved Serial Number");
                }
            }
        }
        private async void PostData()
        {

            GetMoheaderDetails = KitList.GetMohDetails_DS(txtmo_number.Text);
            object res = JsonConvert.SerializeObject(GetMoheaderDetails.Tables[1]);
            string res1 = "";
            List<Model.kitlist.item> item = (List<Model.kitlist.item>)JsonConvert.DeserializeObject(res.ToString(), typeof(List<Model.kitlist.item>));
            if (res.ToString() != "[]")
            { 
                Model.kitlist.manufacturing_order man = new Model.kitlist.manufacturing_order
                {
                    
                    mo_id = GetMoheaderDetails.Tables[0].Rows[0][0].ToString(),
                    pcn_number = GetMoheaderDetails.Tables[0].Rows[0][1].ToString(),
                    description = GetMoheaderDetails.Tables[0].Rows[0][2].ToString(),
                    location = GetMoheaderDetails.Tables[0].Rows[0][3].ToString(),
                    bom_item = GetMoheaderDetails.Tables[0].Rows[0][4].ToString(),
                    bom_revision_number = GetMoheaderDetails.Tables[0].Rows[0][5].ToString(),
                    order_quantity = GetMoheaderDetails.Tables[0].Rows[0][6].ToString(),
                    order_date = GetMoheaderDetails.Tables[0].Rows[0][7].ToString(),
                    kit_date = GetMoheaderDetails.Tables[0].Rows[0][8].ToString(),
                    start_date = GetMoheaderDetails.Tables[0].Rows[0][9].ToString(),
                    end_date = GetMoheaderDetails.Tables[0].Rows[0][10].ToString(),
                    kit_list_items = item
                };
                res1 = JsonConvert.SerializeObject(man);
            }
            string responseData = "";
            HttpResponseMessage response = new HttpResponseMessage();
            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(res1, Encoding.UTF8, "application/json");

                response = await client.PostAsync("https://app.btcp-enterprise.com/api/kit-list", content);
                responseData = await response.Content.ReadAsStringAsync();
                if (response.StatusCode.ToString() == "422")
                {
                    Model.kitlist.error_logs error = JsonConvert.DeserializeObject<Model.kitlist.error_logs>(responseData);
                    string url = $"https://app.btcp-enterprise.com/api/kit-list-item?mo_id={txtmo_number.Text}&per_row=9999";
                    string modetails = await GetMohDetails(url);
                    Model.kitlist.GetData model_modetails = JsonConvert.DeserializeObject<Model.kitlist.GetData>(modetails);
                    next_page = model_modetails.next_page_url;
                    if (model_modetails.prev_page_url == null)
                    {
                        btnprevious_page.Enabled = false;
                    }
                    if (model_modetails.next_page_url == null)
                        btnnext.Enabled = false;
                    else
                        btnnext.Enabled = true;
                    label5.Text = model_modetails.to.ToString() + " out of " + model_modetails.total;
                    string res3 = JsonConvert.SerializeObject(model_modetails.data);
                    List<Model.kitlist.manufacturing_order_items> model = (List<Model.kitlist.manufacturing_order_items>)JsonConvert.DeserializeObject(res3, typeof(List<Model.kitlist.manufacturing_order_items>));
                    bunifuloading.Hide();
                    dataGridView1.DataSource = model;
                }
                else
                {
                    string url = $"https://app.btcp-enterprise.com/api/kit-list-item?mo_id={txtmo_number.Text}&per_row=9999";
                    string modetails = await GetMohDetails(url);
                    Model.kitlist.GetData model_modetails = JsonConvert.DeserializeObject<Model.kitlist.GetData>(modetails);
                    next_page = model_modetails.next_page_url;
                    if (model_modetails.prev_page_url == null)
                    {
                        btnprevious_page.Enabled = false;
                    }
                    if (model_modetails.next_page_url == null)
                        btnnext.Enabled = false;
                    else
                        btnnext.Enabled = true;
                    label5.Text = model_modetails.to.ToString()+" out of " + model_modetails.total;
                    string res3 = JsonConvert.SerializeObject(model_modetails.data);
                    List<Model.kitlist.manufacturing_order_items> model = (List<Model.kitlist.manufacturing_order_items>)JsonConvert.DeserializeObject(res3, typeof(List<Model.kitlist.manufacturing_order_items>));
                    bunifuloading.Hide();
                    dataGridView1.DataSource = model;

                }
                dataGridView1.Rows[0].Cells[0].Selected = true;
                dataGridView1.BeginEdit(true);
            }
        }
        private async Task<string> GetMohDetails (string url)
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
        private async void btnnext_Click(object sender, EventArgs e)
        {
            bunifuloading.Show();   
            string modetails = await GetMohDetails(next_page+"&per_row=9999");
            Model.kitlist.GetData model_modetails = JsonConvert.DeserializeObject<Model.kitlist.GetData>(modetails);
            string res3 = JsonConvert.SerializeObject(model_modetails.data);
            next_page = model_modetails.next_page_url;
            prev_page = model_modetails.prev_page_url;
            if (next_page == null)
                btnnext.Enabled = false;
            if (prev_page != null)
                btnprevious_page.Enabled = true;
            label5.Text = model_modetails.to.ToString() + " out of " + model_modetails.total;
            List<Model.kitlist.manufacturing_order_items> model = (List<Model.kitlist.manufacturing_order_items>)JsonConvert.DeserializeObject(res3, typeof(List<Model.kitlist.manufacturing_order_items>));
            btnprevious_page.Enabled = true;
            bunifuloading.Hide();
            dataGridView1.DataSource = model;
        }

        private async void btnprevious_page_Click(object sender, EventArgs e)
        {
            bunifuloading.Show();
            string modetails = await GetMohDetails(prev_page + "&per_row=9999");
            Model.kitlist.GetData model_modetails = JsonConvert.DeserializeObject<Model.kitlist.GetData>(modetails);
            string res3 = JsonConvert.SerializeObject(model_modetails.data);
            next_page = model_modetails.next_page_url;
            prev_page = model_modetails.prev_page_url;
            if (prev_page == null)
                btnprevious_page.Enabled=false;
            if (next_page != null)
                btnnext.Enabled = true;
            label5.Text = model_modetails.to.ToString() + " out of " + model_modetails.total;
            List<Model.kitlist.manufacturing_order_items> model = (List<Model.kitlist.manufacturing_order_items>)JsonConvert.DeserializeObject(res3, typeof(List<Model.kitlist.manufacturing_order_items>));
            bunifuloading.Hide();
            dataGridView1.DataSource = model;
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //var grid = sender as DataGridView;
            //var rowindx = (e.RowIndex + 1).ToString();
            //var centerformat = new StringFormat()
            //{
            //    Alignment = StringAlignment.Center,
            //    LineAlignment = StringAlignment.Center
            //};
            //var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            //e.Graphics.DrawString(rowindx, this.Font, SystemBrushes.ControlText, headerBounds, centerformat);
        }

        private void txtserial_number_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[colpart_serial.Name].Value.ToString() == txtserial_number.Text)
                    {
                        if (Convert.ToInt32(row.Cells[colpickqty.Name].Value) > Convert.ToInt32(row.Cells[colkitted.Name].Value))
                        {
                            int recieved_quantity = row.Cells[colkitted.Name].Value == null ? 0 + 1 : Convert.ToInt32(row.Cells[colkitted.Name].Value) + 1;
                            row.Cells[colkitted.Name].Value = recieved_quantity;
                            //int kitte_quantity = Convert.ToInt32(row.Cells[colpickqty.Name].Value) - Convert.ToInt32(row.Cells[colrecieved_quantity.Name].Value);
                            //row.Cells[colkit_quantity.Name].Value = kitte_quantity;
                        }
                        else
                        {
                            txtserial_number.SelectAll();
                            MessageBox.Show("Pick Quantity and Kitted Quantity is Equal","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            return;
                        }
                    }
                }
                txtserial_number.SelectAll();
            }
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    string cellValue = Convert.ToString(selectedRow.Cells[colpart_serial.Name].Value);
                    if (item.Cells[colpart_serial.Name].Value.ToString() == cellValue)
                    {
                        MessageBox.Show("Serial Number is already Exist");
                    }
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            List<Model.kitlist.kitted_quantity> list_kitted_quantity = new List<Model.kitlist.kitted_quantity>();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                Model.kitlist.kitted_quantity data_kitted_quantity = new Model.kitlist.kitted_quantity
                {
                    id = Convert.ToInt32(item.Cells[colid.Name].Value.ToString()),
                    kitted = item.Cells[colkitted.Name].Value.ToString(),
                    comment = item.Cells[colcomment.Name].Value == null?"": item.Cells[colcomment.Name].Value.ToString()
                };
                
                list_kitted_quantity.Add(data_kitted_quantity);
            }
            Model.kitlist.update_kitting_quantity list = new Model.kitlist.update_kitting_quantity
            {
                kit_list_items = list_kitted_quantity
            };
            string res = JsonConvert.SerializeObject(list);
            string responseData = "";
            HttpResponseMessage response = new HttpResponseMessage();
            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(res, Encoding.UTF8, "application/json");

                response = await client.PostAsync("https://app.btcp-enterprise.com/api/kit-list-item/scan-bulk", content);
                responseData = await response.Content.ReadAsStringAsync();
                if (response.StatusCode.ToString() == "422")
                {
                }
                else
                {
                    MessageBox.Show("Saved Kitted Quantity");
                }
            }
        }
    }
}
