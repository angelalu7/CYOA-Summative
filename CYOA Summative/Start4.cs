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
    public partial class doorway : Form
    {
        
        public doorway()
        {
            InitializeComponent();
        }

        private void monster_Click(object sender, EventArgs e)
        {

        }

        private void monsterright_Tick(object sender, EventArgs e)
        {
            //make monster go right
            monster.Left += 6;

            //when monster hits edge, turn around
            if (monster.Right >= this.Width)
            {
                monsterright.Stop();
                monsterleft.Start();

                monster.Image = Properties.Resources.monster;
            }

        }

        private void monsterleft_Tick(object sender, EventArgs e)
        {
            //make monster go left
            monster.Left -= 6;
            //monster edge turn around
            if (monster.Left <= 0)
            {
                monsterleft.Stop();
                monsterright.Start();

                monster.Image = Properties.Resources._5fa183f3dc0a2543091950;
            }
        }

        private void inventory_Click(object sender, EventArgs e)
        {
            //open the inventory
            g.inv.ShowDialog();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            //bring user back to previous form
            hallway3 hallway3 = new hallway3();
            hallway3.ShowDialog();
        }

        private void leave_Click(object sender, EventArgs e)
        {
            //exit the game to main menu copy and paaste
            if (MessageBox.Show("Are you sure you would like to exit? All progress will be lost.", "Exit to Main Menu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void mercy_Click(object sender, EventArgs e)
        {
            //pull up text for mercy button
            mercytext.Visible = true;
            res.Visible = false;
            distracttext.Visible = false;
            searchtext.Visible = false;
        }

        private void distract_Click(object sender, EventArgs e)
        {
            //pull up new text
            mercytext.Visible = false;
            distracttext.Visible = true;
            res.Visible = false;
            //set state to CORN as the only correct choice
            g.state = "corn";
            
            
        }

        private void search_Click(object sender, EventArgs e)
        {
            //pull up text
            searchtext.Visible = true;
            mercytext.Visible = false;
            distracttext.Visible = false;
            res.Visible = false;
            
        }

        private void corntimer_Tick(object sender, EventArgs e)
        {
            //to throw corn at beast
            if (g.cornused == true)
            {
                throwtxt.Visible = false;
                distracttext.Visible = false;
                searchtext.Visible = false;
                mercytext.Visible = false;
                
                //changev this form
                res.Visible = true;
                res.Text = "You distract the monster using the corn. Hopefully he's a vegetarian. What next?";
                monsterright.Stop();
                monsterleft.Stop();
                corn1.Visible = true;
                monster.Image = Properties.Resources._5fa183f3dc0a2543091950;
                monster.Left = -59;
                //take away other options
                mercy.Visible = false;
                distract.Visible = false;
                // pull up new options
                run.Visible = true;
                throwsmth.Visible = true;
                //remove corn from inv 
                g.inv.cornitem.Visible = false;
                // turn this timer off
                corntimer.Stop();
            }
            else
            {
                //if they pick the wrong item
                if (g.rockused == true)
                {
                    throwtxt.Visible = false;
                    distracttext.Visible = false;
                    searchtext.Visible = false;
                    mercytext.Visible = false;
                    res.Visible = true;
                    res.Text = "That won't work here... Try again!";
                    
                    

                    g.rockused = false;

                }
                else if (g.chloroformused == true)
                {
                    throwtxt.Visible = false;
                    distracttext.Visible = false;
                    searchtext.Visible = false;
                    mercytext.Visible = false;
                    res.Visible = true;
                    res.Text = "That won't work here... Try again!";
                    


                    g.chloroformused = false;
                }
            }
        }

        private void doorway_Load(object sender, EventArgs e)
        {

        }

        private void run_Click(object sender, EventArgs e)
        {
            this.Hide();
            //death form
            RunAway runaway = new RunAway();
            runaway.ShowDialog();
        }

        private void throwsmth_Click(object sender, EventArgs e)
        {
            if (g.rock == true)
            {
                //throw rock and hit monster
                throwtxt.Visible = true;
                distracttext.Visible = false;
                searchtext.Visible = false;
                mercytext.Visible = false;
                res.Visible = false;
                
                nothrow.Visible = false;
                rockpic.Visible = true;
                monster.Image = Properties.Resources.monster2;
                g.inv.rockitem.Visible = false;

                // TAKE AWAY REST OF OPTIONS
                search.Visible = false;
                run.Visible = false;
                throwsmth.Visible = false;

                // show continue button
                next.Visible = true;
            }
            else 
            {
                //tell them they need a rock
                throwtxt.Visible = false;
                distracttext.Visible = false;
                searchtext.Visible = false;
                mercytext.Visible = false;
                res.Visible = false;
                nothrow.Visible = true;
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            //open next form
            this.Hide();
            Entrance entrance = new Entrance();
            entrance.ShowDialog();
        }
    }
}
