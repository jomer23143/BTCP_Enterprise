using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTCP_Enterprise.Model;
using Newtonsoft.Json;

namespace BTCP_Enterprise.SideBar
{
    public partial class PreAss_Sidebar : Form
    {

        string modulename = "Pre-Assy";
        string type;
        private object jsonResponse;

        public PreAss_Sidebar()
        {
            InitializeComponent();
        }

        private void btn_s1_Click(object sender, EventArgs e)
        {
            type = "S1";
            Forms.Login login = new Forms.Login(modulename,type);
            login.Show();
        }


        private void PreAss_Sidebar_Load(object sender, EventArgs e)
        {
            string apiUrl = "http://127.0.0.1:8000/pre-assy";
            Myrequest(apiUrl);
        }

        private async void Myrequest(string apiUrl)
        {
            try
            {
          

                string jsonResponse = await Utilities.WebRequestApi.GetData_httpclient(apiUrl);

                Console.WriteLine($"Raw API Response: {jsonResponse}");

                //if (string.IsNullOrEmpty(jsonResponse) || jsonResponse.Trim().StartsWith("<"))
                //{
                //    MessageBox.Show("Invalid response from server.", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                //var response = JsonConvert.DeserializeObject<Process>(jsonResponse);

                //if (response == null)
                //{
                //    MessageBox.Show("Invalid response format.", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}

                label2.Text = jsonResponse;




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

       
    }
}
