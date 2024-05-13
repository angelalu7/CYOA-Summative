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
    public partial class beginning : Form
    {
        public beginning()
        {
            InitializeComponent();
        }

        private void next_Click(object sender, EventArgs e)
        {
            //pull up new line of text
            backstory.Visible = false;
            whatdo.Visible = true;
            next.Visible = false;
            //pull up player's options
            search.Visible = true;
            cry.Visible = true;
            venture.Visible = true;
            leave.Visible = true;
        }

        private void leave_Click(object sender, EventArgs e)
        {
            //close program if they want to leave
            if (MessageBox.Show("Are you sure you would like to exit? All progress will be lost.","Exit to Main Menu",MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (g.corn==false)
            { 
            //open line of text that associates with the search button
            crytext.Visible = false;
                g.corn = true;
            
            searchtext.Visible = true;
            Refresh();
            //show the player their prized ear of corn
            System.Threading.Thread.Sleep(3000);
            item.Visible = true;
            item.Image = Properties.Resources.corn;
            cornobtain.Visible = true;
            Refresh();
            //close the image
            System.Threading.Thread.Sleep(3000);
            item.Visible = false;
            cornobtain.Visible = false;
            g.inv.cornitem.Visible = true;
            }
            //dont let get item 2x
            else 
            {
                searchtext.Visible = true;
                crytext.Visible = false;
                searchtext.Text = "You've already done this!";
            }
        }

        private void cry_Click(object sender, EventArgs e)
        {
            if (g.rock == false)
            { 
            //copy and paste code from search button bc it's pretty much the same 
            //open line of text that associates with the cry button
            searchtext.Visible = false;
                g.rock = true;
            crytext.Visible = true;
            Refresh();
            //show the player their prized rock
            System.Threading.Thread.Sleep(3000);
            item.Visible = true;
            item.Image = Properties.Resources.rock;
            rockobtain.Visible = true;
            Refresh();
            //close the image
            System.Threading.Thread.Sleep(3000);
            item.Visible = false;
            rockobtain.Visible = false;
            //g.inv.label1.visible=true; BUT NEEDS TO BE MODIFIER= PUBLIC
            //put in inventory
            g.inv.rockitem.Visible = true;
            }

            else 
            {
                crytext.Visible = true;
                searchtext.Visible = false;
                crytext.Text = "You've already cried enough. Suck it up.";
            }
        }

        private void venture_Click(object sender, EventArgs e)
        {
            this.Hide();
            //open new form to further the storyline
            hallway2 hallway2 = new hallway2();
            hallway2.ShowDialog();
            
        }

        private void inventory_Click(object sender, EventArgs e)
        {
            // open the global inventory
            g.inv.ShowDialog();

        }
    }
}
