using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Tarea1
{
    public partial class UserControl2 : UserControl
    {

        Modelo hola = new Modelo();

        public UserControl2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Hashtable hash = hola.getUsuarios();
            String usuario = textBox1.Text;
            if (hash.ContainsKey(usuario))
            {
                var pass = hash[usuario];
                if (pass.Equals(textBox2.Text))
                {
                    textBox1.Text = "Correcto";
                }
                this.Hide();
                Form2 f = new Form2();
                f.Show();
            }
            else {
                Console.WriteLine("No existe");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
