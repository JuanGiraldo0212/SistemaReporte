using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Tarea1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hashtable hash = hola.getUsuarios();
            String usuario = textBox1.Text;
            var pass = hash[usuario];
            if (pass.Equals(textBox2.Text)) {
                label1.Text = "Correcto";
            }
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }
    }
}
