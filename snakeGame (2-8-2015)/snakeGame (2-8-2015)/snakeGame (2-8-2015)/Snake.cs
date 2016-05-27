using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace snakeGame__2_8_2015_
{
    public class Snake : Form 
    {
        private Rectangle[] snakeRec;
        Image imgSnakeRec;
        Image imgSnakeMouth;
        Image imgSnakeTale;
        private SolidBrush brush;
        Form obj = new Form();
        //private Image snakeMouth = snakeGame__2_8_2015_.Properties.Resources.newSnakeMouth;
        // private SolidBrush Xbrush;
        Pen pen;
        private int x, y, width, height;

        public Rectangle[] SnakeRec
        {
            get { return snakeRec; }
        }

        private int snakePosX, snakePosY, snakeRecLenht;

        public int snakeRecLenhtSnakeRecLenght
        {
            get { return snakeRecLenht; }
            set { snakeRecLenht = snakeRec.Length - 1; }
        } 

        public int SnakeRecZeroPosX
        {
            get { return snakeRec[0].X; }
            set { snakePosX = snakeRec[0].X; }
        }
        public int SnakeRecZeroPosY
        {
            get { return snakeRec[0].Y; }
            set { snakePosY = snakeRec[0].Y; }
        }

        public Snake()
        {
            imgSnakeRec = snakeGame__2_8_2015_.Properties.Resources.newSnakeRec;
            imgSnakeMouth = snakeGame__2_8_2015_.Properties.Resources.newSnakeMouth;
            imgSnakeTale = snakeGame__2_8_2015_.Properties.Resources.newSnakeTale;

            pen = new Pen(Color.White, 3);

            snakeRec = new Rectangle[3];
            brush = new SolidBrush(Color.White);
            x = 100;
            y = 0;
            width = 40;
            height = 40;


            for (int i = 0; i < snakeRec.Length; i++)
            {
                //SnakeRec[0] = new Rectangle(snakeMouth,);
                snakeRec[i] = new Rectangle(x, y, width, height);
                x -= 50;
            }
        }
        public void drawSnake(Graphics paper)
        {
           

            paper.DrawImage(imgSnakeMouth, snakeRec[0]);
            int lenght = snakeRec.Length - 1;
            paper.DrawImage(imgSnakeTale, snakeRec[lenght]);


            for (int i = 1; i < snakeRec.Length - 1; i++)
            {
                paper.DrawImage(imgSnakeRec, snakeRec[i]);
            }
        }
        public void drawSnake()
        {
            for (int i = snakeRec.Length - 1; i > 0; i--)
            {
                snakeRec[i] = snakeRec[i - 1];
            }
        }
        public void moveDown()
        {
            imgSnakeMouth = snakeGame__2_8_2015_.Properties.Resources.newSnakeMouthDown;
            drawSnake();
            snakeRec[0].Y += 50;
        }
        public void moveDown(int foodY)
        {
            if (snakeRec[0].Y == foodY)
            {
                return;
            }
            drawSnake();
            snakeRec[0].Y += 50;
        }
        public void moveUp()
        {
            imgSnakeMouth = snakeGame__2_8_2015_.Properties.Resources.newSnakeMouthUp;
            drawSnake();
            snakeRec[0].Y -= 50;
        }
        public void moveRight(int foodX)
        {
            if (snakeRec[0].X == foodX)
            {
                return;
            }
            drawSnake();
            snakeRec[0].X += 50;
        }
        public void moveRight()
        {
            imgSnakeMouth = snakeGame__2_8_2015_.Properties.Resources.newSnakeMouth;
            drawSnake();
            snakeRec[0].X += 50;
        }
        public void moveLeft()
        {
            imgSnakeMouth = snakeGame__2_8_2015_.Properties.Resources.newSnakeMouthRight;
            drawSnake();
            snakeRec[0].X -= 50;
        }

        public void growSnake()
        {
            List<Rectangle> rec = snakeRec.ToList();
            rec.Add(new Rectangle(snakeRec[snakeRec.Length - 1].X, snakeRec[snakeRec.Length - 1].Y, width, height));
            snakeRec = rec.ToArray();
        }
    }
}
