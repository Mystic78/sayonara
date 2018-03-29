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
    public partial class Auth : WSR.tmplt
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var f = new Form1();
            f.Show();
            Hide();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            var f = new Form1();
            f.Show();
            Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            Constructor constructor = new Constructor();
            constructor.Show();
            //if (check())
            //{
            //    var q = (from u in wsrDataSet1.User
            //             where u.login == textBox1.Text && u.pass == textBox2.Text
            //             select u.role).ToList().Last();
            //    TempData.loginUser = textBox1.Text;
            //    TempData.roleUser = q;
            //    switch (q) // Подгрузка формы пользователя в зависимости от его роли
            //    {
            //        case "client": 
            //            var f = new zakazchikcs();
            //            f.Show();
            //            Hide();
            //            break;
            //        case "director":
            //            var d = new Director();
            //            d.Show();
            //            Hide();
            //            break;
            //        case "manager":
            //            var m = new manager();
            //            m.Show();
            //            Hide();
            //            break;
            //        case "sklad":
            //            var k = new kladovschik();
            //            k.Show();
            //            Hide();
            //            break;
            //    }
            //}
        }

        // Проверка введенных данных
        private bool check()
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Все поля обязательны для заполнения!", "Внимание");
                return false;
            }
            var q = (from u in wsrDataSet1.User
                     where u.login == textBox1.Text && u.pass == textBox2.Text
                     select u).ToList().Count();
            if(q == 0)
            {
                MessageBox.Show("Вы ввели неверный логин и/или пароль!", "Внимание");
                return false;
            }
            return true;
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            userTableAdapter1.Fill(wsrDataSet1.User);
            //дыа
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Добавление пользователей в базу
            userTableAdapter1.Insert("client1", "Pass1", "client", "Сергей Есенин");
            userTableAdapter1.Insert("client2", "Pass2", "client", "Иван Тургенев");
            userTableAdapter1.Insert("client3", "Pass3", "director", "Марина Цветаева");
            userTableAdapter1.Insert("client4", "Pass4", "manager", "Александр Пушкин");
            userTableAdapter1.Insert("client5", "Pass5", "manager", "Владимир Маяковский");
            userTableAdapter1.Insert("client6", "Pass6", "sklad", "Анна Ахматова");*/
        }
    }
}
