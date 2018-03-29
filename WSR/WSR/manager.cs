using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSR
{
    public partial class manager : WSR.tmplt
    {
        public manager()
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

        private void newOrder_Click(object sender, EventArgs e)
        {
            var d = new newOrder();
            d.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var d = new listOrders("manager");
            d.Show();
            Hide();
        }
    }
}
