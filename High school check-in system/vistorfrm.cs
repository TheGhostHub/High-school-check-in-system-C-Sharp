using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Emgu.CV;

namespace High_school_check_in_system
{


    public partial class vistorfrm : Form
    {


        bool straming;
        Capture capture;




        public vistorfrm()
        {
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            var welcomfrm = new welcomefrm();
            this.Hide();
            welcomfrm.Show();
        }

        private void vistorfrm_Load(object sender, EventArgs e)
        {

            straming = false;
            capture = new Capture();


            // Calculate the center position of the form
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            btnhome.Anchor = AnchorStyles.None;
            btnhome.TextAlign = ContentAlignment.MiddleCenter;
            btnhome.AutoSize = false;
            btnhome.Width = 200;
            btnhome.Height = 100;

            btnhome.Location = new Point(centerX - (btnhome.Width / 2) + 800, centerY - (btnhome.Height / 2) - 450);


            lblYourname.Anchor = AnchorStyles.None;
            lblYourname.TextAlign = ContentAlignment.MiddleLeft;
            lblYourname.AutoSize = false;
            lblYourname.Width = 700;
            lblYourname.Height = 150;

            lblYourname.Location = new Point(centerX - (lblYourname.Width / 2) - 300, centerY - (lblYourname.Height / 2) - 350);

            lblstaffname.Anchor = AnchorStyles.None;
            lblstaffname.TextAlign = ContentAlignment.MiddleLeft;
            lblstaffname.AutoSize = false;
            lblstaffname.Width = 700;
            lblstaffname.Height = 150;

            lblstaffname.Location = new Point(centerX - (lblstaffname.Width / 2) -300, centerY - (lblstaffname.Height / 2) - 200);

            txtbxYourname.Anchor = AnchorStyles.None;
            txtbxYourname.AutoSize = false;
            txtbxYourname.Width = 600;
            txtbxYourname.Height = 90;

            txtbxYourname.Location = new Point(centerX - (txtbxYourname.Width / 2) + 300, centerY - (txtbxYourname.Height / 2) - 350);

            cmbboxStafname.Anchor = AnchorStyles.None;
            cmbboxStafname.AutoSize = false;
            cmbboxStafname.Width = 600;
            cmbboxStafname.Height = 150;

            cmbboxStafname.Location = new Point(centerX - (cmbboxStafname.Width / 2) + 300, centerY - (cmbboxStafname.Height / 2) -200 );

            lblTakePhoto.Anchor = AnchorStyles.None;
            lblTakePhoto.TextAlign = ContentAlignment.MiddleLeft;
            lblTakePhoto.AutoSize = false;
            lblTakePhoto.Width = 700;
            lblTakePhoto.Height = 150;

            lblTakePhoto.Location = new Point(centerX - (lblTakePhoto.Width / 2)-300, centerY - (lblTakePhoto.Height / 2) -50);


            btncamerastartStop.Anchor = AnchorStyles.None;
            btncamerastartStop.TextAlign = ContentAlignment.MiddleCenter;
            btncamerastartStop.AutoSize = false;
            btncamerastartStop.Width = 400;
            btncamerastartStop.Height = 100;

            btncamerastartStop.Location = new Point(centerX - (btncamerastartStop.Width / 2)-400, centerY - (btncamerastartStop.Height / 2) +100);

            
            pictureBoxPriview.Anchor = AnchorStyles.None;
            pictureBoxPriview.AutoSize = false;
            pictureBoxPriview.Width = 300;
            pictureBoxPriview.Height = 300;

            pictureBoxPriview.Location = new Point(centerX - (pictureBoxPriview.Width / 2)+150, centerY - (pictureBoxPriview.Height / 2) +50);


            btnConform.Anchor = AnchorStyles.None;
            btnConform.TextAlign = ContentAlignment.MiddleCenter;
            btnConform.AutoSize = false;
            btnConform.Width = 450;
            btnConform.Height = 150;

            btnConform.Location = new Point(centerX - (btnConform.Width / 2), centerY - (btnConform.Height / 2) + 300);


        }
        private void streaming(object sender, EventArgs e)
        {

            try
            {
                var img = capture.QueryFrame().ToImage<Bgr, byte>();
                var bmp = img.Bitmap;
                pictureBoxPriview.Image = bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void btncamera_Click(object sender, EventArgs e)
        {
            
            

            if (!straming)
            {
                Application.Idle += streaming;
                btncamerastartStop.Text = @"Capture";
                btncamerastartStop.ForeColor= Color.White;
                btncamerastartStop.BackColor = Color.Green;

            }
            else 
            {
                Application.Idle -= streaming;
                btncamerastartStop.Text = @"Start";
                btncamerastartStop.ForeColor = Color.White;
                btncamerastartStop.BackColor = Color.FromArgb(0,120,214);
                
            }

            straming = !straming;
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
