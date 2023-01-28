namespace DeMenPhieuLuuKy
{
    partial class Level_6_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level_6_1));
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.Spider_L = new System.Windows.Forms.PictureBox();
            this.Spider_R = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.mediaGotHit = new AxWMPLib.AxWindowsMediaPlayer();
            this.mediaEnemy = new AxWMPLib.AxWindowsMediaPlayer();
            this.mediaPunch = new AxWMPLib.AxWindowsMediaPlayer();
            this.mediaJump = new AxWMPLib.AxWindowsMediaPlayer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EnemyLife = new System.Windows.Forms.ProgressBar();
            this.PlayerLife = new System.Windows.Forms.ProgressBar();
            this.txtRockCount = new System.Windows.Forms.Label();
            this.mediaStomp = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.SpiderTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spider_L)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spider_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaGotHit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPunch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaJump)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaStomp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::DeMenPhieuLuuKy.Properties.Resources.DeMen_Idle_Small;
            this.player.Location = new System.Drawing.Point(264, 372);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(33, 65);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 118;
            this.player.TabStop = false;
            this.player.Tag = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DeMenPhieuLuuKy.Properties.Resources.Ground_blue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(115, 443);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 130;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::DeMenPhieuLuuKy.Properties.Resources.Ground_blue;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(510, 443);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(398, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 130;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::DeMenPhieuLuuKy.Properties.Resources.Ground_blue;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(-280, 443);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(398, 88);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 130;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "platform";
            // 
            // Enemy
            // 
            this.Enemy.BackColor = System.Drawing.Color.Transparent;
            this.Enemy.Image = global::DeMenPhieuLuuKy.Properties.Resources.Nhen_Walk;
            this.Enemy.Location = new System.Drawing.Point(227, 51);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(163, 163);
            this.Enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy.TabIndex = 131;
            this.Enemy.TabStop = false;
            this.Enemy.Tag = "enemy";
            // 
            // Spider_L
            // 
            this.Spider_L.BackColor = System.Drawing.Color.Transparent;
            this.Spider_L.Image = global::DeMenPhieuLuuKy.Properties.Resources.Nhen_Small_L;
            this.Spider_L.Location = new System.Drawing.Point(831, 398);
            this.Spider_L.Name = "Spider_L";
            this.Spider_L.Size = new System.Drawing.Size(53, 39);
            this.Spider_L.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Spider_L.TabIndex = 131;
            this.Spider_L.TabStop = false;
            this.Spider_L.Tag = "enemy";
            // 
            // Spider_R
            // 
            this.Spider_R.BackColor = System.Drawing.Color.Transparent;
            this.Spider_R.Image = global::DeMenPhieuLuuKy.Properties.Resources.Nhen_Small;
            this.Spider_R.Location = new System.Drawing.Point(-253, 398);
            this.Spider_R.Name = "Spider_R";
            this.Spider_R.Size = new System.Drawing.Size(53, 39);
            this.Spider_R.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Spider_R.TabIndex = 131;
            this.Spider_R.TabStop = false;
            this.Spider_R.Tag = "enemy";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimeEvents);
            // 
            // mediaGotHit
            // 
            this.mediaGotHit.Enabled = true;
            this.mediaGotHit.Location = new System.Drawing.Point(597, 95);
            this.mediaGotHit.Name = "mediaGotHit";
            this.mediaGotHit.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaGotHit.OcxState")));
            this.mediaGotHit.Size = new System.Drawing.Size(75, 54);
            this.mediaGotHit.TabIndex = 132;
            this.mediaGotHit.TabStop = false;
            this.mediaGotHit.Visible = false;
            // 
            // mediaEnemy
            // 
            this.mediaEnemy.Enabled = true;
            this.mediaEnemy.Location = new System.Drawing.Point(678, 95);
            this.mediaEnemy.Name = "mediaEnemy";
            this.mediaEnemy.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaEnemy.OcxState")));
            this.mediaEnemy.Size = new System.Drawing.Size(75, 54);
            this.mediaEnemy.TabIndex = 133;
            this.mediaEnemy.TabStop = false;
            this.mediaEnemy.Visible = false;
            // 
            // mediaPunch
            // 
            this.mediaPunch.Enabled = true;
            this.mediaPunch.Location = new System.Drawing.Point(759, 95);
            this.mediaPunch.Name = "mediaPunch";
            this.mediaPunch.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPunch.OcxState")));
            this.mediaPunch.Size = new System.Drawing.Size(75, 54);
            this.mediaPunch.TabIndex = 134;
            this.mediaPunch.TabStop = false;
            this.mediaPunch.Visible = false;
            // 
            // mediaJump
            // 
            this.mediaJump.Enabled = true;
            this.mediaJump.Location = new System.Drawing.Point(759, 35);
            this.mediaJump.Name = "mediaJump";
            this.mediaJump.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaJump.OcxState")));
            this.mediaJump.Size = new System.Drawing.Size(75, 54);
            this.mediaJump.TabIndex = 135;
            this.mediaJump.TabStop = false;
            this.mediaJump.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(345, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 139;
            this.label2.Text = "Nhện";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(2, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 140;
            this.label1.Text = "Dế Mèn";
            // 
            // EnemyLife
            // 
            this.EnemyLife.ForeColor = System.Drawing.Color.OrangeRed;
            this.EnemyLife.Location = new System.Drawing.Point(396, 11);
            this.EnemyLife.Maximum = 1400;
            this.EnemyLife.Name = "EnemyLife";
            this.EnemyLife.Size = new System.Drawing.Size(210, 19);
            this.EnemyLife.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.EnemyLife.TabIndex = 136;
            // 
            // PlayerLife
            // 
            this.PlayerLife.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PlayerLife.Location = new System.Drawing.Point(73, 11);
            this.PlayerLife.Name = "PlayerLife";
            this.PlayerLife.Size = new System.Drawing.Size(110, 19);
            this.PlayerLife.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PlayerLife.TabIndex = 138;
            // 
            // txtRockCount
            // 
            this.txtRockCount.AutoSize = true;
            this.txtRockCount.BackColor = System.Drawing.Color.LightBlue;
            this.txtRockCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRockCount.Location = new System.Drawing.Point(202, 11);
            this.txtRockCount.Name = "txtRockCount";
            this.txtRockCount.Size = new System.Drawing.Size(55, 19);
            this.txtRockCount.TabIndex = 141;
            this.txtRockCount.Text = "Số đá :";
            // 
            // mediaStomp
            // 
            this.mediaStomp.Enabled = true;
            this.mediaStomp.Location = new System.Drawing.Point(597, 36);
            this.mediaStomp.Name = "mediaStomp";
            this.mediaStomp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaStomp.OcxState")));
            this.mediaStomp.Size = new System.Drawing.Size(75, 54);
            this.mediaStomp.TabIndex = 142;
            this.mediaStomp.TabStop = false;
            this.mediaStomp.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::DeMenPhieuLuuKy.Properties.Resources.Ground_blue;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(904, 443);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(398, 88);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 130;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "platform";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::DeMenPhieuLuuKy.Properties.Resources.Ground_blue;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(-1069, 443);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(398, 88);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 130;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "platform";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = global::DeMenPhieuLuuKy.Properties.Resources.Ground_blue;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(-674, 443);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(398, 88);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 130;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "platform";
            // 
            // SpiderTimer
            // 
            this.SpiderTimer.Enabled = true;
            this.SpiderTimer.Interval = 10;
            this.SpiderTimer.Tick += new System.EventHandler(this.SpiderTimer_Tick);
            // 
            // Level_6_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeMenPhieuLuuKy.Properties.Resources.Cave_Spider;
            this.ClientSize = new System.Drawing.Size(624, 481);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.txtRockCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnemyLife);
            this.Controls.Add(this.PlayerLife);
            this.Controls.Add(this.mediaGotHit);
            this.Controls.Add(this.mediaEnemy);
            this.Controls.Add(this.mediaPunch);
            this.Controls.Add(this.mediaJump);
            this.Controls.Add(this.Spider_R);
            this.Controls.Add(this.Spider_L);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.player);
            this.Controls.Add(this.mediaStomp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Level_6_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level_6_1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.This_Closing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spider_L)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spider_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaGotHit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPunch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaJump)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaStomp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.PictureBox Spider_L;
        private System.Windows.Forms.PictureBox Spider_R;
        private System.Windows.Forms.Timer GameTimer;
        private AxWMPLib.AxWindowsMediaPlayer mediaGotHit;
        private AxWMPLib.AxWindowsMediaPlayer mediaEnemy;
        private AxWMPLib.AxWindowsMediaPlayer mediaPunch;
        private AxWMPLib.AxWindowsMediaPlayer mediaJump;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar EnemyLife;
        private System.Windows.Forms.ProgressBar PlayerLife;
        private System.Windows.Forms.Label txtRockCount;
        private AxWMPLib.AxWindowsMediaPlayer mediaStomp;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer SpiderTimer;
    }
}