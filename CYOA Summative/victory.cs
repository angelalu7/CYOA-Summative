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
    public partial class victory : Form
    {
        public victory()
        {
            InitializeComponent();
        }

        private void leave_Click(object sender, EventArgs e)
        {
            //exit to menu
            Application.Restart();
        }

        private void youdied_Click(object sender, EventArgs e)
        {

        }
    }
}
