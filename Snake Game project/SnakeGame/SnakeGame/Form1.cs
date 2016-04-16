using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboSelectDificulty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbFullScreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCustomSize.Checked == true)
            {
                lblHeight.Visible = true;
                lblWidth.Visible = true;
                comboHeight.Visible = true;
                comboWidth.Visible = true;
            }
           
            else
            {
                lblHeight.Visible = false;
                lblWidth.Visible = false;
                comboHeight.Visible = false;
                comboWidth.Visible = false;          }
        }

       

        
      
    }
}
