using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTCP_Enterprise.Class;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO.Ports;
using System.Data.SqlClient;
using BTCP_Enterprise.Model;
using Newtonsoft.Json;
using BTCP_Enterprise.Utilities;
using System.IO;



namespace BTCP_Enterprise.Forms
{
    public partial class Login: Form
    {
        private object jsonResponse;
        public string modulename;
        public string type;
        public Login(string modulename, string type)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            Corners corners = new Corners();
            corners.RoundedFormsDocker(this, 18);
            txt_scanid.Select();
            lbl_userinfo.Text = "Tap ID to Proceed.";
            lbl_position.Text = "";
            //txt_scanid.Hide();
            btn_close.TextAlign = ContentAlignment.MiddleCenter;
            this.modulename = modulename;
            this.type = type;
        }
          

     
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DragDropForm.ReleaseCapture();
                DragDropForm.SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void txt_id_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_scanid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txt_scanid.Text))
            {
                lbl_userinfo.Text = "Processing...";

                string apiUrl = "https://app.btcp-enterprise.com/api/login-production"; // No need to append scan_id

                // Call API with correct dat
                Myrequest(apiUrl, txt_scanid.Text);

                // Clear input field after scanning
                txt_scanid.Clear();
                txt_scanid.Focus();

                e.Handled = true; // Prevents the Enter key from making a system sound
            }
        }


        private async void Myrequest(string apiUrl, string rfid)
        {
            try
            {
                var postData = new { rfid_no = rfid };
                string json = JsonConvert.SerializeObject(postData);

                string jsonResponse = await Utilities.WebRequestApi.Operator_httpclient(apiUrl, json);

                Console.WriteLine($"Raw API Response: {jsonResponse}");

                if (string.IsNullOrEmpty(jsonResponse) || jsonResponse.Trim().StartsWith("<"))
                {
                    MessageBox.Show("Invalid response from server.", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var response = JsonConvert.DeserializeObject<operatorAPI_Response>(jsonResponse);

                if (response == null || response.user == null)
                {
                    MessageBox.Show("Failed to parse API response.", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ Corrected property accesses
                txt_id.Text = response.user.employee_id.ToString() ?? "N/A";
                lbl_userinfo.Text = $"{response.user.profile?.first_name ?? ""} {response.user.profile?.last_name ?? ""}".Trim();
                lbl_position.Text = response.user.job_title ?? "Unknown";

                // ✅ Default image setup
                string defaultImagePath = Path.Combine(Application.StartupPath, "Assets", "Unknown.png");
                string imagePath = defaultImagePath;  // No image found in response

                pb_rfid.Image = File.Exists(imagePath) ? Image.FromFile(imagePath) : null;

                await Task.Delay(1000);

                // ✅ Reset UI
                string defaultImagePathRfid = Path.Combine(Application.StartupPath, "Assets", "rfid.png");
                txt_id.Text = "";
                lbl_userinfo.Text = "Tap ID to Proceed.";
                lbl_position.Text = "";
                pb_rfid.Image = Image.FromFile(defaultImagePathRfid);

               getLoadModule(modulename, type);
                this.Close();
            }
            catch (JsonReaderException ex)
            {
                MessageBox.Show($"JSON Error: {ex.Message}\n\nResponse: {jsonResponse}", "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl_userinfo.Text = "The Server has incounter a problem please contact IT.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void getLoadModule(string module,string type)
        {
            MainDashboard mainDashboard = (MainDashboard)Application.OpenForms["MainDashboard"];
            switch (module)
            {
                case "Pre-Assy":
                  if (type == "S1")
                    {
                        Forms.OperatorsVFrm s1frm = new Forms.OperatorsVFrm();
                       
                        if (mainDashboard != null)
                        {
                            mainDashboard.LoadChildForm(s1frm);
                        }
                        else
                        {
                            MessageBox.Show("Main Dashboard not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }    
                    break;
                case "Material Inventory":
                    Forms.Kitlistfrm kitlistfrm = new Forms.Kitlistfrm();
                    if (mainDashboard != null)
                    {
                        mainDashboard.LoadChildForm(kitlistfrm);
                    }
                    else
                    {
                        MessageBox.Show("Main Dashboard not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default:
                    MessageBox.Show("Module not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

           
        }





        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
