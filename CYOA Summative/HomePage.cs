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
    public partial class homeform : Form
    {
        public homeform()
        {
            InitializeComponent();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void title_Click_1(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            //check if they've filled out all blanks
            if (namebox.Text == "")
            {
                MessageBox.Show("Please enter your name to continue.", "ERROR");
            }
            else if (gender.Text == "")
            {
                MessageBox.Show("Please enter your gender to continue.", "ERROR");
            }
            else
            {
                g.inv.cornitem.Visible = false;
                g.inv.rockitem.Visible = false;
                g.inv.chloroformitem.Visible = false;
                g.inv.sworditem.Visible = false;
                g.corn = false;
                g.rock = false;
                g.chloroform = false;
                //save info
                string gender1 = Convert.ToString(gender.Text);
                g.genderr = gender1;
                string name1 = Convert.ToString(namebox.Text);
                g.name = name1;
                this.Hide();
                //start the program by opening a new form
                beginning beginning = new beginning();
                beginning.ShowDialog();
                this.Close();
                
                
                
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //close the program
            if (MessageBox.Show("Are you sure you would like to exit?", "Exit Game", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void instructions_Click(object sender, EventArgs e)
        {
            this.Hide();
            //open instructions
            Instruction instruction = new Instruction();
            instruction.ShowDialog();
            this.Show();
        }

        private void homeform_Load(object sender, EventArgs e)
        {

        }

        private void homeform_VisibleChanged(object sender, EventArgs e)
        {
            
        }
    }
}
