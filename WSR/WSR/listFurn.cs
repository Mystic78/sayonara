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
    public partial class listFurn : WSR.tmplt
    {
        public listFurn()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var d = new kladovschik();
            d.Show();
            Hide();
        }

        // подгрузка данных о фурнитуре
        private void listFurn_Load(object sender, EventArgs e)
        {
            furnitureTableAdapter1.Fill(wsrDataSet1.Furniture);
            var q = (from f in wsrDataSet1.Furniture
                    select f).ToList();
            foreach(var el in q)
            {
                dataGridView1.Rows.Add(el.artF, el.nameF, el.type, el.width, el.height, el.weight, el.cost);
            }
        }
    }
}
