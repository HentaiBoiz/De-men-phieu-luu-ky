using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using static DeMenPhieuLuuKy.PlayerProfile;
using static DeMenPhieuLuuKy.Difficulty;
using DeMenPhieuLuuKy.Puzzle;

namespace DeMenPhieuLuuKy
{
    public partial class Level_3_1 : Form
    {
        private int gravity = (int)playerJumpSpeed;
        private int falling = 1;
        private int force;
        private int score = 0;
        private int backgroundSpeed = 4;


        //Khai báo các biến liên quan đến kẻ địch
        int giunTime = 90;
        private int kienLuaSpeed_1 = KienLuaGobalSpeed, kienLuaSpeed_2 = KienLuaGobalSpeed, kienLuaSpeed_3 = KienLuaGobalSpeed-1;


        //Khai báo các biến xử lí di chuyển của nhân vật
        private int playerSpeed = 3;
        private int playerDir = 1;
        private bool goLeft, goRight, grounded;
        private bool jumping = false;
        private bool holdL = false, holdR = false;


        //Khai báo các biến background
        Image layer_1 = Properties.Resources.Cave;
        int b1 = -150;

        //Khai báo các biến xử lí âm thanh
        SoundPlayer sndBackgroundTheme = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\gameTheme.wav");
        SoundPlayer sndPlayerDie = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\player_die.wav");

        //Reset lại dữ liệu khi chết
        private float upJumpSpeedTemp = 0;
        private int upPowerTemp = 0, upHealthTemp = 0;

        //Giải đố
        private bool isSolve = false;

        public Level_3_1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            sndBackgroundTheme.PlayLooping();

            //Lấy đường dẫn file âm thanh
            mediaCoin.URL = AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\smw_coin.wav";
            mediaCoin.Ctlcontrols.stop();
            mediaCoin.settings.volume = 100;

            mediaJump.URL = AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\smw_jump.wav";
            mediaJump.Ctlcontrols.stop();
            mediaJump.settings.volume = 100;

            mediaStomp.URL = AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\smw_stomp.wav";
            mediaStomp.Ctlcontrols.stop();
            mediaStomp.settings.volume = 100;
        }
        private void MainTimeEvents(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score; //Điểm số người chơi nhận được khi thu thập "coin"
            grounded = false;
            BackgroundMove();

            // Trọng lực hút người chơi khi không nhấn nhảy
            if (jumping == false && grounded == false)
            {
                player.Top += falling;
                falling += 1;
            }

            //Player Dead
            if (player.Top > this.Bottom || (player.Top + player.Height < 0))
            {
                sndPlayerDie.Play();
                GameTimer.Stop();
                MessageBox.Show("Bạn đã rơi xuống vực ! " + Environment.NewLine + "Nhấp chọn OK để chơi lại");
                RestartGame();

            }

            foreach (Control x in this.Controls)
            {
                //Các vấn đề gặp phải khi người chơi va chạm với platform
                if (x is PictureBox && (string)x.Tag == "platform"
                    || x is PictureBox && (string)x.Tag == "platform_vertical")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (player.Left < x.Right && player.Bottom > x.Top && player.Top < x.Top - (player.Height * 60 / 100)
                            || player.Right > x.Left && player.Bottom > x.Top && player.Top < x.Top - (player.Height * 60 / 100))
                        {
                            player.Top = x.Top - player.Height;
                            grounded = true;
                            falling = 1;

                            if (jumping == true)
                            {
                                jumping = false;
                                if (holdL)
                                {
                                    player.Image = Properties.Resources.DeMen_Run_Small_L;
                                }
                                if (holdR)
                                {
                                    player.Image = Properties.Resources.DeMen_Run_Small;
                                }
                            }
                        }
                        else
                        if (player.Left < x.Right && player.Top < x.Bottom && player.Bottom > x.Bottom
                            || player.Right > x.Left && player.Bottom > x.Top && player.Top < x.Top)
                        {
                            player.Top += 3;
                            if (jumping == true)
                            {
                                jumping = false;
                                if (holdL)
                                {
                                    player.Image = Properties.Resources.DeMen_Run_Small_L;
                                }
                                if (holdR)
                                {
                                    player.Image = Properties.Resources.DeMen_Run_Small;
                                }
                            }
                            grounded = false;
                        }
                        else
                        {

                            if (player.Right > x.Left && player.Left < x.Left && player.Bottom >= x.Top)
                            {
                                goRight = false;
                            }

                            if (player.Left < x.Right && player.Right > x.Right && player.Bottom >= x.Top)
                            {
                                goLeft = false;
                            }
                        }
                    }

                    x.BringToFront();
                }


                //Vertical Platform
                if (x is PictureBox && (string)x.Tag == "platform_vertical")
                {
                    x.Top -= backgroundSpeed + 2;

                    if ((x.Top + x.Width) < 0)
                    {
                        x.Top = 520;
                    }
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        player.Top = x.Top - player.Height;
                    }
                }

                //Đến form tiếp theo
                if (x is PictureBox && (string)x.Tag == "nextForm")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameTimer.Stop();
                        Level_3_2 newWindow = new Level_3_2(score);
                        newWindow.Show();
                        this.Hide();
                    }

                }

                //Thu thập đồ vật "item"
                if (x is PictureBox && ((string)x.Tag == "jumpItem" || (string)x.Tag == "powerItem" || (string)x.Tag == "healthItem"))
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        //Kiểm tra loại item
                        if ((string)x.Tag == "jumpItem") upJumpSpeed(ref upJumpSpeedTemp);
                        else if ((string)x.Tag == "powerItem") upPower(ref upPowerTemp);
                        else if ((string)x.Tag == "healthItem") upHealth(ref upHealthTemp);

                        //Phát sound và xóa item
                        mediaCoin.Ctlcontrols.play();
                        score++;
                        this.Controls.Remove(x);
                        x.Dispose();
                    }

                }

                //Người chơi va chạm với kẻ địch
                if (x is PictureBox && (string)x.Tag == "enemy")
                {
                    //Kẻ địch: Kiến lửa 1
                    if (x.Name == "KienLua_1")
                    {
                        x.Top += 2;
                        x.Left -= kienLuaSpeed_1;
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            if (player.Left < x.Right && player.Bottom > x.Top && player.Top < x.Top - (player.Height * 80 / 100)
                                   || player.Right > x.Left && player.Bottom > x.Top && player.Top < x.Top - (player.Height * 80 / 100))
                            {
                                mediaStomp.Ctlcontrols.play();
                                enemyDead(Properties.Resources.KienLua_Dead, (PictureBox)x);
                                ObjDestroy(x);
                            }
                            else if (x.Visible == true)
                            {
                                sndPlayerDie.Play();
                                GameTimer.Stop();
                                MessageBox.Show("Bạn đã bị giết ! " + Environment.NewLine + "Nhấp chọn OK để chơi lại");
                                RestartGame();
                            }

                        }

                        //Kiến di chuyển
                        foreach (Control y in this.Controls)
                        {
                            if (y is PictureBox && (string)y.Tag == "platform")
                            {
                                if (x.Bounds.IntersectsWith(y.Bounds))
                                {
                                    x.Top = y.Top - x.Height;
                                    if (x.Left < y.Left)
                                    {
                                        kienLuaSpeed_1 = -kienLuaSpeed_1;
                                        KienLua_1.Image = Properties.Resources.KienLua_Walk_R;
                                    }
                                    if (x.Right > y.Right)
                                    {
                                        kienLuaSpeed_1 = -kienLuaSpeed_1;
                                        KienLua_1.Image = Properties.Resources.KienLua_Walk_L;
                                    }
                                }

                                y.BringToFront();
                            }

                        }
                    }


                    //Kẻ địch: Kiến lửa 3
                    if (x.Name == "KienLua_3")
                    {
                        x.Top += 2;
                        x.Left -= kienLuaSpeed_3;
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            if (player.Left < x.Right && player.Bottom > x.Top && player.Top < x.Top - (player.Height * 80 / 100)
                                   || player.Right > x.Left && player.Bottom > x.Top && player.Top < x.Top - (player.Height * 80 / 100))
                            {
                                mediaStomp.Ctlcontrols.play();
                                enemyDead(Properties.Resources.KienLua_Dead, (PictureBox)x);
                                ObjDestroy(x);
                            }
                            else if (x.Visible == true)
                            {
                                sndPlayerDie.Play();
                                GameTimer.Stop();
                                MessageBox.Show("Bạn đã bị giết ! " + Environment.NewLine + "Nhấp chọn OK để chơi lại");
                                RestartGame();
                            }

                        }

                        //Kiến di chuyển
                        foreach (Control y in this.Controls)
                        {
                            if (y is PictureBox && (string)y.Tag == "platform")
                            {
                                if (x.Bounds.IntersectsWith(y.Bounds))
                                {
                                    x.Top = y.Top - x.Height;
                                    if (x.Left < y.Left)
                                    {
                                        kienLuaSpeed_3 = -kienLuaSpeed_3;
                                        KienLua_3.Image = Properties.Resources.KienLua_Walk_R;
                                    }
                                    if (x.Right > y.Right)
                                    {
                                        kienLuaSpeed_3 = -kienLuaSpeed_3;
                                        KienLua_3.Image = Properties.Resources.KienLua_Walk_L;
                                    }
                                }

                                y.BringToFront();
                            }
                        }
                    }

                    //Kẻ địch: Giun
                    if (x.Name == "Giun_1")
                    {
                        giunTime -= 1;
                        x.Top -= 2;
                        if (giunTime < 0)
                        {
                            giunTime = 90;
                            x.Top = 0;
                        }
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            sndPlayerDie.Play();
                            GameTimer.Stop();
                            MessageBox.Show("Bạn đã bị giết ! " + Environment.NewLine + "Nhấp chọn OK để chơi lại");
                            RestartGame();
                        }
                    }
                }
            }
            //Di chuyển qua trái
            if (goLeft == true & player.Left - (player.Width + 399) > 0)
            {
                player.Left -= playerSpeed;
            }
            //Di chuyển qua phải
            if (goRight == true & player.Left + (player.Width + 399) < this.ClientSize.Width)
            {
                player.Left += playerSpeed;
            }

            //Di chuyển background
            if (goLeft == true)
            {
                MoveGameElement("forward");
            }
            if (goRight == true)
            {
                MoveGameElement("back");
            }

            //Người chơi thực hiện "nhảy"
            if (jumping == true)
            {
                player.Top -= force;
                force -= 1;
            }
        }

        private void Level_3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(layer_1, b1, -110);
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left & !holdL)
            {
                goLeft = true;
                holdL = true;
                playerDir = -1;
                player.Image = Properties.Resources.DeMen_Run_Small_L;
            }
            if (e.KeyCode == Keys.Right & !holdR)
            {
                goRight = true;
                holdR = true;
                playerDir = 1;
                player.Image = Properties.Resources.DeMen_Run_Small;
            }
            if (e.KeyCode == Keys.Space && jumping == false && grounded == true)
            {
                mediaJump.Ctlcontrols.play();
                jumping = true;
                force = gravity;
                if (playerDir > 0)
                {
                    player.Image = Properties.Resources.DeMen_Jump_Small;
                }
                else
                {
                    player.Image = Properties.Resources.DeMen_Jump_Small_L;
                }

            }

            //Hiện puzzle
            if (e.KeyCode == Keys.E && player.Bounds.IntersectsWith(showPuzzle.Bounds) && !isSolve)
            {
                MiniGame puzzleForm = new MiniGame();
                puzzleForm = RandomPuzzle.GetRandomPuzzle();
                puzzleForm.ShowDialog();
                this.isSolve = puzzleForm.isPuzzleSolve;
                if (isSolve) FinishPuzzle();

            }

            //Về màn hình chính
            if (e.KeyCode == Keys.Escape)
            {
                GameTimer.Stop();
                DialogResult result;

                result = MessageBox.Show("Bạn có muốn trở về màn hình chính ?\nChú ý: Mọi dữ liệu chưa lưu sẽ bị mất !", "CẢNH BÁO !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    GameTimer.Stop();
                    sndBackgroundTheme = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\titleScreenTheme.wav");
                    sndBackgroundTheme.PlayLooping();

                    Program.titleScreen.Show();
                    Program.titleScreen.Enabled = true;
                    this.Hide();
                }
                else { GameTimer.Start(); }
            }

            //Hiện thông số
            if (e.KeyCode == Keys.P)
            {
                PlayerStat playerStat = new PlayerStat(this);
                playerStat.Show();
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left & holdL)
            {
                if (!holdR)
                {
                    goLeft = false;
                    holdL = false;
                    player.Image = Properties.Resources.DeMen_Idle_Small_L;
                }
                if (holdR)
                {
                    goLeft = false;
                    holdL = false;
                }

            }

            if (e.KeyCode == Keys.Right & holdR)
            {
                if (!holdL)
                {
                    goRight = false;
                    holdR = false;
                    player.Image = Properties.Resources.DeMen_Idle_Small;
                }
                if (holdL)
                {
                    goRight = false;
                    holdR = false;
                }

            }
        }

        private void This_Closing(object sender, FormClosingEventArgs e)
        {
            sndBackgroundTheme.Stop();
            Application.Exit();
        }

        //Cuộn background khi di chuyển
        private void BackgroundMove()
        {
            //Qua phải
            if (goRight == true)
            {
                b1 -= 2;

            }

            //Qua trái
            if (goLeft == true)
            {
                b1 += 2;

            }


            Invalidate();
        }

        //Di chuyển các vật thể trong game
        private void MoveGameElement(string direction)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform"
                    || x is PictureBox && (string)x.Tag == "platform_vertical"
                    || x is PictureBox && (string)x.Tag == "limitBox"
                    || x is PictureBox && (string)x.Tag == "key"
                    || x is PictureBox && (string)x.Tag == "door"
                    || x is PictureBox && (string)x.Tag == "enemy"
                    || x is PictureBox && (string)x.Tag == "tutorialOn"
                    || x is PictureBox && (string)x.Tag == "corpse"
                    || x is PictureBox && (string)x.Tag == "nextForm"
                    || x is PictureBox && (string)x.Tag == "healthItem"
                    || x is PictureBox && (string)x.Tag == "powerItem"
                    || x is PictureBox && (string)x.Tag == "jumpItem"
                    || x is PictureBox && (string)x.Tag == "puzzle")
                {
                    if (direction == "back")
                    {
                        x.Left -= backgroundSpeed;
                    }
                    if (direction == "forward")
                    {
                        x.Left += backgroundSpeed;
                    }
                }
            }

        }

        //Khi enemy bị tiêu diệt, sẽ để lại 1 cái xác
        private void enemyDead(Image deadSpirte, PictureBox enemy)
        {
            PictureBox corpse = new PictureBox();
            corpse.BackColor = System.Drawing.Color.Transparent;
            corpse.Image = deadSpirte;
            corpse.Tag = "corpse";
            corpse.Height = deadSpirte.Height;
            corpse.Width = deadSpirte.Width;
            corpse.Left = enemy.Left;
            corpse.Top = enemy.Top;
            this.Controls.Add(corpse);
        }

        //Xóa Control khỏi màn chơi
        private void ObjDestroy(Control x)
        {
            this.Controls.Remove(x);
            x.Dispose();
        }

        private void RestartGame()
        {
            ResetDuLieu();
            Level_3_1 newWindow = new Level_3_1();
            newWindow.Show();
            this.Hide();
        }

        private void ResetDuLieu()
        {
            playerJumpSpeed -= upJumpSpeedTemp;
            playerPower -= upPowerTemp;
            playerGobalHealth -= upHealthTemp;
        }
        private void FinishPuzzle()
        {
            puzzleStone.Image = Properties.Resources.stone_small;
            puzzleStone.Tag = "door";
            puzzleStone.SendToBack();
        }
    }
}
