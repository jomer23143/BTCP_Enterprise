namespace BTCP_Enterprise.Forms
{
    partial class PreAssyOperfrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreAssyOperfrm));
            this.DGV_Process = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.txt_serial_number = new System.Windows.Forms.TextBox();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Process)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Process
            // 
            this.DGV_Process.AllowUserToAddRows = false;
            this.DGV_Process.AllowUserToDeleteRows = false;
            this.DGV_Process.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Process.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Process.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV_Process.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Process.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_Process.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Process.Location = new System.Drawing.Point(31, 273);
            this.DGV_Process.Name = "DGV_Process";
            this.DGV_Process.RowHeadersVisible = false;
            this.DGV_Process.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Process.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_Process.RowTemplate.Height = 24;
            this.DGV_Process.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Process.Size = new System.Drawing.Size(1175, 446);
            this.DGV_Process.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(535, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "Serial Number";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(519, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 40);
            this.label4.TabIndex = 9;
            this.label4.Text = "HANDLING TIME";
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 18;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.txt_serial_number);
            this.bunifuPanel1.Location = new System.Drawing.Point(319, 97);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(604, 65);
            this.bunifuPanel1.TabIndex = 10;
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
            this.txt_serial_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_serial_number_KeyPress);
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BorderRadius = 12;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Controls.Add(this.label3);
            this.bunifuPanel3.Controls.Add(this.bunifuPanel1);
            this.bunifuPanel3.Controls.Add(this.DGV_Process);
            this.bunifuPanel3.Controls.Add(this.label4);
            this.bunifuPanel3.Location = new System.Drawing.Point(32, 30);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(1238, 750);
            this.bunifuPanel3.TabIndex = 15;
            this.bunifuPanel3.Click += new System.EventHandler(this.bunifuPanel3_Click);
            // 
            // PreAssyOperfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1306, 809);
            this.Controls.Add(this.bunifuPanel3);
            this.Name = "PreAssyOperfrm";
            this.Text = "PreAssyOperfrm";
            this.Load += new System.EventHandler(this.PreAssyOperfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Process)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.bunifuPanel3.ResumeLayout(false);
            this.bunifuPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_Process;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.TextBox txt_serial_number;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
    }
}