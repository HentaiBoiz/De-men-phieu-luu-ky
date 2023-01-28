using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace DeMenPhieuLuuKy
{


    public partial class Title_Screen : Form
    {
        //Khai báo các biến âm thanh
        SoundPlayer sndTitleScreenTheme = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\titleScreenTheme.wav");

        //Khai báo form save game
        SaveData saveGameData;
        InputName inputName;
        HuongDan huongDan;
        DoiNgu doiNgu;

        public bool saveDataDispose = false;

        public Title_Screen()
        {
            InitializeComponent();
            sndTitleScreenTheme.PlayLooping();

            saveGameData = new SaveData(this);
            saveGameData.Hide();

        }


        // Xử lí các button ngoài title screen --Start_1
        private void DoiMauButton(Label obj, bool hover)
        {
            if (hover == true)
            {
                obj.ForeColor = Color.Green;
                Leaf_Cursor.Top = obj.Top;
                Leaf_Cursor.Visible = true;
            }
            if (hover == false)
            {
                obj.ForeColor = Color.Black;
            }
        }
        private void btnChoiMoi_Hover(object sender, EventArgs e)
        {
            DoiMauButton(btnChoimoi, true);
        }

        private void btnChoiMoi_Leave(object sender, EventArgs e)
        {
            DoiMauButton(btnChoimoi, false);
        }

        private void btnTieptuc_Hover(object sender, EventArgs e)
        {
            DoiMauButton(btnTieptuc, true);
        }

        private void btnTieptuc_Leave(object sender, EventArgs e)
        {
            DoiMauButton(btnTieptuc, false);
        }

        private void btnDoingu_Hover(object sender, EventArgs e)
        {
            DoiMauButton(btnDoingu, true);
        }

        private void btnDoingu_Leave(object sender, EventArgs e)
        {
            DoiMauButton(btnDoingu, false);
        }

        private void btnThoat_Hover(object sender, EventArgs e)
        {
            DoiMauButton(btnThoat, true);
        }

        private void btnThoat_Leave(object sender, EventArgs e)
        {
            DoiMauButton(btnThoat, false);
        }

        private void btnChoimoi_Click(object sender, EventArgs e)
        {
            inputName = new InputName(this, saveGameData);
            inputName.Show();
            this.Enabled = false;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Bạn có thật sự muốn thoát khỏi trò chơi chứ ?", "CẢNH BÁO !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void This_Closing(object sender, FormClosingEventArgs e)
        {
            sndTitleScreenTheme.Stop();
            Application.Exit();
        }

        private void btnTieptuc_Click(object sender, EventArgs e)
        {
            if (saveDataDispose)
            {
                saveGameData = new SaveData(this);
                saveDataDispose = false;
            }
            saveGameData.Show();
            this.Enabled = false;
        }

        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            huongDan = new HuongDan(this);
            huongDan.Show();
            this.Enabled = false;
        }
        private void btnDoingu_Click(object sender, EventArgs e)
        {
            doiNgu = new DoiNgu(this);
            doiNgu.Show();
            this.Enabled = false;
        }

        private void btnHuongDan_Hover(object sender, EventArgs e)
        {
            DoiMauButton(btnTutorial, true);
        }

        private void btnHuongDan_Leave(object sender, EventArgs e)
        {
            DoiMauButton(btnTutorial, false);
        }

        //Button Open Save Game
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Program.SaveFilePath = ofd.SelectedPath + "\\SaveData.xlsx";
                Program.SaveFolderPath = ofd.SelectedPath;
                Console.WriteLine(ofd.SelectedPath);
                saveGameData.ImportFromExcel();
            }
        }


        // --End_1

    }
}
