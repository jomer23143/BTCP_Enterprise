namespace BTCP_Enterprise.Forms
{
    partial class OperatorsVFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperatorsVFrm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.txt_serial_number = new System.Windows.Forms.TextBox();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btn_start = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_stop = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.DGV_Process = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Process)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(479, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Serial Number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 18;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.txt_serial_number);
            this.bunifuPanel1.Location = new System.Drawing.Point(263, 105);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(604, 65);
            this.bunifuPanel1.TabIndex = 3;
            this.bunifuPanel1.Click += new System.EventHandler(this.bunifuPanel1_Click);
            // 
            // txt_serial_number
            // 
            this.txt_serial_number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_serial_number.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serial_number.Location = new System.Drawing.Point(23, 13);
            this.txt_serial_number.Name = "txt_serial_number";
            this.txt_serial_number.Size = new System.Drawing.Size(568, 37);
            this.txt_serial_number.TabIndex = 0;
            this.txt_serial_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_serial_number.TextChanged += new System.EventHandler(this.txt_serial_number_TextChanged);
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 12;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.lblTimer);
            this.bunifuPanel2.Location = new System.Drawing.Point(167, 329);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(773, 99);
            this.bunifuPanel2.TabIndex = 4;
            this.bunifuPanel2.Click += new System.EventHandler(this.bunifuPanel2_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(22, 10);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(739, 76);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "00:00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_start
            // 
            this.btn_start.AllowAnimations = true;
            this.btn_start.AllowMouseEffects = true;
            this.btn_start.AllowToggling = false;
            this.btn_start.AnimationSpeed = 200;
            this.btn_start.AutoGenerateColors = false;
            this.btn_start.AutoRoundBorders = false;
            this.btn_start.AutoSizeLeftIcon = true;
            this.btn_start.AutoSizeRightIcon = true;
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.btn_start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_start.BackgroundImage")));
            this.btn_start.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_start.ButtonText = "START";
            this.btn_start.ButtonTextMarginLeft = 0;
            this.btn_start.ColorContrastOnClick = 45;
            this.btn_start.ColorContrastOnHover = 45;
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_start.CustomizableEdges = borderEdges1;
            this.btn_start.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_start.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_start.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_start.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_start.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_start.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.White;
            this.btn_start.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_start.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_start.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_start.IconMarginLeft = 11;
            this.btn_start.IconPadding = 10;
            this.btn_start.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_start.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_start.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_start.IconSize = 25;
            this.btn_start.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.btn_start.IdleBorderRadius = 18;
            this.btn_start.IdleBorderThickness = 1;
            this.btn_start.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.btn_start.IdleIconLeftImage = null;
            this.btn_start.IdleIconRightImage = null;
            this.btn_start.IndicateFocus = false;
            this.btn_start.Location = new System.Drawing.Point(425, 178);
            this.btn_start.Name = "btn_start";
            this.btn_start.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_start.OnDisabledState.BorderRadius = 18;
            this.btn_start.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_start.OnDisabledState.BorderThickness = 1;
            this.btn_start.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_start.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_start.OnDisabledState.IconLeftImage = null;
            this.btn_start.OnDisabledState.IconRightImage = null;
            this.btn_start.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.btn_start.onHoverState.BorderRadius = 18;
            this.btn_start.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_start.onHoverState.BorderThickness = 1;
            this.btn_start.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_start.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_start.onHoverState.IconLeftImage = null;
            this.btn_start.onHoverState.IconRightImage = null;
            this.btn_start.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.btn_start.OnIdleState.BorderRadius = 18;
            this.btn_start.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_start.OnIdleState.BorderThickness = 1;
            this.btn_start.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.btn_start.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_start.OnIdleState.IconLeftImage = null;
            this.btn_start.OnIdleState.IconRightImage = null;
            this.btn_start.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.btn_start.OnPressedState.BorderRadius = 18;
            this.btn_start.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_start.OnPressedState.BorderThickness = 1;
            this.btn_start.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_start.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_start.OnPressedState.IconLeftImage = null;
            this.btn_start.OnPressedState.IconRightImage = null;
            this.btn_start.Size = new System.Drawing.Size(285, 65);
            this.btn_start.TabIndex = 5;
            this.btn_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_start.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_start.TextMarginLeft = 0;
            this.btn_start.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_start.UseDefaultRadiusAndThickness = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(450, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 40);
            this.label4.TabIndex = 2;
            this.label4.Text = "HANDLING TIME";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BorderRadius = 18;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Controls.Add(this.btn_stop);
            this.bunifuPanel3.Controls.Add(this.DGV_Process);
            this.bunifuPanel3.Controls.Add(this.label3);
            this.bunifuPanel3.Controls.Add(this.btn_start);
            this.bunifuPanel3.Controls.Add(this.label4);
            this.bunifuPanel3.Controls.Add(this.bunifuPanel2);
            this.bunifuPanel3.Controls.Add(this.bunifuPanel1);
            this.bunifuPanel3.Location = new System.Drawing.Point(18, 43);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(1082, 880);
            this.bunifuPanel3.TabIndex = 6;
            // 
            // btn_stop
            // 
            this.btn_stop.AllowAnimations = true;
            this.btn_stop.AllowMouseEffects = true;
            this.btn_stop.AllowToggling = false;
            this.btn_stop.AnimationSpeed = 200;
            this.btn_stop.AutoGenerateColors = false;
            this.btn_stop.AutoRoundBorders = false;
            this.btn_stop.AutoSizeLeftIcon = true;
            this.btn_stop.AutoSizeRightIcon = true;
            this.btn_stop.BackColor = System.Drawing.Color.Transparent;
            this.btn_stop.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(71)))), ((int)(((byte)(77)))));
            this.btn_stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_stop.BackgroundImage")));
            this.btn_stop.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_stop.ButtonText = "STOP";
            this.btn_stop.ButtonTextMarginLeft = 0;
            this.btn_stop.ColorContrastOnClick = 45;
            this.btn_stop.ColorContrastOnHover = 45;
            this.btn_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_stop.CustomizableEdges = borderEdges2;
            this.btn_stop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_stop.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_stop.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_stop.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_stop.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_stop.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.ForeColor = System.Drawing.Color.White;
            this.btn_stop.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stop.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_stop.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_stop.IconMarginLeft = 11;
            this.btn_stop.IconPadding = 10;
            this.btn_stop.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_stop.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_stop.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_stop.IconSize = 25;
            this.btn_stop.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.btn_stop.IdleBorderRadius = 18;
            this.btn_stop.IdleBorderThickness = 1;
            this.btn_stop.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(71)))), ((int)(((byte)(77)))));
            this.btn_stop.IdleIconLeftImage = null;
            this.btn_stop.IdleIconRightImage = null;
            this.btn_stop.IndicateFocus = false;
            this.btn_stop.Location = new System.Drawing.Point(425, 766);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_stop.OnDisabledState.BorderRadius = 18;
            this.btn_stop.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_stop.OnDisabledState.BorderThickness = 1;
            this.btn_stop.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_stop.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_stop.OnDisabledState.IconLeftImage = null;
            this.btn_stop.OnDisabledState.IconRightImage = null;
            this.btn_stop.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.btn_stop.onHoverState.BorderRadius = 18;
            this.btn_stop.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_stop.onHoverState.BorderThickness = 1;
            this.btn_stop.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_stop.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_stop.onHoverState.IconLeftImage = null;
            this.btn_stop.onHoverState.IconRightImage = null;
            this.btn_stop.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.btn_stop.OnIdleState.BorderRadius = 18;
            this.btn_stop.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_stop.OnIdleState.BorderThickness = 1;
            this.btn_stop.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(71)))), ((int)(((byte)(77)))));
            this.btn_stop.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_stop.OnIdleState.IconLeftImage = null;
            this.btn_stop.OnIdleState.IconRightImage = null;
            this.btn_stop.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.btn_stop.OnPressedState.BorderRadius = 18;
            this.btn_stop.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_stop.OnPressedState.BorderThickness = 1;
            this.btn_stop.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_stop.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_stop.OnPressedState.IconLeftImage = null;
            this.btn_stop.OnPressedState.IconRightImage = null;
            this.btn_stop.Size = new System.Drawing.Size(285, 65);
            this.btn_stop.TabIndex = 5;
            this.btn_stop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_stop.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_stop.TextMarginLeft = 0;
            this.btn_stop.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_stop.UseDefaultRadiusAndThickness = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // DGV_Process
            // 
            this.DGV_Process.AllowUserToAddRows = false;
            this.DGV_Process.AllowUserToDeleteRows = false;
            this.DGV_Process.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Process.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV_Process.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Process.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Process.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Process.Location = new System.Drawing.Point(25, 434);
            this.DGV_Process.Name = "DGV_Process";
            this.DGV_Process.RowHeadersVisible = false;
            this.DGV_Process.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Process.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Process.RowTemplate.Height = 24;
            this.DGV_Process.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Process.Size = new System.Drawing.Size(1041, 303);
            this.DGV_Process.TabIndex = 7;
            this.DGV_Process.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Process_CellContentClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OperatorsVFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1119, 994);
            this.Controls.Add(this.bunifuPanel3);
            this.Name = "OperatorsVFrm";
            this.Text = "OperatorsVFrm";
            this.Load += new System.EventHandler(this.OperatorsVFrm_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel3.ResumeLayout(false);
            this.bunifuPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Process)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.TextBox txt_serial_number;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTimer;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private System.Windows.Forms.DataGridView DGV_Process;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_stop;
        private System.Windows.Forms.Timer timer1;
    }
}