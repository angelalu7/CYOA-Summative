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
    public partial class FInal : Form
    {
        public FInal()
        {
            InitializeComponent();
        }

        private void option2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void option1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void yes_Click(object sender, EventArgs e)
        {
            //take away buttons
            yes.Visible = false;
            no.Visible = false;
            mintxt.Visible = false;
            
            txtbubble.Visible = false;
            option1.Visible = false;
            option2.Visible = false;
            enter.Visible = false;
            //pull up your text
            nametell.Visible = true;
            txtbub2.Visible = true;
            //base text dependng on gender
            if (g.genderr == "FEMALE")
            {
                nametell.Text = "Very well! My name is " + g.name + ". And soon, I will be the queen of this kingdom!";
            }
            else if (g.genderr == "MALE")
            {
                nametell.Text = "Very well! My name is " + g.name + ". And soon, I will be the king of this kingdom!";
            }
            else if (g.genderr == "RATHER NOT SAY")
            {
                nametell.Text = "Very well! My name is " + g.name + ". And soon, I will be the ruler of this kingdom!";
            }
            else if (g.genderr == "OTHER")
            {
                nametell.Text = "Very well! My name is " + g.name + ". And soon, I will be the ruler of this kingdom!";
            }
            next.Visible = true;
            
        }

        private void inventory_Click(object sender, EventArgs e)
        {
            //open inv
            g.inv.ShowDialog();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (option1.Checked == true)
            {
                //change form take away other options
                fighttxt.Visible = true;
                mintxt.Visible = false;
                txtbub2.Visible = false;
                txtbubble.Visible = false;
                option1.Visible = false;
                option2.Visible = false;
                enter.Visible = false;
                // pull up options
                yes.Visible = true;
                no.Visible = true;
            }
            else if (option2.Checked == true)
            {
                //open death form
                Dead dead = new Dead();
                dead.ShowDialog();
            }
        }

        private void next2_Click(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            this.Hide();
            //open new form
            Fight fight = new Fight();
            fight.ShowDialog();
        }

        private void no_Click(object sender, EventArgs e)
        {
            //take away buttons
            yes.Visible = false;
            no.Visible = false;
            mintxt.Visible = false;

            txtbubble.Visible = false;
            option1.Visible = false;
            option2.Visible = false;
            enter.Visible = false;
            //pull up your text
            nametell.Visible = true;
            txtbub2.Visible = true;
            nametell.Text = "You don't need to know my name.";
            next.Visible = true;
        }
    }
}
