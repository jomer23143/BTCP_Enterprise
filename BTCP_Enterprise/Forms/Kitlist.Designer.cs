namespace BTCP_Enterprise.Forms
{
    partial class Kitlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitlist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuloading = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtmo_number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btncomplete = new System.Windows.Forms.Button();
            this.colstatus_item = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colpart_serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colipn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmfg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmfgprodcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunitqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmoqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colwipqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpickqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colshortqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colkit_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colrecieved_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colreject_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colinvoicenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colkitted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colindividualkitted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltrack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colrack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcomment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcreated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colupdated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colhistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colitem_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colkit_list_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuloading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 82);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kit list Recieving";
            // 
            // bunifuloading
            // 
            this.bunifuloading.AllowFocused = false;
            this.bunifuloading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuloading.AutoSizeHeight = true;
            this.bunifuloading.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuloading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuloading.BorderRadius = 58;
            this.bunifuloading.Image = ((System.Drawing.Image)(resources.GetObject("bunifuloading.Image")));
            this.bunifuloading.IsCircle = true;
            this.bunifuloading.Location = new System.Drawing.Point(638, 396);
            this.bunifuloading.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuloading.Name = "bunifuloading";
            this.bunifuloading.Size = new System.Drawing.Size(117, 117);
            this.bunifuloading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuloading.TabIndex = 14;
            this.bunifuloading.TabStop = false;
            this.bunifuloading.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colstatus_item,
            this.colpart_serial,
            this.colipn,
            this.coldescription,
            this.coltype,
            this.colmfg,
            this.colmfgprodcode,
            this.collocation,
            this.colstock,
            this.colunitqty,
            this.colmoqty,
            this.colwipqty,
            this.colpickqty,
            this.colshortqty,
            this.colkit_quantity,
            this.colrecieved_quantity,
            this.colreject_quantity,
            this.colunit,
            this.colinvoicenumber,
            this.colkitted,
            this.colindividualkitted,
            this.coltrack,
            this.colrack,
            this.colcomment,
            this.colcreated_at,
            this.colupdated_at,
            this.colstatus,
            this.colhistory,
            this.colid,
            this.colmo_id,
            this.colitem_number,
            this.colgroup,
            this.colkit_list_id});
            this.dataGridView1.Location = new System.Drawing.Point(15, 130);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1334, 538);
            this.dataGridView1.TabIndex = 13;
            // 
            // txtmo_number
            // 
            this.txtmo_number.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmo_number.Location = new System.Drawing.Point(119, 92);
            this.txtmo_number.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtmo_number.Name = "txtmo_number";
            this.txtmo_number.Size = new System.Drawing.Size(285, 27);
            this.txtmo_number.TabIndex = 12;
            this.txtmo_number.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmo_number_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "MO Number :";
            // 
            // btncomplete
            // 
            this.btncomplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btncomplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(180)))), ((int)(((byte)(62)))));
            this.btncomplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncomplete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomplete.ForeColor = System.Drawing.Color.White;
            this.btncomplete.Location = new System.Drawing.Point(15, 674);
            this.btncomplete.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btncomplete.Name = "btncomplete";
            this.btncomplete.Size = new System.Drawing.Size(138, 51);
            this.btncomplete.TabIndex = 15;
            this.btncomplete.Text = "Saved";
            this.btncomplete.UseVisualStyleBackColor = false;
            this.btncomplete.Click += new System.EventHandler(this.btncomplete_Click);
            // 
            // colstatus_item
            // 
            this.colstatus_item.HeaderText = "Check (If complete)";
            this.colstatus_item.Name = "colstatus_item";
            this.colstatus_item.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colpart_serial
            // 
            this.colpart_serial.DataPropertyName = "part_serial";
            this.colpart_serial.HeaderText = "Serial Number";
            this.colpart_serial.Name = "colpart_serial";
            this.colpart_serial.Width = 180;
            // 
            // colipn
            // 
            this.colipn.DataPropertyName = "ipn";
            this.colipn.HeaderText = "Internal PN";
            this.colipn.Name = "colipn";
            this.colipn.ReadOnly = true;
            // 
            // coldescription
            // 
            this.coldescription.DataPropertyName = "description";
            this.coldescription.HeaderText = "Description";
            this.coldescription.Name = "coldescription";
            this.coldescription.ReadOnly = true;
            this.coldescription.Width = 300;
            // 
            // coltype
            // 
            this.coltype.DataPropertyName = "type";
            this.coltype.HeaderText = "Type";
            this.coltype.Name = "coltype";
            this.coltype.ReadOnly = true;
            // 
            // colmfg
            // 
            this.colmfg.DataPropertyName = "manufacturing";
            this.colmfg.HeaderText = "Mfg";
            this.colmfg.Name = "colmfg";
            this.colmfg.ReadOnly = true;
            this.colmfg.Visible = false;
            // 
            // colmfgprodcode
            // 
            this.colmfgprodcode.DataPropertyName = "manufacturing_product_code";
            this.colmfgprodcode.HeaderText = "Mfg Product Code";
            this.colmfgprodcode.Name = "colmfgprodcode";
            this.colmfgprodcode.ReadOnly = true;
            this.colmfgprodcode.Visible = false;
            // 
            // collocation
            // 
            this.collocation.DataPropertyName = "source_location";
            this.collocation.HeaderText = "Location";
            this.collocation.Name = "collocation";
            this.collocation.ReadOnly = true;
            this.collocation.Visible = false;
            this.collocation.Width = 70;
            // 
            // colstock
            // 
            this.colstock.DataPropertyName = "stock";
            this.colstock.HeaderText = "Stock";
            this.colstock.Name = "colstock";
            this.colstock.ReadOnly = true;
            this.colstock.Visible = false;
            this.colstock.Width = 80;
            // 
            // colunitqty
            // 
            this.colunitqty.DataPropertyName = "unit_quantity";
            this.colunitqty.HeaderText = "Unit Quantity";
            this.colunitqty.Name = "colunitqty";
            this.colunitqty.ReadOnly = true;
            this.colunitqty.Visible = false;
            this.colunitqty.Width = 80;
            // 
            // colmoqty
            // 
            this.colmoqty.DataPropertyName = "mo_quantity";
            this.colmoqty.HeaderText = "MO Quantity";
            this.colmoqty.Name = "colmoqty";
            this.colmoqty.ReadOnly = true;
            this.colmoqty.Visible = false;
            this.colmoqty.Width = 80;
            // 
            // colwipqty
            // 
            this.colwipqty.DataPropertyName = "wip_quantity";
            this.colwipqty.HeaderText = "WIP Quantity";
            this.colwipqty.Name = "colwipqty";
            this.colwipqty.ReadOnly = true;
            this.colwipqty.Visible = false;
            this.colwipqty.Width = 80;
            // 
            // colpickqty
            // 
            this.colpickqty.DataPropertyName = "pick_quantity";
            this.colpickqty.HeaderText = "Pick Quantity";
            this.colpickqty.Name = "colpickqty";
            this.colpickqty.ReadOnly = true;
            this.colpickqty.Width = 80;
            // 
            // colshortqty
            // 
            this.colshortqty.DataPropertyName = "short_quantity";
            this.colshortqty.HeaderText = "Short Quantity";
            this.colshortqty.Name = "colshortqty";
            this.colshortqty.Width = 80;
            // 
            // colkit_quantity
            // 
            this.colkit_quantity.HeaderText = "Kit Quantity";
            this.colkit_quantity.Name = "colkit_quantity";
            this.colkit_quantity.Visible = false;
            this.colkit_quantity.Width = 80;
            // 
            // colrecieved_quantity
            // 
            this.colrecieved_quantity.HeaderText = "Recieved Quantity";
            this.colrecieved_quantity.Name = "colrecieved_quantity";
            this.colrecieved_quantity.Visible = false;
            this.colrecieved_quantity.Width = 80;
            // 
            // colreject_quantity
            // 
            this.colreject_quantity.HeaderText = "Reject Quantity";
            this.colreject_quantity.Name = "colreject_quantity";
            this.colreject_quantity.Visible = false;
            this.colreject_quantity.Width = 80;
            // 
            // colunit
            // 
            this.colunit.DataPropertyName = "unit";
            this.colunit.HeaderText = "Unit UOM";
            this.colunit.Name = "colunit";
            this.colunit.ReadOnly = true;
            this.colunit.Width = 60;
            // 
            // colinvoicenumber
            // 
            this.colinvoicenumber.DataPropertyName = "invoice_number";
            this.colinvoicenumber.HeaderText = "Invoice #";
            this.colinvoicenumber.Name = "colinvoicenumber";
            this.colinvoicenumber.ReadOnly = true;
            this.colinvoicenumber.Visible = false;
            // 
            // colkitted
            // 
            this.colkitted.DataPropertyName = "kitted";
            this.colkitted.HeaderText = "Kitted";
            this.colkitted.Name = "colkitted";
            this.colkitted.Width = 70;
            // 
            // colindividualkitted
            // 
            this.colindividualkitted.DataPropertyName = "individual_kitting";
            this.colindividualkitted.HeaderText = "Individual Kitted";
            this.colindividualkitted.Name = "colindividualkitted";
            this.colindividualkitted.ReadOnly = true;
            this.colindividualkitted.Visible = false;
            // 
            // coltrack
            // 
            this.coltrack.DataPropertyName = "track";
            this.coltrack.HeaderText = "Track";
            this.coltrack.Name = "coltrack";
            this.coltrack.ReadOnly = true;
            // 
            // colrack
            // 
            this.colrack.DataPropertyName = "rack";
            this.colrack.HeaderText = "Rack";
            this.colrack.Name = "colrack";
            this.colrack.ReadOnly = true;
            this.colrack.Visible = false;
            // 
            // colcomment
            // 
            this.colcomment.DataPropertyName = "comment";
            this.colcomment.HeaderText = "Comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Width = 200;
            // 
            // colcreated_at
            // 
            this.colcreated_at.DataPropertyName = "created_at";
            this.colcreated_at.HeaderText = "created_at";
            this.colcreated_at.Name = "colcreated_at";
            this.colcreated_at.ReadOnly = true;
            this.colcreated_at.Visible = false;
            // 
            // colupdated_at
            // 
            this.colupdated_at.DataPropertyName = "updated_at";
            this.colupdated_at.HeaderText = "update at";
            this.colupdated_at.Name = "colupdated_at";
            this.colupdated_at.ReadOnly = true;
            this.colupdated_at.Visible = false;
            // 
            // colstatus
            // 
            this.colstatus.DataPropertyName = "status";
            this.colstatus.HeaderText = "status";
            this.colstatus.Name = "colstatus";
            this.colstatus.ReadOnly = true;
            this.colstatus.Visible = false;
            // 
            // colhistory
            // 
            this.colhistory.DataPropertyName = "history";
            this.colhistory.HeaderText = "history";
            this.colhistory.Name = "colhistory";
            this.colhistory.ReadOnly = true;
            this.colhistory.Visible = false;
            // 
            // colid
            // 
            this.colid.DataPropertyName = "id";
            this.colid.HeaderText = "id";
            this.colid.Name = "colid";
            this.colid.ReadOnly = true;
            this.colid.Visible = false;
            // 
            // colmo_id
            // 
            this.colmo_id.DataPropertyName = "mo_id";
            this.colmo_id.HeaderText = "mo id";
            this.colmo_id.Name = "colmo_id";
            this.colmo_id.ReadOnly = true;
            this.colmo_id.Visible = false;
            // 
            // colitem_number
            // 
            this.colitem_number.DataPropertyName = "item_number";
            this.colitem_number.HeaderText = "item number";
            this.colitem_number.Name = "colitem_number";
            this.colitem_number.ReadOnly = true;
            this.colitem_number.Visible = false;
            // 
            // colgroup
            // 
            this.colgroup.DataPropertyName = "group";
            this.colgroup.HeaderText = "group";
            this.colgroup.Name = "colgroup";
            this.colgroup.ReadOnly = true;
            this.colgroup.Visible = false;
            // 
            // colkit_list_id
            // 
            this.colkit_list_id.DataPropertyName = "kit_list_item_status_id";
            this.colkit_list_id.HeaderText = "kit_list_id";
            this.colkit_list_id.Name = "colkit_list_id";
            this.colkit_list_id.Visible = false;
            // 
            // Kitlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 734);
            this.Controls.Add(this.btncomplete);
            this.Controls.Add(this.bunifuloading);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtmo_number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Kitlist";
            this.Text = "Kitlist";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Kitlist_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuloading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuloading;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtmo_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncomplete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colstatus_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpart_serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colipn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltype;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmfg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmfgprodcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn collocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunitqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmoqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colwipqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpickqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colshortqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colkit_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colrecieved_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colreject_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colinvoicenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colkitted;
        private System.Windows.Forms.DataGridViewTextBoxColumn colindividualkitted;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltrack;
        private System.Windows.Forms.DataGridViewTextBoxColumn colrack;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcomment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcreated_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn colupdated_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colhistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmo_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colitem_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn colgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colkit_list_id;
    }
}