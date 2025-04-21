namespace BTCP_Enterprise.SideBar
{
    partial class ProductionProcessSidebar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductionProcessSidebar));
            this.lbl_process = new System.Windows.Forms.Label();
            this.Process_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.pb_loadingSidebar = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.Process_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loadingSidebar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_process
            // 
            this.lbl_process.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.lbl_process.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_process.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_process.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_process.Location = new System.Drawing.Point(0, 0);
            this.lbl_process.Name = "lbl_process";
            this.lbl_process.Size = new System.Drawing.Size(309, 54);
            this.lbl_process.TabIndex = 1;
            this.lbl_process.Text = "Sub-Assy";
            this.lbl_process.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Process_Panel
            // 
            this.Process_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Process_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(85)))));
            this.Process_Panel.Controls.Add(this.pb_loadingSidebar);
            this.Process_Panel.Location = new System.Drawing.Point(6, 56);
            this.Process_Panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Process_Panel.Name = "Process_Panel";
            this.Process_Panel.Size = new System.Drawing.Size(300, 707);
            this.Process_Panel.TabIndex = 5;
            // 
            // pb_loadingSidebar
            // 
            this.pb_loadingSidebar.AllowFocused = false;
            this.pb_loadingSidebar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_loadingSidebar.AutoSizeHeight = true;
            this.pb_loadingSidebar.BorderRadius = 152;
            this.pb_loadingSidebar.Image = ((System.Drawing.Image)(resources.GetObject("pb_loadingSidebar.Image")));
            this.pb_loadingSidebar.IsCircle = true;
            this.pb_loadingSidebar.Location = new System.Drawing.Point(4, 4);
            this.pb_loadingSidebar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_loadingSidebar.Name = "pb_loadingSidebar";
            this.pb_loadingSidebar.Size = new System.Drawing.Size(305, 305);
            this.pb_loadingSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_loadingSidebar.TabIndex = 0;
            this.pb_loadingSidebar.TabStop = false;
            this.pb_loadingSidebar.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // ProductionProcessSidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(309, 762);
            this.Controls.Add(this.Process_Panel);
            this.Controls.Add(this.lbl_process);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProductionProcessSidebar";
            this.Text = "ProductionProcessSidebar";
            this.Process_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_loadingSidebar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_process;
        private System.Windows.Forms.FlowLayoutPanel Process_Panel;
        private Bunifu.UI.WinForms.BunifuPictureBox pb_loadingSidebar;
    }
}