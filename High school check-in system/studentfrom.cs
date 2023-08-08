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
    public partial class studentfrom : Form
    {
        public studentfrom()
        {
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            var welcomfrm = new welcomefrm();
            this.Hide();
            welcomfrm.Show();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {


          
        }

        private void cmbboxYear_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbboxYear.SelectedItem.ToString() == "Year 7")
                {
                    comboxID.Items.Clear();
                    comboxID.Items.Add("TG");
                    comboxID.Items.Add("AD");
                    comboxID.Items.Add("MS");
                    comboxID.Items.Add("AH");
                }
                if (cmbboxYear.SelectedItem.ToString() == "Year 8")
                {
                    comboxID.Items.Clear();
                    comboxID.Items.Add("CB");
                    comboxID.Items.Add("RK");
                    comboxID.Items.Add("CW");
                    comboxID.Items.Add("MB");
                }
                if (cmbboxYear.SelectedItem.ToString() == "Year 9")
                {
                    comboxID.Items.Clear();
                    comboxID.Items.Add("TG");
                    comboxID.Items.Add("AD");
                    comboxID.Items.Add("MS");
                    comboxID.Items.Add("AH");
                }
                if (cmbboxYear.SelectedItem.ToString() == "Year 10")
                {
                    comboxID.Items.Clear();
                    comboxID.Items.Add("TG");
                    comboxID.Items.Add("AD");
                    comboxID.Items.Add("MS");
                    comboxID.Items.Add("AH");
                }
                if (cmbboxYear.SelectedItem.ToString() == "Year 11")
                {
                    comboxID.Items.Clear();
                    comboxID.Items.Add("TG");
                    comboxID.Items.Add("AD");
                    comboxID.Items.Add("MS");
                    comboxID.Items.Add("AH");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbboxYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void studentfrom_Load(object sender, EventArgs e)
        {
            // Calculate the center position of the form
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            btnhome.Anchor = AnchorStyles.None;
            btnhome.TextAlign = ContentAlignment.MiddleCenter;
            btnhome.AutoSize = false;
            btnhome.Width = 200;
            btnhome.Height = 100;

            btnhome.Location = new Point(centerX - (btnhome.Width / 2) + 800, centerY - (btnhome.Height / 2) - 450);

            lblyear.Anchor = AnchorStyles.None;
            lblyear.TextAlign = ContentAlignment.MiddleLeft;
            lblyear.AutoSize = false;
            lblyear.Width = 750;
            lblyear.Height = 200;

            lblyear.Location = new Point(centerX - (lblyear.Width / 2) -300, centerY - (lblyear.Height / 2) - 300);

            lblid.Anchor = AnchorStyles.None;
            lblid.TextAlign = ContentAlignment.MiddleLeft;
            lblid.AutoSize = false;
            lblid.Width = 750;
            lblid.Height = 200;

            lblid.Location = new Point(centerX - (lblid.Width / 2)  -300, centerY - (lblid.Height / 2) - 100);

            lblname.Anchor = AnchorStyles.None;
            lblname.TextAlign = ContentAlignment.MiddleLeft;
            lblname.AutoSize = false;
            lblname.Width = 750;
            lblname.Height = 200;

            lblname.Location = new Point(centerX - (lblname.Width / 2) -300, centerY - (lblname.Height / 2)+100 );

            cmbboxYear.Anchor = AnchorStyles.None;
            cmbboxYear.AutoSize = false;
            cmbboxYear.Width = 600;
            cmbboxYear.Height = 200;

            cmbboxYear.Location = new Point(centerX - (cmbboxYear.Width / 2) + 300, centerY - (cmbboxYear.Height / 2) - 300);

            comboxID.Anchor = AnchorStyles.None;
            comboxID.AutoSize = false;
            comboxID.Width = 600;
            comboxID.Height = 200;

            comboxID.Location = new Point(centerX - (comboxID.Width / 2) + 300, centerY - (comboxID.Height / 2) - 100);

            comboBoxname.Anchor = AnchorStyles.None;
            comboBoxname.AutoSize = false;
            comboBoxname.Width = 600;
            comboBoxname.Height = 200;

            comboBoxname.Location = new Point(centerX - (comboBoxname.Width / 2) + 300, centerY - (comboBoxname.Height / 2)+100 );

            btnConform.Anchor = AnchorStyles.None;
            btnConform.TextAlign = ContentAlignment.MiddleCenter;
            btnConform.AutoSize = false;
            btnConform.Width = 450;
            btnConform.Height = 150;

            btnConform.Location = new Point(centerX - (btnConform.Width / 2), centerY - (btnConform.Height / 2) + 300);


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
