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
    public partial class moveMaterial : WSR.tmplt
    {
        public moveMaterial()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var k = new Director();
            k.Show();
            Hide();
        }

        private void moveMaterial_Load(object sender, EventArgs e)
        {
            skladFurnitureTableAdapter1.Fill(wsrDataSet1.SkladFurniture);
            skladTkaniTableAdapter1.Fill(wsrDataSet1.SkladTkani);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value >= dateTimePicker2.Value || dateTimePicker1.Value > DateTime.Now)
            {
                dataGridView1.Rows.Clear();
                MessageBox.Show("Даты выбраны неверно! Попробуйте снова");
                return;
            }
            var q = (from s in wsrDataSet1.SkladFurniture
                    select s).ToList();
            if(dateTimePicker1.Value > new DateTime(2017, 1, 1))
            {
                foreach(var el in q)
                {
                    dataGridView1.Rows.Add(el.artF, el.count - 5 + 2, 5, 2, el.count);
                }
            }
            else
            {
                dataGridView1.Rows.Clear();
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
