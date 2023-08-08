using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace High_school_check_in_system
{
    public partial class User_Options : Form
    {
        public User_Options()
        {
            InitializeComponent();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            var staff_from = new staff_from();
            staff_from.Show();
            this.Hide();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            var studentfrom = new studentfrom();
            studentfrom.Show();
            this.Hide();
        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            var vistorfrm = new vistorfrm();
            vistorfrm.Show();
            this.Hide();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            var welcomfrm=new welcomefrm();
            welcomfrm.Show();
            this.Hide();
        }

        private void User_Options_Load(object sender, EventArgs e)
        {
            // Calculate the center position of the form
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            labeltitle.Anchor= AnchorStyles.None;
            labeltitle.TextAlign = ContentAlignment.MiddleCenter;
            labeltitle.AutoSize = false;
            labeltitle.Width = 1500;
            labeltitle.Height = 350;

            labeltitle.Location = new Point(centerX - (labeltitle.Width / 2), centerY - (labeltitle.Height / 2)-200);


            btnStaff.Anchor = AnchorStyles.None;
            btnStaff.TextAlign = ContentAlignment.MiddleCenter;
            btnStaff.AutoSize = false;
            btnStaff.Width = 450;
            btnStaff.Height = 150;

            btnStaff.Location = new Point(centerX - (btnStaff.Width / 2), centerY - (btnStaff.Height / 2) + 200);


            btnVisitor.Anchor = AnchorStyles.None;
            btnVisitor.TextAlign = ContentAlignment.MiddleCenter;
            btnVisitor.AutoSize = false;
            btnVisitor.Width = 450;
            btnVisitor.Height = 150;

            btnVisitor.Location = new Point(centerX - (btnVisitor.Width / 2)-500, centerY - (btnVisitor.Height / 2) + 200);

            btnStudent.Anchor = AnchorStyles.None;
            btnStudent.TextAlign = ContentAlignment.MiddleCenter;
            btnStudent.AutoSize = false;
            btnStudent.Width = 450;
            btnStudent.Height = 150;

            btnStudent.Location = new Point(centerX - (btnStudent.Width / 2) + 500, centerY - (btnStudent.Height / 2) + 200);


            btnhome.Anchor = AnchorStyles.None;
            btnhome.TextAlign = ContentAlignment.MiddleCenter;
            btnhome.AutoSize = false;
            btnhome.Width = 200;
            btnhome.Height = 100;

            btnhome.Location = new Point(centerX - (btnhome.Width / 2) + 800, centerY - (btnhome.Height / 2) - 450);
        }
    }
}
