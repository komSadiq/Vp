using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace snakeGame__2_8_2015_
{
    public partial class frmGamePlay : Form
    {
        Random randFood = new Random();
        int level ;
        Graphics paper;
        Snake snake = new Snake();
        Food food;
        int xPos;
        List<int> xPosChange = new List<int>();

        int snakeX, snakeY, foodX, foodY;
        int foodXposX, posY;
        Int64 score = 0;

        bool left = false;
        bool right = false;
        bool up = false;
        bool down = false;

        public frmGamePlay()
        {
            InitializeComponent();
            score = 0;
            level = 1;
            food = new Food(randFood);
            foodX = food.FoodPosX;
            foodY = food.FoodPosY;
        }

        public void highScore()

        {
            
            
            StreamReader fileRead = new StreamReader("score.txt");
            int fileScore = Convert.ToInt32(fileRead.ReadLine());
            fileRead.Close();
            if (score > fileScore)
            {
                StreamWriter fileWrite = new StreamWriter("score.txt");
                fileWrite.Write(score);
                fileWrite.Close();
            }
           
        }

        private void frmGamePlay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                timer_SnakeMovement.Enabled = true;
                pbSpaceBar.Visible = false;
                down = false;
                up = false;
                right = true;
                left = false;
            }
            if (e.KeyData == Keys.Down && up == false)
            {
                down = true;
                up = false;
                left = false;
                right = false;
            }
            if (e.KeyData == Keys.Up && down == false)
            {
                down = false;
                up = true;
                left = false;
                right = false;
            }
            if (e.KeyData == Keys.Left && right == false)
            {
                down = false;
                up = false;
                left = true;
                right = false;
            }
            if (e.KeyData == Keys.Right && left == false)
            {
                down = false;
                up = false;
                left = false;
                right = true;
            }

            #region For Multiple keys check
            if (e.KeyData == Keys.Up && e.KeyData == Keys.Right)
            {
                // do nothing
            }
            if (e.KeyData == Keys.Up && e.KeyData == Keys.Left)
            {
                // do nothing
            }
            if (e.KeyData == Keys.Down && e.KeyData == Keys.Left)
            {
                // do nothing
            }
            if (e.KeyData == Keys.Down && e.KeyData == Keys.Right)
            {
                // do nothing
            }
            if (e.KeyData == Keys.Up && e.KeyData == Keys.Right && e.KeyData == Keys.Left )
            {
                // do nothing
            }
            if (e.KeyData == Keys.Up && e.KeyData == Keys.Right && e.KeyData == Keys.Down)
            {
                // do nothing
            }
            if (e.KeyData == Keys.Up && e.KeyData == Keys.Left && e.KeyData == Keys.Right)
            {
                // do nothing
            }
            if (e.KeyData == Keys.Up && e.KeyData == Keys.Left && e.KeyData == Keys.Down)
            {
                // do nothing
            }
            if (e.KeyData == Keys.Down && e.KeyData == Keys.Left && e.KeyData == Keys.Right)
            {
                // do nothing
            }
            if (e.KeyData == Keys.Down && e.KeyData == Keys.Left && e.KeyData == Keys.Up)
            {
                // do nothing
            }
            if (e.KeyData == Keys.Down && e.KeyData == Keys.Right && e.KeyData == Keys.Left)
            {
                // do nothing
            }
            if (e.KeyData == Keys.Down && e.KeyData == Keys.Right && e.KeyData == Keys.Up)
            {
                // do nothing
            }

            #endregion

        }

        private void frmGamePlay_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMainMenu obj = new frmMainMenu();
            obj.Show();
            this.Dispose();
        }

        private void frmGamePlay_Paint(object sender, PaintEventArgs e)
        {
            paper = e.Graphics;
            snake.drawSnake(paper);
            food.drawFood(paper);
        }

        private void timer_SnakeMovement_Tick(object sender, EventArgs e)
        {
            if (up) { snake.moveUp();  }
            if (down) { snake.moveDown(); }
            if (left) { snake.moveLeft(); }
            if (right) { snake.moveRight(); }

            for (int i = 0; i < snake.SnakeRec.Length; i++)
            {
                if (snake.SnakeRec[i].IntersectsWith(food.foodRec))
                {
                    score += 10;
                    if (score ==100)
                    {
                        level++;
                        timer_SnakeMovement.Interval = 250;
                    }
                    else if (score == 300)
                    {
                        level++;
                        timer_SnakeMovement.Interval = 220;
                    }
                    else if (score == 500)
                    {
                        level++;
                        timer_SnakeMovement.Interval = 200;
                    }
                    else if (score == 700)
                    {
                        level++;
                        timer_SnakeMovement.Interval = 180;
                    }
                    else if (score == 1000)
                    {
                        level++;
                        timer_SnakeMovement.Interval = 170;
                    }
                    else if (score == 1200)
                    {
                        level++;
                        timer_SnakeMovement.Interval = 150;
                    }
                    else if (score == 1500)
                    {
                        level++;
                        timer_SnakeMovement.Interval = 140;
                    }
                    else if (score == 1700)
                    {
                        level++;
                        timer_SnakeMovement.Interval = 130;
                    }
                    else if (score == 2000)
                    {
                        level++;
                        timer_SnakeMovement.Interval = 120;
                    }
                    else if (score == 2500)
                    {
                        level++;
                        timer_SnakeMovement.Interval = 110;
                    }
                    else if (score == 3000)
                    {
                        level++;
                        timer_SnakeMovement.Interval = 100;
                    }
                    lblLevel.Text = level.ToString();
                    lblScore.Text = score.ToString();
                    snake.growSnake();
                    // check collase with snakeRec & redraw food
                    for (int j = 0; j < snake.SnakeRec.Length -1 ; j++)
                    {
                        if (snake.SnakeRec[i].X == foodX)
                        {
                            food.foodLocation(randFood);
                        }

                        if (snake.SnakeRec[i].X == foodY)
                        {
                            food.foodLocation(randFood);
                        }
                    }
                    food.foodLocation(randFood);
                }
            }
            collision();
            this.Invalidate();

        }
        public void collision()
        {
            // To detect snake collide with itself 
            for (int i = 1; i < snake.SnakeRec.Length; i++)
            {
                if (snake.SnakeRec[0].IntersectsWith(snake.SnakeRec[i]))
                {
                    highScore();
                    restart();
                }
            }

            // going out of bound loccation kill him :P
            if (snake.SnakeRec[0].X < 0 || snake.SnakeRec[0].X > 878)
            {
                highScore();
                restart();
            }
            if (snake.SnakeRec[0].Y < 0 || snake.SnakeRec[0].Y > 566)
            {
                highScore();
                restart();
            }
        }
        public void restart()
        {
            // On restart what to do ????
            timer_SnakeMovement.Enabled = false;
            MessageBox.Show("Snak is dead, Your score is "+ lblScore.Text);
           lblScore.Text = "0";
            score = 0;
            // lblSpaceBar.Text = "Press Space Bar To Begin";
            pbSpaceBar.Visible = true;
            snake = new Snake();
        }
    }
}
