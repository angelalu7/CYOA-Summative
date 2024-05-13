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
    public partial class Dead : Form
    {
        public Dead()
        {
            InitializeComponent();
        }

        private void leave_Click(object sender, EventArgs e)
        {
            //exit to main menu
            Application.Restart();
        }
    }
}
