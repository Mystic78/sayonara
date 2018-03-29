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
    public partial class newOrder : WSR.tmplt
    {
        int countI = 0;
        int[] cost = { 1300, 452, 781, 623, 445, 451, 732 };
        int[] ordercost = { 0, 0, 0, 0, 0, 0, 0 };
        public newOrder()
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

        private void button1_Click(object sender, EventArgs e)
        {
            var d = new Constructor();
            d.Show();
            Hide();
        }

        private void newOrder_Load(object sender, EventArgs e)
        {
            orderTableAdapter1.Fill(wsrDataSet1.Order);
            orderIzdelieTableAdapter1.Fill(wsrDataSet1.OrderIzdelie);
            userTableAdapter1.Fill(wsrDataSet1.User);
            izdelieTableAdapter1.Fill(wsrDataSet1.Izdelie);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Text = 1.ToString();
                label20.Text = (int.Parse(textBox1.Text) * cost[0]).ToString();
                countI++;
            }
            else
            {
                textBox1.Clear();
                label20.Text = "0";
                countI--;
            }
            updateAllCost();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.Text = 1.ToString();
                countI++;
                label21.Text = (int.Parse(textBox2.Text) * cost[1]).ToString();
            }
            else
            {
                textBox2.Clear();
                countI--;
                label21.Text = "0";
            }
            updateAllCost();
        }


        private void updateAllCost()
        {
            label5.Text = (int.Parse(label20.Text) + int.Parse(label21.Text) + 
                int.Parse(label22.Text) + int.Parse(label23.Text) 
                + int.Parse(label26.Text)  + int.Parse(label24.Text) + int.Parse(label25.Text)).ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox3.Text = "1";
                countI++;
                label22.Text = (int.Parse(textBox3.Text) * cost[2]).ToString();
            }
            else
            {
                textBox3.Clear();
                countI--;
                label22.Text = "0";
            }
            updateAllCost();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox4.Text = "1";
                countI++;
                label23.Text = (int.Parse(textBox4.Text) * cost[3]).ToString();
            }
            else
            {
                textBox4.Clear();
                countI--;
                label23.Text = "0";
            }
            updateAllCost();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                textBox5.Text = "1";
                countI++;
                label24.Text = (int.Parse(textBox5.Text) * cost[4]).ToString();
            }
            else
            {
                textBox5.Clear();
                countI--;
                label24.Text = "0";
            }
            updateAllCost();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                textBox6.Text = "1";
                countI++;
                label25.Text = (int.Parse(textBox5.Text) * cost[5]).ToString();
            }
            else
            {
                textBox6.Clear();
                countI--;
                label25.Text = "0";
            }
            updateAllCost();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                textBox7.Text = "1";
                countI++;
                label26.Text = (int.Parse(textBox6.Text) * cost[6]).ToString();
            }
            else
            {
                textBox7.Clear();
                countI--;
                label26.Text = "0";
            }
            updateAllCost();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                label20.Text = (int.Parse(textBox1.Text) * cost[0]).ToString();
            }
            catch { textBox1.Clear(); MessageBox.Show("Введено неверное значение!", "Внимание");}
            updateAllCost();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                label21.Text = (int.Parse(textBox2.Text) * cost[1]).ToString();
            }
            catch { textBox2.Clear(); MessageBox.Show("Введено неверное значение!", "Внимание"); }
            
            updateAllCost();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                label22.Text = (int.Parse(textBox3.Text) * cost[2]).ToString();
            }
            catch { textBox3.Clear(); MessageBox.Show("Введено неверное значение!", "Внимание"); }

            
            updateAllCost();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                label23.Text = (int.Parse(textBox4.Text) * cost[3]).ToString();
            }
            catch { textBox4.Clear(); MessageBox.Show("Введено неверное значение!", "Внимание"); }
            
            updateAllCost();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                label24.Text = (int.Parse(textBox5.Text) * cost[4]).ToString();
            }
            catch { textBox5.Clear(); MessageBox.Show("Введено неверное значение!", "Внимание"); }
            
            updateAllCost();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                label25.Text = (int.Parse(textBox6.Text) * cost[5]).ToString();
            }
            catch { textBox6.Clear(); MessageBox.Show("Введено неверное значение!", "Внимание"); }
            
            updateAllCost();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                label26.Text = (int.Parse(textBox7.Text) * cost[6]).ToString();
            }
            catch { textBox7.Clear(); MessageBox.Show("Введено неверное значение!", "Внимание"); }
           
            updateAllCost();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void order_Click(object sender, EventArgs e)
        {
            var q = (from o in wsrDataSet1.Order
                    select o).ToList().Count();
            if(!(checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked || checkBox6.Checked || checkBox7.Checked))
            {
                MessageBox.Show("Ни одно изделие не выбрано!", "Внимание");
                return;
            }
            string nameZ = (from n in wsrDataSet1.User
                           where n.login == TempData.loginUser
                           select n.nameUser).ToList().Last();
            orderTableAdapter1.Insert(q + 1, DateTime.Now, "Новый", nameZ, "", int.Parse(label5.Text));
            var rnd = new Random();

            


            orderIzdelieTableAdapter1.Insert(q + 1, rnd.Next().ToString(), countI);
            MessageBox.Show("Ваш заказ принят и ожидает одобрения менеджера!", "Внимание");
        }
    }
}
