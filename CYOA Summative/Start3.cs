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
    public partial class hallway3 : Form
    {
        public hallway3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            //pull up new text
            whatdo.Visible = true;
            next.Visible = false;
            //pull up buttons
            search.Visible = true;
            follow.Visible = true;
            away.Visible = true;
            leave.Visible = true;
            back.Visible = true;
        }

        private void inventory_Click(object sender, EventArgs e)
        {
            //open the inventory
            g.inv.ShowDialog();
        }

        private void leave_Click(object sender, EventArgs e)
        {
            //exit the game to main menu copy and paaste
            if (MessageBox.Show("Are you sure you would like to exit? All progress will be lost.", "Exit to Main Menu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            //bring the user back to the previous form
            this.Hide();
            hallway2 hallway2 = new hallway2();
            hallway2.ShowDialog();
        }

        private void search_Click(object sender, EventArgs e)
        {
            // i copied and pasted code from start
            if (g.chloroform == false)
            {
                //open line of text that associates with the search button
                
                g.chloroform = true;

                searchtext.Visible = true;
                Refresh();
                //show the player their prized chloroform
                System.Threading.Thread.Sleep(3000);
                item.Visible = true;
                
                chlorobtain.Visible = true;
                Refresh();
                //close the image
                System.Threading.Thread.Sleep(3000);
                item.Visible = false;
                chlorobtain.Visible = false;
                g.inv.chloroformitem.Visible = true;
            }
            else
            {
                searchtext.Visible = true;
                
                searchtext.Text = "You've already done this!";
            }
        }

        private void away_Click(object sender, EventArgs e)
        {
            //pull up text for button
            oppositetext.Visible = true;
            searchtext.Visible = false;
            //hide other buttons
            search.Visible = false;
            follow.Visible = false;
            away.Visible = false;
            back.Visible = false;
            //pull up option buttons
            stand.Visible = true;
            run.Visible = true;
        }

        private void follow_Click(object sender, EventArgs e)
        {
            this.Hide();
            //pull up next form
            doorway doorway = new doorway();
            doorway.ShowDialog();
        }

        private void run_Click(object sender, EventArgs e)
        {
            this.Hide();
            //bring the player to their death
            Death death = new Death();
            death.ShowDialog();
        }

        private void stand_Click(object sender, EventArgs e)
        {
            //pull up the new form
            this.Hide();
            //pull up next form
            doorway doorway = new doorway();
            doorway.ShowDialog();

        }
    }
}
