using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventBehindButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
          
            private void button1_Click(object sender, EventArgs e)
            {
                MessageBox.Show("this os message box");
            }

            private void button2_Click(object sender, EventArgs e)
            {
                Button clickedButton = (Button)sender;
                clickedButton.Text = "...button clicked...";
                clickedButton.Enabled = true;
            }

            private void button3_Click(object sender, EventArgs e)
            {
                this.button3.Location = new System.Drawing.Point(180, 12);
                this.button2.Location = new System.Drawing.Point(29, 99);
            }

            private void button5_Click_1(object sender, EventArgs e)
            {
                Button btn5 = new Button();
                btn5.Show();
            }

            private void button4_Click(object sender, EventArgs e)
            {
                MessageBox.Show("are you sure you want to exit");
                Application.Exit();
            }



        }
    }


