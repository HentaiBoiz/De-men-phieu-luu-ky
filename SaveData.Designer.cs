namespace DeMenPhieuLuuKy
{
    partial class SaveData
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
            this.saveDataGridView = new System.Windows.Forms.DataGridView();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDoiBanLuu = new System.Windows.Forms.Button();
            this.colPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDifficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHealth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJumpSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.saveDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveDataGridView
            // 
            this.saveDataGridView.AllowUserToAddRows = false;
            this.saveDataGridView.AllowUserToDeleteRows = false;
            this.saveDataGridView.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.saveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saveDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPlayer,
            this.colScore,
            this.colLevel,
            this.colDifficulty,
            this.colHealth,
            this.colPower,
            this.colJumpSpeed});
            this.saveDataGridView.GridColor = System.Drawing.Color.Linen;
            this.saveDataGridView.Location = new System.Drawing.Point(32, 161);
            this.saveDataGridView.MultiSelect = false;
            this.saveDataGridView.Name = "saveDataGridView";
            this.saveDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.saveDataGridView.Size = new System.Drawing.Size(499, 324);
            this.saveDataGridView.TabIndex = 0;
            this.saveDataGridView.TabStop = false;
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.LightGreen;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(585, 161);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(153, 53);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.TabStop = false;
            this.btnContinue.Text = "Tiếp tục chơi";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightGreen;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(585, 250);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(153, 53);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Xóa bản lưu";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightGreen;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(585, 429);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 56);
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Quay lại";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DeMenPhieuLuuKy.Properties.Resources.Title_Text;
            this.pictureBox1.Location = new System.Drawing.Point(167, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnDoiBanLuu
            // 
            this.btnDoiBanLuu.BackColor = System.Drawing.Color.LightGreen;
            this.btnDoiBanLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiBanLuu.Location = new System.Drawing.Point(585, 341);
            this.btnDoiBanLuu.Name = "btnDoiBanLuu";
            this.btnDoiBanLuu.Size = new System.Drawing.Size(153, 53);
            this.btnDoiBanLuu.TabIndex = 1;
            this.btnDoiBanLuu.TabStop = false;
            this.btnDoiBanLuu.Text = "Đổi bản lưu";
            this.btnDoiBanLuu.UseVisualStyleBackColor = false;
            this.btnDoiBanLuu.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // colPlayer
            // 
            this.colPlayer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPlayer.DataPropertyName = "PlayerName";
            this.colPlayer.HeaderText = "Tên người chơi";
            this.colPlayer.Name = "colPlayer";
            this.colPlayer.ReadOnly = true;
            this.colPlayer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colScore
            // 
            this.colScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colScore.HeaderText = "Tổng điểm";
            this.colScore.Name = "colScore";
            this.colScore.ReadOnly = true;
            this.colScore.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colLevel
            // 
            this.colLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLevel.HeaderText = "Màn chơi hiện tại";
            this.colLevel.Name = "colLevel";
            this.colLevel.ReadOnly = true;
            this.colLevel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colDifficulty
            // 
            this.colDifficulty.HeaderText = "Độ Khó";
            this.colDifficulty.Name = "colDifficulty";
            // 
            // colHealth
            // 
            this.colHealth.HeaderText = "Máu";
            this.colHealth.Name = "colHealth";
            this.colHealth.Visible = false;
            // 
            // colPower
            // 
            this.colPower.HeaderText = "Sức mạnh";
            this.colPower.Name = "colPower";
            this.colPower.Visible = false;
            // 
            // colJumpSpeed
            // 
            this.colJumpSpeed.HeaderText = "Sức bật";
            this.colJumpSpeed.Name = "colJumpSpeed";
            this.colJumpSpeed.Visible = false;
            // 
            // SaveData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeMenPhieuLuuKy.Properties.Resources.Jungle;
            this.ClientSize = new System.Drawing.Size(782, 520);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDoiBanLuu);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.saveDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SaveData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaveData";
            ((System.ComponentModel.ISupportInitialize)(this.saveDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView saveDataGridView;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDoiBanLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDifficulty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHealth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPower;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJumpSpeed;
    }
}