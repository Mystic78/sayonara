using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSR
{
    public partial class Register : WSR.tmplt
    {
        public Register()
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

        private void reg_Click(object sender, EventArgs e)
        {
            if (check())
            {
                userTableAdapter1.Insert(textBox1.Text, textBox2.Text, "client", textBox4.Text + " " + textBox5.Text);
                MessageBox.Show("Вы успешно зарегистриованы в системе!", "Внимание");
                var f = new Auth();
                f.Show();
                Hide();
            }
        }

        // проверка данных, введенных пользователем
        private bool check()
        {
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Все поля обязательны для заполнения!", "Внимание");
                return false;
            }
            if(textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Пароль не совпадает с подтверждением!", "Внимание");
                return false;
            }
            bool letter = false;
            bool dig = false;
            foreach (var c in textBox2.Text)
            {
                if (Char.IsUpper(c))
                {
                    letter = true;
                    break;
                }
            }
            foreach (var c in textBox2.Text)
            {
                if (Char.IsDigit(c))
                {
                    dig = true;
                    break;
                }
            }
            if (!letter)
            {
                MessageBox.Show("Пароль должен содержать хотя бы одну прописную букву", "Внимание");
                return false;
            }
            if (!letter)
            {
                MessageBox.Show("Пароль должен содержать хотя бы одну цифру", "Внимание");
                return false;
            }
            return true;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            userTableAdapter1.Fill(wsrDataSet1.User);
        }
    }
}
