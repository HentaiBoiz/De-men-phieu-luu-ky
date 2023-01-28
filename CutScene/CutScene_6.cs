using System;
using System.Windows.Forms;

namespace DeMenPhieuLuuKy.CutScene
{
    public partial class CutScene_6 : Form
    {


        public CutScene_6()
        {
            InitializeComponent();

            //Lấy đường dẫn video cutscene
            videoPlayer.URL = AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\End.mp4";
            videoPlayer.settings.setMode("loop", true);
            videoPlayer.Ctlcontrols.play();
            videoPlayer.settings.volume = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            videoPlayer.Ctlcontrols.stop();
            Title_Screen newWindow = new Title_Screen();
            newWindow.Show();
            this.Hide();
        }
    }
}
