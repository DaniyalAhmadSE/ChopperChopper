using System;
using System.Windows.Forms;

namespace ChopperChopper.Forms
{
    public partial class Form_GameOver : Form
    {
        public Form_GameOver(int score, int highScore)
        {
            InitializeComponent();
            Lbl_Score.Text = $"Your Score : {score}";
            Lbl_HighScore.Text = (score > highScore) ? "New High Score!" : $"High Score : {highScore}";
        }

        private void Lbl_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
