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
    public partial class buttonpuzzle : Form
    {
        public buttonpuzzle()
        {
            InitializeComponent();
        }

        private void go_Click(object sender, EventArgs e)
        {
            //check if the player got the correct pattern
            if (aa.Checked == true && bb.Checked == true && ee.Checked == true && hh.Checked == true && ii.Checked == true)
            {
                no.Visible = false;
                yes.Visible = true;
                g.enable = true;
            }
            //otherwise rejec t them
            else
            {
                yes.Visible = false;
                no.Visible = true;
                Refresh();
                System.Threading.Thread.Sleep(1000);
                no.Visible = false;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            //CLOSE
            this.Hide();
        }
    }
}
