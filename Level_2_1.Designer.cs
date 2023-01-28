namespace DeMenPhieuLuuKy
{
    partial class Level_2_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level_2_1));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            this.mediaJump = new AxWMPLib.AxWindowsMediaPlayer();
            this.mediaCoin = new AxWMPLib.AxWindowsMediaPlayer();
            this.label2 = new System.Windows.Forms.Label();
            this.EnemyLife = new System.Windows.Forms.ProgressBar();
            this.ultimateBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.mediaGotHit = new AxWMPLib.AxWindowsMediaPlayer();
            this.mediaPunch = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HorizontalPlatform_1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.ChimCoc = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mediaJump)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaGotHit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPunch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalPlatform_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChimCoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimeEvents);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(540, 18);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(72, 18);
            this.txtScore.TabIndex = 51;
            this.txtScore.Text = "Score: 3";
            // 
            // mediaJump
            // 
            this.mediaJump.Enabled = true;
            this.mediaJump.Location = new System.Drawing.Point(330, 12);
            this.mediaJump.Name = "mediaJump";
            this.mediaJump.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaJump.OcxState")));
            this.mediaJump.Size = new System.Drawing.Size(75, 54);
            this.mediaJump.TabIndex = 93;
            this.mediaJump.TabStop = false;
            this.mediaJump.Visible = false;
            // 
            // mediaCoin
            // 
            this.mediaCoin.Enabled = true;
            this.mediaCoin.Location = new System.Drawing.Point(249, 12);
            this.mediaCoin.Name = "mediaCoin";
            this.mediaCoin.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaCoin.OcxState")));
            this.mediaCoin.Size = new System.Drawing.Size(75, 54);
            this.mediaCoin.TabIndex = 94;
            this.mediaCoin.TabStop = false;
            this.mediaCoin.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(245, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 141;
            this.label2.Text = "Chị Cốc";
            // 
            // EnemyLife
            // 
            this.EnemyLife.ForeColor = System.Drawing.Color.OrangeRed;
            this.EnemyLife.Location = new System.Drawing.Point(173, 28);
            this.EnemyLife.Maximum = 1400;
            this.EnemyLife.Name = "EnemyLife";
            this.EnemyLife.Size = new System.Drawing.Size(210, 13);
            this.EnemyLife.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.EnemyLife.TabIndex = 140;
            // 
            // ultimateBar
            // 
            this.ultimateBar.ForeColor = System.Drawing.Color.Gold;
            this.ultimateBar.Location = new System.Drawing.Point(429, 28);
            this.ultimateBar.Name = "ultimateBar";
            this.ultimateBar.Size = new System.Drawing.Size(77, 10);
            this.ultimateBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ultimateBar.TabIndex = 142;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(435, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 143;
            this.label1.Text = "Dế Mèn";
            // 
            // mediaGotHit
            // 
            this.mediaGotHit.Enabled = true;
            this.mediaGotHit.Location = new System.Drawing.Point(252, 64);
            this.mediaGotHit.Name = "mediaGotHit";
            this.mediaGotHit.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaGotHit.OcxState")));
            this.mediaGotHit.Size = new System.Drawing.Size(75, 54);
            this.mediaGotHit.TabIndex = 144;
            this.mediaGotHit.TabStop = false;
            this.mediaGotHit.Visible = false;
            // 
            // mediaPunch
            // 
            this.mediaPunch.Enabled = true;
            this.mediaPunch.Location = new System.Drawing.Point(330, 64);
            this.mediaPunch.Name = "mediaPunch";
            this.mediaPunch.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPunch.OcxState")));
            this.mediaPunch.Size = new System.Drawing.Size(75, 54);
            this.mediaPunch.TabIndex = 145;
            this.mediaPunch.TabStop = false;
            this.mediaPunch.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::DeMenPhieuLuuKy.Properties.Resources.Platform_3;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(621, 412);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::DeMenPhieuLuuKy.Properties.Resources.Platform_2;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(233, 412);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(141, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "platform";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DeMenPhieuLuuKy.Properties.Resources.Platform_2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(431, 307);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform";
            // 
            // HorizontalPlatform_1
            // 
            this.HorizontalPlatform_1.BackColor = System.Drawing.Color.Transparent;
            this.HorizontalPlatform_1.BackgroundImage = global::DeMenPhieuLuuKy.Properties.Resources.Platform_1;
            this.HorizontalPlatform_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HorizontalPlatform_1.Location = new System.Drawing.Point(-14, 376);
            this.HorizontalPlatform_1.Name = "HorizontalPlatform_1";
            this.HorizontalPlatform_1.Size = new System.Drawing.Size(141, 41);
            this.HorizontalPlatform_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HorizontalPlatform_1.TabIndex = 3;
            this.HorizontalPlatform_1.TabStop = false;
            this.HorizontalPlatform_1.Tag = "platform";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::DeMenPhieuLuuKy.Properties.Resources.DeMen_Run_Small;
            this.player.Location = new System.Drawing.Point(252, 307);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(37, 64);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            this.player.Tag = "";
            // 
            // ChimCoc
            // 
            this.ChimCoc.BackColor = System.Drawing.Color.Transparent;
            this.ChimCoc.Image = global::DeMenPhieuLuuKy.Properties.Resources.ChimCoc;
            this.ChimCoc.Location = new System.Drawing.Point(-304, 18);
            this.ChimCoc.Name = "ChimCoc";
            this.ChimCoc.Size = new System.Drawing.Size(471, 583);
            this.ChimCoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ChimCoc.TabIndex = 98;
            this.ChimCoc.TabStop = false;
            this.ChimCoc.Tag = "enemy";
            // 
            // Enemy
            // 
            this.Enemy.BackColor = System.Drawing.Color.Transparent;
            this.Enemy.Location = new System.Drawing.Point(-2, 6);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(52, 479);
            this.Enemy.TabIndex = 146;
            this.Enemy.TabStop = false;
            this.Enemy.Tag = "enemy";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::DeMenPhieuLuuKy.Properties.Resources.ChuonChuon;
            this.pictureBox4.Location = new System.Drawing.Point(187, 64);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(59, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 98;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "chuongChuong";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Image = global::DeMenPhieuLuuKy.Properties.Resources.ChuonChuon;
            this.pictureBox11.Location = new System.Drawing.Point(609, 106);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(59, 33);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 98;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "chuongChuong";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Image = global::DeMenPhieuLuuKy.Properties.Resources.Dust;
            this.pictureBox5.Location = new System.Drawing.Point(575, 249);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(26, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 147;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "coin";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox6.Image = global::DeMenPhieuLuuKy.Properties.Resources.Dust;
            this.pictureBox6.Location = new System.Drawing.Point(474, 201);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(26, 24);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 147;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "coin";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox7.Image = global::DeMenPhieuLuuKy.Properties.Resources.Dust;
            this.pictureBox7.Location = new System.Drawing.Point(330, 249);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(26, 24);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 147;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "coin";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox8.Image = global::DeMenPhieuLuuKy.Properties.Resources.Dust;
            this.pictureBox8.Location = new System.Drawing.Point(220, 201);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(26, 24);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 147;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "coin";
            // 
            // Level_2_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ultimateBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnemyLife);
            this.Controls.Add(this.mediaJump);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HorizontalPlatform_1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.mediaGotHit);
            this.Controls.Add(this.mediaPunch);
            this.Controls.Add(this.mediaCoin);
            this.Controls.Add(this.ChimCoc);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Level_2_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level_2_1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.This_Closing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Level_2_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.mediaJump)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaGotHit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPunch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalPlatform_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChimCoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox HorizontalPlatform_1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label txtScore;
        private AxWMPLib.AxWindowsMediaPlayer mediaJump;
        private AxWMPLib.AxWindowsMediaPlayer mediaCoin;
        private System.Windows.Forms.PictureBox ChimCoc;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar EnemyLife;
        private System.Windows.Forms.ProgressBar ultimateBar;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer mediaGotHit;
        private AxWMPLib.AxWindowsMediaPlayer mediaPunch;
        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}