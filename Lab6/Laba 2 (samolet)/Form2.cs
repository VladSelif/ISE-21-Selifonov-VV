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
    public partial class Form2 : Form
    {
        // переменная-выбранная машина
        ITransport airplane = null;
        // получить машину

        public ITransport getAirplane { get { return airplane; } }
        

        public Form2()
        {
            InitializeComponent();
            panel2.MouseDown += panelColor_MouseDown;
            panel3.MouseDown += panelColor_MouseDown;
            panel4.MouseDown += panelColor_MouseDown;
            panel5.MouseDown += panelColor_MouseDown;
            panel6.MouseDown += panelColor_MouseDown;
            panel7.MouseDown += panelColor_MouseDown;
            panel8.MouseDown += panelColor_MouseDown;
            panel9.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
       
       

        private void DrawAirplane()
        {
            if (airplane != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxAirplane.Width, pictureBoxAirplane.Height);
                Graphics gr = Graphics.FromImage(bmp);
                airplane.setPosition(5, 5);
                airplane.drawAirplane(gr);
                pictureBoxAirplane.Image = bmp;
            }
        }
       

        private event myDel eventAddAirplane;

        public void AddEvent(myDel ev)
        {
            if (eventAddAirplane == null)
            {
                eventAddAirplane = new myDel(ev);
            }
            else
            {
                eventAddAirplane += ev;
            }
        }

        private void labelAirplane_MouseDown(object sender, MouseEventArgs e)
        {
            labelAirplane.DoDragDrop(labelAirplane.Text, DragDropEffects.Move | DragDropEffects.Copy);

        }

        private void labelAerobus_MouseDown(object sender, MouseEventArgs e)
        {
            labelAerobus.DoDragDrop(labelAerobus.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }



        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Airplane":
                    airplane = new Airplane(100, 4, 500, Color.White);
                    break;
                case "Aerobus":
                    airplane = new Aerobus(100, 4, 500, Color.White, true, true, true, true, Color.Black);
                    break;
            }
            DrawAirplane();

        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
       
      
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if ( airplane != null)
            {
                airplane.setMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawAirplane();
            }

        }

        
        

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, 
                DragDropEffects.Move | DragDropEffects.Copy);
        }



        private void label2_DragDrop(object sender, DragEventArgs e)
        {

            if (airplane != null)
            {
                if (airplane is Aerobus)
                {
                    (airplane as Aerobus).setDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawAirplane();
                }
            }
        }

       

        
        private void buttonSetAirplane_Click(object sender, EventArgs e)
        {
            if (eventAddAirplane != null)
            {
                eventAddAirplane(airplane);
            }
            Close();
        }

     
    }
}
