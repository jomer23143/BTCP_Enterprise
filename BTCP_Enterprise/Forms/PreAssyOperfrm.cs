using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using BTCP_Enterprise.Modal;
using Timer = System.Threading.Timer;
using Newtonsoft.Json;
using System.ComponentModel;
using BTCP_Enterprise.Model;
using System.IO;
using System.Threading.Tasks;

namespace BTCP_Enterprise.Forms
{
    public partial class PreAssyOperfrm : Form
    {
        private Dictionary<string, (Timer, DateTime)> activeTimers; // Store active timers
        public string operID;
        public string operName;
        public string  serial;
        string moid;
        public string itemparts;
        private object jsonResponse;

        public PreAssyOperfrm(string operID, string operName,string moid)
        {
            InitializeComponent();
           
            activeTimers = new Dictionary<string, (Timer, DateTime)>();

            // ✅ Initialize DataGridView columns
            InitializeDataGridView();
            this.operID = operID;
            this.operName = operName;
            this.moid = moid;
        }

        private void PreAssyOperfrm_Load(object sender, EventArgs e)
        {
            txt_serial_number.Select();
        }

        private void InitializeDataGridView()
        {
            DGV_Process.Columns.Clear();
            DGV_Process.Columns.Add("serialno", "Serial Number");
            DGV_Process.Columns.Add("itemparts", "Item Parts Name");
            DGV_Process.Columns.Add("startTime", "Time Started");
            DGV_Process.Columns.Add("endTime", "Time Ended");
            DGV_Process.Columns.Add("duration", "Duration");
            DGV_Process.Columns.Add("operator", "Operator");
        }

        private void txt_serial_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent beep sound

                string rfid = txt_serial_number.Text.Trim();
                if (!string.IsNullOrEmpty(rfid))
                {

                    if (rfid.Length <= 11)
                    {
                        // MessageBox.Show("Invalid RFID. Please scan a valid RFID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        RFID_Tapped(operName);
                        txt_serial_number.Clear();
                        txt_serial_number.Focus();
                        return;
                    }
                    else
                    {
                        operName = rfid;

                        //ProcessConfirmation processConfirmation = new ProcessConfirmation();
                        //processConfirmation.ShowDialog();
                        //MessageBox.Show("RFID Tapped: " + operName, "RFID Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string apiUrl = "https://app.btcp-enterprise.com/api/kit-list-item/scan?part_seria";


                        Modal.ProcessConfirmation confimation = new Modal.ProcessConfirmation();

                        // Subscribe to event
                        confimation.rfidscanned += (scanderfid) =>
                        {

                            operName = scanderfid;

                        };

                        confimation.ShowDialog();
                        Myrequest(apiUrl, txt_serial_number.Text);

                    }
                }

                MessageBox.Show("Please enter a serial number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                txt_serial_number.Clear();
                txt_serial_number.Focus();

            }
        }

        private async void Myrequest(string apiUrl, string serialnumber)
        {
            try
            {
                var postData = new { serialnumber = serialnumber };
                string json = JsonConvert.SerializeObject(postData);

                string jsonResponse = await Utilities.WebRequestApi.Operator_httpclient(apiUrl, json);

                Console.WriteLine($"Raw API Response: {jsonResponse}");

                if (string.IsNullOrEmpty(jsonResponse) || jsonResponse.Trim().StartsWith("<"))
                {
                    MessageBox.Show("Invalid response from server.", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ Deserialize JSON response into a list of objects
                var response = JsonConvert.DeserializeObject<List<KitItem>>(jsonResponse);

                if (response == null || response.Count == 0)
                {
                    MessageBox.Show("No valid data found.", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ Extract serial and description
                var firstItem = response[0]; // Assuming you only need the first item
                serial = firstItem.part_serial;
                itemparts = firstItem.description;
                RFID_Tapped(operName);



            }
            catch (JsonReaderException ex)
            {
                MessageBox.Show($"JSON Error: {ex.Message}\n\nResponse: {jsonResponse}", "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ Define a class to match JSON structure
        public class KitItem
        {
            public int id { get; set; }
            public int kit_list_id { get; set; }
            public string mo_id { get; set; }  // Serial Number
            public string description { get; set; }  // Item Description
            public string part_serial { get; set; } // Part Serial
        }



        private void RFID_Tapped(string rfid)
        {
            bool hasOngoingProcess = activeTimers.ContainsKey(rfid);
            bool hasStoppedProcess = CheckIfOperatorHasStoppedProcess(rfid);

            if (hasOngoingProcess)
            {
                // ✅ Stop the timer and update the duration
                StopTimer(rfid);
            }
            else if (hasStoppedProcess)
            {
                // ✅ Create a new session for this RFID
                StartNewTimer(rfid);
            }
            else
            {
                // ✅ Start a new process normally
                StartNewTimer(rfid);
            }
        }

        // ✅ Check if an operator has already completed a process
        private bool CheckIfOperatorHasStoppedProcess(string rfid)
        {
            foreach (DataGridViewRow row in DGV_Process.Rows)
            {
                if (row.Cells["operator"].Value?.ToString() == rfid && row.Cells["serialno"].Value?.ToString() == serial &&
                    row.Cells["endTime"].Value?.ToString() != "-") // Means process has ended
                {
                    return true;
                }
            }
            return false;
        }

     
        private void StartNewTimer(string rfid)
        {
            DateTime startTime = DateTime.Now;
            Timer newTimer = new Timer(TimerCallback, rfid, 0, 1000); // Timer ticks every second

            activeTimers[rfid] = (newTimer, startTime);

            // ✅ Create a new row for a new process
            Invoke(new Action(() =>
            {
               
                    DGV_Process.Rows.Add(serial, itemparts, startTime.ToString("HH:mm:ss"), "-", "00:00:00", rfid);
                
               
            }));
        }

        private void StopTimer(string rfid)
        {
            if (activeTimers.TryGetValue(rfid, out var timerData))
            {
                Timer timer = timerData.Item1;
                DateTime startTime = timerData.Item2;
                DateTime endTime = DateTime.Now;
                TimeSpan elapsed = endTime - startTime;

                // Stop and remove the timer
                timer.Dispose();
                activeTimers.Remove(rfid);

                // ✅ Find the last row where this RFID has a "-" in the "endTime" column and update it
                Invoke(new Action(() =>
                {
                    for (int i = DGV_Process.Rows.Count - 1; i >= 0; i--)
                    {
                        if (DGV_Process.Rows[i].Cells["operator"].Value?.ToString() == rfid && DGV_Process.Rows[i].Cells["serialno"].Value?.ToString() == serial &&
                            DGV_Process.Rows[i].Cells["endTime"].Value?.ToString() == "-")
                        {
                            DGV_Process.Rows[i].Cells["endTime"].Value = endTime.ToString("HH:mm:ss");
                            DGV_Process.Rows[i].Cells["duration"].Value = elapsed.ToString(@"hh\:mm\:ss");
                            return;
                        }
                    }
                }));
            }
        }


        private void TimerCallback(object state)
        {
            string rfid = (string)state;
            Console.WriteLine($"Timer running for {rfid}... {DateTime.Now}");
        }

        private void bunifuPanel3_Click(object sender, EventArgs e)
        {

        }
    }
}
