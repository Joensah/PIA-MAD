﻿namespace WinFormsApp2
{
    partial class Alta_Habitacion
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
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 36);
            label1.Name = "label1";
            label1.Size = new Size(154, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese los datos solicitados";
            // 
            // button1
            // 
            button1.Location = new Point(198, 440);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(189, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 113);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "Tipo/Nivel:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 157);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 5;
            label3.Text = "Número de camas:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(189, 149);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 23);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 196);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 7;
            label4.Text = "Tamaño de las camas:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(189, 193);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(165, 23);
            textBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 249);
            label5.Name = "label5";
            label5.Size = new Size(135, 15);
            label5.TabIndex = 9;
            label5.Text = "Precio Noche x Persona:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(189, 246);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(165, 23);
            textBox4.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(110, 296);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 11;
            label6.Text = "Capacidad:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(189, 288);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(165, 23);
            textBox5.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(104, 332);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 13;
            label7.Text = "Descripción:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(189, 329);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(194, 23);
            textBox6.TabIndex = 12;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(104, 373);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 15;
            label8.Text = "Amenidades:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(189, 370);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(194, 23);
            textBox7.TabIndex = 14;
            // 
            // Alta_Habitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 475);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Alta_Habitacion";
            Text = "Alta Habitación";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox7;
    }
}