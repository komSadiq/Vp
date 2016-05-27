namespace snakeGame__2_8_2015_
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.timerSnakeMovement = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreText = new System.Windows.Forms.Label();
            this.pbInstructions = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbBtnInstructions = new System.Windows.Forms.PictureBox();
            this.pbBtnHighScore = new System.Windows.Forms.PictureBox();
            this.pbBtnComputerPlay = new System.Windows.Forms.PictureBox();
            this.pbBtnPlay = new System.Windows.Forms.PictureBox();
            this.pbMainMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbInstructions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnInstructions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnHighScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnComputerPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblScore.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblScore.Location = new System.Drawing.Point(12, 151);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(572, 135);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "High Socre";
            this.lblScore.Visible = false;
            // 
            // lblScoreText
            // 
            this.lblScoreText.AutoSize = true;
            this.lblScoreText.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreText.Location = new System.Drawing.Point(590, 151);
            this.lblScoreText.Name = "lblScoreText";
            this.lblScoreText.Size = new System.Drawing.Size(116, 135);
            this.lblScoreText.TabIndex = 6;
            this.lblScoreText.Text = "0";
            this.lblScoreText.Visible = false;
            // 
            // pbInstructions
            // 
            this.pbInstructions.BackColor = System.Drawing.Color.OliveDrab;
            this.pbInstructions.Image = global::snakeGame__2_8_2015_.Properties.Resources.inst;
            this.pbInstructions.Location = new System.Drawing.Point(160, 26);
            this.pbInstructions.Name = "pbInstructions";
            this.pbInstructions.Size = new System.Drawing.Size(608, 366);
            this.pbInstructions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInstructions.TabIndex = 8;
            this.pbInstructions.TabStop = false;
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.OliveDrab;
            this.pbBack.Image = global::snakeGame__2_8_2015_.Properties.Resources.skleftbtnclk1;
            this.pbBack.Location = new System.Drawing.Point(12, 475);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(100, 63);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 7;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            this.pbBack.MouseEnter += new System.EventHandler(this.pbBack_MouseEnter);
            this.pbBack.MouseLeave += new System.EventHandler(this.pbBack_MouseLeave);
            // 
            // pbBtnInstructions
            // 
            this.pbBtnInstructions.Image = global::snakeGame__2_8_2015_.Properties.Resources.btnInstructionsnew;
            this.pbBtnInstructions.Location = new System.Drawing.Point(515, 202);
            this.pbBtnInstructions.Name = "pbBtnInstructions";
            this.pbBtnInstructions.Size = new System.Drawing.Size(289, 42);
            this.pbBtnInstructions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBtnInstructions.TabIndex = 4;
            this.pbBtnInstructions.TabStop = false;
            this.pbBtnInstructions.Click += new System.EventHandler(this.pbBtnInstructions_Click);
            this.pbBtnInstructions.MouseEnter += new System.EventHandler(this.pbBtnInstructions_MouseEnter);
            this.pbBtnInstructions.MouseLeave += new System.EventHandler(this.pbBtnInstructions_MouseLeave);
            // 
            // pbBtnHighScore
            // 
            this.pbBtnHighScore.Image = global::snakeGame__2_8_2015_.Properties.Resources.btnHighScorenew;
            this.pbBtnHighScore.Location = new System.Drawing.Point(160, 202);
            this.pbBtnHighScore.Name = "pbBtnHighScore";
            this.pbBtnHighScore.Size = new System.Drawing.Size(289, 42);
            this.pbBtnHighScore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBtnHighScore.TabIndex = 3;
            this.pbBtnHighScore.TabStop = false;
            this.pbBtnHighScore.Click += new System.EventHandler(this.pbBtnHighScore_Click);
            this.pbBtnHighScore.MouseEnter += new System.EventHandler(this.pbBtnHighScore_MouseEnter);
            this.pbBtnHighScore.MouseLeave += new System.EventHandler(this.pbBtnHighScore_MouseLeave);
            // 
            // pbBtnComputerPlay
            // 
            this.pbBtnComputerPlay.Image = global::snakeGame__2_8_2015_.Properties.Resources.btnComptuterTest;
            this.pbBtnComputerPlay.Location = new System.Drawing.Point(515, 106);
            this.pbBtnComputerPlay.Name = "pbBtnComputerPlay";
            this.pbBtnComputerPlay.Size = new System.Drawing.Size(289, 42);
            this.pbBtnComputerPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBtnComputerPlay.TabIndex = 2;
            this.pbBtnComputerPlay.TabStop = false;
            this.pbBtnComputerPlay.Click += new System.EventHandler(this.pbBtnComputerPlay_Click);
            this.pbBtnComputerPlay.MouseEnter += new System.EventHandler(this.pbBtnComputerPlay_MouseEnter);
            this.pbBtnComputerPlay.MouseLeave += new System.EventHandler(this.pbBtnComputerPlay_MouseLeave);
            // 
            // pbBtnPlay
            // 
            this.pbBtnPlay.Image = global::snakeGame__2_8_2015_.Properties.Resources.btnPlaynew;
            this.pbBtnPlay.Location = new System.Drawing.Point(160, 106);
            this.pbBtnPlay.Name = "pbBtnPlay";
            this.pbBtnPlay.Size = new System.Drawing.Size(289, 42);
            this.pbBtnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBtnPlay.TabIndex = 1;
            this.pbBtnPlay.TabStop = false;
            this.pbBtnPlay.Click += new System.EventHandler(this.pbBtnPlay_Click);
            this.pbBtnPlay.MouseEnter += new System.EventHandler(this.pbBtnPlay_MouseEnter);
            this.pbBtnPlay.MouseLeave += new System.EventHandler(this.pbBtnPlay_MouseLeave);
            // 
            // pbMainMenu
            // 
            this.pbMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbMainMenu.Image")));
            this.pbMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pbMainMenu.Name = "pbMainMenu";
            this.pbMainMenu.Size = new System.Drawing.Size(884, 561);
            this.pbMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMainMenu.TabIndex = 0;
            this.pbMainMenu.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pbInstructions);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.lblScoreText);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbBtnInstructions);
            this.Controls.Add(this.pbBtnHighScore);
            this.Controls.Add(this.pbBtnComputerPlay);
            this.Controls.Add(this.pbBtnPlay);
            this.Controls.Add(this.pbMainMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbInstructions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnInstructions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnHighScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnComputerPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMainMenu;
        private System.Windows.Forms.PictureBox pbBtnPlay;
        private System.Windows.Forms.PictureBox pbBtnComputerPlay;
        private System.Windows.Forms.PictureBox pbBtnHighScore;
        private System.Windows.Forms.PictureBox pbBtnInstructions;
        private System.Windows.Forms.Timer timerSnakeMovement;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreText;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbInstructions;
    }
}