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
    public partial class Keypad : Form
    {
        public Keypad()
        {
            InitializeComponent();
        }

        private void but1_Click(object sender, EventArgs e)
        {
            //check if text 1 is empty or not then start filling other slots if full
            if (numa.Text == "_")
            {
                numa.Text = "1";
            }
            else if (numb.Text == "_")
            {
                numb.Text = "1";
            }
            else if (numc.Text == "_")
            {
                numc.Text = "1";
            }
            else if (numd.Text == "_")
            {
                numd.Text = "1";
            }
            else if (nume.Text == "_")
            {
                nume.Text = "1";
            }
        }

        private void but2_Click(object sender, EventArgs e)
        {
            //copy and paste for the 2 on keypad
            if (numa.Text == "_")
            {
                numa.Text = "2";
            }
            else if (numb.Text == "_")
            {
                numb.Text = "2";
            }
            else if (numc.Text == "_")
            {
                numc.Text = "2";
            }
            else if (numd.Text == "_")
            {
                numd.Text = "2";
            }
            else if (nume.Text == "_")
            {
                nume.Text = "2";
            }

        }

        private void but3_Click(object sender, EventArgs e)
        {
            //c and p
            if (numa.Text == "_")
            {
                numa.Text = "3";
            }
            else if (numb.Text == "_")
            {
                numb.Text = "3";
            }
            else if (numc.Text == "_")
            {
                numc.Text = "3";
            }
            else if (numd.Text == "_")
            {
                numd.Text = "3";
            }
            else if (nume.Text == "_")
            {
                nume.Text = "3";
            }
        }

        private void but4_Click(object sender, EventArgs e)
        {
            //c and p
            if (numa.Text == "_")
            {
                numa.Text = "4";
            }
            else if (numb.Text == "_")
            {
                numb.Text = "4";
            }
            else if (numc.Text == "_")
            {
                numc.Text = "4";
            }
            else if (numd.Text == "_")
            {
                numd.Text = "4";
            }
            else if (nume.Text == "_")
            {
                nume.Text = "4";
            }
        }

        private void but5_Click(object sender, EventArgs e)
        {
            //c and p
            if (numa.Text == "_")
            {
                numa.Text = "5";
            }
            else if (numb.Text == "_")
            {
                numb.Text = "5";
            }
            else if (numc.Text == "_")
            {
                numc.Text = "5";
            }
            else if (numd.Text == "_")
            {
                numd.Text = "5";
            }
            else if (nume.Text == "_")
            {
                nume.Text = "5";
            }
        }

        private void but6_Click(object sender, EventArgs e)
        {
            //c and p
            if (numa.Text == "_")
            {
                numa.Text = "6";
            }
            else if (numb.Text == "_")
            {
                numb.Text = "6";
            }
            else if (numc.Text == "_")
            {
                numc.Text = "6";
            }
            else if (numd.Text == "_")
            {
                numd.Text = "6";
            }
            else if (nume.Text == "_")
            {
                nume.Text = "6";
            }
        }

        private void but7_Click(object sender, EventArgs e)
        {
            //c and p
            if (numa.Text == "_")
            {
                numa.Text = "7";
            }
            else if (numb.Text == "_")
            {
                numb.Text = "7";
            }
            else if (numc.Text == "_")
            {
                numc.Text = "7";
            }
            else if (numd.Text == "_")
            {
                numd.Text = "7";
            }
            else if (nume.Text == "_")
            {
                nume.Text = "7";
            }
        }

        private void but8_Click(object sender, EventArgs e)
        {
            //c and p
            if (numa.Text == "_")
            {
                numa.Text = "8";
            }
            else if (numb.Text == "_")
            {
                numb.Text = "8";
            }
            else if (numc.Text == "_")
            {
                numc.Text = "8";
            }
            else if (numd.Text == "_")
            {
                numd.Text = "8";
            }
            else if (nume.Text == "_")
            {
                nume.Text = "8";
            }
        }

        private void but9_Click(object sender, EventArgs e)
        {
            //c and p
            if (numa.Text == "_")
            {
                numa.Text = "9";
            }
            else if (numb.Text == "_")
            {
                numb.Text = "9";
            }
            else if (numc.Text == "_")
            {
                numc.Text = "9";
            }
            else if (numd.Text == "_")
            {
                numd.Text = "9";
            }
            else if (nume.Text == "_")
            {
                nume.Text = "9";
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            //if llast number is not blank, then make it blank.
            if (nume.Text != "_")
            {
                nume.Text = "_";
            }
            else if (numd.Text != "_")
            {
                numd.Text = "_";
            }
            else if (numc.Text != "_")
            {
                numc.Text = "_";
            }
            else if (numb.Text != "_")
            {
                numb.Text = "_";
            }
            else if (numa.Text != "_")
            {
                numa.Text = "_";
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            //close the keypad
            this.Hide();
            
        }

        private void ok_Click(object sender, EventArgs e)
        {
            //PARSE THE NUMBERS (i needed a parse
            // create a float if number passes
            float c1;
            // parse and create boolean to hold true or false
            bool numcheck = float.TryParse(numa.Text, out c1);
            // is the number parseable to a number
            if (numcheck == false)
            {
                MessageBox.Show("Invalid entry", "Error");
            }
            else
            {
                //convert each number to a float
                if (numa.Text != "_" && numb.Text != "_" && numc.Text != "_" && numd.Text != "_" && nume.Text != "_")
                {
                    float b1 = Convert.ToSingle(numa.Text);
                    float b2 = Convert.ToSingle(numb.Text);
                    float b3 = Convert.ToSingle(numc.Text);
                    float b4 = Convert.ToSingle(numd.Text);
                    float b5 = Convert.ToSingle(nume.Text);
                    //match each number with the colour and number on the puzzle
                    //1st numb er: a3
                    if (b1 == g.a3 && b2 == g.a2 && b3 == g.a5 && b4 == g.a1 && b5 == g.a4)
                    {
                        REJECTED.Visible = false;
                        ACCEPT.Visible = true;
                        g.accept1 = true;
                    }
                    else
                    {
                        REJECTED.Visible = true;
                        ACCEPT.Visible = false;
                        Refresh();
                        System.Threading.Thread.Sleep(1000);
                        REJECTED.Visible = false;
                    }
                }
                //no crashes
                else
                {
                    MessageBox.Show("Please enter a 5-digit code.", "ERROR");
                }
            }
        }
    }
}
