﻿using BTCP_Enterprise.Class;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTCP_Enterprise.Forms
{
    public partial class Kitlist: Form
    {
        int kitlist_id1 = 0;
        public Kitlist()
        {
            InitializeComponent();
            bunifuloading.Visible = false;
        }

        private void Kitlist_MouseDown(object sender, MouseEventArgs e)
        {
            DragDropForm.ReleaseCapture();
            DragDropForm.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private async void txtmo_number_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bunifuloading.Show();
                string json_mo = await GetMohDetails($@"https://app.btcp-enterprise.com/api/kit-list-item?mo_id={txtmo_number.Text}&per_row=9999");
                Model.kitlist.GetData model_mo = JsonConvert.DeserializeObject<Model.kitlist.GetData>(json_mo);
                string json_mo_details = JsonConvert.SerializeObject(model_mo.data);
                dynamic temp = JsonConvert.DeserializeObject(json_mo_details);
                List<Model.kitlist.manufacturing_order_items> model_mo_details = (List<Model.kitlist.manufacturing_order_items>)JsonConvert.DeserializeObject(json_mo_details, typeof(List<Model.kitlist.manufacturing_order_items>));

                dataGridView1.DataSource = model_mo_details;
                foreach (var item in model_mo_details)
                {
                    kitlist_id1 = item.kit_list_item_status_id;
                }
                for (int currenrow = 0; currenrow < dataGridView1.Rows.Count; currenrow++)
                {
                    if (dataGridView1.Rows[currenrow].Cells[colkit_list_id.Name].Value.ToString() == "2")
                    {
                        dataGridView1.Rows[currenrow].Cells[colstatus_item.Name].Value = 1;
                    }
                    else
                    {
                        dataGridView1.Rows[currenrow].Cells[colstatus_item.Name].Value = 0;
                    }

                }
                bunifuloading.Hide();
            }
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

        private  void btncomplete_Click(object sender, EventArgs e)
        {
             saved_comment_status();
        }
        private async void saved_comment_status()
        {
            List<Model.kitlist.kitted_quantity> list_kitted_quantity = new List<Model.kitlist.kitted_quantity>();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                Model.kitlist.kitted_quantity data_kitted_quantity = new Model.kitlist.kitted_quantity
                {
                    id = Convert.ToInt32(item.Cells[colid.Name].Value.ToString()),
                    kitted = item.Cells[colkitted.Name].Value.ToString(),
                    comment = item.Cells[colcomment.Name].Value == null ? "" : item.Cells[colcomment.Name].Value.ToString(),
                    kit_list_item_status_id = Convert.ToBoolean(item.Cells[colstatus_item.Name].Value) == true ? 2 : 3
                };

                list_kitted_quantity.Add(data_kitted_quantity);
            }
            Model.kitlist.update_kitting_quantity list = new Model.kitlist.update_kitting_quantity
            {
                kit_list_id = kitlist_id1,
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
                    MessageBox.Show("Saved");
                    txtmo_number.Clear();
                    txtmo_number.Clear();
                    dataGridView1.DataSource = null;
                    initialize_datagridview_columns();
                }
            }
        }
        void initialize_datagridview_columns()
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Serial Number";
            column.DataPropertyName = "part_serial";
            column.Name = "colpart_serial";
            column.Width = 180;
            dataGridView1.Columns.Add(column);

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

            //column = new DataGridViewCheckBoxColumn();
            //column.HeaderText = "Check (If Complete)";
            //column.DataPropertyName = "";
            //column.Name = "colstatus_item";
            //column.Width = 70;
            //column.Visible = true;
            //dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Kit_list_id";
            column.DataPropertyName = "kit_list_item_status_id";
            column.Name = "colkit_list_id";
            column.Width = 70;
            column.Visible = false;
            dataGridView1.Columns.Add(column);

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridView1.Rows.Count == 0)
            //    return;
            //int row_index = dataGridView1.CurrentCell.RowIndex;
            //if (dataGridView1.Rows[row_index].Cells[colcomment.Name].Value.ToString().ToUpper() == "OKAY" || dataGridView1.Rows[row_index].Cells[colcomment.Name].Value.ToString().ToUpper() == "OK")
            //{
            //    dataGridView1.Rows[row_index].Cells[colstatus_item.Name].Value = 1;
            //}
            //else
            //{
            //    dataGridView1.Rows[row_index].Cells[colstatus_item.Name].Value = 0;
            //}
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                return;
           
            if (dataGridView1.Rows[e.RowIndex].Cells[colcomment.Name].Value.ToString().ToUpper() == "OKAY" || dataGridView1.Rows[e.RowIndex].Cells[colcomment.Name].Value.ToString().ToUpper() == "OK")
            {
                dataGridView1.Rows[e.RowIndex].Cells[colstatus_item.Name].Value = 1;
            }
            else
            {
                dataGridView1.Rows[e.RowIndex].Cells[colstatus_item.Name].Value = 0;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridView1.Columns[e.ColumnIndex].Name == "colstatus_item")
            //{
            //    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells[colstatus_item.Name];
            //    if (chk.Value == chk.FalseValue || chk.Value == null)
            //    {
            //        dataGridView1.Rows[e.RowIndex].Cells[colcomment.Name].Value = "OK";
            //        chk.Value = chk.TrueValue;
            //    }
            //    else
            //    {
            //        dataGridView1.Rows[e.RowIndex].Cells[colcomment.Name].Value = "";
            //        chk.Value = chk.FalseValue;
            //    }
            //}
        }
    }
}
