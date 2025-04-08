namespace BTCP_Enterprise.Forms
{
    partial class ScanSerialnumber
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgSerialnumber = new System.Windows.Forms.DataGridView();
            this.btnsave_scan = new System.Windows.Forms.Button();
            this.txtserial_number = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.colscan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colpart_serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coliscan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgSerialnumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "IPN";
            // 
            // dgSerialnumber
            // 
            this.dgSerialnumber.AllowUserToAddRows = false;
            this.dgSerialnumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgSerialnumber.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgSerialnumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSerialnumber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colscan,
            this.colpart_serial,
            this.colid,
            this.coliscan});
            this.dgSerialnumber.Location = new System.Drawing.Point(16, 120);
            this.dgSerialnumber.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dgSerialnumber.Name = "dgSerialnumber";
            this.dgSerialnumber.Size = new System.Drawing.Size(515, 433);
            this.dgSerialnumber.TabIndex = 18;
            // 
            // btnsave_scan
            // 
            this.btnsave_scan.Location = new System.Drawing.Point(17, 559);
            this.btnsave_scan.Name = "btnsave_scan";
            this.btnsave_scan.Size = new System.Drawing.Size(125, 37);
            this.btnsave_scan.TabIndex = 20;
            this.btnsave_scan.Text = "Save Scan Serial";
            this.btnsave_scan.UseVisualStyleBackColor = true;
            this.btnsave_scan.Click += new System.EventHandler(this.btnsave_scan_Click);
            // 
            // txtserial_number
            // 
            this.txtserial_number.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtserial_number.Location = new System.Drawing.Point(119, 47);
            this.txtserial_number.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtserial_number.Name = "txtserial_number";
            this.txtserial_number.Size = new System.Drawing.Size(302, 40);
            this.txtserial_number.TabIndex = 0;
            this.txtserial_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtserial_number.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtserial_number_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "Scan Serial Number ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 559);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "0 out of 0";
            // 
            // colscan
            // 
            this.colscan.HeaderText = "(Check if scan)";
            this.colscan.Name = "colscan";
            this.colscan.ReadOnly = true;
            this.colscan.Width = 70;
            // 
            // colpart_serial
            // 
            this.colpart_serial.DataPropertyName = "kit_list_part_serial_number";
            this.colpart_serial.HeaderText = "Serial Number";
            this.colpart_serial.Name = "colpart_serial";
            this.colpart_serial.Width = 200;
            // 
            // colid
            // 
            this.colid.DataPropertyName = "id";
            this.colid.HeaderText = "ID";
            this.colid.Name = "colid";
            this.colid.ReadOnly = true;
            this.colid.Visible = false;
            this.colid.Width = 50;
            // 
            // coliscan
            // 
            this.coliscan.DataPropertyName = "is_scan";
            this.coliscan.HeaderText = "Column1";
            this.coliscan.Name = "coliscan";
            // 
            // ScanSerialnumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 608);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtserial_number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnsave_scan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgSerialnumber);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ScanSerialnumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scan Serial Number";
            this.Load += new System.EventHandler(this.ScanSerialnumber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSerialnumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgSerialnumber;
        private System.Windows.Forms.Button btnsave_scan;
        private System.Windows.Forms.TextBox txtserial_number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colscan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpart_serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn coliscan;
    }
}