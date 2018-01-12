using NLog;
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

        Form2 form;

        private Logger log;
        

        public Form1()
        {
            InitializeComponent();
            log = LogManager.GetCurrentClassLogger();
            parking = new Parking(5);
            

            for (int i = 1; i < 6; i++)
            {
                listBox1.Items.Add("Уровень " + i);
            }
            listBox1.SelectedIndex = parking.getCurrentLevel;

            Draw();
        }

        private void Draw()
        {
            if (listBox1.SelectedIndex > -1)
            {


                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking.Draw(gr);
                pictureBox1.Image = bmp;
            }
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
            if (listBox1.SelectedIndex > -1)
            {// Прежде чем забрать машину, надо выбрать с какого уровня будем забирать
                string level = listBox1.Items[listBox1.SelectedIndex].ToString();
                if (maskedTextBox1.Text != "")
                {
                    log.Info("Забрали из ангара :" + Convert.ToInt32(maskedTextBox1.Text));
                    
                    try
                    {
                        ITransport airplane = parking.GetAirplaneInParking(Convert.ToInt32(maskedTextBox1.Text));

                        Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        airplane.setPosition(5, 5);
                        airplane.drawAirplane(gr);
                        pictureBox2.Image = bmp;
                        Draw();
                    }
                    catch (ParkingOverflowException ex)
                    {
                        MessageBox.Show(ex.Message, "Неверный номер", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Общая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        { }
        private void pictureBox1_Click(object sender, EventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {
            parking.LevelDown();
            listBox1.SelectedIndex = parking.getCurrentLevel;
            log.Info("Переход на этаж ниже: " + parking.getCurrentLevel);
            Draw();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parking.LevelUp();
            listBox1.SelectedIndex = parking.getCurrentLevel;
            log.Info("Переход на этаж выше: " + parking.getCurrentLevel);
            Draw();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            form = new Form2();
            form.AddEvent(AddAirplane);
            form.Show();
           
        }

        private void AddAirplane(ITransport airplane)
        {
            if (airplane != null)
            {
                try { 

                int place = parking.PutAirplaneInParking(airplane);         
                  Draw();
                    log.Info("Добавление в ангар :" + place);
                    MessageBox.Show("Ваше место: " + place);
                }
                catch (ParkingOverflowException ex)
                {
                    MessageBox.Show

                        (ex.Message, "Ошибка переполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Общая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.SaveData(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.LoadData(openFileDialog1.FileName))
                {
                    MessageBox.Show("Загрузили", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("Не загрузили", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
