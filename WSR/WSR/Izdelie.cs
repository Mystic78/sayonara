using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSR
{
    public partial class Izdelie : WSR.tmplt
    {
        string image;
        string n; string o;
        //public Izdelie(string image, string n, string o)
        public Izdelie()
        {
            InitializeComponent();
           /* this.image = image;
            this.o = o;
            this.n = n;*/
        }

        private void back_Click(object sender, EventArgs e)
        {
            var k = new production();
            k.Show();
            Hide();
        }

        private void Izdelie_Load(object sender, EventArgs e)
        {
            /*pictureBox2.Image = Image.FromFile(image);
            label4.Text = n;
            label3.Text = o;*/
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
