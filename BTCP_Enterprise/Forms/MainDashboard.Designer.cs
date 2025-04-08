namespace BTCP_Enterprise.Forms
{
    partial class MainDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            this.panel_menubar = new System.Windows.Forms.Panel();
            this.lbl_currentdate = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.btn_warehousekiting = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_material_recieving = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_main_display = new System.Windows.Forms.Panel();
            this.panel_main_form = new Bunifu.UI.WinForms.BunifuPanel();
            this.panel_sidebar = new Bunifu.UI.WinForms.BunifuPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_menubar.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.panel_main_display.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menubar
            // 
            this.panel_menubar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.panel_menubar.Controls.Add(this.lbl_currentdate);
            this.panel_menubar.Controls.Add(this.lbl_time);
            this.panel_menubar.Controls.Add(this.btn_warehousekiting);
            this.panel_menubar.Controls.Add(this.button3);
            this.panel_menubar.Controls.Add(this.button4);
            this.panel_menubar.Controls.Add(this.button2);
            this.panel_menubar.Controls.Add(this.btn_material_recieving);
            this.panel_menubar.Controls.Add(this.label1);
            this.panel_menubar.Controls.Add(this.panel2);
            this.panel_menubar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menubar.Location = new System.Drawing.Point(0, 0);
            this.panel_menubar.Margin = new System.Windows.Forms.Padding(2);
            this.panel_menubar.Name = "panel_menubar";
            this.panel_menubar.Size = new System.Drawing.Size(1218, 54);
            this.panel_menubar.TabIndex = 0;
            this.panel_menubar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lbl_currentdate
            // 
            this.lbl_currentdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_currentdate.AutoSize = true;
            this.lbl_currentdate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentdate.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_currentdate.Location = new System.Drawing.Point(1060, 30);
            this.lbl_currentdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_currentdate.Name = "lbl_currentdate";
            this.lbl_currentdate.Size = new System.Drawing.Size(154, 17);
            this.lbl_currentdate.TabIndex = 4;
            this.lbl_currentdate.Text = "Monday, October 07 2024";
            this.lbl_currentdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_time
            // 
            this.lbl_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.lbl_time.Location = new System.Drawing.Point(1109, 5);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(102, 21);
            this.lbl_time.TabIndex = 3;
            this.lbl_time.Text = "10:10:00 AM";
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_warehousekiting
            // 
            this.btn_warehousekiting.FlatAppearance.BorderSize = 0;
            this.btn_warehousekiting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_warehousekiting.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_warehousekiting.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_warehousekiting.Location = new System.Drawing.Point(256, 14);
            this.btn_warehousekiting.Margin = new System.Windows.Forms.Padding(2);
            this.btn_warehousekiting.Name = "btn_warehousekiting";
            this.btn_warehousekiting.Size = new System.Drawing.Size(156, 28);
            this.btn_warehousekiting.TabIndex = 2;
            this.btn_warehousekiting.Text = "Warehouse Recieving";
            this.btn_warehousekiting.UseVisualStyleBackColor = true;
            this.btn_warehousekiting.Click += new System.EventHandler(this.btn_warehousekiting_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Location = new System.Drawing.Point(724, 14);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sub Assy";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button4.Location = new System.Drawing.Point(880, 14);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 28);
            this.button4.TabIndex = 2;
            this.button4.Text = "Rain Test";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Location = new System.Drawing.Point(568, 14);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Pre Assy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_material_recieving
            // 
            this.btn_material_recieving.FlatAppearance.BorderSize = 0;
            this.btn_material_recieving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_material_recieving.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_material_recieving.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_material_recieving.Location = new System.Drawing.Point(412, 14);
            this.btn_material_recieving.Margin = new System.Windows.Forms.Padding(2);
            this.btn_material_recieving.Name = "btn_material_recieving";
            this.btn_material_recieving.Size = new System.Drawing.Size(156, 28);
            this.btn_material_recieving.TabIndex = 2;
            this.btn_material_recieving.Text = "Material Recieving";
            this.btn_material_recieving.UseVisualStyleBackColor = true;
            this.btn_material_recieving.Click += new System.EventHandler(this.btn_material_recieving_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(225, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(10, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 28);
            this.panel2.TabIndex = 0;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_main_display);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 54);
            this.panel_main.Margin = new System.Windows.Forms.Padding(2);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1218, 677);
            this.panel_main.TabIndex = 1;
            // 
            // panel_main_display
            // 
            this.panel_main_display.Controls.Add(this.panel_main_form);
            this.panel_main_display.Controls.Add(this.panel_sidebar);
            this.panel_main_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main_display.Location = new System.Drawing.Point(0, 0);
            this.panel_main_display.Margin = new System.Windows.Forms.Padding(2);
            this.panel_main_display.Name = "panel_main_display";
            this.panel_main_display.Size = new System.Drawing.Size(1218, 677);
            this.panel_main_display.TabIndex = 0;
            // 
            // panel_main_form
            // 
            this.panel_main_form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_main_form.BackgroundColor = System.Drawing.Color.Transparent;
            this.panel_main_form.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_main_form.BackgroundImage")));
            this.panel_main_form.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_main_form.BorderColor = System.Drawing.Color.Transparent;
            this.panel_main_form.BorderRadius = 12;
            this.panel_main_form.BorderThickness = 1;
            this.panel_main_form.Location = new System.Drawing.Point(256, 5);
            this.panel_main_form.Margin = new System.Windows.Forms.Padding(2);
            this.panel_main_form.Name = "panel_main_form";
            this.panel_main_form.ShowBorders = true;
            this.panel_main_form.Size = new System.Drawing.Size(950, 658);
            this.panel_main_form.TabIndex = 1;
            // 
            // panel_sidebar
            // 
            this.panel_sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_sidebar.BackgroundColor = System.Drawing.Color.Transparent;
            this.panel_sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_sidebar.BackgroundImage")));
            this.panel_sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_sidebar.BorderColor = System.Drawing.Color.Transparent;
            this.panel_sidebar.BorderRadius = 12;
            this.panel_sidebar.BorderThickness = 1;
            this.panel_sidebar.Location = new System.Drawing.Point(10, 5);
            this.panel_sidebar.Margin = new System.Windows.Forms.Padding(2);
            this.panel_sidebar.Name = "panel_sidebar";
            this.panel_sidebar.ShowBorders = true;
            this.panel_sidebar.Size = new System.Drawing.Size(232, 658);
            this.panel_sidebar.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1218, 731);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_menubar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            this.panel_menubar.ResumeLayout(false);
            this.panel_menubar.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_main_display.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menubar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_warehousekiting;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_material_recieving;
        private System.Windows.Forms.Label lbl_currentdate;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_main_display;
        private Bunifu.UI.WinForms.BunifuPanel panel_main_form;
        private Bunifu.UI.WinForms.BunifuPanel panel_sidebar;
        private System.Windows.Forms.Timer timer1;
    }
}