using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if(TempData.loginUser == "") // если еще не авторизован
            {
                var f = new Auth();
                f.Show();
                Hide();
            }
            else
            {
                switch (TempData.roleUser) // Подгрузка формы пользователя в зависимости от его роли
                {
                    case "client":
                        var z = new zakazchikcs();
                        z.Show();
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
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var k = new Register();
            k.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //insert in db from txt
            /*string[] arr = File.ReadAllLines(@"C:\Users\Competitor\Desktop\Book1.txt");
            int index = 0;
            foreach (var l in arr)
            {
                string[] temp = l.Split(',').ToArray();
                if (index == 0)
                {
                    index++;
                    continue;
                }
                int cost = 0;
                try
                {
                    if (temp[3] != "") try { cost = int.Parse(temp[3].Split('.').ToArray()[0]); } catch { cost = 0; }
                }
                catch { continue; }
                try
                {
                    furnitureTableAdapter1.Insert(temp[0], temp[1], temp[4], int.Parse(temp[2]), int.Parse(temp[3]), int.Parse(temp[6].Split(' ').ToArray()[0]), "", cost);
                }
                catch { }
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tkaniTableAdapter1.Fill(wsrDataSet1.Tkani);
            furnitureTableAdapter1.Fill(wsrDataSet1.Furniture);
            izdelieTableAdapter1.Fill(wsrDataSet1.Izdelie);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //   update cost
            /*var q = (from f in wsrDataSet1.Furniture
                    select f).ToList();
            var rnd = new Random();
            foreach (var c in q)
            {
                int cost = rnd.Next(250, 1400);
                furnitureTableAdapter1.Update(c.nameF, c.type, c.width, c.height, c.weight, c.image, cost, c.artF, c.nameF, c.type, c.width, c.height, c.weight, c.image, c.cost);
            }
            */

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var z = new production();
            z.Show();
            Hide();
        }
    }
}
