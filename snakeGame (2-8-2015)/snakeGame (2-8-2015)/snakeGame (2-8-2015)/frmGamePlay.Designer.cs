namespace snakeGame__2_8_2015_
{
    partial class frmGamePlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGamePlay));
            this.timer_SnakeMovement = new System.Windows.Forms.Timer(this.components);
            this.pbSpaceBar = new System.Windows.Forms.PictureBox();
            this.lblScoreTag = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpaceBar)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_SnakeMovement
            // 
            this.timer_SnakeMovement.Interval = 300;
            this.timer_SnakeMovement.Tick += new System.EventHandler(this.timer_SnakeMovement_Tick);
            // 
            // pbSpaceBar
            // 
            this.pbSpaceBar.BackColor = System.Drawing.Color.Transparent;
            this.pbSpaceBar.Image = global::snakeGame__2_8_2015_.Properties.Resources.spaceBar;
            this.pbSpaceBar.Location = new System.Drawing.Point(186, 127);
            this.pbSpaceBar.Name = "pbSpaceBar";
            this.pbSpaceBar.Size = new System.Drawing.Size(556, 255);
            this.pbSpaceBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSpaceBar.TabIndex = 0;
            this.pbSpaceBar.TabStop = false;
            // 
            // lblScoreTag
            // 
            this.lblScoreTag.AutoSize = true;
            this.lblScoreTag.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreTag.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTag.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblScoreTag.Location = new System.Drawing.Point(665, 9);
            this.lblScoreTag.Name = "lblScoreTag";
            this.lblScoreTag.Size = new System.Drawing.Size(128, 45);
            this.lblScoreTag.TabIndex = 1;
            this.lblScoreTag.Text = "Score :";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScore.Location = new System.Drawing.Point(799, 14);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 40);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(665, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Level :";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLevel.Location = new System.Drawing.Point(799, 511);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(35, 40);
            this.lblLevel.TabIndex = 4;
            this.lblLevel.Text = "0";
            // 
            // frmGamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::snakeGame__2_8_2015_.Properties.Resources.gameBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblScoreTag);
            this.Controls.Add(this.pbSpaceBar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGamePlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGamePlay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGamePlay_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmGamePlay_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGamePlay_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbSpaceBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_SnakeMovement;
        private System.Windows.Forms.PictureBox pbSpaceBar;
        private System.Windows.Forms.Label lblScoreTag;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLevel;
    }
}