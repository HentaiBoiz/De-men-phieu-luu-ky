namespace DeMenPhieuLuuKy
{
    partial class InputName
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên người chơi";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.BackColor = System.Drawing.Color.OldLace;
            this.txtPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(95, 82);
            this.txtPlayerName.Multiline = true;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(227, 31);
            this.txtPlayerName.TabIndex = 1;
            this.txtPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightGreen;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(228, 199);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 43);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DeMenPhieuLuuKy.Properties.Resources.DeMen_Idle_Small;
            this.pictureBox2.Location = new System.Drawing.Point(36, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 39);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.LightGreen;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(95, 199);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(94, 43);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Trở về";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Bisque;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.Olive;
            this.radioButton1.Location = new System.Drawing.Point(93, 142);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 20);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.Tag = "1";
            this.radioButton1.Text = "Dễ";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.ChangeDifficulty);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Bisque;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.Green;
            this.radioButton2.Location = new System.Drawing.Point(155, 142);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(100, 20);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "2";
            this.radioButton2.Text = "Trung Bình";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.ChangeDifficulty);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Bisque;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.Brown;
            this.radioButton3.Location = new System.Drawing.Point(270, 142);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 20);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.Tag = "3";
            this.radioButton3.Text = "Khó";
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.ChangeDifficulty);
            // 
            // InputName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeMenPhieuLuuKy.Properties.Resources.Jungle;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(403, 254);
            this.ControlBox = false;
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InputName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Name";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}