using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTCP_Enterprise.Model;
using Newtonsoft.Json;
using static BTCP_Enterprise.Model.TestModel;

namespace BTCP_Enterprise.Forms
{
    public partial class TestForm : Form
    {
        private object jsonResponse;

        public TestForm()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string url = "https://app.btcp-enterprise.com/api/kit-list-item/scan-bulk";

            // Collecting input data from textboxes
            var kitListItems = new List<serial_number>
    {
            new KitListItem { id = txt_id1.Text, part_serial = txt_serial1.Text },
            new KitListItem { id = txt_id2.Text, part_serial = txt_serial2.Text },
            new KitListItem { id = txt_id3.Text, part_serial = txt_serial3.Text }
    };

            // Constructing JSON payload
            var requestData = new { kit_list_items = kitListItems };
            string jsonPayload = JsonConvert.SerializeObject(requestData, Formatting.Indented);

            // Sending API request
            await FetchDataAsync(url, jsonPayload);



        }



        public async Task FetchDataAsync(string apiUrl, string jsonPayload)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Setting headers
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    // Sending POST request
                    var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Raw API Response: {jsonResponse}");

                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Error: {response.StatusCode}\n{jsonResponse}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    MessageBox.Show("Data submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
