namespace SnakeGame
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.comboSelectPlayer = new System.Windows.Forms.ComboBox();
            this.comboSelectDificulty = new System.Windows.Forms.ComboBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.comboHeight = new System.Windows.Forms.ComboBox();
            this.comboWidth = new System.Windows.Forms.ComboBox();
            this.txtBoxDisplay = new System.Windows.Forms.TextBox();
            this.rbFullScreen = new System.Windows.Forms.RadioButton();
            this.rbCustomSize = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Snake Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select Difficulty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(183, 223);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // comboSelectPlayer
            // 
            this.comboSelectPlayer.FormattingEnabled = true;
            this.comboSelectPlayer.Items.AddRange(new object[] {
            "User",
            "System"});
            this.comboSelectPlayer.Location = new System.Drawing.Point(174, 56);
            this.comboSelectPlayer.Name = "comboSelectPlayer";
            this.comboSelectPlayer.Size = new System.Drawing.Size(121, 21);
            this.comboSelectPlayer.TabIndex = 5;
            // 
            // comboSelectDificulty
            // 
            this.comboSelectDificulty.FormattingEnabled = true;
            this.comboSelectDificulty.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboSelectDificulty.Location = new System.Drawing.Point(174, 83);
            this.comboSelectDificulty.Name = "comboSelectDificulty";
            this.comboSelectDificulty.Size = new System.Drawing.Size(121, 21);
            this.comboSelectDificulty.TabIndex = 6;
            
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(248, 163);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 7;
            this.lblHeight.Text = "Height";
           
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(251, 202);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 8;
            this.lblWidth.Text = "Width";
            // 
            // comboHeight
            // 
            this.comboHeight.FormattingEnabled = true;
            this.comboHeight.Items.AddRange(new object[] {
            "100",
            "200",
            "300"});
            this.comboHeight.Location = new System.Drawing.Point(292, 160);
            this.comboHeight.Name = "comboHeight";
            this.comboHeight.Size = new System.Drawing.Size(121, 21);
            this.comboHeight.TabIndex = 9;
            // 
            // comboWidth
            // 
            this.comboWidth.FormattingEnabled = true;
            this.comboWidth.Items.AddRange(new object[] {
            "100",
            "200",
            "300"});
            this.comboWidth.Location = new System.Drawing.Point(292, 199);
            this.comboWidth.Name = "comboWidth";
            this.comboWidth.Size = new System.Drawing.Size(121, 21);
            this.comboWidth.TabIndex = 10;
            // 
            // txtBoxDisplay
            // 
            this.txtBoxDisplay.Location = new System.Drawing.Point(58, 252);
            this.txtBoxDisplay.Multiline = true;
            this.txtBoxDisplay.Name = "txtBoxDisplay";
            this.txtBoxDisplay.Size = new System.Drawing.Size(334, 93);
            this.txtBoxDisplay.TabIndex = 11;
            // 
            // rbFullScreen
            // 
            this.rbFullScreen.AutoSize = true;
            this.rbFullScreen.Location = new System.Drawing.Point(91, 137);
            this.rbFullScreen.Name = "rbFullScreen";
            this.rbFullScreen.Size = new System.Drawing.Size(78, 17);
            this.rbFullScreen.TabIndex = 12;
            this.rbFullScreen.TabStop = true;
            this.rbFullScreen.Text = "Full Screen";
            this.rbFullScreen.UseVisualStyleBackColor = true;
            this.rbFullScreen.CheckedChanged += new System.EventHandler(this.rbFullScreen_CheckedChanged);
            // 
            // rbCustomSize
            // 
            this.rbCustomSize.AutoSize = true;
            this.rbCustomSize.Location = new System.Drawing.Point(280, 137);
            this.rbCustomSize.Name = "rbCustomSize";
            this.rbCustomSize.Size = new System.Drawing.Size(83, 17);
            this.rbCustomSize.TabIndex = 13;
            this.rbCustomSize.TabStop = true;
            this.rbCustomSize.Text = "Custom Size";
            this.rbCustomSize.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 357);
            this.Controls.Add(this.rbCustomSize);
            this.Controls.Add(this.rbFullScreen);
            this.Controls.Add(this.txtBoxDisplay);
            this.Controls.Add(this.comboWidth);
            this.Controls.Add(this.comboHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.comboSelectDificulty);
            this.Controls.Add(this.comboSelectPlayer);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ComboBox comboSelectPlayer;
        private System.Windows.Forms.ComboBox comboSelectDificulty;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.ComboBox comboHeight;
        private System.Windows.Forms.ComboBox comboWidth;
        private System.Windows.Forms.TextBox txtBoxDisplay;
        private System.Windows.Forms.RadioButton rbFullScreen;
        private System.Windows.Forms.RadioButton rbCustomSize;
    }
}

