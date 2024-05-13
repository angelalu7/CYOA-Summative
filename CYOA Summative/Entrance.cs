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
    public partial class Entrance : Form
    {
        public Entrance()
        {
            InitializeComponent();
        }

        private void inventory_Click(object sender, EventArgs e)
        {
            //open the inventory
            g.inv.ShowDialog();
        }

        private void corn1_Click(object sender, EventArgs e)
        {
            //when they click the sword, put it in their inventory
            sword1.Visible = false;
            g.inv.sworditem.Visible = true;
            g.sword = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //exit the game to main menu copy and paaste
            if (MessageBox.Show("Are you sure you would like to exit? All progress will be lost.", "Exit to Main Menu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            //bring back to old form
            this.Hide();
            doorway doorway = new doorway();
            doorway.ShowDialog();
        }

        private void paper_Click(object sender, EventArgs e)
        {
            //hide buttons and text
            background.Visible = false;
            narrative.Visible = false;
            paper.Visible = false;
            keypad.Visible = false;
            buttonpuz.Visible = false;
            exit.Visible = false;
            back.Visible = false;
            //pull up pic and ok
            cluepic.Visible = true;
            ok.Visible = true;
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (g.accept1 == true)
            {
                //show buttons and text
                background.Visible = true;
                narrative.Visible = true;
                paper.Visible = true;
                keypad.Visible = false;
                buttonpuz.Visible = true;
                exit.Visible = true;
                back.Visible = true;
                //hide pic
                cluepic.Visible = false;
                ok.Visible = false;
            }
            else if (g.enable == true)
            {
                //show buttons and text
                background.Visible = true;
                narrative.Visible = true;
                paper.Visible = true;
                keypad.Visible = true;
                buttonpuz.Visible = false;
                exit.Visible = true;
                back.Visible = true;
                //hide pic
                cluepic.Visible = false;
                ok.Visible = false;
            }
            else
            {
                //show buttons and text
                background.Visible = true;
                narrative.Visible = true;
                paper.Visible = true;
                keypad.Visible = true;
                buttonpuz.Visible = true;
                exit.Visible = true;
                back.Visible = true;
                //hide pic
                cluepic.Visible = false;
                ok.Visible = false;
            }
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            //exit the game to main menu copy and paaste
            if (MessageBox.Show("Are you sure you would like to exit? All progress will be lost.", "Exit to Main Menu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            //send back
            //bring back to old form
            this.Hide();
            doorway doorway = new doorway();
            doorway.ShowDialog();
        }

        private void keypad_Click(object sender, EventArgs e)
        {
            //open keypad
            Keypad keypad = new Keypad();
            keypad.ShowDialog();
        }

        private void keypadgood_Tick(object sender, EventArgs e)
        {
            //when they enter the correct answer, change the base form
            if (g.accept1 == true)
            {
                //change form
                keypad.Visible = false;
                //turn timer off
                keypadgood.Stop();
            }
        }

        private void buttongood_Tick(object sender, EventArgs e)
        {
            //when button entered correct. change base
            if (g.enable == true)
            {
                //change form
                buttonpuz.Visible = false;
                //turn timer off
                buttongood.Stop();
            }
        }

        private void buttonpuz_Click(object sender, EventArgs e)
        {
            //open button puzzle
            buttonpuzzle puzzle2 = new buttonpuzzle();
            puzzle2.ShowDialog();
        }

        private void complete_Tick(object sender, EventArgs e)
        {
            if(g.accept1==true && g.enable == true)
            {
                //change form
                paper.Visible = false;
                success.Visible = true;
                next.Visible = true;
                keypad.Visible = false;
                buttonpuz.Visible = false;
                //stop timer
                complete.Stop();
            }
        }

        private void next_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            //next form
            FInal final = new FInal();
            final.ShowDialog();
        }
    }
}
