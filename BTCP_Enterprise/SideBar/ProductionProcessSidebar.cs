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
        public string themoid;
        public string segment;

        public ProductionProcessSidebar(object id, string segment, string moid)
        {
            InitializeComponent();
            lbl_process.Text = segment;
            this.id = id;
            // label1.Text = id.ToString();
          
            Process_Panel.AutoScroll = true;
            this.themoid = moid;
            this.segment = segment;
            Myrequest(id.ToString(), themoid);
        }


        private async void Myrequest(string moidmodid,string boomid)
        {
            string jsonResponse = "";

            try
            {
                //string apiUrl = $"https://app.btcp-enterprise.com/api/product?with_segment={id}";
                string postData = $"https://app.btcp-enterprise.com/api/product?bom_item={boomid}&with_segment={id}&with_process={id}";
                Console.WriteLine($"API URL: {postData}");

                jsonResponse = await Utilities.WebRequestApi.GetData_httpclient(postData);

                Console.WriteLine($"Raw API Response: {jsonResponse}");

                if (string.IsNullOrEmpty(jsonResponse) || jsonResponse.Trim().StartsWith("<"))
                {
                    MessageBox.Show("Invalid response from server.", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var root = JsonConvert.DeserializeObject<Root>(jsonResponse);


                if (root?.data == null || root.data.Count == 0)
                {
                    MessageBox.Show("No valid data found.", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var firstDatum = root.data[0];

                if (firstDatum.segment == null || firstDatum.segment.Count == 0)
                {
                    MessageBox.Show("No segment data found.", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var segment = firstDatum.segment[0];

                if (segment.process == null || segment.process.Count == 0)
                {
                    MessageBox.Show("No process data found.", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // UI updates
                Process_Panel.Invoke((MethodInvoker)(() =>
                {
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
                Console.WriteLine($"Error: {ex.Message}");
                MessageBox.Show($"Error: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Datum
        {
            public int id { get; set; }
            public string bom_item { get; set; }
            public string description { get; set; }
            public string bom_revision_number { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public List<Segment> segment { get; set; }
        }

        public class Link
        {
            public string url { get; set; }
            public string label { get; set; }
            public bool active { get; set; }
        }

        public class Process
        {
            public int id { get; set; }
            public int product_segment_id { get; set; }
            public string name { get; set; }
            public object descripion { get; set; }
            public int is_active { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
        }

        public class Root
        {
            public int current_page { get; set; }
            public List<Datum> data { get; set; }
            public string first_page_url { get; set; }
            public int from { get; set; }
            public int last_page { get; set; }
            public string last_page_url { get; set; }
            public List<Link> links { get; set; }
            public object next_page_url { get; set; }
            public string path { get; set; }
            public int per_page { get; set; }
            public object prev_page_url { get; set; }
            public int to { get; set; }
            public int total { get; set; }
        }

        public class Segment
        {
            public int id { get; set; }
            public int product_id { get; set; }
            public string name { get; set; }
            public object descripion { get; set; }
            public int is_serial { get; set; }
            public int is_active { get; set; }
            public object format { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public List<Process> process { get; set; }
        }




        private void ProcessButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {

                MainDashboard mainDashboard = (MainDashboard)Application.OpenForms["MainDashboard"];
                string processId = clickedButton.Tag.ToString();
                string processName = clickedButton .Text;
                string moid = this.themoid;
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
