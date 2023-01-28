using System;
using System.Windows.Forms;

namespace DeMenPhieuLuuKy
{
    public partial class DoiNgu : Form
    {
        Title_Screen titleScreen;

        public DoiNgu(Title_Screen titleScreen)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.titleScreen = titleScreen;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
            titleScreen.Enabled = true;
            titleScreen.Focus();
        }

        private void MainTimeEvents(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if ((x is Label || x is PictureBox) && (string)x.Tag == "scroll")
                {
                    x.Top -= 3;
                }
                if (gameName.Top < 160)
                {
                    if (x is Label && (string)x.Tag == "scroll") x.Visible = false;
                    timer1.Stop();
                }
            }
        }
    }
}
