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
        int kit_list_id1 = 0;
        public static int kit_list_item_id = 0;
        public static string kit_list_item_ipn = "";
        public static int total_pick_quantity = 0;
        public static DataTable list_serial = null;
        public static string mo_number = "";
        int rowid;
        DataSet GetMoheaderDetails = new DataSet();
        
        public Kitlistfrm()
        {
            InitializeComponent();
            //initialize_datagridview_columns();
            txtserial_number.Visible = false;
            label3.Visible = false;
            list_serial = null;
            list_serial = new DataTable("list_of_seials");
            list_serial.Columns.Add("id");
            list_serial.Columns.Add("kit_list_part_serial_number");
            list_serial.Columns.Add("is_scan");
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
            txtmo_number.Focus();
            bunifuloading.Hide();
            btnserial.Visible = false;
            btncomplete.Visible = false;
            btnincomplete.Visible = false;
            btnnext.Enabled = false;
            btnprevious_page.Enabled = false;
            btnnext.Visible = false;
            btnprevious_page.Visible = false;
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
        bool is_error = false;
        private  void button1_Click(object sender, EventArgs e)
        {
            //for (int currentRow = 0; currentRow < dataGridView1.Rows.Count; currentRow++)
            //{
            //    string serial_number =dataGridView2.Rows[currentRow].Cells[colpart_serial.Name].Value.ToString();
            //    string ipn = dataGridView2.Rows[currentRow].Cells[colipn.Name].Value.ToString();
            //    for (int row = 0; row < dataGridView2.Rows.Count; row++)
            //    {
            //        string serial_number_compare = dataGridView2.Rows[row].Cells[colpart_serial.Name].Value.ToString();
            //        string ipn_compare = dataGridView2.Rows[row].Cells[colipn.Name].Value.ToString();
            //        if (currentRow != row)
            //        {
            //            if (serial_number == serial_number_compare)
            //            {
            //                is_error = true;
            //                dataGridView2.Rows[currentRow].Cells[colpart_serial.Name].Style.BackColor = Color.Red;
            //                break;
            //            }
            //            else
            //            {
            //                dataGridView2.Rows[currentRow].Cells[colpart_serial.Name].Style.BackColor = Color.White;
            //            }
            //        }
            //    }
            //}
            //if (is_error)
            //{
            //    MessageBox.Show($@"Duplicate Serial", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    is_error = false;
            //    return;
            //}
            //bunifuloading.Show();
            //List<Model.kitlist.serial_number> list_serial_number = new List<Model.kitlist.serial_number>();
            //foreach (DataGridViewRow item in dataGridView1.Rows)
            //{
            //    Model.kitlist.serial_number data_serial_number = new Model.kitlist.serial_number { 
            //        id = Convert.ToInt32(item.Cells[colid.Name].Value.ToString()),
            //        part_serial = item.Cells[colpart_serial.Name].Value.ToString()
            //    };
            //    list_serial_number.Add(data_serial_number);
            //}
            //Model.kitlist.add_serial_number list = new Model.kitlist.add_serial_number
            //{
            //    kit_list_items = list_serial_number
            //};
            //string res = JsonConvert.SerializeObject(list);
            //string responseData = "";
            //HttpResponseMessage response = new HttpResponseMessage();
            //using (HttpClient client = new HttpClient())
            //{
            //    var content = new StringContent(res, Encoding.UTF8, "application/json");

            //    response = await client.PostAsync("https://app.btcp-enterprise.com/api/kit-list-item/scan-bulk", content);
            //    responseData = await response.Content.ReadAsStringAsync();
            //    if (response.StatusCode.ToString() == "422")
            //    {
            //        bunifuloading.Hide();
            //    }
            //    else
            //    {
            //        bunifuloading.Hide();
            //        txtserial_number.Focus();
            //        MessageBox.Show("Saved Serial Number");
            //        btnserial.Visible = false;
            //        btncomplete.Visible = true;
            //        btnincomplete.Visible = true;
            //    }
            //}
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
                    dynamic tmp = JsonConvert.DeserializeObject(responseData);
                    kit_list_id1 = tmp.id;
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
                    string res3 = JsonConvert.SerializeObject(model_modetails.data);
                    List<Model.kitlist.manufacturing_order_items> model = (List<Model.kitlist.manufacturing_order_items>)JsonConvert.DeserializeObject(res3, typeof(List<Model.kitlist.manufacturing_order_items>));
                    foreach (var row in model)
                    {
                        if (row.status.name.ToUpper() == "COMPLETE")
                        {
                            bunifuloading.Hide();
                            MessageBox.Show("This is MO number is already Complete");
                            return;
                        }
                    }
                    bunifuloading.Hide();
                    dataGridView1.DataSource = model;
                    label5.Text = model_modetails.to.ToString() + " out of " + model_modetails.total;
                    kit_list_item_id = Convert.ToInt32(dataGridView1.Rows[0].Cells[colid.Name].Value);
                    kit_list_item_ipn = dataGridView1.Rows[0].Cells[colipn.Name].Value.ToString();
                    total_pick_quantity = Convert.ToInt32(dataGridView1.Rows[0].Cells[colpickqty.Name].Value);
                    btnAddSerial.Enabled = true;   
                    btnscan.Enabled = true;
                    btncomplete.Visible = true;
                    btnincomplete.Visible = true;
                }
                else
                {
                    dynamic tmp = JsonConvert.DeserializeObject(responseData);
                    kit_list_id1 = tmp.id;

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
                    kit_list_item_id = Convert.ToInt32(dataGridView1.Rows[0].Cells[colid.Name].Value);
                    kit_list_item_ipn = dataGridView1.Rows[0].Cells[colipn.Name].Value.ToString();
                    total_pick_quantity = Convert.ToInt32(dataGridView1.Rows[0].Cells[colpickqty.Name].Value);
                    btnAddSerial.Enabled = true;
                    btnscan.Enabled = true;
                    btncomplete.Visible = true;
                    btnincomplete.Visible = true;
                }
                mo_number = txtmo_number.Text;
                //dataGridView2.Rows[0].Cells[0].Selected = true;
                //dataGridView2.BeginEdit(true);
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
            //if (e.KeyCode == Keys.Enter)
            //{
            //    foreach (DataGridViewRow row in dataGridView1.Rows)
            //    {
            //        if (row.Cells[colpart_serial.Name].Value.ToString() == txtserial_number.Text)
            //        {
            //            if (Convert.ToInt32(row.Cells[colpickqty.Name].Value) > Convert.ToInt32(row.Cells[colkitted.Name].Value))
            //            {
            //                int recieved_quantity = row.Cells[colkitted.Name].Value == null ? 0 + 1 : Convert.ToInt32(row.Cells[colkitted.Name].Value) + 1;
            //                row.Cells[colkitted.Name].Value = recieved_quantity;
            //                //int kitte_quantity = Convert.ToInt32(row.Cells[colpickqty.Name].Value) - Convert.ToInt32(row.Cells[colrecieved_quantity.Name].Value);
            //                //row.Cells[colkit_quantity.Name].Value = kitte_quantity;
            //            }
            //            else
            //            {
            //                txtserial_number.SelectAll();
            //                MessageBox.Show("Pick Quantity and Kitted Quantity is Equal","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //                return;
            //            }
            //        }
            //    }
            //    txtserial_number.SelectAll();
            //}
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    foreach (DataGridViewRow item in dataGridView1.Rows)
            //    {
            //        int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            //        DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            //        string cellValue = Convert.ToString(selectedRow.Cells[colpart_serial.Name].Value);
            //        if (item.Cells[colpart_serial.Name].Value.ToString() == cellValue)
            //        {
            //            MessageBox.Show("Serial Number is already Exist");
            //        }
            //    }
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SavedKittedQuantity(2);/// Status is Complete
        }
        private async void SavedKittedQuantity(int status)
        {
            bunifuloading.Show();
            List<Model.kitlist.kitted_quantity> list_kitted_quantity = new List<Model.kitlist.kitted_quantity>();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                Model.kitlist.kitted_quantity data_kitted_quantity = new Model.kitlist.kitted_quantity
                {
                    id = Convert.ToInt32(item.Cells[colid.Name].Value.ToString()),
                    kitted = item.Cells[colkitted.Name].Value.ToString(),
                    comment = item.Cells[colcomment.Name].Value == null ? "" : item.Cells[colcomment.Name].Value.ToString(),
                    kit_list_item_status_id = 1
                };

                list_kitted_quantity.Add(data_kitted_quantity);
            }
            Model.kitlist.update_kitting_quantity list = new Model.kitlist.update_kitting_quantity
            {
                kit_list_id = kit_list_id1,
                kit_list_status_id = status,
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
                    bunifuloading.Hide();
                }
                else
                {
                    bunifuloading.Hide();
                    MessageBox.Show("Saved Kitted Quantity");
                    txtserial_number.Clear();
                    txtmo_number.Clear();
                    dataGridView1.DataSource = null;
                    initialize_datagridview_columns();
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SavedKittedQuantity(3); /// Status is Incomplete
        }
        void initialize_datagridview_columns()
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            //column.HeaderText = "Serial Number";
            //column.DataPropertyName = "part_serial";
            //column.Name = "colpart_serial";
            //column.Width = 180;
            //dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Internal PN";
            column.DataPropertyName = "ipn";
            column.Name = "colipn";
            column.Width = 100;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Description";
            column.DataPropertyName = "description";
            column.Name = "coldescription";
            column.Width = 300;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Type";
            column.DataPropertyName = "type";
            column.Name = "coltype";
            column.Width = 100;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "MFG";
            column.DataPropertyName = "manufacturing";
            column.Name = "colmfg";
            column.Width = 180;
            column.Visible = false;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "MFG Product Code";
            column.DataPropertyName = "manufacturing_product_code";
            column.Name = "colmfgprodcode";
            column.Width = 180;
            column.Visible = false;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Location";
            column.DataPropertyName = "source_location";
            column.Name = "collocation";
            column.Width = 180;
            column.Visible = false;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Stock";
            column.DataPropertyName = "stock";
            column.Name = "colstock";
            column.Width = 180;
            column.Visible = false;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Unit Quantity";
            column.DataPropertyName = "unit_quantity";
            column.Name = "colunitqty";
            column.Width = 80;
            column.Visible = false;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "MO Quantity";
            column.DataPropertyName = "mo_quantity";
            column.Name = "colmoqty";
            column.Width = 80;
            column.Visible = false;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "WIP Quantity";
            column.DataPropertyName = "wip_quantity";
            column.Name = "colwipqty";
            column.Width = 180;
            column.Visible = false;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Pick Quantity";
            column.DataPropertyName = "pick_quantity";
            column.Name = "colpickqty";
            column.Width = 80;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Short Quantity";
            column.DataPropertyName = "short_quantity";
            column.Name = "colshortqty";
            column.Width = 80;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Kit Quantity";
            column.DataPropertyName = "";
            column.Name = "colkit_quantity";
            column.Width = 80;
            column.Visible = false;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Received Quantity";
            column.DataPropertyName = "";
            column.Name = "colrecieved_quantity";
            column.Width = 80;
            column.Visible = false;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Reject Quantity";
            column.DataPropertyName = "";
            column.Name = "colreject_quantity";
            column.Width = 80;
            column.Visible = false;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Uni UOM";
            column.DataPropertyName = "unit";
            column.Name = "colunit";
            column.Width = 70;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Invoice #";
            column.DataPropertyName = "invoice_number";
            column.Name = "colinvoicenumber";
            column.Width = 180;
            column.Visible = false;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Kitted";
            column.DataPropertyName = "kitted";
            column.Name = "colkitted";
            column.Width = 80;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Individual Kitted";
            column.DataPropertyName = "individual_kitting";
            column.Name = "colindividualkitted";
            column.Width = 180;
            column.Visible = false;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Track";
            column.DataPropertyName = "track";
            column.Name = "coltrack";
            column.Width = 100;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Rack";
            column.DataPropertyName = "rack";
            column.Name = "colrack";
            column.Width = 180;
            column.Visible = false;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Comment";
            column.DataPropertyName = "comment";
            column.Name = "colcomment";
            column.Width = 200;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Created_at";
            column.DataPropertyName = "created_at";
            column.Name = "colcreated_at";
            column.Width = 180;
            column.Visible = false;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Update at";
            column.DataPropertyName = "updated_at";
            column.Name = "colupdated_at";
            column.Width = 180;
            column.Visible = false;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Status";
            column.DataPropertyName = "status";
            column.Name = "colstatus";
            column.Width = 180;
            column.Visible = false;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "history";
            column.DataPropertyName = "history";
            column.Name = "colhistory";
            column.Width = 180;
            column.Visible = false;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "id";
            column.DataPropertyName = "id";
            column.Name = "colid";
            column.Width = 180;
            column.Visible = false;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "mo id";
            column.DataPropertyName = "mo_id";
            column.Name = "colmo_id";
            column.Width = 180;
            column.Visible = false;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "item number";
            column.DataPropertyName = "item_number";
            column.Name = "colitem_number";
            column.Width = 180;
            column.Visible = false;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "group";
            column.DataPropertyName = "group";
            column.Name = "colgroup";
            column.Width = 180;
            column.Visible = false;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Kit_list_id";
            column.DataPropertyName = "kit_list_item_status_id";
            column.Name = "colkit_list_status_item";
            column.Width = 70;
            column.Visible = false;
            dataGridView1.Columns.Add(column);

        }

        private async void btnAddSerial_Click(object sender, EventArgs e)
        {
            list_serial.Clear();
            string url = $@"https://app.btcp-enterprise.com/api/serial/view-serial?kit_list_item_id={kit_list_item_id}";
            string responseData = await GetMohDetails(url);
            List<Model.kitlist.get_serial> serials = (List<Model.kitlist.get_serial>)JsonConvert.DeserializeObject(responseData, typeof(List<Model.kitlist.get_serial>));
            foreach (var item in serials)
            {
                string[] data1 = new string[]
                 {
                    Convert.ToInt32(item.id).ToString(),
                    item.kit_list_part_serial_number,
                    Convert.ToInt32(item.is_scan).ToString()
                 };
                list_serial.Rows.Add(data1);
            }
            Forms.AddSerialnumber addSerialnumber = new Forms.AddSerialnumber();
            addSerialnumber.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            //int columnindex = dataGridView1.CurrentCell.ColumnIndex;
           kit_list_item_ipn = dataGridView1.Rows[rowindex].Cells[colipn.Name].Value.ToString();
           kit_list_item_id =  Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[colid.Name].Value);
           total_pick_quantity = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[colpickqty.Name].Value);
           rowid = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[colid.Name].Value);
        }

        private async void button2_Click_1(object sender, EventArgs e)
        {
            list_serial.Clear();
            string url = $@"https://app.btcp-enterprise.com/api/serial/view-serial?kit_list_item_id={kit_list_item_id}";
            string responseData = await GetMohDetails(url);
            List<Model.kitlist.get_serial> serials = (List<Model.kitlist.get_serial>)JsonConvert.DeserializeObject(responseData, typeof(List<Model.kitlist.get_serial>));
            
            foreach (var item in serials)
            {
               string[] data1 = new string[]
                {
                    Convert.ToInt32(item.id).ToString(),
                    item.kit_list_part_serial_number,
                    Convert.ToInt32(item.is_scan).ToString()
                };
                list_serial.Rows.Add(data1);
            }

            Forms.ScanSerialnumber ScanSerialnumber = new Forms.ScanSerialnumber(this, kit_list_item_id);
            ScanSerialnumber.Show();
        }
        public async void save_serail()
        {
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                {"kit_list_item_id",kit_list_item_id }
            };
            string json = JsonConvert.SerializeObject(data);
            string responseData = "";
            HttpResponseMessage response = new HttpResponseMessage();
            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                response = await client.PostAsync($@"https://app.btcp-enterprise.com/api/serial/view-serial", content);
                responseData = await response.Content.ReadAsStringAsync();
            }
            List<Model.kitlist.get_serial> serials = (List<Model.kitlist.get_serial>)JsonConvert.DeserializeObject(responseData, typeof(List<Model.kitlist.get_serial>));

            foreach (var item in serials)
            {
                string[] data1 = new string[]
                 {
                    Convert.ToInt32(item.kit_list_item_id).ToString(),
                    item.kit_list_part_serial_number,
                    Convert.ToInt32(item.is_scan).ToString()
                 };
                list_serial.Rows.Add(data1);
            }

            Forms.ScanSerialnumber ScanSerialnumber = new Forms.ScanSerialnumber(this, kit_list_item_id);
            ScanSerialnumber.Show();
        }
    }
}
