using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;
using BTCP_Enterprise.Modal;
using BTCP_Enterprise.Model;
using Newtonsoft.Json;

namespace BTCP_Enterprise.Forms
{
    public partial class OperatorsVFrm : Form
    {
        private Timer timer;
        private int elapsedTimeInSeconds; // Stores elapsed time
        private CustomeAlert alert;

        public OperatorsVFrm()
        {
            InitializeComponent();

            btn_start.TextAlign = ContentAlignment.MiddleCenter;
            btn_stop.TextAlign = ContentAlignment.MiddleCenter;
            btn_start.Enabled = false;
            btn_stop.Enabled = false;
            timer = new Timer();
            timer.Interval = 1000; // 1-second interval
            timer.Tick += timer1_Tick;
        }
        //this is for testing only.
        private void btn_start_Click(object sender, EventArgs e)
        {

            Forms.Login login = new Forms.Login("OperatorsVFrm", txt_serial_number.Text);
            login.ShowDialog();
            elapsedTimeInSeconds = 0; // Reset Timer
            lblTimer.Text = "00:00:00"; // Reset Label
            timer.Start();
            btn_start.Enabled = false; // Disable Start Button
            btn_stop.Enabled = true;   // Enable Stop Button
            //  ShowAlert("Are you sure? This will be recorded as downtime!.", CustomeAlert.Alertype.confirm);
        }


        public static void ShowAlert(string message, Modal.CustomeAlert.Alertype type)
        {
            Modal.CustomeAlert alert = new Modal.CustomeAlert("Confirm Action", message, type);
            alert.ShowDialog();
        }

        private void OperatorsVFrm_Load(object sender, EventArgs e)
        {
            txt_serial_number.Select();
            string apiUrl = "http://127.0.0.1:8000/pre-assy";
            Myrequest(apiUrl);
        }

        private void txt_serial_number_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_serial_number.Text))
            {
                btn_start.Enabled = true;

            }
            else
            {
                btn_start.Enabled = false;

            }
        }



        //private async void Myrequest(string apiUrl)
        //{
        //    try
        //    {
        //        string jsonResponse = await Utilities.WebRequestApi.GetData_httpclient(apiUrl);
        //        Console.WriteLine($"Raw API Response: {jsonResponse}");

        //        List<Process> processes = JsonConvert.DeserializeObject<List<Process>>(jsonResponse);

        //        if (processes == null || processes.Count == 0)
        //        {
        //            MessageBox.Show("No data received.", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        // Bind data to DataGridView
        //        DGV_Process.DataSource = new BindingList<Process>(processes);
        //    }
        //    catch (JsonReaderException ex)
        //    {
        //        MessageBox.Show($"JSON Parsing Error: {ex.Message}", "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private async void Myrequest(string apiUrl)
        {
            try
            {
                string jsonResponse = await Utilities.WebRequestApi.GetData_httpclient(apiUrl);
                Console.WriteLine($"Raw API Response: {jsonResponse}");

                List<Process> processes = JsonConvert.DeserializeObject<List<Process>>(jsonResponse);

                if (processes == null || processes.Count == 0)
                {
                    MessageBox.Show("No data received.", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Bind data to DataGridView
                DGV_Process.DataSource = new BindingList<Process>(processes);

                // Customize DataGridView appearance
                CustomizeDataGridView();
            }
            catch (JsonReaderException ex)
            {
                MessageBox.Show($"JSON Parsing Error: {ex.Message}", "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ Function to Customize DataGridView
        private void CustomizeDataGridView()
        {
            // Rename Column Headers
            DGV_Process.Columns["Id"].HeaderText = "ID";
            //DGV_Process.Columns["Product_Id"].HeaderText = "Product ID";
            DGV_Process.Columns["ProcessName"].HeaderText = "Process";
            DGV_Process.Columns["Station"].HeaderText = "Station";
            DGV_Process.Columns["Rev"].HeaderText = "Revision";

            // Adjust Column Widths
            DGV_Process.Columns["Id"].Width = 50;
           // DGV_Process.Columns["Product_Id"].Width = 100;
            DGV_Process.Columns["ProcessName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV_Process.Columns["Station"].Width = 120;
            DGV_Process.Columns["Rev"].Width = 70;

            // Set Column Alignment
            DGV_Process.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Process.Columns["Rev"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Set Font & Row Height
            DGV_Process.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            DGV_Process.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            DGV_Process.RowTemplate.Height = 30;

            // Enable Alternating Row Colors
            DGV_Process.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTimeInSeconds++;
            lblTimer.Text = FormatTime(elapsedTimeInSeconds);
        }
        private string FormatTime(int totalSeconds)
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(totalSeconds);
            return timeSpan.ToString(@"hh\:mm\:ss"); // Format: HH:mm:ss
        }
        private void btn_stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            btn_start.Enabled = true; 
            btn_stop.Enabled = false;
        }

        private void DGV_Process_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}