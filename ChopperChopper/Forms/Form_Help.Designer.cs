
namespace ChopperChopper.Forms
{
    partial class Form_Help
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
            this.Lbl_InstructionsUp = new System.Windows.Forms.Label();
            this.Lbl_Close = new System.Windows.Forms.Label();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Lbl_InstructionsDown = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.Lbl_InstructionsDown);
            this.panel1.Controls.Add(this.Btn_Ok);
            this.panel1.Controls.Add(this.Lbl_InstructionsUp);
            this.panel1.Controls.Add(this.Lbl_Close);
            this.panel1.Controls.Add(this.Lbl_Title);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 224);
            this.panel1.TabIndex = 1;
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.AutoSize = true;
            this.Btn_Ok.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ok.ForeColor = System.Drawing.Color.White;
            this.Btn_Ok.Location = new System.Drawing.Point(108, 176);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(96, 39);
            this.Btn_Ok.TabIndex = 1;
            this.Btn_Ok.Text = "OK";
            this.Btn_Ok.UseVisualStyleBackColor = false;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Lbl_InstructionsUp
            // 
            this.Lbl_InstructionsUp.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InstructionsUp.ForeColor = System.Drawing.Color.White;
            this.Lbl_InstructionsUp.Location = new System.Drawing.Point(6, 82);
            this.Lbl_InstructionsUp.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Lbl_InstructionsUp.Name = "Lbl_InstructionsUp";
            this.Lbl_InstructionsUp.Size = new System.Drawing.Size(300, 20);
            this.Lbl_InstructionsUp.TabIndex = 15;
            this.Lbl_InstructionsUp.Text = "Hold W or Up ↑ to Ascend";
            this.Lbl_InstructionsUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_Close
            // 
            this.Lbl_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_Close.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Close.ForeColor = System.Drawing.Color.White;
            this.Lbl_Close.Location = new System.Drawing.Point(286, 0);
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
            this.Lbl_Title.Size = new System.Drawing.Size(300, 25);
            this.Lbl_Title.TabIndex = 13;
            this.Lbl_Title.Text = "Chopper Chopper";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_InstructionsDown
            // 
            this.Lbl_InstructionsDown.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InstructionsDown.ForeColor = System.Drawing.Color.White;
            this.Lbl_InstructionsDown.Location = new System.Drawing.Point(6, 127);
            this.Lbl_InstructionsDown.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Lbl_InstructionsDown.Name = "Lbl_InstructionsDown";
            this.Lbl_InstructionsDown.Size = new System.Drawing.Size(300, 20);
            this.Lbl_InstructionsDown.TabIndex = 17;
            this.Lbl_InstructionsDown.Text = "Release to Descend";
            this.Lbl_InstructionsDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form_Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 230);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Help";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Ok;
        private System.Windows.Forms.Label Lbl_InstructionsUp;
        private System.Windows.Forms.Label Lbl_Close;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Label Lbl_InstructionsDown;
    }
}