
namespace ChopperChopper.Forms
{
    partial class Form_GameOver
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.Lbl_HighScore = new System.Windows.Forms.Label();
            this.Lbl_Score = new System.Windows.Forms.Label();
            this.Lbl_Close = new System.Windows.Forms.Label();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.Btn_Ok);
            this.panel1.Controls.Add(this.Lbl_HighScore);
            this.panel1.Controls.Add(this.Lbl_Score);
            this.panel1.Controls.Add(this.Lbl_Close);
            this.panel1.Controls.Add(this.Lbl_Title);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 234);
            this.panel1.TabIndex = 0;
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.AutoSize = true;
            this.Btn_Ok.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ok.ForeColor = System.Drawing.Color.White;
            this.Btn_Ok.Location = new System.Drawing.Point(92, 186);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(96, 39);
            this.Btn_Ok.TabIndex = 1;
            this.Btn_Ok.Text = "OK";
            this.Btn_Ok.UseVisualStyleBackColor = false;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Lbl_HighScore
            // 
            this.Lbl_HighScore.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_HighScore.ForeColor = System.Drawing.Color.White;
            this.Lbl_HighScore.Location = new System.Drawing.Point(6, 131);
            this.Lbl_HighScore.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Lbl_HighScore.Name = "Lbl_HighScore";
            this.Lbl_HighScore.Size = new System.Drawing.Size(268, 20);
            this.Lbl_HighScore.TabIndex = 16;
            this.Lbl_HighScore.Text = "High Score : ";
            this.Lbl_HighScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_Score
            // 
            this.Lbl_Score.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Score.ForeColor = System.Drawing.Color.White;
            this.Lbl_Score.Location = new System.Drawing.Point(6, 82);
            this.Lbl_Score.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Lbl_Score.Name = "Lbl_Score";
            this.Lbl_Score.Size = new System.Drawing.Size(268, 20);
            this.Lbl_Score.TabIndex = 15;
            this.Lbl_Score.Text = "Your Score : ";
            this.Lbl_Score.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_Close
            // 
            this.Lbl_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_Close.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Close.ForeColor = System.Drawing.Color.White;
            this.Lbl_Close.Location = new System.Drawing.Point(255, 0);
            this.Lbl_Close.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Lbl_Close.Name = "Lbl_Close";
            this.Lbl_Close.Size = new System.Drawing.Size(25, 25);
            this.Lbl_Close.TabIndex = 14;
            this.Lbl_Close.Text = "x";
            this.Lbl_Close.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lbl_Close.Click += new System.EventHandler(this.Lbl_Close_Click);
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.White;
            this.Lbl_Title.Location = new System.Drawing.Point(6, 25);
            this.Lbl_Title.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(268, 25);
            this.Lbl_Title.TabIndex = 13;
            this.Lbl_Title.Text = "Game Over";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form_GameOver
            // 
            this.AcceptButton = this.Btn_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(288, 240);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_GameOver";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_GameOver";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_HighScore;
        private System.Windows.Forms.Label Lbl_Score;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Label Lbl_Close;
        private System.Windows.Forms.Button Btn_Ok;
    }
}