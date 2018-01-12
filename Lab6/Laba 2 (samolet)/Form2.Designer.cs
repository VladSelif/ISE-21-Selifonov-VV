namespace Laba_2__samolet_
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxAirplane = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAerobus = new System.Windows.Forms.Label();
            this.labelAirplane = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSetAirplane = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirplane)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAirplane
            // 
            this.pictureBoxAirplane.Location = new System.Drawing.Point(52, 22);
            this.pictureBoxAirplane.Name = "pictureBoxAirplane";
            this.pictureBoxAirplane.Size = new System.Drawing.Size(160, 141);
            this.pictureBoxAirplane.TabIndex = 0;
            this.pictureBoxAirplane.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAerobus);
            this.groupBox1.Controls.Add(this.labelAirplane);
            this.groupBox1.Location = new System.Drawing.Point(23, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип Флюзеляжа";
            // 
            // labelAerobus
            // 
            this.labelAerobus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAerobus.Location = new System.Drawing.Point(47, 97);
            this.labelAerobus.Name = "labelAerobus";
            this.labelAerobus.Size = new System.Drawing.Size(87, 40);
            this.labelAerobus.TabIndex = 1;
            this.labelAerobus.Text = "Aerobus";
            this.labelAerobus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAerobus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAerobus_MouseDown);
            // 
            // labelAirplane
            // 
            this.labelAirplane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAirplane.Location = new System.Drawing.Point(47, 45);
            this.labelAirplane.Name = "labelAirplane";
            this.labelAirplane.Size = new System.Drawing.Size(87, 37);
            this.labelAirplane.TabIndex = 0;
            this.labelAirplane.Text = "Airplane";
            this.labelAirplane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAirplane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAirplane_MouseDown);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelBaseColor);
            this.panel1.Controls.Add(this.pictureBoxAirplane);
            this.panel1.Location = new System.Drawing.Point(237, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 366);
            this.panel1.TabIndex = 2;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(39, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "Доп. Цвет";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.DragDrop += new System.Windows.Forms.DragEventHandler(this.label2_DragDrop);
            this.label2.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelBaseColor.Location = new System.Drawing.Point(39, 178);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(140, 46);
            this.labelBaseColor.TabIndex = 1;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel9);
            this.groupBox2.Controls.Add(this.panel8);
            this.groupBox2.Controls.Add(this.panel7);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(520, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 285);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвета";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gold;
            this.panel9.Location = new System.Drawing.Point(75, 159);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(41, 37);
            this.panel9.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Location = new System.Drawing.Point(17, 159);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(41, 37);
            this.panel8.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Yellow;
            this.panel7.Location = new System.Drawing.Point(75, 116);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(41, 37);
            this.panel7.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Red;
            this.panel6.Location = new System.Drawing.Point(17, 116);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(41, 37);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumBlue;
            this.panel5.Location = new System.Drawing.Point(75, 73);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(41, 37);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Lime;
            this.panel4.Location = new System.Drawing.Point(17, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(41, 37);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(75, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(41, 37);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(17, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(41, 37);
            this.panel2.TabIndex = 0;
            // 
            // buttonSetAirplane
            // 
            this.buttonSetAirplane.Location = new System.Drawing.Point(23, 273);
            this.buttonSetAirplane.Name = "buttonSetAirplane";
            this.buttonSetAirplane.Size = new System.Drawing.Size(75, 23);
            this.buttonSetAirplane.TabIndex = 4;
            this.buttonSetAirplane.Text = "добавить";
            this.buttonSetAirplane.UseVisualStyleBackColor = true;
            this.buttonSetAirplane.Click += new System.EventHandler(this.buttonSetAirplane_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(139, 308);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 466);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSetAirplane);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirplane)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAirplane;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAerobus;
        private System.Windows.Forms.Label labelAirplane;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSetAirplane;
        private System.Windows.Forms.Button buttonCancel;
    }
}