namespace High_school_check_in_system
{
    partial class staff_from
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
            this.btnhome = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbboxlist = new System.Windows.Forms.ComboBox();
            this.btnConform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnhome.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhome.Location = new System.Drawing.Point(1095, 33);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(108, 30);
            this.btnhome.TabIndex = 0;
            this.btnhome.Text = "HOME";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(82, 219);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(961, 116);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Choose Your Name";
            // 
            // cmbboxlist
            // 
            this.cmbboxlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbboxlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxlist.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbboxlist.FormattingEnabled = true;
            this.cmbboxlist.Items.AddRange(new object[] {
            "Dr Peria Fearne",
            "Ms T Gibb",
            "Mr V Zotto",
            "Ms A Dobble",
            "Mr H Carette",
            "Ms B McGreal",
            "Dr M Spridgeon",
            "Mr A Hallbord",
            "Dr C Bermingham",
            "Ms R Krienke",
            "Ms G M\'Chirrie",
            "Ms C Waiting",
            "Ms M Bisley",
            "Dr M Sorbie",
            "Mr Y Gude",
            "Mr R Kenyam",
            "Ms W Ivanilov",
            "Ms D Wildber",
            "Dr J O\'Dowgaine",
            "Mr M Levett",
            "Ms L Grzelczak",
            "Rev P Bessey",
            "Mr H Nash",
            "Ms P Hull",
            "Mr O John",
            "Mr L Greater",
            "Mr U Slabor",
            "Ms W Right"});
            this.cmbboxlist.Location = new System.Drawing.Point(677, 216);
            this.cmbboxlist.Name = "cmbboxlist";
            this.cmbboxlist.Size = new System.Drawing.Size(550, 97);
            this.cmbboxlist.TabIndex = 2;
            // 
            // btnConform
            // 
            this.btnConform.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConform.Font = new System.Drawing.Font("Arial", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConform.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConform.Location = new System.Drawing.Point(731, 505);
            this.btnConform.Name = "btnConform";
            this.btnConform.Size = new System.Drawing.Size(263, 76);
            this.btnConform.TabIndex = 3;
            this.btnConform.Text = "Confirm";
            this.btnConform.UseVisualStyleBackColor = false;
            this.btnConform.Click += new System.EventHandler(this.btnConform_Click);
            // 
            // staff_from
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnConform);
            this.Controls.Add(this.cmbboxlist);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnhome);
            this.Name = "staff_from";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "staff_from";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.staff_from_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbboxlist;
        private System.Windows.Forms.Button btnConform;
    }
}