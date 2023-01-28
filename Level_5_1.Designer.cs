namespace DeMenPhieuLuuKy
{
    partial class Level_5_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level_5_1));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.mediaStomp = new AxWMPLib.AxWindowsMediaPlayer();
            this.mediaJump = new AxWMPLib.AxWindowsMediaPlayer();
            this.mediaCoin = new AxWMPLib.AxWindowsMediaPlayer();
            this.txtScore = new System.Windows.Forms.Label();
            this.Platform = new System.Windows.Forms.PictureBox();
            this.DropdownPlatform_2 = new System.Windows.Forms.PictureBox();
            this.DropdownPlatform_1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.KienLua_1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Giun_1 = new System.Windows.Forms.PictureBox();
            this.Giun_2 = new System.Windows.Forms.PictureBox();
            this.nextRound = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.puzzleStone = new System.Windows.Forms.PictureBox();
            this.showPuzzle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaStomp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaJump)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DropdownPlatform_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DropdownPlatform_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KienLua_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Giun_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Giun_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puzzleStone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPuzzle)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimeEvents);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::DeMenPhieuLuuKy.Properties.Resources.DeMen_Idle_Small;
            this.player.Location = new System.Drawing.Point(66, 331);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(33, 65);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            this.player.Tag = "";
            // 
            // mediaStomp
            // 
            this.mediaStomp.Enabled = true;
            this.mediaStomp.Location = new System.Drawing.Point(425, 106);
            this.mediaStomp.Name = "mediaStomp";
            this.mediaStomp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaStomp.OcxState")));
            this.mediaStomp.Size = new System.Drawing.Size(75, 54);
            this.mediaStomp.TabIndex = 90;
            this.mediaStomp.TabStop = false;
            this.mediaStomp.Visible = false;
            // 
            // mediaJump
            // 
            this.mediaJump.Enabled = true;
            this.mediaJump.Location = new System.Drawing.Point(425, 46);
            this.mediaJump.Name = "mediaJump";
            this.mediaJump.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaJump.OcxState")));
            this.mediaJump.Size = new System.Drawing.Size(75, 54);
            this.mediaJump.TabIndex = 91;
            this.mediaJump.TabStop = false;
            this.mediaJump.Visible = false;
            // 
            // mediaCoin
            // 
            this.mediaCoin.Enabled = true;
            this.mediaCoin.Location = new System.Drawing.Point(344, 46);
            this.mediaCoin.Name = "mediaCoin";
            this.mediaCoin.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaCoin.OcxState")));
            this.mediaCoin.Size = new System.Drawing.Size(75, 54);
            this.mediaCoin.TabIndex = 92;
            this.mediaCoin.TabStop = false;
            this.mediaCoin.Visible = false;
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(535, 25);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(72, 18);
            this.txtScore.TabIndex = 89;
            this.txtScore.Text = "Score: 3";
            // 
            // Platform
            // 
            this.Platform.BackColor = System.Drawing.Color.Transparent;
            this.Platform.BackgroundImage = global::DeMenPhieuLuuKy.Properties.Resources.Platform_1;
            this.Platform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Platform.Location = new System.Drawing.Point(-127, 439);
            this.Platform.Name = "Platform";
            this.Platform.Size = new System.Drawing.Size(356, 68);
            this.Platform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Platform.TabIndex = 93;
            this.Platform.TabStop = false;
            this.Platform.Tag = "platform";
            // 
            // DropdownPlatform_2
            // 
            this.DropdownPlatform_2.BackColor = System.Drawing.Color.Transparent;
            this.DropdownPlatform_2.BackgroundImage = global::DeMenPhieuLuuKy.Properties.Resources.Platform_3;
            this.DropdownPlatform_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DropdownPlatform_2.Location = new System.Drawing.Point(469, 309);
            this.DropdownPlatform_2.Name = "DropdownPlatform_2";
            this.DropdownPlatform_2.Size = new System.Drawing.Size(152, 50);
            this.DropdownPlatform_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DropdownPlatform_2.TabIndex = 125;
            this.DropdownPlatform_2.TabStop = false;
            this.DropdownPlatform_2.Tag = "platform_dropdown";
            // 
            // DropdownPlatform_1
            // 
            this.DropdownPlatform_1.BackColor = System.Drawing.Color.Transparent;
            this.DropdownPlatform_1.BackgroundImage = global::DeMenPhieuLuuKy.Properties.Resources.Platform_4;
            this.DropdownPlatform_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DropdownPlatform_1.Location = new System.Drawing.Point(309, 348);
            this.DropdownPlatform_1.Name = "DropdownPlatform_1";
            this.DropdownPlatform_1.Size = new System.Drawing.Size(88, 42);
            this.DropdownPlatform_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DropdownPlatform_1.TabIndex = 126;
            this.DropdownPlatform_1.TabStop = false;
            this.DropdownPlatform_1.Tag = "platform_dropdown";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DeMenPhieuLuuKy.Properties.Resources.Platform_5;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(839, 354);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 127;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform_vertical";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::DeMenPhieuLuuKy.Properties.Resources.Platform_5;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(722, 241);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 128;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform_vertical";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::DeMenPhieuLuuKy.Properties.Resources.Platform_2;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(1024, 276);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(305, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 93;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "platform";
            // 
            // KienLua_1
            // 
            this.KienLua_1.BackColor = System.Drawing.Color.Transparent;
            this.KienLua_1.Image = global::DeMenPhieuLuuKy.Properties.Resources.KienLua_Walk_L;
            this.KienLua_1.Location = new System.Drawing.Point(524, 251);
            this.KienLua_1.Name = "KienLua_1";
            this.KienLua_1.Size = new System.Drawing.Size(56, 52);
            this.KienLua_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.KienLua_1.TabIndex = 131;
            this.KienLua_1.TabStop = false;
            this.KienLua_1.Tag = "enemy";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::DeMenPhieuLuuKy.Properties.Resources.Platform_1;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(1419, 365);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(493, 151);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 93;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "platform";
            // 
            // Giun_1
            // 
            this.Giun_1.BackColor = System.Drawing.Color.Transparent;
            this.Giun_1.Image = global::DeMenPhieuLuuKy.Properties.Resources.Giun_Reverse;
            this.Giun_1.Location = new System.Drawing.Point(1534, 208);
            this.Giun_1.Name = "Giun_1";
            this.Giun_1.Size = new System.Drawing.Size(71, 317);
            this.Giun_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Giun_1.TabIndex = 162;
            this.Giun_1.TabStop = false;
            this.Giun_1.Tag = "enemy";
            // 
            // Giun_2
            // 
            this.Giun_2.BackColor = System.Drawing.Color.Transparent;
            this.Giun_2.Image = global::DeMenPhieuLuuKy.Properties.Resources.Giun_Reverse;
            this.Giun_2.Location = new System.Drawing.Point(1747, 208);
            this.Giun_2.Name = "Giun_2";
            this.Giun_2.Size = new System.Drawing.Size(71, 317);
            this.Giun_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Giun_2.TabIndex = 162;
            this.Giun_2.TabStop = false;
            this.Giun_2.Tag = "enemy";
            // 
            // nextRound
            // 
            this.nextRound.BackColor = System.Drawing.Color.Transparent;
            this.nextRound.Location = new System.Drawing.Point(1879, 419);
            this.nextRound.Name = "nextRound";
            this.nextRound.Size = new System.Drawing.Size(822, 88);
            this.nextRound.TabIndex = 168;
            this.nextRound.TabStop = false;
            this.nextRound.Tag = "nextForm";
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox15.Image = global::DeMenPhieuLuuKy.Properties.Resources.lá_cây_màu_vàng;
            this.pictureBox15.Location = new System.Drawing.Point(344, 196);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(27, 28);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 169;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "jumpItem";
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.Image = global::DeMenPhieuLuuKy.Properties.Resources.lá_cây_màu_vàng;
            this.pictureBox14.Location = new System.Drawing.Point(344, 281);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(27, 28);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 169;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "jumpItem";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::DeMenPhieuLuuKy.Properties.Resources.lá_cây_mau_do;
            this.pictureBox5.Location = new System.Drawing.Point(594, 208);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 170;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "healthItem";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::DeMenPhieuLuuKy.Properties.Resources.lá_cây_mau_do;
            this.pictureBox6.Location = new System.Drawing.Point(657, 148);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(27, 28);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 170;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "healthItem";
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox16.Image = global::DeMenPhieuLuuKy.Properties.Resources.lá_cây_mau_do;
            this.pictureBox16.Location = new System.Drawing.Point(856, 242);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(27, 28);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 170;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "healthItem";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::DeMenPhieuLuuKy.Properties.Resources.lá_cây_mau_do;
            this.pictureBox7.Location = new System.Drawing.Point(746, 97);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(27, 28);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 170;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "healthItem";
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox17.Image = global::DeMenPhieuLuuKy.Properties.Resources.lá_cây_màu_tím;
            this.pictureBox17.Location = new System.Drawing.Point(940, 72);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(27, 28);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 171;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "powerItem";
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox18.Image = global::DeMenPhieuLuuKy.Properties.Resources.lá_cây_màu_tím;
            this.pictureBox18.Location = new System.Drawing.Point(856, 419);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(27, 28);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 171;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Tag = "powerItem";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::DeMenPhieuLuuKy.Properties.Resources.lá_cây_màu_vàng;
            this.pictureBox8.Location = new System.Drawing.Point(1457, 224);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(27, 28);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 169;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "jumpItem";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::DeMenPhieuLuuKy.Properties.Resources.lá_cây_màu_vàng;
            this.pictureBox9.Location = new System.Drawing.Point(1457, 309);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(27, 28);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 169;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "jumpItem";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::DeMenPhieuLuuKy.Properties.Resources.lá_cây_mau_do;
            this.pictureBox10.Location = new System.Drawing.Point(1671, 309);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(27, 28);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 170;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "healthItem";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Image = global::DeMenPhieuLuuKy.Properties.Resources.lá_cây_mau_do;
            this.pictureBox11.Location = new System.Drawing.Point(1671, 224);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(27, 28);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 170;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "healthItem";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = global::DeMenPhieuLuuKy.Properties.Resources.lá_cây_màu_tím;
            this.pictureBox12.Location = new System.Drawing.Point(1862, 309);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(27, 28);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 171;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "powerItem";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Image = global::DeMenPhieuLuuKy.Properties.Resources.lá_cây_màu_tím;
            this.pictureBox13.Location = new System.Drawing.Point(1862, 224);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(27, 28);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 171;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "powerItem";
            // 
            // puzzleStone
            // 
            this.puzzleStone.BackColor = System.Drawing.Color.Transparent;
            this.puzzleStone.Image = global::DeMenPhieuLuuKy.Properties.Resources.stone_big;
            this.puzzleStone.Location = new System.Drawing.Point(1165, 55);
            this.puzzleStone.Name = "puzzleStone";
            this.puzzleStone.Size = new System.Drawing.Size(134, 221);
            this.puzzleStone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.puzzleStone.TabIndex = 173;
            this.puzzleStone.TabStop = false;
            this.puzzleStone.Tag = "platform";
            // 
            // showPuzzle
            // 
            this.showPuzzle.BackColor = System.Drawing.Color.Transparent;
            this.showPuzzle.Location = new System.Drawing.Point(1087, 117);
            this.showPuzzle.Name = "showPuzzle";
            this.showPuzzle.Size = new System.Drawing.Size(74, 161);
            this.showPuzzle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showPuzzle.TabIndex = 172;
            this.showPuzzle.TabStop = false;
            this.showPuzzle.Tag = "puzzle";
            // 
            // Level_5_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 481);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Giun_2);
            this.Controls.Add(this.Giun_1);
            this.Controls.Add(this.KienLua_1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.DropdownPlatform_2);
            this.Controls.Add(this.DropdownPlatform_1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Platform);
            this.Controls.Add(this.mediaStomp);
            this.Controls.Add(this.mediaJump);
            this.Controls.Add(this.mediaCoin);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.player);
            this.Controls.Add(this.nextRound);
            this.Controls.Add(this.puzzleStone);
            this.Controls.Add(this.showPuzzle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Level_5_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level_5_1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.This_Closing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Level5_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaStomp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaJump)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DropdownPlatform_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DropdownPlatform_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KienLua_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Giun_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Giun_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puzzleStone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPuzzle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox player;
        private AxWMPLib.AxWindowsMediaPlayer mediaStomp;
        private AxWMPLib.AxWindowsMediaPlayer mediaJump;
        private AxWMPLib.AxWindowsMediaPlayer mediaCoin;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox Platform;
        private System.Windows.Forms.PictureBox DropdownPlatform_2;
        private System.Windows.Forms.PictureBox DropdownPlatform_1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox KienLua_1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox Giun_1;
        private System.Windows.Forms.PictureBox Giun_2;
        private System.Windows.Forms.PictureBox nextRound;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox puzzleStone;
        private System.Windows.Forms.PictureBox showPuzzle;
    }
}