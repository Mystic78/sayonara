using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSR
{
    public partial class listTkani : WSR.tmplt
    {
        public listTkani()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var d = new kladovschik();
            d.Show();
            Hide();
        }

        // подгрузка данных о ткани

        private void listTkani_Load(object sender, EventArgs e)
        {
            tkaniTableAdapter1.Fill(wsrDataSet1.Tkani);
            var q = (from t in wsrDataSet1.Tkani
                     select t).ToList();
            foreach(var el in q)
            {
                dataGridView1.Rows.Add(el.art, el.nameT, el.color, el.uzor, el.sostav, el.width, el.height, el.cost);
            }

        }
    }
}
