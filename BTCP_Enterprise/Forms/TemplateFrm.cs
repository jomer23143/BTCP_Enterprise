using System;
using System.Drawing;
using System.Windows.Forms;
using BTCP_Enterprise.Modal;
using BTCP_Enterprise.Model;
using Newtonsoft.Json;

namespace BTCP_Enterprise.Forms
{
    public partial class TemplateFrm : Form
    {
        private object jsonResponse;

        public TemplateFrm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void TemplateFrm_Load(object sender, EventArgs e)
        {
            string url = $"https://app.btcp-enterprise.com/api/product?with_segment";
            RequesTemplate(url);
        }


        private async void RequesTemplate(string apiUrl)
        {
            try
            {
                string jsonResponse = await Utilities.WebRequestApi.GetData_httpclient(apiUrl);

                Console.WriteLine($"Raw API Response: {jsonResponse}");

                if (string.IsNullOrEmpty(jsonResponse) || jsonResponse.Trim().StartsWith("<"))
                {
                    var type = CustomeAlert.Alertype.Warning;
                    var alert = new Modal.CustomeAlert("API ERROR", "Invalid response from server.", type);
                    alert.ShowDialog();
                    return;
                }

                var root = JsonConvert.DeserializeObject<TemplateModel.ProductRoot>(jsonResponse);
                var products = root?.data;

                if (products == null || products.Count == 0)
                {
                    MessageBox.Show("No product data found.", "API Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                flowlayout.Invoke((MethodInvoker)(() =>
                {
                    flowlayout.Controls.Clear();

                    // Loading indicator setup (optional, if used)
                    pb_loading.Visible = true;

                    foreach (var product in products)
                    {
                        Button btn = new Button
                        {
                            Text = $"Description: {product.description}  | Bom Item:{product.bom_item} | Rev: {product.bom_revision_number}",
                            Width = 440,
                            Height = 100,
                            BackColor = Color.FromArgb(100, 180, 45),
                            Font = new Font("Arial", 14, FontStyle.Bold),
                            Cursor = Cursors.Hand,
                            ForeColor = Color.White,
                            FlatStyle = FlatStyle.Flat,
                            Tag = product.id
                        };
                        btn.FlatAppearance.BorderSize = 0;

                        btn.Click += ProcessButton_Click;
                        flowlayout.Controls.Add(btn);
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
                var type = CustomeAlert.Alertype.Warning;
                var alert = new Modal.CustomeAlert("API ERROR", ex.Message, type);
                alert.ShowDialog();
            }
        }






        private void ProcessButton_Click(object sender, EventArgs e)
        {

            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                //MainDashboard mainDashboard = (MainDashboard)Application.OpenForms["MainDashboard"];
                //object processId = clickedButton.Tag;
                //string processName = clickedButton.Text;
                //SideBar.ProductionProcessSidebar process = new SideBar.ProductionProcessSidebar(processId, processName, moid);
                //mainDashboard.LoadSideBar(process);
                Modal.ViewTemplateDetialsFrm templateDetails = new Modal.ViewTemplateDetialsFrm();
                templateDetails.FormBorderStyle = FormBorderStyle.None;
                templateDetails.ShowDialog(this); // Still shows as popup, but borderless

            }
        }







    }
}
