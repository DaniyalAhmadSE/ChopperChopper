using ChopperChopper.Interfaces;
using ChopperChopper.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChopperChopper.Forms
{
    public partial class Form_GameEnvironment : Form, IGameEnvironment
    {
        public Form_GameEnvironment()
        {
            InitializeComponent();
            GameTerrainEngine = new TerrainEngine(Panel_Playground, this);
            GameSoundEngine = new SoundEngine();
            ResetGameEnvironment();
            ResetHud();
            FixFlickering();
        }

        private bool IsStarted { get; set; } = false;
        private int Score { get; set; } = 0;
        public int HighScore { get; set; }
        private TerrainEngine GameTerrainEngine { get; set; }
        public SoundEngine GameSoundEngine { get; set; }

        private void Form_PlayGround_Shown(object sender, EventArgs e)
        {
            new Form_Help().ShowDialog();
        }

        private void Btn_Start_Reset_Click(object sender, EventArgs e)
        {
            if (!IsStarted)
            {
                StartGame();
            }
            else
            {
                ResetGameEnvironment();
                ResetHud();
            }
        }

        private void Timer_Clock_Tick(object sender, EventArgs e)
        {
            GameTerrainEngine.RunEngine();
            Chopper_Player.MoveChopper();
            CheckCrash();
        }

        private void Form_Playground_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                Chopper_Player.IsDirectionUp = true;
            }
        }

        private void Form_Playground_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                Chopper_Player.IsDirectionUp = false;
            }
        }

        private void CheckCrash()
        {
            foreach (var obstacle in GameTerrainEngine.DeadlyObstacles)
            {
                if (Chopper_Player.Bounds.IntersectsWith(obstacle.Bounds))
                {
                    GameSoundEngine.StopAllSounds();
                    GameSoundEngine.ExplosionSoundEffectPlayer.PlaySync();
                    HighScoreCheck();
                    Form formGameOver = new Form_GameOver(Score, HighScore);
                    ResetGameEnvironment();
                    formGameOver.ShowDialog();
                    ResetHud();
                }
            }
        }

        private void HighScoreCheck()
        {
            if (Score > HighScore)
            {
                DataManager.UpdateHighScore(Score);
                GameSoundEngine.NewHighScoreMusicPlayer.Play();
            }
            else
            {
                GameSoundEngine.GameOverMusicPlayer.Play();
            }
        }

        private void Rdb_DifficultyChanged(object sender, EventArgs e)
        {
            ResetGameDifficulty();
        }

        private void ResetHud()
        {            
            HideEnvironmentSetupControls(false);
            Lbl_Announcement.Visible = false;

            Score = 0;
            HighScore = DataManager.GetHighScore();

            Lbl_Score.Text = Score.ToString();
            Lbl_HighScore.Text = $"High Score — {HighScore}";

            IsStarted = false;
            Btn_Start_Reset.Text = "Start";

            this.ActiveControl = Btn_Start_Reset;
            GameSoundEngine.StopAllSounds();
            GameSoundEngine.WelcomeMusicPlayer.PlayLooping();
        }

        private void StartGame()
        {
            HideEnvironmentSetupControls(true);

            Btn_Start_Reset.Text = "Stop";
            this.ActiveControl = null;
            this.Activate();

            GameSoundEngine.StopAllSounds();
            GameSoundEngine.BackgroundMusicPlayer.PlayLooping();
            
            IsStarted = true;
            Timer_Clock.Start();

        }

        private void ResetGameEnvironment()
        {
            Timer_Clock.Stop();
            Chopper_Player.IsDirectionUp = false;
            Chopper_Player.Location = new Point(30, (Panel_Playground.Height / 2) - (Chopper_Player.Height / 2));

            ResetGameDifficulty();
        }

        private void ResetGameDifficulty()
        {
            if (Rdb_Easy.Checked)
            {
                SetEasyEnvironment();
            }
            else if (Rdb_Hard.Checked)
            {
                SetHardEnvironment();
            }
            GameTerrainEngine.SetupTerrain();
        }

        private void SetEasyEnvironment()
        {
            GameTerrainEngine.GameSpeed = 5;
            GameTerrainEngine.MinObstacleHeight = 25;
            GameTerrainEngine.MaxObstacleHeight = 175;
            GameTerrainEngine.ObstacleEqualHeights = 100;
            GameTerrainEngine.ObstacleHeightChangeRate = 25;
            Timer_Clock.Interval = 10;
        }

        private void SetHardEnvironment()
        {
            GameTerrainEngine.GameSpeed = 10;
            GameTerrainEngine.MinObstacleHeight = 30;
            GameTerrainEngine.MaxObstacleHeight = 180;
            GameTerrainEngine.ObstacleEqualHeights = 120;
            GameTerrainEngine.ObstacleHeightChangeRate = 30;
            Timer_Clock.Interval = 1;
        }
        
        public void IncrementScore(int amount)
        {
            Score += amount;
            Lbl_Score.Text = Score.ToString();

            if (Score > HighScore) Lbl_Announcement.Visible = true;
        }

        private void HideEnvironmentSetupControls(bool hide)
        {
            Lbl_Difficulty.Visible = !hide;
            Rdb_Easy.Visible = !hide;
            Rdb_Hard.Visible = !hide;
        }

        // ------------- Flickering Fix ----------------------------
        private void FixFlickering()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        // ---------------------------------------------------------
    }
}
