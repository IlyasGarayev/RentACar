using RentACar.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.UserControls.LoginSignUp
{
    public partial class ResetPasswordUC : UserControl
    {
        public ResetPasswordUC()
        {
            InitializeComponent();
        }

        private void btnLoginPage_Click(object sender, EventArgs e)
        {
            var mainForm = (MainForm)this.ParentForm;
            mainForm.ShowUserControl(new LoginUC());
        }
    }
}
