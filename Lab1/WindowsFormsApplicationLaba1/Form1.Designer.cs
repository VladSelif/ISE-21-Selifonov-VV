namespace WindowsFormsApplicationLaba1
{
    partial class Formkitchen
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_knife_egg = new System.Windows.Forms.Button();
            this.button_dough = new System.Windows.Forms.Button();
            this.label_egg = new System.Windows.Forms.Label();
            this.numericUpDown_egg = new System.Windows.Forms.NumericUpDown();
            this.groupBox_products = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_knife = new System.Windows.Forms.GroupBox();
            this.Cut_testo = new System.Windows.Forms.Button();
            this.groupBox_dough = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox_egg = new System.Windows.Forms.CheckBox();
            this.checkBox_sugar = new System.Windows.Forms.CheckBox();
            this.checkBox_flour = new System.Windows.Forms.CheckBox();
            this.add_testo = new System.Windows.Forms.Button();
            this.groupBox_stove = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.open_stove = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_egg)).BeginInit();
            this.groupBox_products.SuspendLayout();
            this.groupBox_knife.SuspendLayout();
            this.groupBox_dough.SuspendLayout();
            this.groupBox_stove.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_knife_egg
            // 
            this.button_knife_egg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_knife_egg.Location = new System.Drawing.Point(65, 11);
            this.button_knife_egg.Name = "button_knife_egg";
            this.button_knife_egg.Size = new System.Drawing.Size(153, 40);
            this.button_knife_egg.TabIndex = 5;
            this.button_knife_egg.Text = "Разбить яйца";
            this.button_knife_egg.UseVisualStyleBackColor = true;
            this.button_knife_egg.Click += new System.EventHandler(this.button_knife_egg_Click);
            // 
            // button_dough
            // 
            this.button_dough.Location = new System.Drawing.Point(42, 147);
            this.button_dough.Name = "button_dough";
            this.button_dough.Size = new System.Drawing.Size(144, 74);
            this.button_dough.TabIndex = 8;
            this.button_dough.Text = "Замесить тесто";
            this.button_dough.UseVisualStyleBackColor = true;
            this.button_dough.Click += new System.EventHandler(this.button_dough_Click);
            // 
            // label_egg
            // 
            this.label_egg.AutoSize = true;
            this.label_egg.Location = new System.Drawing.Point(75, 28);
            this.label_egg.Name = "label_egg";
            this.label_egg.Size = new System.Drawing.Size(33, 13);
            this.label_egg.TabIndex = 14;
            this.label_egg.Text = "Яйца";
            // 
            // numericUpDown_egg
            // 
            this.numericUpDown_egg.Location = new System.Drawing.Point(114, 26);
            this.numericUpDown_egg.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_egg.Name = "numericUpDown_egg";
            this.numericUpDown_egg.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown_egg.TabIndex = 18;
            // 
            // groupBox_products
            // 
            this.groupBox_products.Controls.Add(this.button1);
            this.groupBox_products.Controls.Add(this.label_egg);
            this.groupBox_products.Controls.Add(this.numericUpDown_egg);
            this.groupBox_products.Location = new System.Drawing.Point(20, 25);
            this.groupBox_products.Name = "groupBox_products";
            this.groupBox_products.Size = new System.Drawing.Size(253, 112);
            this.groupBox_products.TabIndex = 22;
            this.groupBox_products.TabStop = false;
            this.groupBox_products.Text = "Ингредиенты";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(78, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 25);
            this.button1.TabIndex = 22;
            this.button1.Text = "✔";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox_knife
            // 
            this.groupBox_knife.Controls.Add(this.Cut_testo);
            this.groupBox_knife.Controls.Add(this.button_knife_egg);
            this.groupBox_knife.Location = new System.Drawing.Point(303, 28);
            this.groupBox_knife.Name = "groupBox_knife";
            this.groupBox_knife.Size = new System.Drawing.Size(279, 121);
            this.groupBox_knife.TabIndex = 24;
            this.groupBox_knife.TabStop = false;
            this.groupBox_knife.Text = "Нож";
            // 
            // Cut_testo
            // 
            this.Cut_testo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Cut_testo.Location = new System.Drawing.Point(65, 63);
            this.Cut_testo.Name = "Cut_testo";
            this.Cut_testo.Size = new System.Drawing.Size(153, 46);
            this.Cut_testo.TabIndex = 6;
            this.Cut_testo.Text = "Порезать тесто на кусочки";
            this.Cut_testo.UseVisualStyleBackColor = false;
            this.Cut_testo.Click += new System.EventHandler(this.Cut_testo_Click);
            // 
            // groupBox_dough
            // 
            this.groupBox_dough.Controls.Add(this.checkBox5);
            this.groupBox_dough.Controls.Add(this.checkBox4);
            this.groupBox_dough.Controls.Add(this.checkBox_egg);
            this.groupBox_dough.Controls.Add(this.checkBox_sugar);
            this.groupBox_dough.Controls.Add(this.checkBox_flour);
            this.groupBox_dough.Controls.Add(this.button_dough);
            this.groupBox_dough.Location = new System.Drawing.Point(20, 166);
            this.groupBox_dough.Name = "groupBox_dough";
            this.groupBox_dough.Size = new System.Drawing.Size(261, 261);
            this.groupBox_dough.TabIndex = 25;
            this.groupBox_dough.TabStop = false;
            this.groupBox_dough.Text = "Форма ";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(45, 120);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(112, 17);
            this.checkBox5.TabIndex = 14;
            this.checkBox5.Text = "Хлопья геркулес";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(45, 97);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(69, 17);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.Text = "Ванилин";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox_egg
            // 
            this.checkBox_egg.AutoSize = true;
            this.checkBox_egg.Location = new System.Drawing.Point(45, 28);
            this.checkBox_egg.Name = "checkBox_egg";
            this.checkBox_egg.Size = new System.Drawing.Size(52, 17);
            this.checkBox_egg.TabIndex = 10;
            this.checkBox_egg.Text = "Яйца";
            this.checkBox_egg.UseVisualStyleBackColor = true;
            // 
            // checkBox_sugar
            // 
            this.checkBox_sugar.AutoSize = true;
            this.checkBox_sugar.Location = new System.Drawing.Point(45, 51);
            this.checkBox_sugar.Name = "checkBox_sugar";
            this.checkBox_sugar.Size = new System.Drawing.Size(56, 17);
            this.checkBox_sugar.TabIndex = 11;
            this.checkBox_sugar.Text = "Сахар";
            this.checkBox_sugar.UseVisualStyleBackColor = true;
            this.checkBox_sugar.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox_flour
            // 
            this.checkBox_flour.AutoSize = true;
            this.checkBox_flour.Location = new System.Drawing.Point(45, 74);
            this.checkBox_flour.Name = "checkBox_flour";
            this.checkBox_flour.Size = new System.Drawing.Size(52, 17);
            this.checkBox_flour.TabIndex = 12;
            this.checkBox_flour.Text = "Мука";
            this.checkBox_flour.UseVisualStyleBackColor = true;
            this.checkBox_flour.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // add_testo
            // 
            this.add_testo.Location = new System.Drawing.Point(57, 19);
            this.add_testo.Name = "add_testo";
            this.add_testo.Size = new System.Drawing.Size(132, 66);
            this.add_testo.TabIndex = 0;
            this.add_testo.Text = "Добавить  сырые  печеньки ";
            this.add_testo.UseVisualStyleBackColor = true;
            this.add_testo.Click += new System.EventHandler(this.add_testo_Click);
            // 
            // groupBox_stove
            // 
            this.groupBox_stove.Controls.Add(this.add_testo);
            this.groupBox_stove.Controls.Add(this.button4);
            this.groupBox_stove.Controls.Add(this.button3);
            this.groupBox_stove.Controls.Add(this.open_stove);
            this.groupBox_stove.Location = new System.Drawing.Point(303, 166);
            this.groupBox_stove.Name = "groupBox_stove";
            this.groupBox_stove.Size = new System.Drawing.Size(253, 261);
            this.groupBox_stove.TabIndex = 27;
            this.groupBox_stove.TabStop = false;
            this.groupBox_stove.Text = "Духовка";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(57, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 54);
            this.button4.TabIndex = 8;
            this.button4.Text = "ГОТОВИТЬ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(57, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Поставить форму";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // open_stove
            // 
            this.open_stove.AutoSize = true;
            this.open_stove.Location = new System.Drawing.Point(78, 91);
            this.open_stove.Name = "open_stove";
            this.open_stove.Size = new System.Drawing.Size(73, 17);
            this.open_stove.TabIndex = 6;
            this.open_stove.TabStop = true;
            this.open_stove.Text = "включить";
            this.open_stove.UseVisualStyleBackColor = true;
            this.open_stove.CheckedChanged += new System.EventHandler(this.open_stove_CheckedChanged);
            // 
            // Formkitchen
            // 
            this.ClientSize = new System.Drawing.Size(631, 467);
            this.Controls.Add(this.groupBox_stove);
            this.Controls.Add(this.groupBox_dough);
            this.Controls.Add(this.groupBox_knife);
            this.Controls.Add(this.groupBox_products);
            this.HelpButton = true;
            this.Name = "Formkitchen";
            this.Text = "Кухня";
            this.Load += new System.EventHandler(this.Formkitchen_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_egg)).EndInit();
            this.groupBox_products.ResumeLayout(false);
            this.groupBox_products.PerformLayout();
            this.groupBox_knife.ResumeLayout(false);
            this.groupBox_dough.ResumeLayout(false);
            this.groupBox_dough.PerformLayout();
            this.groupBox_stove.ResumeLayout(false);
            this.groupBox_stove.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_dough;
        private System.Windows.Forms.Button button_knife_egg;
        private System.Windows.Forms.Label label_egg;
        private System.Windows.Forms.NumericUpDown numericUpDown_egg;
        private System.Windows.Forms.GroupBox groupBox_products;
        private System.Windows.Forms.GroupBox groupBox_knife;
        private System.Windows.Forms.GroupBox groupBox_dough;
        private System.Windows.Forms.GroupBox groupBox_stove;
        private System.Windows.Forms.CheckBox checkBox_egg;
        private System.Windows.Forms.CheckBox checkBox_sugar;
        private System.Windows.Forms.CheckBox checkBox_flour;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button Cut_testo;
        private System.Windows.Forms.Button add_testo;
        private System.Windows.Forms.RadioButton open_stove;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

