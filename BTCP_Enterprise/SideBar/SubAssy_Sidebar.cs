using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTCP_Enterprise.Forms;
using Newtonsoft.Json;

namespace BTCP_Enterprise.SideBar
{
    public partial class SubAssy_Sidebar : Form
    {
        string modulename = "Pre-Assy";
        string type;

        public string MOID;
        private object jsonResponse;
     
        public SubAssy_Sidebar(string moID)
        {
            InitializeComponent();
   
            MOID = moID;
           pb_loadingsidebar.Visible = false;
            Process_Panel.AutoScroll = true;

        }

        private void SubAssy_Sidebar_Load(object sender, EventArgs e)
        {
        
            string apiUrl = "https://app.btcp-enterprise.com/api/kit-list-item/scan?mo_id";
            Myrequest(apiUrl, MOID);
        }


        private async void Myrequest(string apiUrl, string modid)
        {
            try
            {
                var postData = new { serialnumber = modid };
                string json = JsonConvert.SerializeObject(postData);

                // 🔥 Ensure Correct API URL
                apiUrl = $"https://app.btcp-enterprise.com/api/kit-list-item/scan?mo_id={modid}";

                string jsonResponse = await Utilities.WebRequestApi.Operator_httpclient(apiUrl, json);

                Console.WriteLine($"Raw API Response: {jsonResponse}");

                if (string.IsNullOrEmpty(jsonResponse) || jsonResponse.Trim().StartsWith("<"))
                {
                    MessageBox.Show("Invalid response from server.", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var response = JsonConvert.DeserializeObject<List<ItemList>>(jsonResponse);

                if (response == null || response.Count == 0)
                {
                    MessageBox.Show("No valid data found.", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 🔥 Ensure UI updates are done in the main thread
                Process_Panel.Invoke((MethodInvoker)(() =>
                {
                    Process_Panel.Controls.Clear();
                   pb_loadingsidebar.Visible = true;

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

                   pb_loadingsidebar.Visible = false;
                }));
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



        public class ItemList
        {
            public int id { get; set; }
            public int kit_list_id { get; set; }
            public string mo_id { get; set; }
            public string description { get; set; }
            public string name { get; set; }
        }
        private void ProcessButton_Click(object sender, EventArgs e)
        {
            type = "S1";
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                MainDashboard mainDashboard = (MainDashboard)Application.OpenForms["MainDashboard"];
                string processId = clickedButton.Tag.ToString();
                string processName = clickedButton.Text;
                string serial = MOID;
                Forms.PreAssyOperfrm s1frm = new Forms.PreAssyOperfrm(processId, processName,MOID);
                mainDashboard.LoadChildForm(s1frm);
            }
        }


    }
}
