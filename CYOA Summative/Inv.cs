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
    public partial class Inv : Form
    {
        public Inv()
        {
            InitializeComponent();
        }

        private void cornitem_Click(object sender, EventArgs e)
        {
            //when click, display item
            output.Text = "";
            disp.Visible = true;
            disp.Image = Properties.Resources.corn;
            output.Text = "CORN";
            //FOR DISTRACTION BUTTON
            if (g.state == "corn")
            {
                g.state = "";
                g.cornused = true;
                this.Hide();
            }
            else if(g.state == "chloroform" || g.state=="rock"||g.state == "sword")
            {
                this.Hide();
            }





        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //display
            output.Text = "";
            disp.Visible = true;
            g.chloroformused = true;
            disp.Image = Properties.Resources.chloroform;
            output.Text = "CHLOROFORM";
            //incorrect item
            if (g.state == "chloroform")
            {
                g.chloroformused = true;
                this.Close();
            }
            else if (g.state == "corn" || g.state == "rock" || g.state == "sword")
            {
                this.Hide();
            }


        }

        private void rockitem_Click(object sender, EventArgs e)
        {
            //display
            output.Text = "";
            disp.Visible = true;
            g.rockused = true;
            disp.Image = Properties.Resources.rock;
            output.Text = "ROCK";
            //incorrect item
            if (g.state == "rock")
            {
                g.rockused = true;
                this.Close();
            }
            else if (g.state == "corn" || g.state == "chloroform" || g.state == "sword")
            {
                this.Hide();
            }

        }

        private void sworditem_Click(object sender, EventArgs e)
        {
            //display
            output.Text = "";
            disp.Visible = true;
            disp.Image = Properties.Resources.sword;
            output.Text = "SWORD";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //get rid of stuff in displauy
            disp.Visible = false;
            output.Text = "";
            g.rockused = false;
            g.chloroformused = false;
            g.cornused = false;
            //close
            this.Close();
        }
    }
}
