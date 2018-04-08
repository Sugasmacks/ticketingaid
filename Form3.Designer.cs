namespace BadlandsLSPDTicketingAid
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label89 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.TicketingAidVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label89
            // 
            this.label89.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label89.AutoSize = true;
            this.label89.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label89.ForeColor = System.Drawing.Color.White;
            this.label89.Location = new System.Drawing.Point(486, 263);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(215, 16);
            this.label89.TabIndex = 165;
            this.label89.Text = "Using Ticketing Guide Version:  2.1";
            // 
            // label87
            // 
            this.label87.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label87.AutoSize = true;
            this.label87.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label87.ForeColor = System.Drawing.Color.White;
            this.label87.Location = new System.Drawing.Point(592, 241);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(85, 16);
            this.label87.TabIndex = 164;
            this.label87.Text = "App Version:";
            this.label87.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TicketingAidVersion
            // 
            this.TicketingAidVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TicketingAidVersion.AutoSize = true;
            this.TicketingAidVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketingAidVersion.ForeColor = System.Drawing.Color.White;
            this.TicketingAidVersion.Location = new System.Drawing.Point(676, 241);
            this.TicketingAidVersion.Name = "TicketingAidVersion";
            this.TicketingAidVersion.Size = new System.Drawing.Size(25, 16);
            this.TicketingAidVersion.TabIndex = 163;
            this.TicketingAidVersion.Text = "1.4";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 32);
            this.label1.TabIndex = 166;
            this.label1.Text = "You can move the application window so long as you left click + drag anywhere\r\nth" +
    "at isn\'t a button.";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(707, 288);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label89);
            this.Controls.Add(this.label87);
            this.Controls.Add(this.TicketingAidVersion);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Badlands LSPD Ticketing Aid - Help";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label89;
        public System.Windows.Forms.Label label87;
        public System.Windows.Forms.Label TicketingAidVersion;
        public System.Windows.Forms.Label label1;
    }
}