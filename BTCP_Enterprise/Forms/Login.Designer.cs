namespace BTCP_Enterprise.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_userinfo = new System.Windows.Forms.Label();
            this.pb_rfid = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.txt_id = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txt_scanid = new System.Windows.Forms.TextBox();
            this.lbl_position = new System.Windows.Forms.Label();
            this.btn_close = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rfid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 40);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lbl_userinfo
            // 
            this.lbl_userinfo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userinfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_userinfo.Location = new System.Drawing.Point(12, 379);
            this.lbl_userinfo.Name = "lbl_userinfo";
            this.lbl_userinfo.Size = new System.Drawing.Size(558, 42);
            this.lbl_userinfo.TabIndex = 4;
            this.lbl_userinfo.Text = "Operator Name";
            this.lbl_userinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_rfid
            // 
            this.pb_rfid.AllowFocused = false;
            this.pb_rfid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_rfid.AutoSizeHeight = true;
            this.pb_rfid.BorderRadius = 148;
            this.pb_rfid.Image = ((System.Drawing.Image)(resources.GetObject("pb_rfid.Image")));
            this.pb_rfid.IsCircle = true;
            this.pb_rfid.Location = new System.Drawing.Point(153, 62);
            this.pb_rfid.Name = "pb_rfid";
            this.pb_rfid.Size = new System.Drawing.Size(296, 296);
            this.pb_rfid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_rfid.TabIndex = 6;
            this.pb_rfid.TabStop = false;
            this.pb_rfid.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // txt_id
            // 
            this.txt_id.AcceptsReturn = false;
            this.txt_id.AcceptsTab = false;
            this.txt_id.AnimationSpeed = 200;
            this.txt_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_id.BackColor = System.Drawing.Color.Transparent;
            this.txt_id.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_id.BackgroundImage")));
            this.txt_id.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(86)))));
            this.txt_id.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_id.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(86)))));
            this.txt_id.BorderColorIdle = System.Drawing.SystemColors.ControlLight;
            this.txt_id.BorderRadius = 18;
            this.txt_id.BorderThickness = 2;
            this.txt_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.DefaultFont = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.DefaultText = "";
            this.txt_id.Enabled = false;
            this.txt_id.FillColor = System.Drawing.Color.SeaGreen;
            this.txt_id.ForeColor = System.Drawing.Color.White;
            this.txt_id.HideSelection = true;
            this.txt_id.IconLeft = null;
            this.txt_id.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.IconPadding = 10;
            this.txt_id.IconRight = null;
            this.txt_id.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.Lines = new string[0];
            this.txt_id.Location = new System.Drawing.Point(122, 495);
            this.txt_id.MaxLength = 32767;
            this.txt_id.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_id.Modified = false;
            this.txt_id.Multiline = false;
            this.txt_id.Name = "txt_id";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(86)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_id.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(86)))));
            stateProperties2.FillColor = System.Drawing.Color.SeaGreen;
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_id.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(86)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_id.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.SystemColors.ControlLight;
            stateProperties4.FillColor = System.Drawing.Color.SeaGreen;
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_id.OnIdleState = stateProperties4;
            this.txt_id.Padding = new System.Windows.Forms.Padding(3);
            this.txt_id.PasswordChar = '\0';
            this.txt_id.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_id.PlaceholderText = "";
            this.txt_id.ReadOnly = false;
            this.txt_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_id.SelectedText = "";
            this.txt_id.SelectionLength = 0;
            this.txt_id.SelectionStart = 0;
            this.txt_id.ShortcutsEnabled = true;
            this.txt_id.Size = new System.Drawing.Size(361, 61);
            this.txt_id.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_id.TabIndex = 5;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_id.TextMarginBottom = 0;
            this.txt_id.TextMarginLeft = 3;
            this.txt_id.TextMarginTop = 0;
            this.txt_id.TextPlaceholder = "";
            this.txt_id.UseSystemPasswordChar = false;
            this.txt_id.WordWrap = true;
            // 
            // txt_scanid
            // 
            this.txt_scanid.Location = new System.Drawing.Point(136, 498);
            this.txt_scanid.Name = "txt_scanid";
            this.txt_scanid.Size = new System.Drawing.Size(280, 22);
            this.txt_scanid.TabIndex = 7;
            this.txt_scanid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_scanid_KeyDown);
            // 
            // lbl_position
            // 
            this.lbl_position.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_position.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_position.Location = new System.Drawing.Point(12, 435);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Size = new System.Drawing.Size(558, 42);
            this.lbl_position.TabIndex = 4;
            this.lbl_position.Text = "Position";
            this.lbl_position.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_close
            // 
            this.btn_close.AllowAnimations = true;
            this.btn_close.AllowMouseEffects = true;
            this.btn_close.AllowToggling = false;
            this.btn_close.AnimationSpeed = 200;
            this.btn_close.AutoGenerateColors = false;
            this.btn_close.AutoRoundBorders = false;
            this.btn_close.AutoSizeLeftIcon = true;
            this.btn_close.AutoSizeRightIcon = true;
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackColor1 = System.Drawing.Color.Tomato;
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_close.ButtonText = "CANCEL";
            this.btn_close.ButtonTextMarginLeft = 0;
            this.btn_close.ColorContrastOnClick = 45;
            this.btn_close.ColorContrastOnHover = 45;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_close.CustomizableEdges = borderEdges1;
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_close.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_close.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_close.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_close.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_close.IconMarginLeft = 11;
            this.btn_close.IconPadding = 10;
            this.btn_close.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_close.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_close.IconSize = 25;
            this.btn_close.IdleBorderColor = System.Drawing.Color.Tomato;
            this.btn_close.IdleBorderRadius = 12;
            this.btn_close.IdleBorderThickness = 1;
            this.btn_close.IdleFillColor = System.Drawing.Color.Tomato;
            this.btn_close.IdleIconLeftImage = null;
            this.btn_close.IdleIconRightImage = null;
            this.btn_close.IndicateFocus = false;
            this.btn_close.Location = new System.Drawing.Point(153, 577);
            this.btn_close.Name = "btn_close";
            this.btn_close.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_close.OnDisabledState.BorderRadius = 12;
            this.btn_close.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_close.OnDisabledState.BorderThickness = 1;
            this.btn_close.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_close.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_close.OnDisabledState.IconLeftImage = null;
            this.btn_close.OnDisabledState.IconRightImage = null;
            this.btn_close.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_close.onHoverState.BorderRadius = 12;
            this.btn_close.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_close.onHoverState.BorderThickness = 1;
            this.btn_close.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_close.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_close.onHoverState.IconLeftImage = null;
            this.btn_close.onHoverState.IconRightImage = null;
            this.btn_close.OnIdleState.BorderColor = System.Drawing.Color.Tomato;
            this.btn_close.OnIdleState.BorderRadius = 12;
            this.btn_close.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_close.OnIdleState.BorderThickness = 1;
            this.btn_close.OnIdleState.FillColor = System.Drawing.Color.Tomato;
            this.btn_close.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_close.OnIdleState.IconLeftImage = null;
            this.btn_close.OnIdleState.IconRightImage = null;
            this.btn_close.OnPressedState.BorderColor = System.Drawing.Color.SeaGreen;
            this.btn_close.OnPressedState.BorderRadius = 12;
            this.btn_close.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_close.OnPressedState.BorderThickness = 1;
            this.btn_close.OnPressedState.FillColor = System.Drawing.Color.SeaGreen;
            this.btn_close.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_close.OnPressedState.IconLeftImage = null;
            this.btn_close.OnPressedState.IconRightImage = null;
            this.btn_close.Size = new System.Drawing.Size(296, 55);
            this.btn_close.TabIndex = 8;
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_close.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_close.TextMarginLeft = 0;
            this.btn_close.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_close.UseDefaultRadiusAndThickness = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 645);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.pb_rfid);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_position);
            this.Controls.Add(this.lbl_userinfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_scanid);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_rfid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_userinfo;
        private Bunifu.UI.WinForms.BunifuPictureBox pb_rfid;
        private Bunifu.UI.WinForms.BunifuTextBox txt_id;
        private System.Windows.Forms.TextBox txt_scanid;
        private System.Windows.Forms.Label lbl_position;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_close;
    }
}