using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace High_school_check_in_system
{
    internal class message
    {

        public void messageBox()
        {

            //MessageBox.Show("Success", "Message", MessageBoxButtons.OKCancel);

            Form messageBoxForm = new Form();
            messageBoxForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            messageBoxForm.MaximizeBox = false;
            messageBoxForm.MinimizeBox = false;
            messageBoxForm.StartPosition = FormStartPosition.CenterScreen;
            messageBoxForm.ClientSize = new Size(800, 400);
            messageBoxForm.BackColor = Color.White;


            int centerX = messageBoxForm.ClientSize.Width / 2;
            int centerY = messageBoxForm.ClientSize.Height / 2;
            Label messageLabel = new Label();
            messageLabel.Text = "Thank You";
            messageLabel.AutoSize = true;
            messageLabel.Font = new Font(messageLabel.Font.FontFamily, 55, FontStyle.Bold);
            messageLabel.Location = new Point(200, 20);


            // create a button for the OK action
            Button okButton = new Button();
            okButton.Width = 300;
            okButton.Height = 100;
            okButton.Font = new Font(okButton.Font.FontFamily, 28, FontStyle.Bold);
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.ForeColor = Color.White;
            okButton.BackColor = Color.FromArgb(0, 120, 214);
            okButton.Location = new Point(centerX - (okButton.Width / 2), centerY - (okButton.Height / 2) + 50);

            // add the label and button to the form
            messageBoxForm.Controls.Add(messageLabel);
            messageBoxForm.Controls.Add(okButton);

            // show the custom message box and get the result
            DialogResult result = messageBoxForm.ShowDialog();
        }


    }


}
