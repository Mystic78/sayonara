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
    public partial class listOrders : WSR.tmplt
    {
        List<string> stat = new List<string> () { "Новый", "Ожидает", "Обработка", "Отклонен", "К оплате", "Оплачен", "Раскрой", "Готов"};
        string mode;
        public listOrders(string mode = "client")
        {
            InitializeComponent();
            this.mode = mode;
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

        // подгрузка данных
        private void listOrders_Load(object sender, EventArgs e)
        {
            userTableAdapter1.Fill(wsrDataSet1.User);
            orderIzdelieTableAdapter1.Fill(wsrDataSet1.OrderIzdelie);
            orderTableAdapter1.Fill(wsrDataSet1.Order);
            var q = from o in wsrDataSet1.Order
                    join oi in wsrDataSet1.OrderIzdelie on o.numZ equals oi.numZ
                    select new
                    {
                        num = o.numZ,
                        date = o.dateZ.ToShortDateString(),
                        count = oi.count,
                        etap = o.Etap,
                        zak = o.Zakazchik,
                        manager = o.Manager
                    };
            string name = (from u in wsrDataSet1.User
                          where u.login == TempData.loginUser
                          select u.nameUser).ToList().Last();
            foreach(var r in q)
            {
                if((mode == "manager" && r.manager == name) || mode == "manager" && r.manager == "")
                {
                    dataGridView1.Rows.Add(r.num, r.date, r.count, r.etap, r.zak, r.manager, "Сменить статус", "Отклонить", "Отчет по производству");
                }
               else if(mode != "manager")
                {
                    dataGridView1.Rows.Add(r.num, r.date, r.count, r.etap, r.zak, r.manager, "Сменить статус", "Отклонить", "Отчет по производству");
                }
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        // обработка нажатия кнопок dataGridView1
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(mode == "manager" || mode == "director")
            {
                if (e.ColumnIndex == 6)
                {
                    var num = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var order = (from o in wsrDataSet1.Order
                                where o.numZ == num
                                select o).ToList().Last();
                    var name = (from o in wsrDataSet1.User
                                where o.login == TempData.loginUser
                                select o.nameUser).ToList().Last();
                    switch (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()) // смена статуса
                    {
                        case "Новый":
                            orderTableAdapter1.Update(order.dateZ, "Ожидание", order.Zakazchik, name, order.Cost, order.numZ, order.dateZ, order.Etap, order.Zakazchik, order.Manager, order.Cost);
                            dataGridView1.Rows[e.RowIndex].Cells[0].Value = "Ожидание";
                            MessageBox.Show("Знгачение сохранено! Внимание, изменения будут отображены после следующего взода в форму");
                            break;
                        case "Ожидание":
                            orderTableAdapter1.Update(order.dateZ, "Обработка", order.Zakazchik, name, order.Cost, order.numZ, order.dateZ, order.Etap, order.Zakazchik, order.Manager, order.Cost);
                            dataGridView1.Rows[e.RowIndex].Cells[0].Value = "Обработка";
                            MessageBox.Show("Знгачение сохранено! Внимание, изменения будут отображены после следующего взода в форму");

                            break;
                        case "Обработка":
                            orderTableAdapter1.Update(order.dateZ, "К оплате", order.Zakazchik, name, order.Cost, order.numZ, order.dateZ, order.Etap, order.Zakazchik, order.Manager, order.Cost);
                            dataGridView1.Rows[e.RowIndex].Cells[0].Value = "К оплате";
                            MessageBox.Show("Знгачение сохранено! Внимание, изменения будут отображены после следующего взода в форму");

                            break;
                        case "Отклонен":
                            MessageBox.Show("Смена статуса заказа недоступна", "Внимание");
                            break;
                        case "К оплате":
                            orderTableAdapter1.Update(order.dateZ, "Оплачен", order.Zakazchik, name, order.Cost, order.numZ, order.dateZ, order.Etap, order.Zakazchik, order.Manager, order.Cost);
                            dataGridView1.Rows[e.RowIndex].Cells[0].Value = "Оплачен";
                            MessageBox.Show("Знгачение сохранено! Внимание, изменения будут отображены после следующего взода в форму");

                            break;
                        case "Оплачен":
                            orderTableAdapter1.Update(order.dateZ, "Раскрой", order.Zakazchik, name, order.Cost, order.numZ, order.dateZ, order.Etap, order.Zakazchik, order.Manager, order.Cost);
                            dataGridView1.Rows[e.RowIndex].Cells[0].Value = "Раскрой";
                            MessageBox.Show("Знгачение сохранено! Внимание, изменения будут отображены после следующего взода в форму");


                            break;
                        case "Раскрой":
                            orderTableAdapter1.Update(order.dateZ, "Готов", order.Zakazchik, name, order.Cost, order.numZ, order.dateZ, order.Etap, order.Zakazchik, order.Manager, order.Cost);
                            dataGridView1.Rows[e.RowIndex].Cells[0].Value = "Готов";
                            MessageBox.Show("Знгачение сохранено! Внимание, изменения будут отображены после следующего взода в форму");


                            break;
                        case "Готов":
                            MessageBox.Show("Заказ завершен. Смена статуса невозможна");
                            break;

                    }
                }
                else if (e.ColumnIndex == 7)
                {
                    var num = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var order = (from o in wsrDataSet1.Order
                                 where o.numZ == num
                                 select o).ToList().Last();
                    var name = (from o in wsrDataSet1.User
                                where o.login == TempData.loginUser
                                select o.nameUser).ToList().Last();
                    orderTableAdapter1.Update(order.dateZ, "Отклонен", order.Zakazchik, name, order.Cost, order.numZ, order.dateZ, order.Etap, order.Zakazchik, order.Manager, order.Cost);
                }
                else if(e.ColumnIndex == 8)
                {
                    var num = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var f = new proizvodstvo(num);
                    f.Show();
                    Hide();
                }
            }
            else
            {
                if (e.ColumnIndex == 6 || e.ColumnIndex == 7 || e.ColumnIndex == 8){
                    MessageBox.Show("Недостаточно прав для доступа!", "Внимание");
                }
            }
            
        }
    }
}
