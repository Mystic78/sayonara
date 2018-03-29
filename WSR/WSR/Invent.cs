using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSR
{
    public partial class Invent : WSR.tmplt
    {
        int realy = 0;
        int inbase = 0;
        public Invent()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var d = new kladovschik();
            d.Show();
            Hide();
        }

        //Выбор текстового файла
        private void button1_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK)
            {
                string path = open.FileName;
                if(Path.GetExtension(path) != ".txt")
                {
                    MessageBox.Show("Файл имеет неверный формат", "Внимание");
                    return;
                }
                textBox1.Text = path;
            }
              
        }

        private void Invent_Load(object sender, EventArgs e)
        {
            skladFurnitureTableAdapter1.Fill(wsrDataSet1.SkladFurniture);
            skladTkaniTableAdapter1.Fill(wsrDataSet1.SkladTkani);
        }

        // обработка выбранного файла
        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
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
                        int q = (from t in wsrDataSet1.SkladTkani
                                 where t.artT == art
                                 select t.count).ToList().Last();
                        richTextBox1.Text += "Ткань " + art + " - погрешность инвентаризации: " + (count - q).ToString() + "\n";
                        inbase += q;
                        realy += count;
                    }
                    else if (type == "фурнитура")
                    {
                        int q = (from f in wsrDataSet1.SkladFurniture
                                 where f.artF == art
                                 select f.count).ToList().Last();
                        richTextBox1.Text += "Фурнитура " + art + " - погрешность инвентаризации: " + (count - q).ToString() + "\n";
                        inbase += q;
                        realy += count;
                    }
                }
                richTextBox1.Text += "\n\nОбщая погрешность: " + (realy - inbase).ToString() + " шт";
            }
            catch
            {
                MessageBox.Show("Файл имеет неправильную структуру", "Внимание");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var d = new kladovschik();
            d.Show();
            Hide();
        }
    }
}
