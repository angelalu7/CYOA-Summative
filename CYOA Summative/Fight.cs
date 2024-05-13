using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CYOA_Summative
{
    public partial class Fight : Form
    {
        int h = 10;
        public Fight()
        {
            InitializeComponent();
        }

        private void sword_Click(object sender, EventArgs e)
        {
            //check if they have a sword
            if (g.sword == true)
            {
                swordtxt.Visible = true;
                handtxt.Visible = false;
                next.Visible = true;
                sword.Visible = false;
                hand.Visible = false;
            }
            //otherwise tell them they dont
            else
            {
                nosword.Visible = true;
                swordtxt.Visible = false;
                sword.Visible = false;
            }
        }

        private void hand_Click(object sender, EventArgs e)
        {
            //take away other buttons
            swordtxt.Visible = false;
            next.Visible = true;
            sword.Visible = false;
            hand.Visible = false;
            handtxt.Visible = true;
            nosword.Visible = false;
        }

        private void minotaur_Click(object sender, EventArgs e)
        {
            //remove health every time user clicjks minotaur
            if (h == 10)
            {
                health.Image = Properties.Resources._9;
            }
            else if (h==9)
            {
                health.Image = Properties.Resources._8;
            }
            else if (h == 8)
            {
                health.Image = Properties.Resources._7;
            }
            else if (h == 7)
            {
                health.Image = Properties.Resources._6;
            }
            else if (h == 6)
            {
                health.Image = Properties.Resources._5;
            }
            else if (h == 5)
            {
                health.Image = Properties.Resources._4;
            }
            else if (h == 4)
            {
                health.Image = Properties.Resources._3;
            }
            else if (h == 3)
            {
                health.Image = Properties.Resources._2;
            }
            else if (h == 2)
            {
                health.Image = Properties.Resources._1;
            }
            //say they won and remove minotaur
            else if (h == 1)
            {
                minotaur.Visible = false;
                health.Visible = false;
                background.Visible = true;
                win.Visible = true;
                okk.Visible = true;
            }
            //numerical manip 
            h--;
                
        }

        private void next_Click(object sender, EventArgs e)
        {
            //get rid of everything
            swordtxt.Visible = false;
            next.Visible = false;
            sword.Visible = false;
            hand.Visible = false;
            handtxt.Visible = false;
            background.Visible = false;
            nosword.Visible = false;
            fighttxt.Visible = false;

            //minotaur health bar
            health.Visible = true;
        }

        private void okk_Click(object sender, EventArgs e)
        {
            //open victory form
            this.Hide();
            victory victory = new victory();
            victory.ShowDialog();
        }
    }
}
