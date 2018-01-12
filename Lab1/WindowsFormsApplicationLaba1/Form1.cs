using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApplicationLaba1
{
    public partial class Formkitchen : System.Windows.Forms.Form
    {
        private Egg[] eggs;
        private Sugar sugar;
        private Flour flour;
        private Dough d;
        private Knife knife;
        private Pan pan;
        private Stove stove;
        private Vanillin vanillin;
        private Flakes_gerkules flakes;

        public Formkitchen()
        {
            InitializeComponent();
        }

        private void Formkitchen_Load_1(object sender, EventArgs e)
        {
            knife = new Knife();
            pan = new Pan();
            stove = new Stove();
            d = new Dough();
            sugar = new Sugar();
            flour = new Flour();
            flakes = new Flakes_gerkules();
            vanillin = new Vanillin();
        }

        private void button_knife_egg_Click(object sender, EventArgs e)
        {

            if (eggs == null)
            {
                MessageBox.Show("Что разбивать, если яйца не добавили? ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (eggs.Length == 0)
            {
                MessageBox.Show("Что разбивать,если яйца не добавили? ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < eggs.Length; i++)
            {
                eggs[i].Have_shell_egg = false;
            }

            for (int i = 0; i < eggs.Length; ++i)
            {
                knife.Cut_Egg(eggs[i]);
            }

            numericUpDown_egg.Enabled = false;
            MessageBox.Show("яйца разбили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Cut_testo_Click(object sender, EventArgs e)

        {
            if (!button_dough.Enabled == true)
            {

                MessageBox.Show("тесто порезали на кусочки", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cut_testo.Enabled = false;
                return;
            }
            else
            {
                MessageBox.Show("нужно тесто, чтобы нарезать!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Error);

               add_testo.Enabled = true;
            }
        }
  
        private void button_dough_Click(object sender, EventArgs e)
        {

            if ((eggs != null) && (eggs.Length != 0))
            {
                for (int i = 0; i < eggs.Length; i++)
                {
                    if (eggs[i].Have_shell_egg == true)
                    {
                        MessageBox.Show("яйца не разбиты!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            if ((eggs == null) || (!checkBox_egg.Checked))
            {
                MessageBox.Show("Яиц нет!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((eggs.Length == 0) || (!checkBox_egg.Checked))
            {
                MessageBox.Show("Яиц нет!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                for (int i = 0; i < eggs.Length; i++)
                {
                    d.AddEgg(eggs[i]);
                }
            }

            if (!sugar.Count_Sugar)
            {
                MessageBox.Show("Добавьте сахар!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                sugar = new Sugar();
                d.AddSugar(sugar);
            }
            if (!flour.Count_Flour)
            {
                MessageBox.Show("Добавьте муки!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                flour = new Flour();
                d.AddFlour(flour);
            }

            if (!flakes.Count_Flakes)
            {
                MessageBox.Show("Добавьте хлопья!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                flakes = new Flakes_gerkules();
                d.AddFlakes_gerkules(flakes);
            }

            if (!vanillin.Count_Vanillin)
            {
                MessageBox.Show("Добавьте ванилин!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                vanillin = new Vanillin();
                d.AddVanillin(vanillin);
            }

            MessageBox.Show("Тесто замешано", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

            button_dough.Enabled = false;
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_sugar.Checked)
            {
                sugar.Count_Sugar = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_flour.Checked)
            {
                flour.Count_Flour = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                vanillin.Count_Vanillin = true;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                flakes.Count_Flakes = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown_egg.Value == 0)
            {
                MessageBox.Show("Нужно добавить яйца!", "Ингредиенты", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (numericUpDown_egg.Value > 0)
            {
                MessageBox.Show("Ингредиенты добавлены", "Ингредиенты", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = true;
            }

            eggs = new Egg[Convert.ToInt32(numericUpDown_egg.Value)];
            d.Init(eggs.Length);
            for (int i = 0; i < eggs.Length; i++)
            {
                eggs[i] = new Egg();
            }
        }

        private void add_testo_Click(object sender, EventArgs e)
        {          
                if (!Cut_testo.Enabled)
                {
                    if (d == null)
                    {
                        MessageBox.Show("Добавьте сырые печеньки!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Сырые печеньки добавлены!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pan.AddDough(d);
                    }
                }

                else
                MessageBox.Show("Нарежьте тесто!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                add_testo.Enabled = true;         
        }

        private void open_stove_CheckedChanged(object sender, EventArgs e)
        {
            stove.State = open_stove.Checked;
            add_testo.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stove.Pan = pan;
            button4.Enabled = true;
            add_testo.Enabled = false;
            MessageBox.Show("Форма в духовке", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void button4_Click(object sender, EventArgs e)
        {

            if (!add_testo.Enabled)
            {
                if (!stove.State)
                {
                    MessageBox.Show("Включите духовку!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                stove.Cook();
                if (!stove.Pan.Isready())
                {
                    open_stove.Checked = false;
                    MessageBox.Show("ГОТОВОО!!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    button4.Enabled = false;
                    MessageBox.Show("нажали куда-то не туда", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {

                MessageBox.Show("Добавьте сырые печеньки", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
