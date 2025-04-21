namespace BTCP_Enterprise.Forms
{
    partial class ProductionSegmentFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductionSegmentFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.flowlayoutsegment = new System.Windows.Forms.FlowLayoutPanel();
            this.pb_loading = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.flowlayoutsegment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loading)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 81);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(409, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Production Segment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 18;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.flowlayoutsegment);
            this.bunifuPanel1.Location = new System.Drawing.Point(11, 86);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1166, 709);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // flowlayoutsegment
            // 
            this.flowlayoutsegment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowlayoutsegment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.flowlayoutsegment.Controls.Add(this.pb_loading);
            this.flowlayoutsegment.Location = new System.Drawing.Point(136, 24);
            this.flowlayoutsegment.Name = "flowlayoutsegment";
            this.flowlayoutsegment.Size = new System.Drawing.Size(912, 590);
            this.flowlayoutsegment.TabIndex = 1;
            // 
            // pb_loading
            // 
            this.pb_loading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_loading.Image = ((System.Drawing.Image)(resources.GetObject("pb_loading.Image")));
            this.pb_loading.Location = new System.Drawing.Point(3, 3);
            this.pb_loading.Name = "pb_loading";
            this.pb_loading.Size = new System.Drawing.Size(909, 587);
            this.pb_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_loading.TabIndex = 0;
            this.pb_loading.TabStop = false;
            // 
            // ProductionSegmentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1188, 824);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductionSegmentFrm";
            this.Text = "ProductionSegmentFrm";
            this.Load += new System.EventHandler(this.ProductionSegmentFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bunifuPanel1.ResumeLayout(false);
            this.flowlayoutsegment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_loading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowlayoutsegment;
        private System.Windows.Forms.PictureBox pb_loading;
    }
}