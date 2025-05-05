using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BTCP_Enterprise.Modal;
using Newtonsoft.Json;

namespace BTCP_Enterprise.Forms
{
    public partial class ProductionSegmentFrm : Form
    {
        public string boom_item;
        private object jsonResponse;

        public ProductionSegmentFrm(string moid)
        {
            InitializeComponent();
            this.boom_item = moid;

            // Force these settings to avoid borders when embedded
            this.TopLevel = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }


        private void ProductionSegmentFrm_Load(object sender, EventArgs e)
        {
            Console.WriteLine($"MOID: {boom_item}");
            lbl_Test.Text = boom_item;
            string url = $"https://app.btcp-enterprise.com/api/product?with_segment={boom_item}";
            RequesTProductSegment(url, boom_item);
        }



        private async void RequesTProductSegment(string apiUrl, string moid)
        {
            try
            {
                string jsonResponse = await Utilities.WebRequestApi.GetData_httpclient(apiUrl);

                Console.WriteLine($"Raw API Response: {jsonResponse}");

                if (string.IsNullOrEmpty(jsonResponse) || jsonResponse.Trim().StartsWith("<"))
                {
                    CustomeAlert.Alertype type = CustomeAlert.Alertype.Warning;
                    Modal.CustomeAlert alert = new Modal.CustomeAlert("API ERROR", "Invalid response from server.", type);
                    alert.ShowDialog();
                    return;
                }

                var root = JsonConvert.DeserializeObject<Root>(jsonResponse);
                var response = root?.data?.FirstOrDefault()?.segment;


                if (response == null || response.Count == 0)
                {

                    CustomeAlert.Alertype type = CustomeAlert.Alertype.Warning;
                    Modal.CustomeAlert alert = new Modal.CustomeAlert("Attention: API Error", "No data available\", \"We couldn't find any items for your request.", type);
                    alert.ShowDialog();
                    return;
                }

                flowlayoutsegment.Invoke((MethodInvoker)(() =>
                {
                    flowlayoutsegment.Controls.Clear();

                    Panel loadingContainer = new Panel
                    {
                        Width = flowlayoutsegment.ClientSize.Width,
                        Height = flowlayoutsegment.ClientSize.Height,
                        BackColor = Color.Transparent // optional
                    };


                    pb_loading.Location = new Point(
                        (loadingContainer.Width - pb_loading.Width) / 10,
                        (loadingContainer.Height - pb_loading.Height) / 10
                    );
                    pb_loading.Visible = true;


                    loadingContainer.Controls.Add(pb_loading);
                    flowlayoutsegment.Controls.Add(loadingContainer);

                    flowlayoutsegment.Controls.Clear();

                    foreach (var process in response)
                    {
                        Button btn = new Button
                        {
                            Text = $"{process.name}",
                            Width = 440,
                            Height = 100,
                            BackColor = Color.FromArgb(100, 180, 45),
                            Font = new Font("Arial", 14, FontStyle.Bold),
                            Cursor = Cursors.Hand,
                            ForeColor = Color.White,
                            FlatAppearance = { BorderSize = 0 },
                            FlatStyle = FlatStyle.Flat,
                            Tag = process.id
                        };

                        btn.Click += ProcessButton_Click;
                        flowlayoutsegment.Controls.Add(btn);
                    }

                    pb_loading.Visible = false;
                }));
            }

            catch (JsonReaderException ex)
            {
                MessageBox.Show($"JSON Error: {ex.Message}\n\nResponse: {jsonResponse}", "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error: {ex.Message}");
                CustomeAlert.Alertype type = CustomeAlert.Alertype.Warning;
                Modal.CustomeAlert alert = new Modal.CustomeAlert("API ERROR", ex.Message, type);
                alert.ShowDialog();

            }
        }
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class ApiResponse
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

        public class Root
        {
            public int current_page { get; set; }
            public List<ApiResponse> data { get; set; }
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
        }




        private void ProcessButton_Click(object sender, EventArgs e)
        {

            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                MainDashboard mainDashboard = (MainDashboard)Application.OpenForms["MainDashboard"];
                object processId = clickedButton.Tag;
                string processName = clickedButton.Text;
                SideBar.ProductionProcessSidebar process = new SideBar.ProductionProcessSidebar(processId, processName, lbl_Test.Text);
                mainDashboard.LoadSideBar(process);
            }
        }

    }
}
