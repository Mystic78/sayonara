using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSR
{
    public partial class zakazchikcs : WSR.tmplt
    {
        public zakazchikcs()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var f = new Form1();
            f.Show();
            Hide();
        }

        private void constructor_Click(object sender, EventArgs e)
        {
            var d = new Constructor();
            d.Show();
            Hide();
        }

        private void newOrder_Click(object sender, EventArgs e)
        {
            var d = new newOrder();
            d.Show();
            Hide();
        }

        private void listOrders_Click(object sender, EventArgs e)
        {
            var d = new listOrders();
            d.Show();
            Hide();
        }
    }
}
