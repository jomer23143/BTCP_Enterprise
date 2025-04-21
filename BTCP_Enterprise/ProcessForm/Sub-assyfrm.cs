using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Documents;
using System.Windows.Forms;
using QRCoder;

namespace BTCP_Enterprise.ProcessForm
{
    public partial class Sub_assyfrm : Form
    {
        public string toplvlipn;
        public string psegment;
        public string station;
        public string mo;
        public string serialnumber;
        public string generatedcode;
        public Sub_assyfrm(string mo,string serialno,string toplvlipn, string psegment, string station,string code)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            this.FormBorderStyle = FormBorderStyle.None;
         
            PB_qrcode.SizeMode = PictureBoxSizeMode.StretchImage;
            lbl_qrinfo.Visible = false;
            PB_qrcode.Visible = false;
            this.mo = mo;
            this.serialnumber = serialno;
            this.toplvlipn = toplvlipn;
            this.psegment = psegment;
            this.station = station;
            this.generatedcode = code;
        }

        public void qrcodecontroller()
        {
            btn_scan.Visible = true;
            PB_qrcode.SizeMode = PictureBoxSizeMode.StretchImage;
            lbl_qrinfo.Visible = false;
            PB_qrcode.Visible = false;
        }
        public void response()
        {
            string timeend = DateTime.Now.ToString("hh:mm:ss");
            string timeStart = lbl_timestart.Text;
            TimeSpan duration = DateTime.Parse(timeend) - DateTime.Parse(timeStart);
            string durationString = duration.ToString(@"hh\:mm\:ss");
            lbl_timeEnd.Text = timeend;
            lbl_duration.Text = durationString;
        }
        private void Sub_assyfrm_Load(object sender, EventArgs e)
        {
            lbl_segment.Text = psegment;
            lbl_toplvlipn.Text = toplvlipn;
            lbl_station.Text = station;
            lbl_generatedserial.Text = generatedcode;
            lbl_timestart.Text = DateTime.Now.ToString("hh:mm:ss");

        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            btn_scan.Visible = false;
            PB_qrcode.Visible = true;
            lbl_qrinfo.Visible = true;
            string id = string.Empty;
            string processname = "Sub Assy";
            string moid = mo;
            string segment = psegment;
            GenerateQRCode(lbl_generatedserial.Text);
            Modal.Scanner scan = new Modal.Scanner(id,processname,mo,segment,this);
            scan.ShowDialog();
        }

        private void GenerateQRCode(string qrText)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            PB_qrcode.Image = qrCodeImage;
        }

    }
}
