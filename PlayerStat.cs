using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DeMenPhieuLuuKy.PlayerProfile;

namespace DeMenPhieuLuuKy
{

    public partial class PlayerStat : Form
    {

        private Form prevForm;

        public PlayerStat(Form _prevForm)
        {
            InitializeComponent();

            prevForm = _prevForm;
            prevForm.Enabled = false;

            txtPlayerName.Text = Program.playerNameData;
            txtPlayerHealth.Text = playerGobalHealth.ToString();
            txtPlayerPower.Text = playerGobalHealth.ToString();
            txtPlayerJumpSpeed.Text = playerJumpSpeed.ToString();

        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            prevForm.Enabled = true;
            this.Dispose();
        }


    }

}
