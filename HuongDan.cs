using System;
using System.Windows.Forms;

namespace DeMenPhieuLuuKy
{
    public partial class HuongDan : Form
    {
        Title_Screen titleScreen;

        public HuongDan(Title_Screen titleScreen)
        {
            InitializeComponent();
            this.titleScreen = titleScreen;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            titleScreen.Enabled = true;
            titleScreen.Focus();
        }
    }
}
