namespace BTCP_Enterprise.SideBar
{
    partial class SubAssy_Sidebar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubAssy_Sidebar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Process_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.pb_loadingsidebar = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel1.SuspendLayout();
            this.Process_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loadingsidebar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 58);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sub-Assy";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Process_Panel
            // 
            this.Process_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Process_Panel.BackColor = System.Drawing.Color.White;
            this.Process_Panel.Controls.Add(this.pb_loadingsidebar);
            this.Process_Panel.Location = new System.Drawing.Point(1, 60);
            this.Process_Panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Process_Panel.Name = "Process_Panel";
            this.Process_Panel.Size = new System.Drawing.Size(232, 526);
            this.Process_Panel.TabIndex = 4;
            // 
            // pb_loadingsidebar
            // 
            this.pb_loadingsidebar.AllowFocused = false;
            this.pb_loadingsidebar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_loadingsidebar.AutoSizeHeight = true;
            this.pb_loadingsidebar.BorderRadius = 115;
            this.pb_loadingsidebar.Image = ((System.Drawing.Image)(resources.GetObject("pb_loadingsidebar.Image")));
            this.pb_loadingsidebar.IsCircle = true;
            this.pb_loadingsidebar.Location = new System.Drawing.Point(2, 2);
            this.pb_loadingsidebar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_loadingsidebar.Name = "pb_loadingsidebar";
            this.pb_loadingsidebar.Size = new System.Drawing.Size(230, 230);
            this.pb_loadingsidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_loadingsidebar.TabIndex = 0;
            this.pb_loadingsidebar.TabStop = false;
            this.pb_loadingsidebar.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // SubAssy_Sidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 619);
            this.Controls.Add(this.Process_Panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SubAssy_Sidebar";
            this.Text = "SubAssy_Sidebar";
            this.Load += new System.EventHandler(this.SubAssy_Sidebar_Load);
            this.panel1.ResumeLayout(false);
            this.Process_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_loadingsidebar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel Process_Panel;
        private Bunifu.UI.WinForms.BunifuPictureBox pb_loadingsidebar;
    }
}