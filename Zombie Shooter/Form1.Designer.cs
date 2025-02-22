namespace Zombie_Shooter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            HealthBox = new ProgressBar();
            txtAmmo = new Label();
            txtScore = new Label();
            label3 = new Label();
            BulletTimerEvent = new System.Windows.Forms.Timer(components);
            player = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            SuspendLayout();
            // 
            // HealthBox
            // 
            HealthBox.Location = new Point(741, 12);
            HealthBox.Name = "HealthBox";
            HealthBox.Size = new Size(169, 22);
            HealthBox.TabIndex = 3;
            HealthBox.Value = 100;
            // 
            // txtAmmo
            // 
            txtAmmo.AutoSize = true;
            txtAmmo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAmmo.ForeColor = SystemColors.ButtonHighlight;
            txtAmmo.Location = new Point(21, 9);
            txtAmmo.Name = "txtAmmo";
            txtAmmo.Size = new Size(111, 31);
            txtAmmo.TabIndex = 5;
            txtAmmo.Text = "Ammo: 0";
            txtAmmo.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtScore.ForeColor = SystemColors.ButtonHighlight;
            txtScore.Location = new Point(388, 9);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(79, 31);
            txtScore.TabIndex = 6;
            txtScore.Text = "Kills:0";
            txtScore.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(643, 9);
            label3.Name = "label3";
            label3.Size = new Size(92, 31);
            label3.TabIndex = 7;
            label3.Text = "Health:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // BulletTimerEvent
            // 
            BulletTimerEvent.Enabled = true;
            BulletTimerEvent.Interval = 20;
            BulletTimerEvent.Tick += MainTimerEvent_Tick;
            // 
            // player
            // 
            player.Image = Properties.Resources.up;
            player.Location = new Point(396, 376);
            player.Name = "player";
            player.Size = new Size(71, 100);
            player.SizeMode = PictureBoxSizeMode.AutoSize;
            player.TabIndex = 8;
            player.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(922, 653);
            Controls.Add(player);
            Controls.Add(label3);
            Controls.Add(txtScore);
            Controls.Add(txtAmmo);
            Controls.Add(HealthBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ProgressBar HealthBox;
        private Label txtAmmo;
        private Label txtScore;
        private Label label3;
        private System.Windows.Forms.Timer BulletTimerEvent;
        private PictureBox player;
    }
}
