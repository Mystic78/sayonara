using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSR
{
    public partial class proizvodstvo : WSR.tmplt
    {
        int num = 0;
        public proizvodstvo(int num)
        {
            InitializeComponent();
            this.num = num;
        }

        private void back_Click(object sender, EventArgs e)
        {
            var d = new listOrders("director");
            d.Show();
            Hide();
        }

        //подгрузка данных о заказе
        
        private void proizvodstvo_Load(object sender, EventArgs e)
        {
            orderIzdelieTableAdapter1.Fill(wsrDataSet1.OrderIzdelie);
            orderTableAdapter1.Fill(wsrDataSet1.Order);
            var q = (from o in wsrDataSet1.Order
                    join oi in wsrDataSet1.OrderIzdelie on o.numZ equals oi.numZ
                    where o.numZ == num
                    select new
                    {
                        num = o.numZ,
                        date = o.dateZ.ToShortDateString(),
                        count = oi.count,
                        etap = o.Etap,
                        zak = o.Zakazchik,
                        manager = o.Manager, 
                        cost = o.Cost
                    }).ToList().Last();
            label2.Text = q.num.ToString();
            label4.Text = q.date.ToString();
            label6.Text = q.etap;
            label8.Text = q.zak;
            label10.Text = q.manager;
            label12.Text = q.cost.ToString();
        }

        //выбор файла

        private void browse_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                string path = open.FileName;
                if (Path.GetExtension(path) != ".txt")
                {
                    MessageBox.Show("Файл имеет неверный формат", "Внимание");
                    return;
                }
                textBox1.Text = path;
            }
        }
        //обработка файла

        private void load_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Файл не выбран!", "Внимание ");
                return;
            }
            string[] data = File.ReadAllLines(textBox1.Text);
            try
            {
                foreach (var l in data)
                {
                    string[] temp = l.Split(',').ToArray();
                    string art = temp[0];
                    string type = temp[1];
                    int count = int.Parse(temp[2]);
                    if (type == "ткань")
                    {
                        richTextBox1.Text = "Ткань, артикул " + art + " - " + count+"\n" ;
                    }
                    else if (type == "фурнитура")
                    {
                        richTextBox1.Text = "Фурнитура, артикул " + art + " - " + count + "\n";
                    }
                }
                richTextBox1.Visible = true;
                label14.Visible = true;

            }
            catch
            {
                MessageBox.Show("Файл имеет неправильную структуру", "Внимание");
            }
        }
        //выбор файла

        private void browse1_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                string path = open.FileName;
                if (Path.GetExtension(path) != ".txt")
                {
                    MessageBox.Show("Файл имеет неверный формат", "Внимание");
                    return;
                }
                textBox2.Text = path;
            }
        }
        //обработка файла

        private void load1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Файл не выбран!", "Внимание ");
                return;
            }
            string[] data = File.ReadAllLines(textBox1.Text);
            try
            {
                foreach (var l in data)
                {
                    string[] temp = l.Split(',').ToArray();
                    string art = temp[0];
                    string type = temp[1];
                    int count = int.Parse(temp[2]);
                    if (type == "ткань")
                    {
                        richTextBox2.Text = "Ткань, артикул " + art + " - " + count + "\n";
                    }
                    else if (type == "фурнитура")
                    {
                        richTextBox2.Text = "Фурнитура, артикул " + art + " - " + count + "\n";
                    }
                }
                richTextBox2.Visible = true;
                label14.Visible = true;

            }
            catch
            {
                MessageBox.Show("Файл имеет неправильную структуру", "Внимание");
            }
        }

        //выбор файла
        private void browse2_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                string path = open.FileName;
                if (Path.GetExtension(path) != ".txt")
                {
                    MessageBox.Show("Файл имеет неверный формат", "Внимание");
                    return;
                }
                textBox3.Text = path;
            }
        }

        private void load2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Файл не выбран!", "Внимание ");
                return;
            }
            string[] data = File.ReadAllLines(textBox1.Text);
            try
            {
                foreach (var l in data)
                {
                    string[] temp = l.Split(',').ToArray();
                    string art = temp[0];
                    string type = temp[1];
                    int count = int.Parse(temp[2]);
                    if (type == "ткань")
                    {
                        richTextBox3.Text = "Ткань, артикул " + art + " - " + count + "\n";
                    }
                    else if (type == "фурнитура")
                    {
                        richTextBox3.Text = "Фурнитура, артикул " + art + " - " + count + "\n";
                    }
                }
                richTextBox3.Visible = true;
                label14.Visible = true;
            }
            catch
            {
                MessageBox.Show("Файл имеет неправильную структуру", "Внимание");
            }
            
        }
    }
}
