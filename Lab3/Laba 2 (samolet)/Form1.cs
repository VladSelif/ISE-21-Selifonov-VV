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

        Parking parking;
        public Form1()
        {
            InitializeComponent();
            parking = new Parking();
            Draw();
        }
      
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
        }

        private void buttonSetAirplane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var airplane = new Airplane(100, 4, 1000, dialog.Color);
                int place = parking.PutAirplaneInParking(airplane);
                Draw();
                MessageBox.Show("№ Ангара: " + place);
            }
        }

        private void buttonSetAerobus_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var airplane = new Aerobus(100, 4, 1000, dialog.Color, true, true, true, true, dialogDop.Color);
                    int place = parking.PutAirplaneInParking(airplane);
                    Draw();
                    MessageBox.Show("№ Ангара: " + place);
                }
            }


        }

        private void buttonTakeAirplane_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                var airplane = parking.GetAirplaneInParking(Convert.ToInt32(maskedTextBox1.Text));

                Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                Graphics gr = Graphics.FromImage(bmp);
                airplane.setPosition(5, 5);
                airplane.drawAirplane(gr);
                pictureBox2.Image = bmp;
                Draw();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {}    
        private void pictureBox1_Click(object sender, EventArgs e)
        {}

   
    }
}