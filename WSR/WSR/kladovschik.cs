using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSR
{
    public partial class kladovschik : WSR.tmplt
    {
        public kladovschik()
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

        private void listTkan_Click(object sender, EventArgs e)
        {
            var d = new listTkani();
            d.Show();
            Hide();
        }

        private void listFurn_Click(object sender, EventArgs e)
        {
            var d = new listFurn();
            d.Show();
            Hide();
        }

        private void furnOst_Click(object sender, EventArgs e)
        {
            var d = new OstFurn();
            d.Show();
            Hide();

        }

        private void invent_Click(object sender, EventArgs e)
        {
            var d = new Invent();
            d.Show();
            Hide();
        }
    }
}
