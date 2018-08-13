using System;
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

        public LoginUsuario()
        {
            InitializeComponent();
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Modelo hola = Ventana.darModelo();
            Hashtable hash = hola.getUsuarios();
            String usuario = textBox3.Text;
            if (hash.ContainsKey(usuario))
            {
                var pass = hash[usuario];
                if (pass.Equals(textBox4.Text))
                {
                    textBox3.Text = "";
                    textBox4.Text = "";
                    this.SendToBack();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta.");
                }
                
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta.");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginUsuario_Load(object sender, EventArgs e)
        {
            
        }
    }
}
