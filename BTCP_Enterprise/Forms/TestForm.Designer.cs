namespace BTCP_Enterprise.Forms
{
    partial class TestForm
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
            this.txt_id1 = new System.Windows.Forms.TextBox();
            this.txt_serial1 = new System.Windows.Forms.TextBox();
            this.txt_id2 = new System.Windows.Forms.TextBox();
            this.txt_serial2 = new System.Windows.Forms.TextBox();
            this.txt_id3 = new System.Windows.Forms.TextBox();
            this.txt_serial3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_id1
            // 
            this.txt_id1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_id1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id1.Location = new System.Drawing.Point(291, 111);
            this.txt_id1.Name = "txt_id1";
            this.txt_id1.Size = new System.Drawing.Size(180, 43);
            this.txt_id1.TabIndex = 0;
            // 
            // txt_serial1
            // 
            this.txt_serial1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_serial1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serial1.Location = new System.Drawing.Point(580, 111);
            this.txt_serial1.Name = "txt_serial1";
            this.txt_serial1.Size = new System.Drawing.Size(316, 43);
            this.txt_serial1.TabIndex = 0;
            // 
            // txt_id2
            // 
            this.txt_id2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_id2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id2.Location = new System.Drawing.Point(291, 197);
            this.txt_id2.Name = "txt_id2";
            this.txt_id2.Size = new System.Drawing.Size(180, 43);
            this.txt_id2.TabIndex = 0;
            // 
            // txt_serial2
            // 
            this.txt_serial2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_serial2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serial2.Location = new System.Drawing.Point(580, 197);
            this.txt_serial2.Name = "txt_serial2";
            this.txt_serial2.Size = new System.Drawing.Size(316, 43);
            this.txt_serial2.TabIndex = 0;
            // 
            // txt_id3
            // 
            this.txt_id3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_id3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id3.Location = new System.Drawing.Point(291, 283);
            this.txt_id3.Name = "txt_id3";
            this.txt_id3.Size = new System.Drawing.Size(180, 43);
            this.txt_id3.TabIndex = 0;
            // 
            // txt_serial3
            // 
            this.txt_serial3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_serial3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serial3.Location = new System.Drawing.Point(580, 283);
            this.txt_serial3.Name = "txt_serial3";
            this.txt_serial3.Size = new System.Drawing.Size(316, 43);
            this.txt_serial3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(291, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(565, 100);
            this.button1.TabIndex = 1;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 719);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_serial3);
            this.Controls.Add(this.txt_id3);
            this.Controls.Add(this.txt_serial2);
            this.Controls.Add(this.txt_id2);
            this.Controls.Add(this.txt_serial1);
            this.Controls.Add(this.txt_id1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id1;
        private System.Windows.Forms.TextBox txt_serial1;
        private System.Windows.Forms.TextBox txt_id2;
        private System.Windows.Forms.TextBox txt_serial2;
        private System.Windows.Forms.TextBox txt_id3;
        private System.Windows.Forms.TextBox txt_serial3;
        private System.Windows.Forms.Button button1;
    }
}