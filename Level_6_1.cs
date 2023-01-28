using DeMenPhieuLuuKy.CutScene;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using static DeMenPhieuLuuKy.PlayerProfile;
using static DeMenPhieuLuuKy.Difficulty;

namespace DeMenPhieuLuuKy
{
    public partial class Level_6_1 : Form
    {

        Random rnd = new Random();
        private int smokeTime = 8, smokeCd, smokeEndCd = 150;

        //Khai báo các biến liên quan đến kẻ địch
        int playerHealth = playerGobalHealth, enemyHealth = nhenGolbalHealth;

        private int enemySpeed = nhenGolbalSpeed;

        private bool enemyCanAttack = true;
        private List<string> enemyAttacks = new List<string> { "enemy_shoot_web", "enemy_shoot_rock" };
        private List<string> enemyMovements = new List<string> { "enemy_goLeft", "enemy_goRight" };
        private int i, enemyMoveCount, enemyShootCount, enemyShootSpeed = nhenGolbalShotSpeed, enemy_WebDamage = nhenGolbalWebDamage, enemy_RockDamage = nhenGolbalRockDamage;
        private bool enemy_goLeft, enemy_goRight;
        private int enemyDir = -1;


        //Khai báo các biến xử lí di chuyển của nhân vật

        private int gravity = (int)playerJumpSpeed;
        private int falling = 1;
        private int force;


        private int playerSpeed = 5;
        private int playerDir = 1; // Dương là bên phải, âm là bên trái
        private bool goLeft, goRight, grounded;
        private bool jumping = false;
        private bool holdL = false, holdR = false;
        //Throw
        int rockCount, throwCount, throwTime = 10, throwSpeed = 16, throwDamage = playerPower;
  

        private void This_Closing(object sender, FormClosingEventArgs e)
        {
            sndBackgroundTheme.Stop();
            Application.Exit();
        }

        

        //Khai báo các biến xử lí âm thanh
        SoundPlayer sndBackgroundTheme = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\runNowTheme.wav");
        SoundPlayer sndPlayerDie = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\player_die.wav");

        public Level_6_1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            sndBackgroundTheme.PlayLooping();

            mediaJump.URL = AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\smw_jump.wav";
            mediaJump.Ctlcontrols.stop();
            mediaJump.settings.volume = 100;

            mediaPunch.URL = AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\smw_punch.wav";
            mediaPunch.Ctlcontrols.stop();
            mediaPunch.settings.volume = 100;

            mediaEnemy.URL = AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\smw_stomp.wav";
            mediaEnemy.Ctlcontrols.stop();
            mediaEnemy.settings.volume = 100;

            mediaGotHit.URL = AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\smw_gotHit.wav";
            mediaGotHit.Ctlcontrols.stop();
            mediaGotHit.settings.volume = 10;


            //Player
            throwCount = throwTime;
            rockCount = 0;

            //Thanh mau
            PlayerLife.Maximum = playerHealth;
            EnemyLife.Maximum = enemyHealth;
        }

        private void MainTimeEvents(object sender, EventArgs e)
        {
            GC.Collect();
            grounded = false;
            smokeCd--;
            txtRockCount.Text = "Số đá: " + rockCount;
            txtRockCount.BringToFront();

            //Smoke
            if (smokeCd < 0)
            {
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && (string)x.Tag == "smoke") { ObjDestroy(x); }
                }
            }

            //Thanh máu của player và enemy
            if (playerHealth >= 0)
            {
                PlayerLife.Value = Convert.ToInt32(playerHealth);
            }
            else
            {
                PlayerLife.Value = 0;
                sndPlayerDie.Play();
                GameTimer.Stop();
                MessageBox.Show("Bạn đã bị đánh bại ! " + Environment.NewLine + "Nhấp chọn OK để chơi lại");
                RestartGame();
            }


            if (enemyHealth > 0)
            {
                EnemyLife.Value = Convert.ToInt32(enemyHealth);
            }
            else
            {
                EnemyLife.Value = 0;
                enemyCanAttack = false;
                if (smokeEndCd > 140)
                {
                    createBigSmoke(Enemy.Left, Enemy.Top);
                    ObjDestroy(Enemy);
                }

                smokeEndCd--;
                if (smokeEndCd < 0)
                {
                    GameTimer.Stop();
                    MessageBox.Show("Chúc mừng bạn đã hoàn thành game ! " + Environment.NewLine + "Nhấp chọn OK để trở về màn hình chính");
                    CutScene_6 newWindow = new CutScene_6();
                    newWindow.Show();
                    this.Hide();
                }

            }

            // Trọng lực hút người chơi khi không nhấn nhảy
            if (jumping == false && grounded == false)
            {
                player.Top += falling;
                falling += 1;
            }
            //Player
            foreach (Control x in this.Controls)
            {
                //Các vấn đề gặp phải khi người chơi va chạm với platform
                if (x is PictureBox && (string)x.Tag == "platform")
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

                

                //Người chơi bị đánh trúng
                if (x is PictureBox && (string)x.Tag == "enemy_web")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        mediaGotHit.Ctlcontrols.play();
                        createSmoke(x.Left, x.Top);
                        ObjDestroy(x);
                        playerHealth -= enemy_WebDamage;
                    }
                }
                if (x is PictureBox && (string)x.Tag == "enemy_rock")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        mediaGotHit.Ctlcontrols.play();
                        createSmoke(x.Left, x.Top);
                        ObjDestroy(x);
                        playerHealth -= enemy_RockDamage;
                    }
                }

                //Người chơi nhặt đá
                if (x is PictureBox && (string)x.Tag == "rock_item")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (rockCount < 3)
                        {
                            rockCount++;
                            ObjDestroy(x);
                        }
                    }
                }

                //Người chơi thực hiện throw
                if (x is PictureBox && (string)x.Tag == "player_rock")
                {
                    x.Top -= throwSpeed;
                    if ((x.Top + x.Width) < 0)
                    {
                        ObjDestroy(x);
                    }

                }


                //Kẻ địch thực hiện shoot
                if (x is PictureBox && (string)x.Tag == "enemy_web")
                {
                    x.Top += enemyShootSpeed;
                    if (x.Top > 520)
                    {
                        ObjDestroy(x);
                    }
                }
                if (x is PictureBox && (string)x.Tag == "enemy_rock")
                {
                    x.Top += enemyShootSpeed;
                    if ((x.Top + x.Width) > 441)
                    {
                        createARockItem(x.Left);
                        ObjDestroy(x);
                    }
                }

            }

            //Di chuyển qua trái
            if (goLeft == true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }
            //Di chuyển qua phải
            if (goRight == true && (player.Left + player.Width) < this.ClientSize.Width)
            {
                player.Left += playerSpeed;
            }

            //Người chơi thực hiện "nhảy"
            if (jumping == true)
            {
                player.Top -= force;
                force -= 2;
            }


        }
        //Hành động của Nhện
        private void SpiderTimer_Tick(object sender, EventArgs e)
        {
            //Nhện lớn
            if (!enemyCanAttack) return;
            enemyShootCount--;
            enemyMoveCount--;
            //Random các hành động của enemy
            i = rnd.Next(0, enemyAttacks.Count);

            //Enemy Attack
            switch (enemyAttacks[i].ToString())
            {
                case "enemy_shoot_web":
                    if (enemyShootCount < 0)
                    {
                        mediaEnemy.Ctlcontrols.play();
                        createEnemyWeb();
                        enemyShootCount = rnd.Next(10, 15);
                    }
                    break;
                case "enemy_shoot_rock":
                    if (enemyShootCount < 0)
                    {
                        mediaEnemy.Ctlcontrols.play();
                        createEnemyRock();
                        enemyShootCount = rnd.Next(50, 60);
                    }
                    break;
            }

            i = rnd.Next(0, enemyMovements.Count);
            switch (enemyMovements[i].ToString())
            {
                case "enemy_goLeft":
                    if (enemyMoveCount < 0 && enemyDir < 0)
                    {
                        enemy_goLeft = true;
                        enemy_goRight = false;
                        enemyMoveCount = rnd.Next(10, 20);
                    }
                    break;
                case "enemy_goRight":
                    if (enemyMoveCount < 0 && enemyDir > 0)
                    {
                        enemy_goRight = true;
                        enemy_goLeft = false;
                        enemyMoveCount = rnd.Next(10, 20);
                    }
                    break;

            }
            //Kẻ địch
            foreach (Control x in this.Controls)
            {

                //Kẻ địch bị đánh trúng
                if (x is PictureBox && (string)x.Tag == "player_rock")
                {
                    if (Enemy.Bounds.IntersectsWith(x.Bounds))
                    {
                        mediaGotHit.Ctlcontrols.play();
                        createSmoke(x.Left, x.Top);
                        ObjDestroy(x);
                        enemyHealth -= throwDamage;
                    }
                }

            }

            //Kẻ địch di chuyển qua trái
            if (enemy_goLeft == true && enemy_goRight == false)
            {
                Enemy.Left -= enemySpeed;
                if (Enemy.Left < 0)
                {
                    enemyDir = 1;
                    enemy_goLeft = false;
                    Enemy.Left = 20;
                }
            }
            //Kẻ địch di chuyển qua phải
            if (enemy_goRight == true && enemy_goLeft == false)
            {
                Enemy.Left += enemySpeed;
                if ((Enemy.Left + Enemy.Width) > 640)
                {
                    enemyDir = -1;
                    enemy_goRight = false;
                    Enemy.Left = 600 - Enemy.Width;
                }
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
            if (e.KeyCode == Keys.A && throwCount == throwTime && rockCount > 0)
            {
                rockCount--;
                mediaPunch.Ctlcontrols.play();
                createPlayerRock();
            }

            //Về màn hình chính
            if (e.KeyCode == Keys.Escape)
            {
                GameTimer.Stop();
                SpiderTimer.Stop();
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
                else { GameTimer.Start(); SpiderTimer.Start(); }
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
        //Xóa Control khỏi màn chơi
        private void ObjDestroy(Control x)
        {
            this.Controls.Remove(x);
            x.Dispose();
            GC.Collect();
        }

        private void RestartGame()
        {
            Level_6_1 newWindow = new Level_6_1();
            newWindow.Show();
            this.Hide();
        }

        //Tạo rock cho player
        private void createPlayerRock()
        {
            PictureBox punch = new PictureBox();
            Image img = Properties.Resources.Rock;
            punch.BackColor = System.Drawing.Color.Transparent;
            punch.Image = img;
            punch.Tag = "player_rock";
            punch.Height = img.Height;
            punch.Width = img.Width;
            punch.Left = player.Left + (player.Width / 2);
            punch.Top = player.Top;

            this.Controls.Add(punch);
        }

        //Tạo cục đá để nhặt
        private void createARockItem(int x)
        {
            PictureBox rockItem = new PictureBox();
            Image img = Properties.Resources.Rock;
            rockItem.BackColor = System.Drawing.Color.Transparent;
            rockItem.Image = img;
            rockItem.Tag = "rock_item";
            rockItem.Height = img.Height;
            rockItem.Width = img.Width;
            rockItem.Left = x;
            rockItem.Top = 441 - img.Height;

            this.Controls.Add(rockItem);
        }

        //Tạo web cho enemy
        private void createEnemyWeb()
        {
            PictureBox punch = new PictureBox();
            Image img = Properties.Resources.Web;
            punch.BackColor = System.Drawing.Color.Transparent;
            punch.Image = img;
            punch.Tag = "enemy_web";
            punch.Height = img.Height;
            punch.Width = img.Width;
            punch.Left = rnd.Next(0, 640 - img.Width);
            punch.Top = Enemy.Top;

            this.Controls.Add(punch);

        }

        //Tạo rock cho enemy
        private void createEnemyRock()
        {
            PictureBox punch = new PictureBox();
            Image img = Properties.Resources.Nhen_Rock;
            punch.BackColor = System.Drawing.Color.Transparent;
            punch.Image = img;
            punch.Tag = "enemy_rock";
            punch.Height = img.Height;
            punch.Width = img.Width;
            punch.Left = rnd.Next(0, 640 - img.Width);
            punch.Top = Enemy.Top;

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

        private void createBigSmoke(int x, int y)
        {
            Image smokeImg = Properties.Resources.Smoke;
            PictureBox smoke = new PictureBox();
            smoke.BackColor = System.Drawing.Color.Transparent;
            smoke.Image = smokeImg;
            smoke.Tag = "";
            smoke.Height = smokeImg.Height;
            smoke.Width = smokeImg.Width;
            smoke.Left = x;
            smoke.Top = y - 20;
            this.Controls.Add(smoke);
            smoke.BringToFront();
        }

    }
}
