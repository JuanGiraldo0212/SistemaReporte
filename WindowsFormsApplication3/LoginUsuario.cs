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
using System.Collections;

namespace WindowsFormsApplication3
{
    public partial class LoginUsuario : UserControl
    {

        Modelo hola = new Modelo();
        public LoginUsuario()
        {
            InitializeComponent();
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Hashtable hash = hola.getUsuarios();
            String usuario = textBox3.Text;
            if (hash.ContainsKey(usuario))
            {
                var pass = hash[usuario];
                if (pass.Equals(textBox4.Text))
                {
                    textBox3.Text = "Correcto";
                }
                this.Hide();
                
            }
            else
            {
                Console.WriteLine("No existe");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
