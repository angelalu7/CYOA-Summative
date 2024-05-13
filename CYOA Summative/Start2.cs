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
    public partial class hallway2 : Form
    {
        public hallway2()
        {
            InitializeComponent();
        }

        private void next_Click(object sender, EventArgs e)
        {
            // next line of text
            whatdopt2.Visible = true;
            story2.Visible = false;
            next.Visible = false;
            //options
            search.Visible = true;
            right.Visible = true;
            straight.Visible = true;
            leave.Visible = true;
            back.Visible = true;
        }

        private void right_Click(object sender, EventArgs e)
        {
            //open form that tells them they died
            this.Hide();
            Pit pit = new Pit();
            pit.ShowDialog();
        }

        private void back_Click(object sender, EventArgs e)
        {
            //bring the user back to the previous form
            this.Hide();
            beginning beginning = new beginning();
            beginning.ShowDialog();
        }

        private void search_Click(object sender, EventArgs e)
        {
            // pull up search text
            searchtext.Visible = true;
            // close other buttons to open yes or no buttons
            search.Visible = false;
            right.Visible = false;
            straight.Visible = false;
            leave.Visible = false;
            back.Visible = false;
            yes.Visible = true;
            no.Visible = true;
        }

        private void straight_Click(object sender, EventArgs e)
        {
            this.Hide();
            //open next form
            hallway3 hallway3 = new hallway3();
            hallway3.ShowDialog();
        }

        private void leave_Click(object sender, EventArgs e)
        {
            //close (copy and paaste from start1 form)
            if (MessageBox.Show("Are you sure you would like to exit? All progress will be lost.", "Exit to Main Menu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void no_Click(object sender, EventArgs e)
        {
            //bring the previous buttons/options back
            search.Visible = true;
            right.Visible = true;
            straight.Visible = true;
            leave.Visible = true;
            back.Visible = true;
            //hide yes or no
            yes.Visible = false;
            no.Visible = false;
            searchtext.Visible = false;
        }

        private void yes_Click(object sender, EventArgs e)
        {
            //open the puzzle form
            this.Hide();
            Puzzle1 puzzle = new Puzzle1();
            puzzle.ShowDialog();
            this.Show();
            //then hide the other buttons
            yes.Visible = false;
            no.Visible = false;
            searchtext.Visible = false;
            //and pull up the original ones
            search.Visible = true;
            right.Visible = true;
            straight.Visible = true;
            leave.Visible = true;
            back.Visible = true;
        }

        private void inventory_Click(object sender, EventArgs e)
        {
            //open global inventory
            g.inv.ShowDialog();
        }

        private void searchtext_Click(object sender, EventArgs e)
        {

        }
    }
}
