using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSR
{
    public partial class Constructor : WSR.tmplt
    {
        string from;
        string temp = ""; // поле для хранения "элемента", инициирующего действие
        public Constructor(string from = "z")
        {
            InitializeComponent();
            this.from = from;
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (from != "z")
            {
                var d = new newOrder();
                d.Show();
                Hide();
            }
            else
            {
                var d = new zakazchikcs();
                d.Show();
                Hide();
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if (!(e.Button == MouseButtons.Left)) temp = "";
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            if (!(e.Button == MouseButtons.Left)) temp = "";
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            if (!(e.Button == MouseButtons.Left)) temp = "";
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            temp = "color2";
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            temp = "color3";

        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            temp = "color4";

        }

        // Обработка попадания мыши в область панели
        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            if(temp != "")
            {
                switch (temp)
                {
                    case "color2":
                        panel3.BackColor = pictureBox2.BackColor;
                        temp = "";
                        break;
                    case "color3":
                        panel3.BackColor = pictureBox3.BackColor;
                        temp = "";

                        break;
                    case "color4":
                        panel3.BackColor = pictureBox4.BackColor;
                        temp = "";

                        break;
                    case "furn7":
                        var cp = PointToClient(Cursor.Position);
                        panel3.Controls.Add(new PictureBox()
                        {
                            Image = pictureBox7.Image,
                            Location = new System.Drawing.Point(cp.X - panel3.Location.X, cp.Y - panel3.Location.Y),
                            Size = new System.Drawing.Size(39, 30),
                            SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
                        });
                        temp = "";

                        break;
                    case "furn6":
                        var cp1 = PointToClient(Cursor.Position);
                        panel3.Controls.Add(new PictureBox()
                        {
                            Image = pictureBox6.Image,
                            Location = new System.Drawing.Point(cp1.X - panel3.Location.X, cp1.Y - panel3.Location.Y),
                            Size = new System.Drawing.Size(39, 30),
                            SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
                        });
                        temp = "";


                        break;
                    case "furn5":
                        var cp2 = PointToClient(Cursor.Position);
                        panel3.Controls.Add(new PictureBox()
                        {
                            Image = pictureBox5.Image,
                            Location = new System.Drawing.Point(cp2.X - panel3.Location.X, cp2.Y - panel3.Location.Y),
                            Size = new System.Drawing.Size(39, 30),
                            SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
                        });
                        temp = "";


                        break;
                    case "kant10":
                        panel10.BackColor = pictureBox10.BackColor;
                        panel9.BackColor = pictureBox10.BackColor;
                        panel8.BackColor = pictureBox10.BackColor;
                        panel7.BackColor = pictureBox10.BackColor;
                        temp = "";
                        break;

                    case "kant9":
                        panel10.BackColor = pictureBox9.BackColor;
                        panel9.BackColor = pictureBox9.BackColor;
                        panel8.BackColor = pictureBox9.BackColor;
                        panel7.BackColor = pictureBox9.BackColor;
                        temp = "";
                        break;
                    case "kant8":
                        panel10.BackColor = pictureBox8.BackColor;
                        panel9.BackColor = pictureBox8.BackColor;
                        panel8.BackColor = pictureBox8.BackColor;
                        panel7.BackColor = pictureBox8.BackColor;
                        temp = "";
                        break;
                }
               
            }
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            temp = "furn7";
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            temp = "furn6";

        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            temp = "furn5";

        }

        private void Constructor_MouseUp(object sender, MouseEventArgs e)
        {
            if(!(e.Button == MouseButtons.Left)) temp = "";
        }

        // Поворот фурнитуры
        private void pictureBox7_DoubleClick(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pb.Invalidate();
        }
        // Поворот фурнитуры

        private void pictureBox5_DoubleClick(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pb.Invalidate();
        }
        // Поворот фурнитуры

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pb.Invalidate();
        }

        private void pictureBox10_MouseDown(object sender, MouseEventArgs e)
        {
            temp = "kant10";
        }

        private void pictureBox9_MouseDown(object sender, MouseEventArgs e)
        {
            temp = "kant9";

        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            temp = "kant8";

        }

        private void Constructor_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {

        }
    }
}
