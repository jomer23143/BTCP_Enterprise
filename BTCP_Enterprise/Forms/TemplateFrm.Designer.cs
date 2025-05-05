namespace BTCP_Enterprise.Forms
{
    partial class TemplateFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_display = new Bunifu.UI.WinForms.BunifuPanel();
            this.flowlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.pb_loading = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel_display.SuspendLayout();
            this.flowlayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loading)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1626, 78);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 769);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1626, 59);
            this.panel2.TabIndex = 0;
            // 
            // panel_display
            // 
            this.panel_display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_display.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.panel_display.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_display.BackgroundImage")));
            this.panel_display.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_display.BorderColor = System.Drawing.Color.Transparent;
            this.panel_display.BorderRadius = 12;
            this.panel_display.BorderThickness = 1;
            this.panel_display.Controls.Add(this.flowlayout);
            this.panel_display.Location = new System.Drawing.Point(61, 84);
            this.panel_display.Name = "panel_display";
            this.panel_display.ShowBorders = true;
            this.panel_display.Size = new System.Drawing.Size(1282, 668);
            this.panel_display.TabIndex = 1;
            // 
            // flowlayout
            // 
            this.flowlayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowlayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.flowlayout.Controls.Add(this.pb_loading);
            this.flowlayout.Location = new System.Drawing.Point(28, 34);
            this.flowlayout.Name = "flowlayout";
            this.flowlayout.Size = new System.Drawing.Size(1233, 617);
            this.flowlayout.TabIndex = 0;
            // 
            // pb_loading
            // 
            this.pb_loading.AllowFocused = false;
            this.pb_loading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_loading.AutoSizeHeight = true;
            this.pb_loading.BorderRadius = 311;
            this.pb_loading.Image = ((System.Drawing.Image)(resources.GetObject("pb_loading.Image")));
            this.pb_loading.IsCircle = true;
            this.pb_loading.Location = new System.Drawing.Point(3, 3);
            this.pb_loading.Name = "pb_loading";
            this.pb_loading.Size = new System.Drawing.Size(623, 623);
            this.pb_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_loading.TabIndex = 0;
            this.pb_loading.TabStop = false;
            this.pb_loading.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // TemplateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1626, 828);
            this.Controls.Add(this.panel_display);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TemplateFrm";
            this.Text = "TemplateFrm";
            this.Load += new System.EventHandler(this.TemplateFrm_Load);
            this.panel_display.ResumeLayout(false);
            this.flowlayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_loading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuPanel panel_display;
        private System.Windows.Forms.FlowLayoutPanel flowlayout;
        private Bunifu.UI.WinForms.BunifuPictureBox pb_loading;
    }
}