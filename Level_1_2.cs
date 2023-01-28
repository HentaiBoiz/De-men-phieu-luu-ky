﻿using DeMenPhieuLuuKy.CutScene;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using static DeMenPhieuLuuKy.PlayerProfile;

namespace DeMenPhieuLuuKy
{
    public partial class Level_1_2 : Form
    {


        private int gravity = (int)playerJumpSpeed;
        private int falling = 1;
        private int force, tutOn;
        private int score_, score;
        private int backgroundSpeed = 4;

        //Các biến liên quản tới vật thể chuyển động
        //Platform di chuyển ngang
        private int movingPlatSpeed = 4;
        private int dir_1 = 1, dir_2 = -1;
        //Platform tự rơi
        private int dropTime_1 = 50, dropTime_2 = 50, dropTime_3 = 50, dropTime_4 = 50;
        private bool willDrop_1 = false, willDrop_2 = false, willDrop_3 = false, willDrop_4 = false;

        //Khai báo các biến liên quan đến kẻ địch

        private int snakeTime = 110;

        //Khai báo các biến xử lí di chuyển của nhân vật
        private int playerSpeed = 3;
        private int playerDir = 1;
        private bool goLeft, goRight, grounded;
        private bool jumping = false;
        private bool holdL = false, holdR = false;


        //Khai báo các biến background
        private Image layer_1 = Properties.Resources.Jungle;
        private int b1 = -150;

        //Khai báo các biến xử lí âm thanh
        private SoundPlayer sndBackgroundTheme = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\gameTheme.wav");
        private SoundPlayer sndPlayerDie = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\player_die.wav");

        //Reset lại dữ liệu khi chết
        private float upJumpSpeedTemp = 0;
        private int upPowerTemp = 0, upHealthTemp = 0;

        private void This_Closing(object sender, FormClosingEventArgs e)
        {
            sndBackgroundTheme.Stop();
            Application.Exit();
        }

        public Level_1_2()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        public Level_1_2(int score_)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.score_ = score_;
            score = this.score_;

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
            tutOn--;

            //Trọng lực hút người chơi khi không nhấn nhảy
            if (jumping == false && grounded == false)
            {
                player.Top += falling;
                falling += 1;
            }

            //Player Dead
            if (player.Top > this.Bottom)
            {
                sndPlayerDie.Play();
                GameTimer.Stop();
                MessageBox.Show("Bạn đã rơi xuống vực ! " + Environment.NewLine + "Nhấp chọn OK để chơi lại");
                RestartGame();
                sndBackgroundTheme.Play();
            }

            foreach (Control x in this.Controls)
            {
                //Dropdown Platform
                if (x is PictureBox && (string)x.Tag == "platform_dropdown")
                {
                    if (x.Name == "DropdownPlatform_1")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                            willDrop_1 = true;
                        if (willDrop_1)
                            dropTime_1 -= 2;
                        if (dropTime_1 < 0)
                            x.Top += movingPlatSpeed * 2;
                        if (x.Top > this.Bottom)
                            ObjDestroy(x);
                    }
                    if (x.Name == "DropdownPlatform_2")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                            willDrop_2 = true;
                        if (willDrop_2)
                            dropTime_2 -= 2;
                        if (dropTime_2 < 0)
                            x.Top += movingPlatSpeed * 2;
                        if (x.Top > this.Bottom)
                            ObjDestroy(x);
                    }
                    if (x.Name == "DropdownPlatform_3")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                            willDrop_3 = true;
                        if (willDrop_3)
                            dropTime_3 -= 2;
                        if (dropTime_3 < 0)
                            x.Top += movingPlatSpeed * 2;
                        if (x.Top > this.Bottom)
                            ObjDestroy(x);
                    }
                    if (x.Name == "DropdownPlatform_4")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                            willDrop_4 = true;
                        if (willDrop_4)
                            dropTime_4 -= 2;
                        if (dropTime_4 < 0)
                            x.Top += movingPlatSpeed * 2;
                        if (x.Top > this.Bottom)
                            ObjDestroy(x);
                    }
                }

                //Các vấn đề gặp phải khi người chơi va chạm với platform
                if (x is PictureBox && (string)x.Tag == "platform"
                    || x is PictureBox && (string)x.Tag == "platform_horizontal"
                    || x is PictureBox && (string)x.Tag == "platform_dropdown")
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
                            player.Top += 3; //x.Bottom
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


                //Horizontal Platform
                if (x is PictureBox && (string)x.Tag == "platform_horizontal")
                {
                    if (x.Name == "HorizontalPlatform_1")
                    {
                        x.Left += movingPlatSpeed * dir_1;
                        foreach (Control y in this.Controls)
                            if (y is PictureBox && (string)y.Tag == "limitBox")
                                if (x.Bounds.IntersectsWith(y.Bounds))
                                {
                                    if (x.Left < y.Left && x.Right > y.Left)
                                    {
                                        x.Left = y.Left;
                                        dir_1 = 1;
                                    }
                                    if (x.Right > y.Right && x.Left > y.Left)
                                    {
                                        x.Left = y.Right - x.Width;
                                        dir_1 = -1;
                                    }
                                }
                    }

                    if (x.Name == "HorizontalPlatform_2")
                    {
                        x.Left += movingPlatSpeed * dir_2;
                        foreach (Control y in this.Controls)
                            if (y is PictureBox && (string)y.Tag == "limitBox")
                                if (x.Bounds.IntersectsWith(y.Bounds))
                                {
                                    if (x.Left < y.Left && x.Right > y.Left)
                                    {
                                        x.Left = y.Left;
                                        dir_2 = 1;
                                    }
                                    if (x.Right > y.Right && x.Left > y.Left)
                                    {
                                        x.Left = y.Right - x.Width;
                                        dir_2 = -1;
                                    }
                                }
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


                //Tương tác với đồ vật "cave"
                if (x is PictureBox && (string)x.Tag == "cave")
                {
                    x.Visible = true;
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameTimer.Stop();
                        Program.AutoSave(score, "Level 2");
                        CutScene_2 newWindow = new CutScene_2();
                        newWindow.Show();
                        this.Hide();
                    }
                }

                //Người chơi va chạm với kẻ địch
                if (x is PictureBox && (string)x.Tag == "enemy")
                {
                    //Kẻ địch: Rắn
                    if (x.Name == "Snake_1")
                    {
                        snakeTime -= 1;
                        x.Top -= 3;
                        if (snakeTime < 0)
                        {
                            snakeTime = 110;
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

                //Người chơi va chạm với hint
                if (x is PictureBox && (string)x.Tag == "tutorialOn")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) == true)
                    {
                        HintOn(txtTutorial, speechBallon, true);
                        tutOn = 5;

                        if (x.Name == "checkTutorial_5")
                        {
                            txtTutorial.Text = "Cẩn thận ! Những tảng đá đang di chuyển phía trước rất trơn trượt, đừng để bị rơi xuống nhé con !";
                        }
                        if (x.Name == "checkTutorial_6")
                        {
                            txtTutorial.Text = "Con ơi ! Coi chừng mấy con rắn !!!";
                        }
                        if (x.Name == "checkTutorial_7")
                        {
                            txtTutorial.Text = "Mấy tảng đá phía trước có vẻ rất dễ rơi ! Con hãy cẩn thận nhé !";
                        }
                    }
                    if (tutOn < 0)
                    {
                        txtTutorial.Clear();
                        HintOn(txtTutorial, speechBallon, false);
                    }

                }
            }

            //Di chuyển qua trái
            if (goLeft == true & player.Left - (player.Width + 390) > 0)
            {
                player.Left -= playerSpeed;
            }
            //Di chuyển qua phải
            if (goRight == true & player.Left + (player.Width + 390) < this.ClientSize.Width)
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

        private void Level_1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(layer_1, b1, -110);
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
                    || x is PictureBox && (string)x.Tag == "platform_horizontal"
                    || x is PictureBox && (string)x.Tag == "platform_dropdown"
                    || x is PictureBox && (string)x.Tag == "limitBox"
                    || x is PictureBox && (string)x.Tag == "key"
                    || x is PictureBox && (string)x.Tag == "door"
                    || x is PictureBox && (string)x.Tag == "enemy"
                    || x is PictureBox && (string)x.Tag == "tutorialOn"
                    || x is PictureBox && (string)x.Tag == "corpse"
                    || x is PictureBox && (string)x.Tag == "cave"
                    || x is PictureBox && (string)x.Tag == "healthItem"
                    || x is PictureBox && (string)x.Tag == "powerItem"
                    || x is PictureBox && (string)x.Tag == "jumpItem")
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

        //Mở hint
        private void HintOn(TextBox txtTut, PictureBox spBallon, bool isOn)
        {
            txtTut.Visible = isOn;
            spBallon.Visible = isOn;

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
            sndBackgroundTheme.PlayLooping();
            Level_1_2 newWindow = new Level_1_2(this.score_);
            newWindow.Show();
            this.Hide();
        }
        private void ResetDuLieu()
        {
            playerJumpSpeed -= upJumpSpeedTemp;
            playerPower -= upPowerTemp;
            playerGobalHealth -= upHealthTemp;
        }

    }
}
