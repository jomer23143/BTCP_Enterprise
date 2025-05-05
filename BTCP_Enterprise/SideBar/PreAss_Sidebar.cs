using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTCP_Enterprise.Forms;
using BTCP_Enterprise.Model;
using Newtonsoft.Json;

namespace BTCP_Enterprise.SideBar
{
    public partial class PreAss_Sidebar : Form
    {
        string modulename = "Pre-Assy";
        string type;

        public string   MOID;
        private object jsonResponse;

        public PreAss_Sidebar(string mOID)
        {
            InitializeComponent();
            InitializeFlowLayoutPanel();
            MOID = mOID;
        }

        private void InitializeFlowLayoutPanel()
        {
           
        }

        private void PreAss_Sidebar_Load(object sender, EventArgs e)
        {
            //for testing purposes
            //string apiUrl = "http://127.0.0.1:8000/pre-assy";
            //Myrequest(apiUrl);
            string apiUrl = "https://app.btcp-enterprise.com/api/kit-list-item/scan?mo_id"; 
            Myrequest(apiUrl, MOID);
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

        //        Process_Panel.Controls.Clear(); // Clear old buttons

        //        foreach (var process in processes)
        //        {
        //            Button btn = new Button
        //            {
        //                Text = process.ProcessName,
        //                Width = 220,
        //                Height = 50,
        //                BackColor = Color.SeaGreen,
        //                Font = new Font("Arial", 10, FontStyle.Bold),
        //                Cursor = Cursors.Hand,
        //                ForeColor = Color.White,
        //                FlatAppearance = { BorderSize = 0 },
        //                FlatStyle = FlatStyle.Flat,
        //                Tag = process.Id
        //            };

        //            btn.Click += ProcessButton_Click;
        //            Process_Panel.Controls.Add(btn);
        //        }
        //    }
        //    catch (System.Text.Json.JsonException ex)
        //    {
        //        MessageBox.Show($"JSON Parsing Error: {ex.Message}", "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        private async void Myrequest(string apiUrl, string modid)
        {
            try
            {
                var postData = new { serialnumber = modid };
                string json = JsonConvert.SerializeObject(postData);

                string jsonResponse = await Utilities.WebRequestApi.Operator_httpclient(apiUrl, json);

                Console.WriteLine($"Raw API Response: {jsonResponse}");

                if (string.IsNullOrEmpty(jsonResponse) || jsonResponse.Trim().StartsWith("<"))
                {
                    MessageBox.Show("Invalid response from server.", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

             
                var response = JsonConvert.DeserializeObject<List<KitItem>>(jsonResponse);

                if (response == null || response.Count == 0)
                {
                    MessageBox.Show("No valid data found.", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Process_Panel.Controls.Clear();

                foreach (var process in response) 
                {
                    Button btn = new Button
                    {
                        Text = $"{process.description}",
                        Width = 220,
                        Height = 60,
                        BackColor = Color.SeaGreen,
                        Font = new Font("Arial", 10, FontStyle.Bold),
                        Cursor = Cursors.Hand,
                        ForeColor = Color.White,
                        FlatAppearance = { BorderSize = 0 },
                        FlatStyle = FlatStyle.Flat,
                        Tag = process.id 
                    };

                    btn.Click += ProcessButton_Click;
                    Process_Panel.Controls.Add(btn);
                }
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

      
        public class KitItem
        {
            public int id { get; set; }
            public int kit_list_id { get; set; }
            public string mo_id { get; set; } 
            public string description { get; set; }  
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            type = "S1";
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                //MessageBox.Show($"You clicked: {clickedButton.Text} (ID: {clickedButton.Tag})", "Process Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Forms.Login login = new Forms.Login(modulename, type);
                //login.ShowDialog();

                MainDashboard mainDashboard = (MainDashboard)Application.OpenForms["MainDashboard"];
                string processId = clickedButton.Tag.ToString();
                string processName = clickedButton.Text;
                string moid =Convert.ToString(MOID);
                Forms.PreAssyOperfrm s1frm = new Forms.PreAssyOperfrm(processId,processName, MOID);
                mainDashboard.LoadChildForm(s1frm);
            }
        }

        private void Process_Panel_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void PreAss_Sidebar_Resize(object sender, EventArgs e)
        {
           
        }
    }

}
