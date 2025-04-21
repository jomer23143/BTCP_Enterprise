using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTCP_Enterprise.Class;
using Newtonsoft.Json;
using static BTCP_Enterprise.SideBar.SubAssy_Sidebar;

namespace BTCP_Enterprise.Forms
{
    public partial class ProductionSegmentFrm : Form
    {
        public string moid;
        private object jsonResponse;

        public ProductionSegmentFrm(string moid)
        {
            InitializeComponent();
            this.moid = moid;
        }

   

        private void ProductionSegmentFrm_Load(object sender, EventArgs e)
        {
            string url = "https://app.btcp-enterprise.com/api/production-segment";
            RequesTProductSegment(url);
        }

        private void btn_subassembly_Click(object sender, EventArgs e)
        {
            MainDashboard mainDashboardSidebar = (MainDashboard)Application.OpenForms["MainDashboard"];  
            SideBar.SubAssy_Sidebar Subassembly = new SideBar.SubAssy_Sidebar(moid);
            mainDashboardSidebar.LoadSideBar(Subassembly);
        }

        private async void RequesTProductSegment(string apiUrl)
        {
            try
            {
                string jsonResponse = await Utilities.WebRequestApi.GetData_httpclient(apiUrl);

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
                MessageBox.Show($"Error: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
          
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                MainDashboard mainDashboard = (MainDashboard)Application.OpenForms["MainDashboard"];
                object processId = clickedButton.Tag;
                string processName = clickedButton.Text;
                SideBar.ProductionProcessSidebar process = new SideBar.ProductionProcessSidebar(processId, processName,moid);
                mainDashboard.LoadSideBar(process);
            }
        }

    }
}
