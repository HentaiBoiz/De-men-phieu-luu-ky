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
    public partial class Level_4_1 : Form
    {

        private Random rnd = new Random();
        private int smokeTime = 8, smokeCd, smokeEndCd = 150;

        //Khai báo các biến liên quan đến kẻ địch
        int playerHealth = playerGobalHealth, enemyHealth = deNhaThinhGolbalHealth;

        private int enemySpeed = deNhaThinhGolbalSpeed, enemy_falling = 1;
        private bool enemy_grounded, enemy_jumping = false;
        private bool enemy_goLeft, enemy_goRight;
        private int enemy_force, enemyDir = -1;

        private bool enemyAnim = false;

        private List<string> enemyAttacks = new List<string> { "enemy_punch", "enemy_super_punch" };
        private List<string> enemyMovements = new List<string> { "enemy_goLeft", "enemy_goRight", "enemy_jump" };
        private int i, enemyMoveCount, enemyAttackCount, enemyPunchSpeed = deNhaThinhGolbalPunchSpeed, enemy_punchDamage = deNhaThinhGolbalPunchDamage, enemy_superPunchDamage = deNhaThinhGolbalSuperPunchDamage;


        //Khai báo các biến xử lí di chuyển của nhân vật

        private int gravity = (int)playerJumpSpeed;
        private int falling = 1;
        private int force;

        private int playerSpeed = 5;
        private int playerDir = 1; // Dương là bên phải, âm là bên trái
        private bool goLeft, goRight, grounded;
        private bool jumping = false;
        private bool holdL = false, holdR = false;
        //Punch
        int punchCount, punchTime = 15, punchSpeed = 15, punchDamage = playerPower;
        int superPunchCount, superPunchTime = 100, superPunchDamage = playerPower + 50;

        //Khai báo các biến xử lí âm thanh
        SoundPlayer sndBackgroundTheme = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\runNowTheme.wav");
        SoundPlayer sndPlayerDie = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\player_die.wav");

        private void This_Closing(object sender, FormClosingEventArgs e)
        {
            sndBackgroundTheme.Stop();
            Application.Exit();
        }


        public Level_4_1()
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
            punchCount = punchTime;
            superPunchCount = 0;

            //Thanh mau
            PlayerLife.Maximum = playerHealth;
            EnemyLife.Maximum = enemyHealth;
        }

        private void MainTimeEvents(object sender, EventArgs e)
        {
            grounded = false;
            smokeCd--;

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
                EnemyMovement.Stop();
                MessageBox.Show("Bạn đã bị đánh bại ! " + Environment.NewLine + "Nhấp chọn OK để chơi lại");
                RestartGame();
            }

            if (superPunchCount >= 0)
            {
                if (superPunchCount > 100) { superPunchCount = 100; }

                ultimateBar.Value = Convert.ToInt32(superPunchCount);
            }

            if (enemyHealth > 0)
            {
                EnemyLife.Value = Convert.ToInt32(enemyHealth);
            }
            else
            {
                PlayerLife.Value = 0;
                if (smokeEndCd > 140)
                {
                    createBigSmoke(Enemy.Left, Enemy.Top);
                    ObjDestroy(Enemy);
                }
                EnemyMovement.Stop();
                smokeEndCd--;
                if (smokeEndCd < 0)
                {
                    GameTimer.Stop();
                    Program.AutoSave(30, "Level 5");
                    CutScene_4 newWindow = new CutScene_4();
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
                if (x is PictureBox && (string)x.Tag == "enemy_punch"
                    || x is PictureBox && (string)x.Tag == "enemy_punch_l")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        mediaGotHit.Ctlcontrols.play();
                        createSmoke(x.Left, x.Top);
                        ObjDestroy(x);
                        playerHealth -= enemy_punchDamage;
                    }
                }
                if (x is PictureBox && (string)x.Tag == "enemy_super_punch"
                    || x is PictureBox && (string)x.Tag == "enemy_super_punch_l")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        mediaGotHit.Ctlcontrols.play();
                        createSmoke(x.Left, x.Top);
                        ObjDestroy(x);
                        playerHealth -= enemy_superPunchDamage;
                    }
                }

                //Va chạm với enemy
                if (player.Bounds.IntersectsWith(Enemy.Bounds))
                {
                    mediaGotHit.Ctlcontrols.play();
                    playerHealth--;
                }

                //Người chơi thực hiện punch
                if (x is PictureBox && (string)x.Tag == "player_punch"
                    || x is PictureBox && (string)x.Tag == "player_super_punch")
                {
                    x.Left += punchSpeed;
                    if ((string)x.Tag == "player_super_punch")
                    {
                        if (x.Left < 0 || (x.Left + x.Width) > 640)
                        {
                            ObjDestroy(x);
                        }
                    }
                    else if ((string)x.Tag == "player_punch")
                    {
                        punchCount--;
                        if (punchCount < 0)
                        {
                            ObjDestroy(x);
                            punchCount = punchTime;
                        }
                    }
                }
                if (x is PictureBox && (string)x.Tag == "player_punch_l"
                    || x is PictureBox && (string)x.Tag == "player_super_punch_l")
                {
                    x.Left -= punchSpeed;
                    if ((string)x.Tag == "player_super_punch_l")
                    {
                        if (x.Left < 0 || (x.Left + x.Width) > 640)
                        {
                            ObjDestroy(x);
                        }
                    }
                    else if ((string)x.Tag == "player_punch_l")
                    {
                        punchCount--;
                        if (punchCount < 0)
                        {
                            ObjDestroy(x);
                            punchCount = punchTime;
                        }
                    }
                }


                //Kẻ địch thực hiện punch
                if (x is PictureBox && (string)x.Tag == "enemy_punch"
                    || x is PictureBox && (string)x.Tag == "enemy_super_punch")
                {
                    x.Left += enemyPunchSpeed;
                    if (x.Left < 0 || (x.Left + x.Width) > 640)
                    {
                        ObjDestroy(x);
                    }
                }
                if (x is PictureBox && (string)x.Tag == "enemy_punch_l"
                    || x is PictureBox && (string)x.Tag == "enemy_super_punch_l")
                {
                    x.Left -= enemyPunchSpeed;
                    if (x.Left < 0 || (x.Left + x.Width) > 640)
                    {
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
                force -= 1;
            }

            //Kẻ địch
            enemy_grounded = false;

            //Kẻ địch thực hiện "nhảy"
            if (enemy_jumping == true)
            {
                Enemy.Top -= enemy_force;
                enemy_force -= 1;
            }

            // Trọng lực hút kẻ địch khi không nhảy
            if (enemy_jumping == false && enemy_grounded == false)
            {
                Enemy.Top += enemy_falling;
                enemy_falling += 1;
            }

            foreach (Control x in this.Controls)
            {

                //Các vấn đề gặp phải khi kẻ địch va chạm với platform
                if (x is PictureBox && (string)x.Tag == "platform")
                {
                    if (Enemy.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (Enemy.Left < x.Right && Enemy.Bottom > x.Top && Enemy.Top < x.Top - (Enemy.Height * 60 / 100)
                            || Enemy.Right > x.Left && Enemy.Bottom > x.Top && Enemy.Top < x.Top - (Enemy.Height * 60 / 100))
                        {
                            Enemy.Top = x.Top - Enemy.Height;
                            enemy_grounded = true;
                            enemy_falling = 1;

                            if (enemy_jumping == true)
                            {
                                enemy_jumping = false;
                                if (Enemy.Left > player.Left)
                                {
                                    Enemy.Image = Properties.Resources.DeMen_Enemy_Idle_L;
                                }
                                if (Enemy.Left < player.Left)
                                {
                                    Enemy.Image = Properties.Resources.DeMen_Enemy_Idle;
                                }
                            }
                        }
                        else
                        if (Enemy.Left < x.Right && Enemy.Top < x.Bottom && Enemy.Bottom > x.Bottom
                            || Enemy.Right > x.Left && Enemy.Bottom > x.Top && Enemy.Top < x.Top)
                        {
                            Enemy.Top += 3;
                            if (enemy_jumping == true)
                            {
                                enemy_jumping = false;
                                if (Enemy.Left > player.Left)
                                {
                                    Enemy.Image = Properties.Resources.DeMen_Enemy_Idle_L;
                                }
                                if (Enemy.Left < player.Left)
                                {
                                    Enemy.Image = Properties.Resources.DeMen_Enemy_Idle;
                                }
                            }
                            enemy_grounded = false;
                        }

                    }

                    x.BringToFront();
                }

                //Kẻ địch bị đánh trúng
                if (x is PictureBox && (string)x.Tag == "player_punch"
                    || x is PictureBox && (string)x.Tag == "player_punch_l")
                {
                    if (Enemy.Bounds.IntersectsWith(x.Bounds))
                    {
                        mediaGotHit.Ctlcontrols.play();
                        createSmoke(x.Left, x.Top);
                        superPunchCount += 20;
                        punchCount = punchTime;
                        ObjDestroy(x);
                        enemyHealth -= punchDamage;
                    }
                }
                if (x is PictureBox && (string)x.Tag == "player_super_punch"
                    || x is PictureBox && (string)x.Tag == "player_super_punch_l")
                {

                    if (Enemy.Bounds.IntersectsWith(x.Bounds))
                    {
                        mediaGotHit.Ctlcontrols.play();
                        createSmoke(x.Left, x.Top);
                        ObjDestroy(x);
                        enemyHealth -= superPunchDamage;
                    }
                }
            }

            //Kẻ địch di chuyển qua trái
            if (enemy_goLeft == true && enemy_goRight == false)
            {
                Enemy.Left -= enemySpeed;
                if (!enemyAnim)
                {
                    Enemy.Image = Properties.Resources.DeMen_Enemy_Run_L;
                    enemyAnim = true;
                }
                if (Enemy.Left < 0)
                {
                    enemyDir = 1;
                    enemy_goLeft = false;
                    Enemy.Left = 30;
                    enemyAnim = false;
                    Enemy.Image = Properties.Resources.DeMen_Enemy_Idle;
                }
            }
            //Kẻ địch di chuyển qua phải
            if (enemy_goRight == true && enemy_goLeft == false)
            {
                Enemy.Left += enemySpeed;
                if (!enemyAnim)
                {
                    Enemy.Image = Properties.Resources.DeMen_Enemy_Run;
                    enemyAnim = true;
                }
                if ((Enemy.Left + Enemy.Width) > 640)
                {
                    enemyDir = -1;
                    enemy_goRight = false;
                    Enemy.Left = 600 - Enemy.Width;
                    enemyAnim = false;
                    Enemy.Image = Properties.Resources.DeMen_Enemy_Idle_L;
                }
            }


        }

        //Các hành động của kẻ địch
        private void EnemyEvents(object sender, EventArgs e)
        {
            enemyAttackCount--;
            enemyMoveCount--;
            //Random các hành động của enemy
            i = rnd.Next(0, enemyAttacks.Count);

            //Enemy Attack
            switch (enemyAttacks[i].ToString())
            {
                case "enemy_punch":
                    if (enemyAttackCount < 0)
                    {
                        mediaEnemy.Ctlcontrols.play();
                        createEnemyPunch();
                        enemyAttackCount = rnd.Next(40, 70);
                    }
                    break;
                case "enemy_super_punch":
                    if (enemyAttackCount < 0)
                    {
                        mediaEnemy.Ctlcontrols.play();
                        createEnemySuperPunch();
                        enemyAttackCount = rnd.Next(50, 80);
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
                        enemyMoveCount = rnd.Next(60, 80);
                    }
                    break;
                case "enemy_goRight":
                    if (enemyMoveCount < 0 && enemyDir > 0)
                    {
                        enemy_goRight = true;
                        enemy_goLeft = false;
                        enemyMoveCount = rnd.Next(60, 80);
                    }
                    break;
                case "enemy_jump":
                    if (enemyMoveCount < 0)
                    {
                        enemy_jumping = true;
                        enemy_force = gravity;
                        if (enemyDir < 0)
                        {
                            Enemy.Image = Properties.Resources.DeMen_Enemy_Jump_L;
                        }
                        if (enemyDir > 0)
                        {
                            Enemy.Image = Properties.Resources.DeMen_Enemy_Jump;
                        }
                        enemyMoveCount = rnd.Next(60, 80);
                    }
                    break;
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
            if (e.KeyCode == Keys.A && punchCount == punchTime)
            {
                mediaPunch.Ctlcontrols.play();
                createPlayerPunch();
            }
            if (e.KeyCode == Keys.D && superPunchCount == superPunchTime)
            {
                mediaPunch.Ctlcontrols.play();
                superPunchCount = 0;
                createPlayerSuperPunch();
            }

            //Về màn hình chính
            if (e.KeyCode == Keys.Escape)
            {
                GameTimer.Stop();
                EnemyMovement.Stop();
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
                else { GameTimer.Start(); EnemyMovement.Start(); }
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
        }

        private void RestartGame()
        {
            Level_4_1 newWindow = new Level_4_1();
            newWindow.Show();
            this.Hide();
        }

        //Tạo punch cho player
        private void createPlayerPunch()
        {
            PictureBox punch = new PictureBox();
            if (playerDir > 0)
            {
                Image img = Properties.Resources.DeMen_Punch;
                punch.BackColor = System.Drawing.Color.Transparent;
                punch.Image = img;
                punch.Tag = "player_punch";
                punch.Height = img.Height;
                punch.Width = img.Width;
                punch.Left = player.Left;
                punch.Top = player.Top + 25;

                this.Controls.Add(punch);

            }
            if (playerDir < 0)
            {
                Image img = Properties.Resources.DeMen_Punch_L;
                punch.BackColor = System.Drawing.Color.Transparent;
                punch.Image = img;
                punch.Tag = "player_punch_l";
                punch.Height = img.Height;
                punch.Width = img.Width;
                punch.Left = player.Left;
                punch.Top = player.Top + 25;

                this.Controls.Add(punch);

            }
        }

        //Tạo super punch cho player
        private void createPlayerSuperPunch()
        {
            PictureBox punch = new PictureBox();
            if (playerDir > 0)
            {
                Image img = Properties.Resources.DeMen_Super_Punch;
                punch.BackColor = System.Drawing.Color.Transparent;
                punch.Image = img;
                punch.Tag = "player_super_punch";
                punch.Height = img.Height;
                punch.Width = img.Width;
                punch.Left = player.Left;
                punch.Top = player.Top;

                this.Controls.Add(punch);

            }
            if (playerDir < 0)
            {
                Image img = Properties.Resources.DeMen_Super_Punch_L;
                punch.BackColor = System.Drawing.Color.Transparent;
                punch.Image = img;
                punch.Tag = "player_super_punch_l";
                punch.Height = img.Height;
                punch.Width = img.Width;
                punch.Left = player.Left;
                punch.Top = player.Top;

                this.Controls.Add(punch);

            }
        }

        //Tạo punch cho enemy
        private void createEnemyPunch()
        {
            PictureBox punch = new PictureBox();
            if (Enemy.Left < player.Left)
            {
                Image img = Properties.Resources.DeMen_Enemy_Punch;
                punch.BackColor = System.Drawing.Color.Transparent;
                punch.Image = img;
                punch.Tag = "enemy_punch";
                punch.Height = img.Height;
                punch.Width = img.Width;
                punch.Left = Enemy.Left;
                punch.Top = rnd.Next(Enemy.Top, Enemy.Bottom - 20);

                this.Controls.Add(punch);

            }
            if ((Enemy.Left + Enemy.Width) > (player.Left + player.Width))
            {
                Image img = Properties.Resources.DeMen_Enemy_Punch_L;
                punch.BackColor = System.Drawing.Color.Transparent;
                punch.Image = img;
                punch.Tag = "enemy_punch_l";
                punch.Height = img.Height;
                punch.Width = img.Width;
                punch.Left = Enemy.Left;
                punch.Top = rnd.Next(Enemy.Top, Enemy.Bottom - 20);

                this.Controls.Add(punch);

            }
        }

        //Tạo super punch cho enemy
        private void createEnemySuperPunch()
        {
            PictureBox punch = new PictureBox();
            if (Enemy.Left < player.Left)
            {
                Image img = Properties.Resources.DeMen_Enemy_Super_Punch;
                punch.BackColor = System.Drawing.Color.Transparent;
                punch.Image = img;
                punch.Tag = "enemy_super_punch";
                punch.Height = img.Height;
                punch.Width = img.Width;
                punch.Left = Enemy.Left;
                punch.Top = rnd.Next(Enemy.Top, Enemy.Bottom - 30);

                this.Controls.Add(punch);

            }
            if ((Enemy.Left + Enemy.Width) > (player.Left + player.Width))
            {
                Image img = Properties.Resources.DeMen_Enemy_Super_Punch_L;
                punch.BackColor = System.Drawing.Color.Transparent;
                punch.Image = img;
                punch.Tag = "enemy_super_punch_l";
                punch.Height = img.Height;
                punch.Width = img.Width;
                punch.Left = Enemy.Left;
                punch.Top = rnd.Next(Enemy.Top, Enemy.Bottom - 30);

                this.Controls.Add(punch);

            }
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
