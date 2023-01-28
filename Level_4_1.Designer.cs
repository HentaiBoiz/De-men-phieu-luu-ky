namespace DeMenPhieuLuuKy
{
    partial class Level_4_1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level_4_1));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.mediaJump = new AxWMPLib.AxWindowsMediaPlayer();
            this.PlayerLife = new System.Windows.Forms.ProgressBar();
            this.EnemyLife = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ultimateBar = new System.Windows.Forms.ProgressBar();
            this.EnemyMovement = new System.Windows.Forms.Timer(this.components);
            this.mediaPunch = new AxWMPLib.AxWindowsMediaPlayer();
            this.mediaEnemy = new AxWMPLib.AxWindowsMediaPlayer();
            this.mediaGotHit = new AxWMPLib.AxWindowsMediaPlayer();
            this.Platform = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mediaJump)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPunch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaGotHit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimeEvents);
            // 
            // mediaJump
            // 
            this.mediaJump.Enabled = true;
            this.mediaJump.Location = new System.Drawing.Point(615, 23);
            this.mediaJump.Name = "mediaJump";
            this.mediaJump.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaJump.OcxState")));
            this.mediaJump.Size = new System.Drawing.Size(75, 54);
            this.mediaJump.TabIndex = 111;
            this.mediaJump.TabStop = false;
            this.mediaJump.Visible = false;
            // 
            // PlayerLife
            // 
            this.PlayerLife.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PlayerLife.Location = new System.Drawing.Point(33, 38);
            this.PlayerLife.Name = "PlayerLife";
            this.PlayerLife.Size = new System.Drawing.Size(149, 23);
            this.PlayerLife.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PlayerLife.TabIndex = 112;
            // 
            // EnemyLife
            // 
            this.EnemyLife.ForeColor = System.Drawing.Color.OrangeRed;
            this.EnemyLife.Location = new System.Drawing.Point(329, 38);
            this.EnemyLife.Maximum = 1400;
            this.EnemyLife.Name = "EnemyLife";
            this.EnemyLife.Size = new System.Drawing.Size(271, 23);
            this.EnemyLife.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.EnemyLife.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 113;
            this.label1.Text = "Dế Mèn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(430, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 113;
            this.label2.Text = "Dế nhà Thịnh";
            // 
            // ultimateBar
            // 
            this.ultimateBar.ForeColor = System.Drawing.Color.Gold;
            this.ultimateBar.Location = new System.Drawing.Point(33, 67);
            this.ultimateBar.Name = "ultimateBar";
            this.ultimateBar.Size = new System.Drawing.Size(94, 10);
            this.ultimateBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ultimateBar.TabIndex = 112;
            // 
            // EnemyMovement
            // 
            this.EnemyMovement.Enabled = true;
            this.EnemyMovement.Interval = 20;
            this.EnemyMovement.Tick += new System.EventHandler(this.EnemyEvents);
            // 
            // mediaPunch
            // 
            this.mediaPunch.Enabled = true;
            this.mediaPunch.Location = new System.Drawing.Point(615, 83);
            this.mediaPunch.Name = "mediaPunch";
            this.mediaPunch.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPunch.OcxState")));
            this.mediaPunch.Size = new System.Drawing.Size(75, 54);
            this.mediaPunch.TabIndex = 111;
            this.mediaPunch.TabStop = false;
            this.mediaPunch.Visible = false;
            // 
            // mediaEnemy
            // 
            this.mediaEnemy.Enabled = true;
            this.mediaEnemy.Location = new System.Drawing.Point(534, 83);
            this.mediaEnemy.Name = "mediaEnemy";
            this.mediaEnemy.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaEnemy.OcxState")));
            this.mediaEnemy.Size = new System.Drawing.Size(75, 54);
            this.mediaEnemy.TabIndex = 111;
            this.mediaEnemy.TabStop = false;
            this.mediaEnemy.Visible = false;
            // 
            // mediaGotHit
            // 
            this.mediaGotHit.Enabled = true;
            this.mediaGotHit.Location = new System.Drawing.Point(453, 83);
            this.mediaGotHit.Name = "mediaGotHit";
            this.mediaGotHit.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaGotHit.OcxState")));
            this.mediaGotHit.Size = new System.Drawing.Size(75, 54);
            this.mediaGotHit.TabIndex = 111;
            this.mediaGotHit.TabStop = false;
            this.mediaGotHit.Visible = false;
            // 
            // Platform
            // 
            this.Platform.BackColor = System.Drawing.Color.Transparent;
            this.Platform.BackgroundImage = global::DeMenPhieuLuuKy.Properties.Resources.Wood;
            this.Platform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Platform.Location = new System.Drawing.Point(-9, 406);
            this.Platform.Name = "Platform";
            this.Platform.Size = new System.Drawing.Size(636, 155);
            this.Platform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Platform.TabIndex = 110;
            this.Platform.TabStop = false;
            this.Platform.Tag = "platform";
            // 
            // Enemy
            // 
            this.Enemy.BackColor = System.Drawing.Color.Transparent;
            this.Enemy.Image = global::DeMenPhieuLuuKy.Properties.Resources.DeMen_Enemy_Idle_L;
            this.Enemy.Location = new System.Drawing.Point(434, 300);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(53, 100);
            this.Enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Enemy.TabIndex = 98;
            this.Enemy.TabStop = false;
            this.Enemy.Tag = "enemy";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::DeMenPhieuLuuKy.Properties.Resources.DeMen_Idle_Small;
            this.player.Location = new System.Drawing.Point(133, 335);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(33, 65);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 98;
            this.player.TabStop = false;
            this.player.Tag = "";
            // 
            // Level_4_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeMenPhieuLuuKy.Properties.Resources.Kids;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 481);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnemyLife);
            this.Controls.Add(this.ultimateBar);
            this.Controls.Add(this.PlayerLife);
            this.Controls.Add(this.Platform);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.player);
            this.Controls.Add(this.mediaGotHit);
            this.Controls.Add(this.mediaEnemy);
            this.Controls.Add(this.mediaPunch);
            this.Controls.Add(this.mediaJump);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Level_4_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level_4_1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.This_Closing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.mediaJump)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPunch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaGotHit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox Platform;
        private System.Windows.Forms.Timer GameTimer;
        private AxWMPLib.AxWindowsMediaPlayer mediaJump;
        private System.Windows.Forms.ProgressBar PlayerLife;
        private System.Windows.Forms.ProgressBar EnemyLife;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar ultimateBar;
        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.Timer EnemyMovement;
        private AxWMPLib.AxWindowsMediaPlayer mediaPunch;
        private AxWMPLib.AxWindowsMediaPlayer mediaEnemy;
        private AxWMPLib.AxWindowsMediaPlayer mediaGotHit;
    }
}