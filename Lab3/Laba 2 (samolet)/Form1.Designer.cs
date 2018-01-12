namespace Laba_2__samolet_
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSetAirplane = new System.Windows.Forms.Button();
            this.buttonSetAerobus = new System.Windows.Forms.Button();
            this.buttonTakeAirplane = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(672, 557);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonSetAirplane
            // 
            this.buttonSetAirplane.Location = new System.Drawing.Point(684, 39);
            this.buttonSetAirplane.Name = "buttonSetAirplane";
            this.buttonSetAirplane.Size = new System.Drawing.Size(152, 83);
            this.buttonSetAirplane.TabIndex = 1;
            this.buttonSetAirplane.Text = "Загнать в ангар самолет";
            this.buttonSetAirplane.UseVisualStyleBackColor = true;
            this.buttonSetAirplane.Click += new System.EventHandler(this.buttonSetAirplane_Click);
            // 
            // buttonSetAerobus
            // 
            this.buttonSetAerobus.Location = new System.Drawing.Point(684, 137);
            this.buttonSetAerobus.Name = "buttonSetAerobus";
            this.buttonSetAerobus.Size = new System.Drawing.Size(152, 84);
            this.buttonSetAerobus.TabIndex = 2;
            this.buttonSetAerobus.Text = "Загнать в Ангар Аэробус";
            this.buttonSetAerobus.UseVisualStyleBackColor = true;
            this.buttonSetAerobus.Click += new System.EventHandler(this.buttonSetAerobus_Click);
            // 
            // buttonTakeAirplane
            // 
            this.buttonTakeAirplane.Location = new System.Drawing.Point(57, 50);
            this.buttonTakeAirplane.Name = "buttonTakeAirplane";
            this.buttonTakeAirplane.Size = new System.Drawing.Size(75, 23);
            this.buttonTakeAirplane.TabIndex = 3;
            this.buttonTakeAirplane.Text = "Выбрать";
            this.buttonTakeAirplane.UseVisualStyleBackColor = true;
            this.buttonTakeAirplane.Click += new System.EventHandler(this.buttonTakeAirplane_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonTakeAirplane);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(678, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 218);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор Самолета";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(6, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 133);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "№ Ангара";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(83, 24);
            this.maskedTextBox1.Mask = "00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(75, 20);
            this.maskedTextBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 557);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSetAerobus);
            this.Controls.Add(this.buttonSetAirplane);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSetAirplane;
        private System.Windows.Forms.Button buttonSetAerobus;
        private System.Windows.Forms.Button buttonTakeAirplane;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

