
namespace ChopperChopper.Forms
{
    partial class Form_GameEnvironment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GameEnvironment));
            this.Timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.Pnl_TopWall = new System.Windows.Forms.Panel();
            this.Lbl_Announcement = new System.Windows.Forms.Label();
            this.Lbl_HighScore = new System.Windows.Forms.Label();
            this.Lbl_ScoreText = new System.Windows.Forms.Label();
            this.Lbl_Score = new System.Windows.Forms.Label();
            this.Pnl_BottomWall = new System.Windows.Forms.Panel();
            this.Rdb_Hard = new System.Windows.Forms.RadioButton();
            this.Rdb_Easy = new System.Windows.Forms.RadioButton();
            this.Btn_Start_Reset = new System.Windows.Forms.Button();
            this.Lbl_Difficulty = new System.Windows.Forms.Label();
            this.Panel_Playground = new System.Windows.Forms.Panel();
            this.Chopper_Player = new ChopperChopper.Models.Chopper();
            this.Pnl_TopWall.SuspendLayout();
            this.Pnl_BottomWall.SuspendLayout();
            this.Panel_Playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chopper_Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer_Clock
            // 
            this.Timer_Clock.Interval = 10;
            this.Timer_Clock.Tick += new System.EventHandler(this.Timer_Clock_Tick);
            // 
            // Pnl_TopWall
            // 
            this.Pnl_TopWall.BackColor = System.Drawing.Color.Black;
            this.Pnl_TopWall.Controls.Add(this.Lbl_Announcement);
            this.Pnl_TopWall.Controls.Add(this.Lbl_HighScore);
            this.Pnl_TopWall.Controls.Add(this.Lbl_ScoreText);
            this.Pnl_TopWall.Controls.Add(this.Lbl_Score);
            this.Pnl_TopWall.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_TopWall.Location = new System.Drawing.Point(0, 0);
            this.Pnl_TopWall.Margin = new System.Windows.Forms.Padding(1);
            this.Pnl_TopWall.Name = "Pnl_TopWall";
            this.Pnl_TopWall.Size = new System.Drawing.Size(944, 45);
            this.Pnl_TopWall.TabIndex = 9;
            // 
            // Lbl_Announcement
            // 
            this.Lbl_Announcement.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Announcement.ForeColor = System.Drawing.Color.White;
            this.Lbl_Announcement.Location = new System.Drawing.Point(351, 9);
            this.Lbl_Announcement.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Lbl_Announcement.Name = "Lbl_Announcement";
            this.Lbl_Announcement.Size = new System.Drawing.Size(242, 25);
            this.Lbl_Announcement.TabIndex = 14;
            this.Lbl_Announcement.Text = "New High Score!";
            this.Lbl_Announcement.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lbl_Announcement.Visible = false;
            // 
            // Lbl_HighScore
            // 
            this.Lbl_HighScore.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_HighScore.ForeColor = System.Drawing.Color.White;
            this.Lbl_HighScore.Location = new System.Drawing.Point(582, 13);
            this.Lbl_HighScore.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Lbl_HighScore.Name = "Lbl_HighScore";
            this.Lbl_HighScore.Size = new System.Drawing.Size(350, 20);
            this.Lbl_HighScore.TabIndex = 10;
            this.Lbl_HighScore.Text = "High Score — 0";
            this.Lbl_HighScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Lbl_ScoreText
            // 
            this.Lbl_ScoreText.AutoSize = true;
            this.Lbl_ScoreText.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ScoreText.ForeColor = System.Drawing.Color.White;
            this.Lbl_ScoreText.Location = new System.Drawing.Point(10, 13);
            this.Lbl_ScoreText.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Lbl_ScoreText.Name = "Lbl_ScoreText";
            this.Lbl_ScoreText.Size = new System.Drawing.Size(86, 20);
            this.Lbl_ScoreText.TabIndex = 6;
            this.Lbl_ScoreText.Text = "Score —";
            // 
            // Lbl_Score
            // 
            this.Lbl_Score.AutoSize = true;
            this.Lbl_Score.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Score.ForeColor = System.Drawing.Color.White;
            this.Lbl_Score.Location = new System.Drawing.Point(98, 13);
            this.Lbl_Score.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Lbl_Score.Name = "Lbl_Score";
            this.Lbl_Score.Size = new System.Drawing.Size(20, 20);
            this.Lbl_Score.TabIndex = 4;
            this.Lbl_Score.Text = "0";
            // 
            // Pnl_BottomWall
            // 
            this.Pnl_BottomWall.BackColor = System.Drawing.Color.Black;
            this.Pnl_BottomWall.Controls.Add(this.Rdb_Hard);
            this.Pnl_BottomWall.Controls.Add(this.Rdb_Easy);
            this.Pnl_BottomWall.Controls.Add(this.Btn_Start_Reset);
            this.Pnl_BottomWall.Controls.Add(this.Lbl_Difficulty);
            this.Pnl_BottomWall.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_BottomWall.Location = new System.Drawing.Point(0, 456);
            this.Pnl_BottomWall.Margin = new System.Windows.Forms.Padding(1);
            this.Pnl_BottomWall.Name = "Pnl_BottomWall";
            this.Pnl_BottomWall.Size = new System.Drawing.Size(944, 45);
            this.Pnl_BottomWall.TabIndex = 8;
            // 
            // Rdb_Hard
            // 
            this.Rdb_Hard.AutoSize = true;
            this.Rdb_Hard.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Hard.ForeColor = System.Drawing.Color.White;
            this.Rdb_Hard.Location = new System.Drawing.Point(245, 10);
            this.Rdb_Hard.Name = "Rdb_Hard";
            this.Rdb_Hard.Size = new System.Drawing.Size(71, 24);
            this.Rdb_Hard.TabIndex = 2;
            this.Rdb_Hard.Text = "Hard";
            this.Rdb_Hard.UseVisualStyleBackColor = false;
            // 
            // Rdb_Easy
            // 
            this.Rdb_Easy.AutoSize = true;
            this.Rdb_Easy.Checked = true;
            this.Rdb_Easy.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Easy.ForeColor = System.Drawing.Color.White;
            this.Rdb_Easy.Location = new System.Drawing.Point(168, 10);
            this.Rdb_Easy.Name = "Rdb_Easy";
            this.Rdb_Easy.Size = new System.Drawing.Size(71, 24);
            this.Rdb_Easy.TabIndex = 1;
            this.Rdb_Easy.TabStop = true;
            this.Rdb_Easy.Text = "Easy";
            this.Rdb_Easy.UseVisualStyleBackColor = false;
            this.Rdb_Easy.CheckedChanged += new System.EventHandler(this.Rdb_DifficultyChanged);
            // 
            // Btn_Start_Reset
            // 
            this.Btn_Start_Reset.AutoSize = true;
            this.Btn_Start_Reset.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Start_Reset.ForeColor = System.Drawing.Color.White;
            this.Btn_Start_Reset.Location = new System.Drawing.Point(836, 3);
            this.Btn_Start_Reset.Name = "Btn_Start_Reset";
            this.Btn_Start_Reset.Size = new System.Drawing.Size(96, 39);
            this.Btn_Start_Reset.TabIndex = 0;
            this.Btn_Start_Reset.Text = "Start";
            this.Btn_Start_Reset.UseVisualStyleBackColor = false;
            this.Btn_Start_Reset.Click += new System.EventHandler(this.Btn_Start_Reset_Click);
            // 
            // Lbl_Difficulty
            // 
            this.Lbl_Difficulty.AutoSize = true;
            this.Lbl_Difficulty.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Difficulty.ForeColor = System.Drawing.Color.White;
            this.Lbl_Difficulty.Location = new System.Drawing.Point(10, 12);
            this.Lbl_Difficulty.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Lbl_Difficulty.Name = "Lbl_Difficulty";
            this.Lbl_Difficulty.Size = new System.Drawing.Size(152, 20);
            this.Lbl_Difficulty.TabIndex = 7;
            this.Lbl_Difficulty.Text = "Difficulty — ";
            // 
            // Panel_Playground
            // 
            this.Panel_Playground.BackColor = System.Drawing.Color.Black;
            this.Panel_Playground.Controls.Add(this.Chopper_Player);
            this.Panel_Playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Playground.Location = new System.Drawing.Point(0, 45);
            this.Panel_Playground.Name = "Panel_Playground";
            this.Panel_Playground.Size = new System.Drawing.Size(944, 411);
            this.Panel_Playground.TabIndex = 10;
            // 
            // Chopper_Player
            // 
            this.Chopper_Player.BackColor = System.Drawing.Color.Transparent;
            this.Chopper_Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Chopper_Player.Image = ((System.Drawing.Image)(resources.GetObject("Chopper_Player.Image")));
            this.Chopper_Player.IsDirectionUp = false;
            this.Chopper_Player.Location = new System.Drawing.Point(30, 190);
            this.Chopper_Player.Name = "Chopper_Player";
            this.Chopper_Player.Size = new System.Drawing.Size(80, 30);
            this.Chopper_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Chopper_Player.Speed = 5;
            this.Chopper_Player.TabIndex = 0;
            this.Chopper_Player.TabStop = false;
            // 
            // Form_GameEnvironment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.Panel_Playground);
            this.Controls.Add(this.Pnl_TopWall);
            this.Controls.Add(this.Pnl_BottomWall);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_GameEnvironment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chopper Chopper";
            this.Shown += new System.EventHandler(this.Form_PlayGround_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Playground_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_Playground_KeyUp);
            this.Pnl_TopWall.ResumeLayout(false);
            this.Pnl_TopWall.PerformLayout();
            this.Pnl_BottomWall.ResumeLayout(false);
            this.Pnl_BottomWall.PerformLayout();
            this.Panel_Playground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chopper_Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Models.Chopper Chopper_Player;
        private System.Windows.Forms.Timer Timer_Clock;
        private System.Windows.Forms.Panel Pnl_TopWall;
        private System.Windows.Forms.Label Lbl_ScoreText;
        private System.Windows.Forms.Label Lbl_Score;
        private System.Windows.Forms.Panel Pnl_BottomWall;
        private System.Windows.Forms.RadioButton Rdb_Hard;
        private System.Windows.Forms.RadioButton Rdb_Easy;
        private System.Windows.Forms.Button Btn_Start_Reset;
        private System.Windows.Forms.Label Lbl_Difficulty;
        private System.Windows.Forms.Panel Panel_Playground;
        private System.Windows.Forms.Label Lbl_HighScore;
        private System.Windows.Forms.Label Lbl_Announcement;
    }
}

