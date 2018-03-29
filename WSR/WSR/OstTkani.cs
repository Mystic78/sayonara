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
    public partial class OstTkani : WSR.tmplt
    {
        public OstTkani()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            switch (TempData.roleUser) // возврат на форму в зависимости о роли
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

        // подгрузка данных о ткани
        private void OstTkani_Load(object sender, EventArgs e)
        {
            skladTkaniTableAdapter1.Fill(wsrDataSet1.SkladTkani);
            var q = (from t in wsrDataSet1.SkladTkani
                    select t).ToList();
            foreach(var el in q)
            {
                dataGridView1.Rows.Add(el.rulon, el.artT, el.width, el.height, el.count, toMetr(el.count, el.width));
            }
        }

        private double toMetr(int rulon, int w)
        {
            return rulon * (w * 0.2);
        }

        private void print_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
        }
        Bitmap memory;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memory, 0, 0);
        }

        private void CaptureScreen()
        {
            var g = CreateGraphics();
            Size s = this.Size;
            memory = new Bitmap(s.Width, s.Height, g);
            var g1 = Graphics.FromImage(memory);
            g1.CopyFromScreen(Location.X, Location.Y, 0, 0, s);
        }
    }
}
