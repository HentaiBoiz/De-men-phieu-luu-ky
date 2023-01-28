using System;
using System.Windows.Forms;

namespace DeMenPhieuLuuKy.CutScene
{
    public partial class CutScene_1 : Form
    {


        public CutScene_1()
        {
            InitializeComponent();

            //Lấy đường dẫn video cutscene
            videoPlayer.URL = AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\P1.mp4";
            videoPlayer.settings.setMode("loop", true);
            videoPlayer.Ctlcontrols.play();
            videoPlayer.settings.volume = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            videoPlayer.Ctlcontrols.stop();
            Level_1 newWindow = new Level_1();
            newWindow.Show();
            this.Hide();
        }
    }
}
