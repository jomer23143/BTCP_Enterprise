namespace BTCP_Enterprise.Forms
{
    partial class AddSerialnumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSerialnumber));
            this.dgSerialnumber = new System.Windows.Forms.DataGridView();
            this.btnsave_serial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuloading = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.colpart_serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colscan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgSerialnumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuloading)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSerialnumber
            // 
            this.dgSerialnumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgSerialnumber.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgSerialnumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSerialnumber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colpart_serial,
            this.dataGridViewTextBoxColumn2,
            this.colscan});
            this.dgSerialnumber.Location = new System.Drawing.Point(14, 62);
            this.dgSerialnumber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgSerialnumber.Name = "dgSerialnumber";
            this.dgSerialnumber.Size = new System.Drawing.Size(382, 380);
            this.dgSerialnumber.TabIndex = 15;
            this.dgSerialnumber.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgSerialnumber_RowPostPaint);
            // 
            // btnsave_serial
            // 
            this.btnsave_serial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnsave_serial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(180)))), ((int)(((byte)(62)))));
            this.btnsave_serial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave_serial.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave_serial.ForeColor = System.Drawing.Color.White;
            this.btnsave_serial.Location = new System.Drawing.Point(13, 449);
            this.btnsave_serial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsave_serial.Name = "btnsave_serial";
            this.btnsave_serial.Size = new System.Drawing.Size(146, 44);
            this.btnsave_serial.TabIndex = 16;
            this.btnsave_serial.Text = "Save Serial Number";
            this.btnsave_serial.UseVisualStyleBackColor = false;
            this.btnsave_serial.Click += new System.EventHandler(this.btnsave_serial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "IPN";
            // 
            // bunifuloading
            // 
            this.bunifuloading.AllowFocused = false;
            this.bunifuloading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuloading.AutoSizeHeight = true;
            this.bunifuloading.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuloading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuloading.BorderRadius = 41;
            this.bunifuloading.Image = ((System.Drawing.Image)(resources.GetObject("bunifuloading.Image")));
            this.bunifuloading.IsCircle = true;
            this.bunifuloading.Location = new System.Drawing.Point(165, 191);
            this.bunifuloading.Name = "bunifuloading";
            this.bunifuloading.Size = new System.Drawing.Size(83, 83);
            this.bunifuloading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuloading.TabIndex = 18;
            this.bunifuloading.TabStop = false;
            this.bunifuloading.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // colpart_serial
            // 
            this.colpart_serial.DataPropertyName = "kit_list_part_serial_number";
            this.colpart_serial.HeaderText = "Serial Number";
            this.colpart_serial.Name = "colpart_serial";
            this.colpart_serial.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // colscan
            // 
            this.colscan.DataPropertyName = "is_scan";
            this.colscan.HeaderText = "scan";
            this.colscan.Name = "colscan";
            this.colscan.Visible = false;
            // 
            // AddSerialnumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 505);
            this.Controls.Add(this.bunifuloading);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsave_serial);
            this.Controls.Add(this.dgSerialnumber);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddSerialnumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Serial Number";
            this.Load += new System.EventHandler(this.AddSerialnumber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSerialnumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuloading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSerialnumber;
        private System.Windows.Forms.Button btnsave_serial;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuloading;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpart_serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colscan;
    }
}