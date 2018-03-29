using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSR
{
    public partial class production : WSR.tmplt
    {
        public production()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var d = new Form1();
            d.Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var k = new Izdelie();
            k.Show();
            Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var k = new Izdelie();
            k.Show();
            Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var k = new Izdelie();
            k.Show();
            Hide();
        }
    }
}
