using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSR
{
    public partial class OstFurn : WSR.tmplt
    {
        public OstFurn()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            switch (TempData.roleUser) // возврат в зависимости от роли пользователя
            {
                case "client":
                    var f = new zakazchikcs();
                    f.Show();
                    Hide();
                    break;
                case "director":
                    var d = new Director();
                    d.Show();
                    Hide();
                    break;
                case "manager":
                    var m = new manager();
                    m.Show();
                    Hide();
                    break;
                case "sklad":
                    var k = new kladovschik();
                    k.Show();
                    Hide();
                    break;
            }
        }

        // подгрузка данных о фурнитуре
        private void OstFurn_Load(object sender, EventArgs e)
        {
            furnitureTableAdapter1.Fill(wsrDataSet1.Furniture);
            skladFurnitureTableAdapter1.Fill(wsrDataSet1.SkladFurniture);

            var q = from f in wsrDataSet1.Furniture
                    join ff in wsrDataSet1.SkladFurniture on f.artF equals ff.artF
                    select new
                    {
                        part = ff.part,
                        artF = f.artF,
                        name = f.nameF,
                        count = ff.count,
                        type = f.type,
                        cost = f.cost
                    };
            foreach(var el in q)
            {
                dataGridView1.Rows.Add(el.part, el.artF, el.name, el.type, el.count, el.cost);
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
        }

        Bitmap memory;
        private void CaptureScreen()
        {
            var g = CreateGraphics();
            Size s = this.Size;
            memory = new Bitmap(s.Width, s.Height, g);
            var g1 = Graphics.FromImage(memory);
            g1.CopyFromScreen(Location.X, Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memory, 0, 0);
        }

    }
}
