using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_2__samolet_
{
    public partial class Form1 : Form
    {
        Color color;
        Color dopColor;
        int maxSpeed;
        int maxCountPass;
        int weight;

        private ITransport inter;
        public Form1()

        {
            InitializeComponent();
            color = Color.Gray;
            dopColor = Color.LightBlue;
            maxSpeed = 150;
            maxCountPass = 4;
            weight = 1500;
            SelectColor.BackColor = color;
            SelectDopColor.BackColor = dopColor;
        }

        private void MoveAirplane_Click(object sender, EventArgs e)
        {
            if (inter != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.moveAirplane(gr);
                pictureBox1.Image = bmp;
            }
        }

        private void zadatsamolet_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {

                inter = new Airplane(maxSpeed, maxCountPass, weight, color);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.drawAirplane(gr);
                pictureBox1.Image = bmp;
            }
        }

        private void SelectColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color = cd.Color;
                SelectColor.BackColor = color;
            }
        }

        private bool checkFields()
        {
            if (!int.TryParse(textBoxmaxspeed.Text, out maxSpeed))
            {
                return false;
            }
            if (!int.TryParse(textBoxcountpass.Text, out maxCountPass))
            {
                return false;
            }
            if (!int.TryParse(textBoxWeight.Text, out weight))
            {
                return false;
            }
            return true;
        }
        private void zadatAerobus_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {

                if (checkFields())
                {
                    inter = new Aerobus(maxSpeed, maxCountPass, weight, color, windows.Checked, reactiveEngine_left.Checked,reactiveEngine_right.Checked, lines.Checked, dopColor);
                    Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    inter.drawAirplane(gr);
                    pictureBox1.Image = bmp;
                }
            }
        }

        private void SelectDopColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dopColor = cd.Color;
                SelectDopColor.BackColor = dopColor;
            }
        }

        private void Take_off_Click(object sender, EventArgs e)
        {
            if (inter != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.UpAirplane(gr);
                pictureBox1.Image = bmp;
            }
        }

        private void DownAirplane_Click(object sender, EventArgs e)
        {
            if (inter != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.DownAirplane(gr);
                pictureBox1.Image = bmp;
            }
        }
    }
}