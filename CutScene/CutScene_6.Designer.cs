namespace DeMenPhieuLuuKy.CutScene
{
    partial class CutScene_6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CutScene_6));
            this.videoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // videoPlayer
            // 
            this.videoPlayer.Enabled = true;
            this.videoPlayer.Location = new System.Drawing.Point(-1, -2);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoPlayer.OcxState")));
            this.videoPlayer.Size = new System.Drawing.Size(624, 543);
            this.videoPlayer.TabIndex = 89;
            this.videoPlayer.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Honeydew;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(489, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(123, 64);
            this.btnStart.TabIndex = 90;
            this.btnStart.Text = "RETURN TO MAIN MENU";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // CutScene_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 481);
            this.ControlBox = false;
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.videoPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CutScene_6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CutScene_6";
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer videoPlayer;
        private System.Windows.Forms.Button btnStart;
    }
}