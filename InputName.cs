using DeMenPhieuLuuKy.CutScene;
using System;
using System.Windows.Forms;
using static DeMenPhieuLuuKy.PlayerProfile;
using static DeMenPhieuLuuKy.Difficulty;

namespace DeMenPhieuLuuKy
{
    public partial class InputName : Form
    {

        private SaveData saveData;
        private Title_Screen titleScreen;
  

        public InputName(Title_Screen _titleScreen, SaveData _saveData)
        {
            InitializeComponent();

            saveData = _saveData;
            titleScreen = _titleScreen;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtPlayerName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên người chơi trước khi bắt đầu !");
            }
            else
            {
                //Kiểm tra ghi đè
                if (saveData.CheckOverwrite(txtPlayerName.Text))
                {
                    DialogResult result;

                    result = MessageBox.Show("Bản lưu đã tồn tại ! Bạn có muốn ghi đè không ?\n Chú ý: Dữ liệu bản lưu cũ sẽ bị xóa sạch !", "CẢNH BÁO !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        ReadyToStart();
                    }
                }
                else
                    //Kiểm tra đầy
                    if (saveData.CheckFull())
                {
                    MessageBox.Show("Dữ liệu đã đầy ! Vui lòng xóa bớt bản lưu !", "CẢNH BÁO !!!");
                }
                else
                {
                    ReadyToStart();
                }
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            titleScreen.Enabled = true;
            titleScreen.Focus();
        }

        private void ReadyToStart()
        {
            if (Program.SaveFolderPath != null)
            {
                saveData.FindAndDelete(txtPlayerName.Text);
                ResetPlayerProfile();
                saveData.AddNewPlayer(txtPlayerName.Text, 0, "Level 1", StringDifficulty(difficulty), playerGobalHealth, playerPower, playerJumpSpeed);
                saveData.ExportToExcel();
                titleScreen.saveDataDispose = true;

                Program.playerNameData = txtPlayerName.Text;
                Program.globalScore = 0;

                CutScene_1 newWindow = new CutScene_1();
                newWindow.Show();
                titleScreen.Hide();
                saveData.Close();
                this.Close();
            }
            else MessageBox.Show("Vui lòng chọn thư mục lưu game ngoài màn hình chính trước khi bắt đầu chơi !");
            
        }

        //Khi chuyển radio button
        private void ChangeDifficulty(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            if (radio.Checked)
            {
                difficulty = Convert.ToInt32(radio.Tag.ToString());
                Console.WriteLine(difficulty);
            }
        }
    }
}
