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
    public partial class staff_from : Form
    {
        public staff_from()
        {
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            var welcomfrm = new welcomefrm();
            welcomfrm.Show();
            this.Hide();
        }

        private void staff_from_Load(object sender, EventArgs e)
        {
            // Calculate the center position of the form
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            lblName.Anchor = AnchorStyles.None;
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            lblName.AutoSize = false;
            lblName.Width = 600;
            lblName.Height = 350;

            lblName.Location = new Point(centerX - (lblName.Width / 2)-300, centerY - (lblName.Height / 2)-200 );

            cmbboxlist.Anchor = AnchorStyles.None;
            cmbboxlist.AutoSize = false;
            cmbboxlist.Width = 600;
            cmbboxlist.Height = 200;

            cmbboxlist.Location = new Point(centerX - (cmbboxlist.Width / 2)+300, centerY - (cmbboxlist.Height / 2)-200);

            btnConform.Anchor = AnchorStyles.None;
            btnConform.TextAlign=ContentAlignment.MiddleCenter;
            btnConform.AutoSize = false;
            btnConform.Width = 450;
            btnConform.Height = 150;

            btnConform.Location = new Point(centerX - (btnConform.Width / 2) , centerY - (btnConform.Height / 2)+200);



            btnhome.Anchor = AnchorStyles.None;
            btnhome.TextAlign = ContentAlignment.MiddleCenter;
            btnhome.AutoSize = false;
            btnhome.Width = 200;
            btnhome.Height = 100;

            btnhome.Location = new Point(centerX - (btnhome.Width / 2)+800, centerY - (btnhome.Height / 2) - 450);

        }

        private void btnConform_Click(object sender, EventArgs e)
        {
            message m = new message();
            m.messageBox();
            var welcomfrm = new welcomefrm();
            welcomfrm.Show();
            this.Hide();
        }
    }
}
