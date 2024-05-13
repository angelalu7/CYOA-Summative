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
    public partial class Instruction : Form
    {
        public Instruction()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //close
            this.Close();
        }

        private void next_Click(object sender, EventArgs e)
        {
            //make 1st invis and 2nd vis
            help1pan.Visible = false;
            pan2.Visible = true;
        }

        private void backbut_Click(object sender, EventArgs e)
        {
            //2invis 1 vis
            help1pan.Visible = true;
            pan2.Visible = false;
        }

        private void close2_Click(object sender, EventArgs e)
        {
            //close
            this.Close();
        }
    }
}
