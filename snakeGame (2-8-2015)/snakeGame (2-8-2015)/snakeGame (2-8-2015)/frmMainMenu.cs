using System;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace snakeGame__2_8_2015_
{
    public partial class frmMainMenu : Form
    {
        
        public frmMainMenu()
        {
            Thread thread = new Thread(new ThreadStart(SplashScreen));
            thread.Start();
            Thread.Sleep(4000);
            thread.Abort();
            
            InitializeComponent();
            displayFrmMenu(true, true, true, true, false, false, false,false);

        }
        private void SplashScreen()
        {
            try
            {
                  Application.Run(new frmSplash());
            }
            catch (Exception)
            {

                throw;
            }
           
        }

       

        private void pbBtnPlay_MouseEnter(object sender, EventArgs e)
        {
            pbBtnPlay.Image = snakeGame__2_8_2015_.Properties.Resources.btnPlaynewPressed;
        }

        private void pbBtnPlay_MouseLeave(object sender, EventArgs e)
        {
            pbBtnPlay.Image = snakeGame__2_8_2015_.Properties.Resources.btnPlaynew;
        }

        private void pbBtnHighScore_MouseEnter(object sender, EventArgs e)
        {
            pbBtnHighScore.Image = snakeGame__2_8_2015_.Properties.Resources.btnHighScorenewPressed;
        }

        private void pbBtnHighScore_MouseLeave(object sender, EventArgs e)
        {
            pbBtnHighScore.Image = snakeGame__2_8_2015_.Properties.Resources.btnHighScorenew;
        }

        private void pbBtnComputerPlay_MouseEnter(object sender, EventArgs e)
        {
            pbBtnComputerPlay.Image = snakeGame__2_8_2015_.Properties.Resources.btnComptuterTestPressed;
        }

        private void pbBtnComputerPlay_MouseLeave(object sender, EventArgs e)
        {
            pbBtnComputerPlay.Image = snakeGame__2_8_2015_.Properties.Resources.btnComptuterTest;
        }

        private void pbBtnInstructions_MouseEnter(object sender, EventArgs e)
        {
            pbBtnInstructions.Image = snakeGame__2_8_2015_.Properties.Resources.btnInstructionsnewPressed;
        }

        private void pbBtnInstructions_MouseLeave(object sender, EventArgs e)
        {
            pbBtnInstructions.Image = snakeGame__2_8_2015_.Properties.Resources.btnInstructionsnew;
        }

        private void pbBtnPlay_Click(object sender, EventArgs e)
        {
            frmGamePlay gamePlay = new frmGamePlay();
            gamePlay.Show();
            this.Hide();
           // play();
        }
        public void play()
        {
            pbBtnComputerPlay.Visible = false;
            pbBtnHighScore.Visible = false;
            pbBtnInstructions.Visible = false;
            pbBtnPlay.Visible = false;
            pbMainMenu.Image = snakeGame__2_8_2015_.Properties.Resources.gameBg;
        }

        public void displayFrmMenu (bool play ,bool cPlay ,bool higScore, bool ins,bool score, bool _lblScoreText, bool _pbBack, bool _pbInstructions)
        {
            pbBtnComputerPlay.Visible = cPlay;
            pbBtnHighScore.Visible = higScore;
            pbBtnInstructions.Visible = ins;
            pbBtnPlay.Visible = play;
            lblScore.Visible = score;
            lblScoreText.Visible = _lblScoreText;
            pbBack.Visible = _pbBack;
            pbInstructions.Visible = _pbInstructions;
        }
        private void pbBtnHighScore_Click(object sender, EventArgs e)
        {
            displayFrmMenu(false, false, false, false, true, false,true,false);
            StreamReader fileRead = new StreamReader("score.txt");
            int fileScore = Convert.ToInt32(fileRead.ReadLine());
            lblScoreText.Text = fileScore.ToString();
            fileRead.Close();
            lblScoreText.Visible = true;
        }

        private void pbBtnComputerPlay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature Under Developmnt","Inforamtion",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void pbBtnInstructions_Click(object sender, EventArgs e)
        {
            displayFrmMenu(false, false, false, false, false, false,true,true);

        }

        private void pbBack_MouseEnter(object sender, EventArgs e)
        {
            pbBack.Image = snakeGame__2_8_2015_.Properties.Resources.skleftbtnclk2;
        }

        private void pbBack_MouseLeave(object sender, EventArgs e)
        {
            pbBack.Image = snakeGame__2_8_2015_.Properties.Resources.skleftbtnclk1;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            displayFrmMenu(true, true, true, true, false, false, false,false);
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure want to exit ? ","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
