using RentACar.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void ShowUserControl(UserControl control)
        {
            panelContainer.Controls.Clear(); // Köhnə görünüşü təmizləyir
            control.Dock = DockStyle.Fill; // Yeni görünüşü tamamilə doldurur

            panelContainer.Controls.Add(control); // Yeni görünüşü əlavə edir
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowUserControl(new LoginUC());
        }
    }
}
