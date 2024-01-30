using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO_GAME
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1(txtplayer1.Text, txtplayer2.Text,rdx.Checked,rdo2.Checked);
            form.ShowDialog();
            this.Close();



        }

        private void rdx_CheckedChanged(object sender, EventArgs e)
        {
            if (rdx.Checked == true)
            {

                rdo2.Checked = true;
            }

        }

        private void rdo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo.Checked == true)
            {

                rdx2.Checked = true;
            }

        }

        private void rdx2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdx2.Checked == true)
            {

                rdo.Checked = true;
            }
        }

        private void rdo2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo2.Checked == true)
            {

                rdx.Checked = true;
            }
        }
    }
}
