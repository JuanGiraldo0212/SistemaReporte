﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea1;

namespace WindowsFormsApplication3
{
    public partial class UserControl2 : UserControl
    {

        public void agregarArticulo() {

            Modelo model = Ventana.darModelo();
            String objeto = textBox1.Text;
            String lugar = textBox2.Text;
            String hora = textBox3.Text;
            String fecha = textBox4.Text;
            String color = textBox5.Text;
            Objeto nuevo = new Objeto(objeto, color, fecha, hora, lugar);
            model.agregarArticulo(nuevo);

            textBox1.Text = "Nombre";
            textBox2.Text = "lugar";
            textBox3.Text = "hora";
            textBox4.Text = "fecha";
            textBox5.Text = "color";
        
    }
        public UserControl2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            FindForm().Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregarArticulo();
        }
    }
}
