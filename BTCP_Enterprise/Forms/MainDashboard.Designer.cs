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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel_menubar = new System.Windows.Forms.Panel();
            this.lbl_currentdate = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.btn_warehousekiting = new System.Windows.Forms.Button();
            this.btn_processflow = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_template = new System.Windows.Forms.Button();
            this.btn_material_recieving = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_main_display = new System.Windows.Forms.Panel();
            this.Lbl_versionControl = new System.Windows.Forms.Label();
            this.btn_logout = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel_main_form = new Bunifu.UI.WinForms.BunifuPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel_Graph = new Bunifu.UI.WinForms.BunifuPanel();
            this.panel_sidebar = new Bunifu.UI.WinForms.BunifuPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_menubar.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.panel_main_display.SuspendLayout();
            this.panel_main_form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menubar
            // 
            this.panel_menubar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.panel_menubar.Controls.Add(this.lbl_currentdate);
            this.panel_menubar.Controls.Add(this.lbl_time);
            this.panel_menubar.Controls.Add(this.btn_warehousekiting);
            this.panel_menubar.Controls.Add(this.btn_processflow);
            this.panel_menubar.Controls.Add(this.button4);
            this.panel_menubar.Controls.Add(this.btn_template);
            this.panel_menubar.Controls.Add(this.btn_material_recieving);
            this.panel_menubar.Controls.Add(this.label1);
            this.panel_menubar.Controls.Add(this.panel2);
            this.panel_menubar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menubar.Location = new System.Drawing.Point(0, 0);
            this.panel_menubar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_menubar.Name = "panel_menubar";
            this.panel_menubar.Size = new System.Drawing.Size(2525, 66);
            this.panel_menubar.TabIndex = 0;
            this.panel_menubar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lbl_currentdate
            // 
            this.lbl_currentdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_currentdate.AutoSize = true;
            this.lbl_currentdate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentdate.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_currentdate.Location = new System.Drawing.Point(2312, 37);
            this.lbl_currentdate.Name = "lbl_currentdate";
            this.lbl_currentdate.Size = new System.Drawing.Size(193, 21);
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
            this.lbl_time.Location = new System.Drawing.Point(2404, 6);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(104, 28);
            this.lbl_time.TabIndex = 3;
            this.lbl_time.Text = "10:10 AM";
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_warehousekiting
            // 
            this.btn_warehousekiting.FlatAppearance.BorderSize = 0;
            this.btn_warehousekiting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_warehousekiting.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_warehousekiting.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_warehousekiting.Location = new System.Drawing.Point(341, 17);
            this.btn_warehousekiting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_warehousekiting.Name = "btn_warehousekiting";
            this.btn_warehousekiting.Size = new System.Drawing.Size(208, 34);
            this.btn_warehousekiting.TabIndex = 2;
            this.btn_warehousekiting.Text = "Warehouse Recieving";
            this.btn_warehousekiting.UseVisualStyleBackColor = true;
            this.btn_warehousekiting.Click += new System.EventHandler(this.btn_warehousekiting_Click);
            // 
            // btn_processflow
            // 
            this.btn_processflow.FlatAppearance.BorderSize = 0;
            this.btn_processflow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_processflow.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_processflow.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_processflow.Location = new System.Drawing.Point(769, 17);
            this.btn_processflow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_processflow.Name = "btn_processflow";
            this.btn_processflow.Size = new System.Drawing.Size(208, 34);
            this.btn_processflow.TabIndex = 2;
            this.btn_processflow.Text = "Process Flow";
            this.btn_processflow.UseVisualStyleBackColor = true;
            this.btn_processflow.Click += new System.EventHandler(this.btn_processflow_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button4.Location = new System.Drawing.Point(1197, 17);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 34);
            this.button4.TabIndex = 2;
            this.button4.Text = "Rain Test";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_template
            // 
            this.btn_template.FlatAppearance.BorderSize = 0;
            this.btn_template.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_template.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_template.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_template.Location = new System.Drawing.Point(983, 17);
            this.btn_template.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_template.Name = "btn_template";
            this.btn_template.Size = new System.Drawing.Size(208, 34);
            this.btn_template.TabIndex = 2;
            this.btn_template.Text = "Templates";
            this.btn_template.UseVisualStyleBackColor = true;
            this.btn_template.Click += new System.EventHandler(this.btn_template_Click);
            // 
            // btn_material_recieving
            // 
            this.btn_material_recieving.FlatAppearance.BorderSize = 0;
            this.btn_material_recieving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_material_recieving.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_material_recieving.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_material_recieving.Location = new System.Drawing.Point(555, 17);
            this.btn_material_recieving.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_material_recieving.Name = "btn_material_recieving";
            this.btn_material_recieving.Size = new System.Drawing.Size(208, 34);
            this.btn_material_recieving.TabIndex = 2;
            this.btn_material_recieving.Text = "Kitlist Recieving";
            this.btn_material_recieving.UseVisualStyleBackColor = true;
            this.btn_material_recieving.Click += new System.EventHandler(this.btn_material_recieving_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(13, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 34);
            this.panel2.TabIndex = 0;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_main_display);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 66);
            this.panel_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(2525, 1203);
            this.panel_main.TabIndex = 1;
            // 
            // panel_main_display
            // 
            this.panel_main_display.Controls.Add(this.Lbl_versionControl);
            this.panel_main_display.Controls.Add(this.btn_logout);
            this.panel_main_display.Controls.Add(this.panel_main_form);
            this.panel_main_display.Controls.Add(this.panel_sidebar);
            this.panel_main_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main_display.Location = new System.Drawing.Point(0, 0);
            this.panel_main_display.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_main_display.Name = "panel_main_display";
            this.panel_main_display.Size = new System.Drawing.Size(2525, 1203);
            this.panel_main_display.TabIndex = 0;
            // 
            // Lbl_versionControl
            // 
            this.Lbl_versionControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_versionControl.AutoSize = true;
            this.Lbl_versionControl.ForeColor = System.Drawing.Color.Lime;
            this.Lbl_versionControl.Location = new System.Drawing.Point(22, 1170);
            this.Lbl_versionControl.Name = "Lbl_versionControl";
            this.Lbl_versionControl.Size = new System.Drawing.Size(44, 16);
            this.Lbl_versionControl.TabIndex = 3;
            this.Lbl_versionControl.Text = "label2";
            // 
            // btn_logout
            // 
            this.btn_logout.AllowAnimations = true;
            this.btn_logout.AllowMouseEffects = true;
            this.btn_logout.AllowToggling = false;
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_logout.AnimationSpeed = 200;
            this.btn_logout.AutoGenerateColors = false;
            this.btn_logout.AutoRoundBorders = false;
            this.btn_logout.AutoSizeLeftIcon = true;
            this.btn_logout.AutoSizeRightIcon = true;
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(71)))), ((int)(((byte)(77)))));
            this.btn_logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_logout.BackgroundImage")));
            this.btn_logout.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_logout.ButtonText = "Log Out";
            this.btn_logout.ButtonTextMarginLeft = 0;
            this.btn_logout.ColorContrastOnClick = 45;
            this.btn_logout.ColorContrastOnHover = 45;
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_logout.CustomizableEdges = borderEdges2;
            this.btn_logout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_logout.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_logout.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_logout.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_logout.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_logout.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_logout.IconMarginLeft = 11;
            this.btn_logout.IconPadding = 10;
            this.btn_logout.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_logout.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_logout.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_logout.IconSize = 25;
            this.btn_logout.IdleBorderColor = System.Drawing.Color.IndianRed;
            this.btn_logout.IdleBorderRadius = 12;
            this.btn_logout.IdleBorderThickness = 1;
            this.btn_logout.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(71)))), ((int)(((byte)(77)))));
            this.btn_logout.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_logout.IdleIconLeftImage")));
            this.btn_logout.IdleIconRightImage = null;
            this.btn_logout.IndicateFocus = false;
            this.btn_logout.Location = new System.Drawing.Point(13, 1098);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_logout.OnDisabledState.BorderRadius = 12;
            this.btn_logout.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_logout.OnDisabledState.BorderThickness = 1;
            this.btn_logout.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_logout.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_logout.OnDisabledState.IconLeftImage = null;
            this.btn_logout.OnDisabledState.IconRightImage = null;
            this.btn_logout.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_logout.onHoverState.BorderRadius = 12;
            this.btn_logout.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_logout.onHoverState.BorderThickness = 1;
            this.btn_logout.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_logout.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_logout.onHoverState.IconLeftImage = null;
            this.btn_logout.onHoverState.IconRightImage = null;
            this.btn_logout.OnIdleState.BorderColor = System.Drawing.Color.IndianRed;
            this.btn_logout.OnIdleState.BorderRadius = 12;
            this.btn_logout.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_logout.OnIdleState.BorderThickness = 1;
            this.btn_logout.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(71)))), ((int)(((byte)(77)))));
            this.btn_logout.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_logout.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_logout.OnIdleState.IconLeftImage")));
            this.btn_logout.OnIdleState.IconRightImage = null;
            this.btn_logout.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_logout.OnPressedState.BorderRadius = 12;
            this.btn_logout.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_logout.OnPressedState.BorderThickness = 1;
            this.btn_logout.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_logout.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_logout.OnPressedState.IconLeftImage = null;
            this.btn_logout.OnPressedState.IconRightImage = null;
            this.btn_logout.Size = new System.Drawing.Size(309, 56);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_logout.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_logout.TextMarginLeft = 0;
            this.btn_logout.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_logout.UseDefaultRadiusAndThickness = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
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
            this.panel_main_form.Controls.Add(this.pictureBox1);
            this.panel_main_form.Controls.Add(this.Panel_Graph);
            this.panel_main_form.Location = new System.Drawing.Point(341, 6);
            this.panel_main_form.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_main_form.Name = "panel_main_form";
            this.panel_main_form.ShowBorders = true;
            this.panel_main_form.Size = new System.Drawing.Size(2168, 1180);
            this.panel_main_form.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(469, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1232, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Panel_Graph
            // 
            this.Panel_Graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Graph.BackgroundColor = System.Drawing.Color.White;
            this.Panel_Graph.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Graph.BackgroundImage")));
            this.Panel_Graph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Graph.BorderColor = System.Drawing.Color.Transparent;
            this.Panel_Graph.BorderRadius = 12;
            this.Panel_Graph.BorderThickness = 1;
            this.Panel_Graph.Location = new System.Drawing.Point(19, 220);
            this.Panel_Graph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_Graph.Name = "Panel_Graph";
            this.Panel_Graph.ShowBorders = true;
            this.Panel_Graph.Size = new System.Drawing.Size(2133, 928);
            this.Panel_Graph.TabIndex = 0;
            // 
            // panel_sidebar
            // 
            this.panel_sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_sidebar.AutoScroll = true;
            this.panel_sidebar.BackgroundColor = System.Drawing.Color.Transparent;
            this.panel_sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_sidebar.BackgroundImage")));
            this.panel_sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_sidebar.BorderColor = System.Drawing.Color.Transparent;
            this.panel_sidebar.BorderRadius = 12;
            this.panel_sidebar.BorderThickness = 1;
            this.panel_sidebar.Location = new System.Drawing.Point(13, 6);
            this.panel_sidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_sidebar.Name = "panel_sidebar";
            this.panel_sidebar.ShowBorders = true;
            this.panel_sidebar.Size = new System.Drawing.Size(309, 1088);
            this.panel_sidebar.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(2525, 1269);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_menubar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainDashboard";
            this.Text = "MainDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainDashboard_FormClosing);
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            this.Resize += new System.EventHandler(this.MainDashboard_Resize);
            this.panel_menubar.ResumeLayout(false);
            this.panel_menubar.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_main_display.ResumeLayout(false);
            this.panel_main_display.PerformLayout();
            this.panel_main_form.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menubar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_warehousekiting;
        private System.Windows.Forms.Button btn_processflow;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_template;
        private System.Windows.Forms.Button btn_material_recieving;
        private System.Windows.Forms.Label lbl_currentdate;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_main_display;
        private Bunifu.UI.WinForms.BunifuPanel panel_sidebar;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuPanel Panel_Graph;
        public Bunifu.UI.WinForms.BunifuPanel panel_main_form;
        private System.Windows.Forms.Label Lbl_versionControl;
    }
}