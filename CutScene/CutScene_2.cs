using System;
using System.Windows.Forms;

namespace DeMenPhieuLuuKy.CutScene
{
    public partial class CutScene_2 : Form
    {


        public CutScene_2()
        {
            InitializeComponent();

            //Lấy đường dẫn video cutscene
            videoPlayer.URL = AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\P2.mp4";
            videoPlayer.settings.setMode("loop", true);
            videoPlayer.Ctlcontrols.play();
            videoPlayer.settings.volume = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            videoPlayer.Ctlcontrols.stop();
            Level_2_1 newWindow = new Level_2_1(0);
            newWindow.Show();
            this.Hide();
        }
    }
}
