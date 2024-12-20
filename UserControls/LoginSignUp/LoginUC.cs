using RentACar.Forms;
using RentACar.UserControls.LoginSignUp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.UserControls
{
    public partial class LoginUC : UserControl
    {
        public LoginUC()
        {
            InitializeComponent();
        }


        private void linkSignUP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var mainForm = (MainForm)this.ParentForm;
            mainForm.ShowUserControl(new SignUpUC());
        }

        private void linkResetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var mainForm = (MainForm)this.ParentForm;
            mainForm.ShowUserControl(new SendCodeToMailUC());
        }
    }
}
