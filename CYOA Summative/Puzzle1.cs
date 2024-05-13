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
    public partial class Puzzle1 : Form
    {
        public Puzzle1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //EXIT OUT OF THE PUZZZLE
            this.Close();
        }

        private void look_Click(object sender, EventArgs e)
        {
            if (num1.Text == "" && g.a1 == 0)
            {

                // prep mvs to give random numbers
                Random rnd = new Random();
                // give the program the range 
                float x = rnd.Next(1, 10);
                string a = Convert.ToString(x);
                // show the number generated in the first box
                num1.Text = a;
                g.a1 = x;

                //REPEAT
                float y = rnd.Next(1, 10);
                string b = Convert.ToString(y);
                num2.Text = b;
                g.a2 = y;

                float z = rnd.Next(1, 10);
                string c = Convert.ToString(z);
                num3.Text = c;
                g.a3 = z;

                float aa = rnd.Next(1, 10);
                string d = Convert.ToString(aa);
                num4.Text = d;
                g.a4 = aa;

                float bb = rnd.Next(1, 10);
                string f = Convert.ToString(bb);
                num5.Text = f;
                g.a5 = bb;
            }
            else if (num1.Text == "" && g.a1 != 0)
            {
                // IF NUMBERS HAVE ALREADY BEEN GENERATED, show them
                num1.Text = g.a1.ToString();
                num2.Text = g.a2.ToString();
                num3.Text = g.a3.ToString();
                num4.Text = g.a4.ToString();
                num5.Text = g.a5.ToString();
            }
            else 
            {
                txt2.Visible = true;
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {

        }
    }
}
