namespace DeMenPhieuLuuKy
{
    partial class PlayerStat
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
            this.txtPlayerHealth = new System.Windows.Forms.Label();
            this.txtPlayerPower = new System.Windows.Forms.Label();
            this.txtPlayerJumpSpeed = new System.Windows.Forms.Label();
            this.btnResume = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlayerHealth
            // 
            this.txtPlayerHealth.BackColor = System.Drawing.Color.Transparent;
            this.txtPlayerHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerHealth.Location = new System.Drawing.Point(183, 156);
            this.txtPlayerHealth.Name = "txtPlayerHealth";
            this.txtPlayerHealth.Size = new System.Drawing.Size(128, 28);
            this.txtPlayerHealth.TabIndex = 0;
            this.txtPlayerHealth.Text = "Máu: ";
            // 
            // txtPlayerPower
            // 
            this.txtPlayerPower.BackColor = System.Drawing.Color.Transparent;
            this.txtPlayerPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerPower.Location = new System.Drawing.Point(183, 204);
            this.txtPlayerPower.Name = "txtPlayerPower";
            this.txtPlayerPower.Size = new System.Drawing.Size(128, 28);
            this.txtPlayerPower.TabIndex = 0;
            this.txtPlayerPower.Text = "Sức mạnh: ";
            // 
            // txtPlayerJumpSpeed
            // 
            this.txtPlayerJumpSpeed.BackColor = System.Drawing.Color.Transparent;
            this.txtPlayerJumpSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerJumpSpeed.Location = new System.Drawing.Point(183, 251);
            this.txtPlayerJumpSpeed.Name = "txtPlayerJumpSpeed";
            this.txtPlayerJumpSpeed.Size = new System.Drawing.Size(128, 28);
            this.txtPlayerJumpSpeed.TabIndex = 0;
            this.txtPlayerJumpSpeed.Text = "Sức bật: ";
            // 
            // btnResume
            // 
            this.btnResume.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResume.Location = new System.Drawing.Point(207, 329);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(107, 49);
            this.btnResume.TabIndex = 0;
            this.btnResume.Text = "Tiếp tục chơi";
            this.btnResume.UseVisualStyleBackColor = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Máu: ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sức mạnh: ";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sức bật: ";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.txtPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(183, 65);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(170, 48);
            this.txtPlayerName.TabIndex = 0;
            this.txtPlayerName.Text = "Tên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DeMenPhieuLuuKy.Properties.Resources.DeMen_Idle_Small;
            this.pictureBox1.Location = new System.Drawing.Point(92, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 68);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PlayerStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeMenPhieuLuuKy.Properties.Resources.playerStat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(326, 390);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPlayerJumpSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlayerPower);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlayerHealth);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayerStat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dế Mèn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtPlayerHealth;
        private System.Windows.Forms.Label txtPlayerPower;
        private System.Windows.Forms.Label txtPlayerJumpSpeed;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtPlayerName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}