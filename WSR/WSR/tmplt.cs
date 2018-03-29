using System;
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
    //шаблон для наследования графического интерфейса
    public partial class tmplt : Form
    {
        public tmplt()
        {
            InitializeComponent();
        }

        private void tmplt_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            TempData.loginUser = "";
            TempData.roleUser = "";
            var f = new Auth();
            f.Show();
            Hide();
        }
    }
}
