using System;
using System.Windows.Forms;

namespace DeMenPhieuLuuKy.CutScene
{
    public partial class CutScene_5 : Form
    {


        public CutScene_5()
        {
            InitializeComponent();

            //Lấy đường dẫn video cutscene
            videoPlayer.URL = AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\P5.mp4";
            videoPlayer.settings.setMode("loop", true);
            videoPlayer.Ctlcontrols.play();
            videoPlayer.settings.volume = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            videoPlayer.Ctlcontrols.stop();
            Level_6_1 newWindow = new Level_6_1();
            newWindow.Show();
            this.Hide();
        }
    }
}
