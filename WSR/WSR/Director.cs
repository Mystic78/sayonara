using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSR
{
    public partial class Director : WSR.tmplt
    {
        public Director()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var f = new Form1();
            f.Show();
            Hide();
        }

        private void tkanOst_Click(object sender, EventArgs e)
        {
            var d = new OstTkani();
            d.Show();
            Hide();
        }

        private void furnOst_Click(object sender, EventArgs e)
        {
            var d = new OstFurn();
            d.Show();
            Hide();
        }

        private void listIzd_Click(object sender, EventArgs e)
        {
            var d = new listIz();
            d.Show();
            Hide();
        }

        private void Director_Load(object sender, EventArgs e)
        {

        }

        private void moveMaterials_Click(object sender, EventArgs e)
        {
            var k = new moveMaterial();
            k.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var d = new listOrders("director");
            d.Show();
            Hide();
        }
    }
}
