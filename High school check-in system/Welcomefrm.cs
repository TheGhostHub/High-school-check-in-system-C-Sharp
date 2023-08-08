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
    public partial class welcomefrm : Form
    {
        public welcomefrm()
        {
            InitializeComponent();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            var User_Options = new User_Options();
            this.Hide();
            User_Options.Show();
            
        }

        private void welcomefrm_Load(object sender, EventArgs e)
        {

            // Calculate the center position of the form
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            // Set the lbl properties
            lblwelcom.Anchor = AnchorStyles.None;
            lblwelcom.TextAlign = ContentAlignment.MiddleCenter;
            lblwelcom.AutoSize = false;
            lblwelcom.Width = 1500;
            lblwelcom.Height = 400;


            // Set the location of the button control to the center of the form
            lblwelcom.Location = new Point(centerX - (lblwelcom.Width / 2), centerY - (lblwelcom.Height / 2)-200);


            btnstart.Anchor = AnchorStyles.None;
            btnstart.TextAlign = ContentAlignment.MiddleCenter;
            btnstart.AutoSize = false;
            btnstart.Width = 600;
            btnstart.Height = 150;

            btnstart.Location = new Point(centerX - (btnstart.Width / 2), centerY - (btnstart.Height / 2) + 200);

        }
    }
}
