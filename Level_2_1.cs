using DeMenPhieuLuuKy.CutScene;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using static DeMenPhieuLuuKy.PlayerProfile;
using static DeMenPhieuLuuKy.Difficulty;

namespace DeMenPhieuLuuKy
{
    public partial class Level_2_1 : Form
    {

        private int smokeTime = 8, smokeCd;

        //Player
        int gravity = (int)(playerJumpSpeed+0.2f);
        int falling = 1;
        int force, score;
        //Punch
        int punchCount, punchSpeed = 15, punchDamage = playerPower + 20;
        bool grounded, jumping = false;

        //Enemy
        int movingEnemySpeed = 10, enemyHealth = chiCocGolbalHealth;

        //Platform di chuyển ngang
        int movingPlatSpeed = 5;

        private Random rnd = new Random();


        //Khai báo các biến background
        Image layer_1 = Properties.Resources.Jungle;
        int b1 = 0, b2 = 2000;

        //Khai báo các biến xử lí âm thanh
        SoundPlayer sndBackgroundTheme = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\runNowTheme.wav");
        SoundPlayer sndPlayerDie = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\player_die.wav");

        public Level_2_1(int score_)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.score = score_;
            sndBackgroundTheme.PlayLooping();
            

            //Lấy đường dẫn file âm thanh
            mediaCoin.URL = AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\smw_coin.wav";
            mediaCoin.Ctlcontrols.stop();
            mediaCoin.settings.volume = 100;

            mediaJump.URL = AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\smw_jump.wav";
            mediaJump.Ctlcontrols.stop();
            mediaJump.settings.volume = 100;

            mediaPunch.URL = AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\smw_punch.wav";
            mediaPunch.Ctlcontrols.stop();
            mediaPunch.settings.volume = 100;

            mediaGotHit.URL = AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\smw_gotHit.wav";
            mediaGotHit.Ctlcontrols.stop();
            mediaGotHit.settings.volume = 10;

            //Player
            punchCount = 0;

            //Thanh mau
            EnemyLife.Maximum = enemyHealth;
            enemyHealth -= Program.tempDamage / 2;
            Program.tempDamage = 0;
        }

        private void MainTimeEvents(object sender, EventArgs e)
        {
            smokeCd--;
            txtScore.Text = "Score: " + score; //Điểm số người chơi nhận được khi thu thập "coin"
            grounded = false;
            BackgroundMove();

            //Smoke
            if (smokeCd < 0)
            {
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && (string)x.Tag == "smoke") { ObjDestroy(x); }
                }
            }

            if (punchCount >= 0)
            {
                if (punchCount > 100) { punchCount = 100; }

                ultimateBar.Value = Convert.ToInt32(punchCount);
            }

            if (enemyHealth > 0)
            {
                EnemyLife.Value = Convert.ToInt32(enemyHealth);
            }
            else
            {
                EnemyLife.Value = 0;
                if ((ChimCoc.Left + ChimCoc.Width) > 0)
                {
                    ChimCoc.Left--;
                }
                if ((ChimCoc.Left + ChimCoc.Width) <= 0)
                {
                    GameTimer.Stop();
                    Program.AutoSave(score, "Level 3");
                    CutScene_3 newWindow = new CutScene_3();
                    newWindow.Show();
                    this.Hide();
                }
            }

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

            }


            //Các sự kiện 
            foreach (Control x in this.Controls)
            {
                //Các vấn đề gặp phải khi người chơi va chạm với platform
                if (x is PictureBox && (string)x.Tag == "platform")
                {
                    //Di chuyển platform qua trái liên tục
                    x.Left -= movingPlatSpeed;
                    if ((x.Left + x.Width) < 0)
                    {
                        x.Left = 640;
                        x.Top = rnd.Next(300, 500 - x.Height);
                    }

                    //Người chơi va chạm với platform
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
                                player.Image = Properties.Resources.DeMen_Run_Small;
                                jumping = false;
                            }
                        }
                        else
                        if (player.Left < x.Right && player.Top < x.Bottom && player.Bottom > x.Bottom
                            || player.Right > x.Left && player.Bottom > x.Top && player.Top < x.Top)
                        {
                            player.Top += 3; //x.Bottom
                            if (jumping == true)
                            {
                                player.Image = Properties.Resources.DeMen_Run_Small;
                                jumping = false;
                            }
                            grounded = false;
                        }
                        else
                        {

                            if (player.Right > x.Left && player.Left < x.Left && player.Bottom >= x.Top)
                            {
                                x.Left -= movingPlatSpeed;
                            }

                        }
                    }

                    x.BringToFront();
                }

                //Người chơi thực hiện punch
                if (x is PictureBox && (string)x.Tag == "player_punch")
                {
                    x.Left -= punchSpeed;
                    x.BringToFront();
                    x.BringToFront();
                    if (x.Left < 0 || (x.Left + x.Width) > 640)
                    {
                        ObjDestroy(x);
                    }
                }


                //Enemy chuồng chuồng
                if (x is PictureBox && (string)x.Tag == "chuongChuong")
                {
                    //Di chuyển chuồng chuồng qua trái liên tục
                    x.Left -= movingEnemySpeed;
                    if ((x.Left + x.Width) < 0)
                    {
                        x.Left = rnd.Next(640, 1000);
                        x.Top = rnd.Next(30, 150 - x.Height);
                    }

                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        sndPlayerDie.Play();
                        GameTimer.Stop();
                        MessageBox.Show("Bạn đã va phải kẻ địch ! " + Environment.NewLine + "Nhấp chọn OK để chơi lại");
                        RestartGame();
                    }
                }

                //Thu thập đồ vật "coin"
                if (x is PictureBox && (string)x.Tag == "coin")
                {
                    x.Left -= movingPlatSpeed;
                    if ((x.Left + x.Width) < -100)
                    {
                        x.Left = rnd.Next(640, 900);
                        x.Top = rnd.Next(200, 300 - x.Height);
                    }
                    if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        mediaCoin.Ctlcontrols.play();
                        score++;
                        punchCount += 20;
                        x.Left = rnd.Next(640, 800);
                        x.Top = rnd.Next(200, 300 - x.Height);
                    }

                }

                //Kẻ địch bị đánh trúng
                if (x is PictureBox && (string)x.Tag == "player_punch")
                {
                    if (Enemy.Bounds.IntersectsWith(x.Bounds))
                    {
                        Program.tempDamage += punchDamage;
                        mediaGotHit.Ctlcontrols.play();
                        createSmoke(x.Left, x.Top);
                        ObjDestroy(x);
                        enemyHealth -= punchDamage;
                    }
                }

            }


            //Người chơi thực hiện "nhảy"
            if (jumping == true)
            {
                player.Top -= force;
                force -= 1;
            }


        }

        //Cuộn background khi di chuyển
        private void BackgroundMove()
        {
            //Qua phải

            b1 -= 2;
            b2 -= 2;

            if (b1 < -2000)
            {
                b1 = 2000;
            }
            if (b2 < -2000)
            {
                b2 = 2000;
            }



            Invalidate();
        }

        private void Level_2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(layer_1, b1, -110);
            e.Graphics.DrawImage(layer_1, b2, -110);
        }

        private void This_Closing(object sender, FormClosingEventArgs e)
        {
            sndBackgroundTheme.Stop();
            Application.Exit();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false && grounded == true)
            {
                //mediaJump.Ctlcontrols.play();
                jumping = true;
                force = gravity;

                player.Image = Properties.Resources.DeMen_Jump_Small;

            }

            if (e.KeyCode == Keys.A && punchCount >= 100)
            {
                mediaPunch.Ctlcontrols.play();
                punchCount = 0;
                createPlayerPunch();
            }

            //Về màn hình chính
            if (e.KeyCode == Keys.Escape)
            {
                GameTimer.Stop();
                DialogResult result;

                result = MessageBox.Show("Bạn có muốn trở về màn hình chính ?\nChú ý: Mọi dữ liệu chưa lưu sẽ bị mất !", "CẢNH BÁO !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Program.tempDamage = 0;
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

        }

        //Xóa Control khỏi màn chơi
        private void ObjDestroy(Control x)
        {
            this.Controls.Remove(x);
            x.Dispose();
        }

        //Tạo punch cho player
        private void createPlayerPunch()
        {
            PictureBox punch = new PictureBox();
            Image img = Properties.Resources.stone;
            punch.BackColor = System.Drawing.Color.Transparent;
            punch.Image = img;
            punch.Tag = "player_punch";
            punch.Height = img.Height;
            punch.Width = img.Width;
            punch.Left = player.Left;
            punch.Top = player.Top + 10;

            this.Controls.Add(punch);

        }

        //Tạo làn khói
        private void createSmoke(int x, int y)
        {
            Image smokeImg = Properties.Resources.Smoke_Small;
            PictureBox smoke = new PictureBox();
            smoke.BackColor = System.Drawing.Color.Transparent;
            smoke.Image = smokeImg;
            smoke.Tag = "smoke";
            smoke.Height = smokeImg.Height;
            smoke.Width = smokeImg.Width;
            smoke.Left = x;
            smoke.Top = y;
            this.Controls.Add(smoke);
            smokeCd = smokeTime;
            smoke.BringToFront();
        }

        private void RestartGame()
        {
            Level_2_1 newWindow = new Level_2_1(score / 2);
            newWindow.Show();
            this.Hide();
        }

    }
}
