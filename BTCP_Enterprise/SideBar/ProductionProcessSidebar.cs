using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTCP_Enterprise.Forms;
using Newtonsoft.Json;
using static BTCP_Enterprise.SideBar.SubAssy_Sidebar;

namespace BTCP_Enterprise.SideBar
{
    public partial class ProductionProcessSidebar : Form
    {
        private object id;
        private object jsonResponse;
        public string moid;
        public string segment;
        public ProductionProcessSidebar(object id, string segment, string moid)
        {
            InitializeComponent();
            lbl_process.Text = segment;
            this.id = id;
            // label1.Text = id.ToString();
            Myrequest(id.ToString());
            Process_Panel.AutoScroll = true;
            this.moid = moid;
            this.segment = segment;
        }


        private async void Myrequest(string modid)
        {
            string jsonResponse = "";

            try
            {
                string apiUrl = $"https://app.btcp-enterprise.com/api/production-segment?id={modid}";
                jsonResponse = await Utilities.WebRequestApi.GetData_httpclient(apiUrl);

                Console.WriteLine($"Raw API Response: {jsonResponse}");

                if (string.IsNullOrEmpty(jsonResponse) || jsonResponse.Trim().StartsWith("<"))
                {
                    MessageBox.Show("Invalid response from server.", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var responseList = JsonConvert.DeserializeObject<List<ProductionSegment>>(jsonResponse);

                if (responseList == null || responseList.Count == 0)
                {
                    MessageBox.Show("No valid data found.", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var segment = responseList[0]; // You can loop if needed

                if (segment.process == null || segment.process.Count == 0)
                {
                    MessageBox.Show("No process data found.", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Process_Panel.Invoke((MethodInvoker)(() =>
                {

                    Process_Panel.Controls.Clear();

                    Panel loadingContainer = new Panel
                    {
                        Width = Process_Panel.ClientSize.Width,
                        Height = Process_Panel.ClientSize.Height,
                        BackColor = Color.Transparent // optional
                    };


                    pb_loadingSidebar.Location = new Point(
                        (loadingContainer.Width - pb_loadingSidebar.Width) / 10,
                        (loadingContainer.Height - pb_loadingSidebar.Height) / 10
                    );
                    pb_loadingSidebar.Visible = true;


                    loadingContainer.Controls.Add(pb_loadingSidebar);
                    Process_Panel.Controls.Add(loadingContainer);

                    Process_Panel.Controls.Clear();

                    Process_Panel.Controls.Clear();

                    foreach (var proc in segment.process)
                    {
                        Button btn = new Button
                        {
                            Text = proc.name,
                            Width = 220,
                            Height = 60,
                            BackColor = Color.SteelBlue,
                            Font = new Font("Arial", 10, FontStyle.Bold),
                            Cursor = Cursors.Hand,
                            ForeColor = Color.White,
                            FlatStyle = FlatStyle.Flat,
                            Tag = proc.id
                        };
                        btn.FlatAppearance.BorderSize = 0;
                        btn.Click += ProcessButton_Click;

                        Process_Panel.Controls.Add(btn);
                    }
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

        public class ProductionSegment
        {
            public int id { get; set; }
            public string name { get; set; }
        
            [JsonProperty("descripion")]
            public string Description { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }
            public List<Process> process { get; set; }
        }

        public class Process
        {
            public int id { get; set; }
            public int production_segment_id { get; set; }
            public string name { get; set; }

            [JsonProperty("descripion")]
            public string Description { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }
        }



        private void ProcessButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {

                MainDashboard mainDashboard = (MainDashboard)Application.OpenForms["MainDashboard"];
                string processId = clickedButton.Tag.ToString();
                string processName = clickedButton .Text;
                string moid = this.moid;
                string seg = segment;
                string serialnumber = string.Empty;
                string toplvlipn = string.Empty;
                string generatedcode = "SUBD1C500DS24A0001";
                ProcessForm.Sub_assyfrm subasy = new ProcessForm.Sub_assyfrm(moid, serialnumber, toplvlipn, seg, processName,generatedcode);
                mainDashboard.LoadChildForm(subasy);
            }

        }
    }
}
