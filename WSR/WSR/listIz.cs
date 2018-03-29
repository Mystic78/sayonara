using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSR
{
    public partial class listIz : WSR.tmplt
    {
        public listIz()
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
    }
}
