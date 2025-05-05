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
    public partial class AddSerialnumber: Form
    {
        bool is_error = false;
        public AddSerialnumber()
        {
            InitializeComponent();
        }

        private void AddSerialnumber_Load(object sender, EventArgs e)
        {
            bunifuloading.Hide();
            dgSerialnumber.DataSource = Forms.Kitlistfrm.list_serial;
            //if (dgSerialnumber.Rows.Count > 1 )
            //    dgSerialnumber.Rows[0].Cells[0].Selected = false;
            //dgSerialnumber.Rows[dgSerialnumber.RowCount - 1].Selected = true;
            label1.Text = String.Format("IPN : {0}",Forms.Kitlistfrm.kit_list_item_ipn);
        }

        private async void btnsave_serial_Click(object sender, EventArgs e)
        {
            for (int currentRow = 0; currentRow < dgSerialnumber.Rows.Count - 1; currentRow++)
            {
                string serial_number = dgSerialnumber.Rows[currentRow].Cells[colpart_serial.Name].Value.ToString();
                //string ipn = dgSerialnumber.Rows[currentRow].Cells[colipn.Name].Value.ToString();
                for (int row = 0; row < dgSerialnumber.Rows.Count - 1; row++)
                {
                    string serial_number_compare = dgSerialnumber.Rows[row].Cells[colpart_serial.Name].Value.ToString();
                    // string ipn_compare = dgSerialnumber.Rows[row].Cells[colipn.Name].Value.ToString();
                    if (currentRow != row)
                    {
                        if (serial_number == serial_number_compare)
                        {
                            is_error = true;
                            dgSerialnumber.Rows[currentRow].Cells[colpart_serial.Name].Style.BackColor = Color.Red;
                            break;
                        }
                        else
                        {
                            dgSerialnumber.Rows[currentRow].Cells[colpart_serial.Name].Style.BackColor = Color.White;
                        }
                    }
                }
            }
            if (is_error)
            {
                //MessageBox.Show($@"Duplicate Serial", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                is_error = false;
                return;
            }
            bunifuloading.Show();
            List<Model.kitlist.serial_number> list_serial_number = new List<Model.kitlist.serial_number>();
            foreach (DataGridViewRow item in dgSerialnumber.Rows)
            {
                if (item.IsNewRow)
                    continue;
                Model.kitlist.serial_number data_serial_number = new Model.kitlist.serial_number
                {
                    kit_list_item_id = Forms.Kitlistfrm.kit_list_item_id,
                    kit_list_part_serial_number = item.Cells[colpart_serial.Name].Value.ToString()
                };
                list_serial_number.Add(data_serial_number);
            }
            Model.kitlist.add_serial_number list = new Model.kitlist.add_serial_number
            {
                kit_list_item_serial = list_serial_number
            };
            string res = JsonConvert.SerializeObject(list);
            string responseData = "";
            HttpResponseMessage response = new HttpResponseMessage();
            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(res, Encoding.UTF8, "application/json");

                response = await client.PostAsync("https://app.btcp-enterprise.com/api/serial/save-serial", content);
                responseData = await response.Content.ReadAsStringAsync();
                if (response.StatusCode.ToString() == "422")
                {
                    bunifuloading.Hide();
                }
                else
                {
                    bunifuloading.Hide();
                    MessageBox.Show("Saved Serial Number");
                }
            }
        }

        private void dgSerialnumber_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowindx = (e.RowIndex + 1).ToString();
            var centerformat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowindx, this.Font, SystemBrushes.ControlText, headerBounds, centerformat);
        }
    }
}
