namespace High_school_check_in_system
{
    partial class User_Options
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
            this.labeltitle = new System.Windows.Forms.Label();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnVisitor = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Arial Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.Location = new System.Drawing.Point(88, 82);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(2325, 283);
            this.labeltitle.TabIndex = 0;
            this.labeltitle.Text = "Please choose your user type to start the\r\ncheck-in process";
            this.labeltitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnStaff.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStaff.Location = new System.Drawing.Point(201, 379);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(210, 94);
            this.btnStaff.TabIndex = 1;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnStudent.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStudent.Location = new System.Drawing.Point(478, 379);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(232, 91);
            this.btnStudent.TabIndex = 2;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnVisitor
            // 
            this.btnVisitor.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVisitor.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVisitor.Location = new System.Drawing.Point(787, 381);
            this.btnVisitor.Name = "btnVisitor";
            this.btnVisitor.Size = new System.Drawing.Size(224, 92);
            this.btnVisitor.TabIndex = 3;
            this.btnVisitor.Text = "Visitor";
            this.btnVisitor.UseVisualStyleBackColor = false;
            this.btnVisitor.Click += new System.EventHandler(this.btnVisitor_Click);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnhome.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhome.Location = new System.Drawing.Point(1756, 29);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(102, 30);
            this.btnhome.TabIndex = 4;
            this.btnhome.Text = "HOME";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // User_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btnVisitor);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.labeltitle);
            this.Name = "User_Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_Options";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.User_Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnVisitor;
        private System.Windows.Forms.Button btnhome;
    }
}