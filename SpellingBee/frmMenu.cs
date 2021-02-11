using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpellingBee
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form frm = new frmGame(); // Opens up frmGame when this button is clicked
            frm.ShowDialog(); // Ensures the user cannont go back to frmMenu unless frmGame is closed
        }
    }
}
