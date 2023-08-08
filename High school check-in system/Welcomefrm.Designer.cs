namespace High_school_check_in_system
{
    partial class welcomefrm
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
            this.lblwelcom = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblwelcom
            // 
            this.lblwelcom.AutoSize = true;
            this.lblwelcom.Font = new System.Drawing.Font("Arial Black", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcom.Location = new System.Drawing.Point(55, 22);
            this.lblwelcom.Name = "lblwelcom";
            this.lblwelcom.Size = new System.Drawing.Size(1667, 338);
            this.lblwelcom.TabIndex = 0;
            this.lblwelcom.Text = "Welcome to High School\r\nCheck-In System";
            this.lblwelcom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnstart.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnstart.Location = new System.Drawing.Point(470, 464);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(401, 64);
            this.btnstart.TabIndex = 1;
            this.btnstart.Text = "Get Started";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // welcomefrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.lblwelcom);
            this.Name = "welcomefrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.welcomefrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwelcom;
        private System.Windows.Forms.Button btnstart;
    }
}

