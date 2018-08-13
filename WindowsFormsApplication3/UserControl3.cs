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

namespace WindowsFormsApplication3
{
    public partial class UserControl3 : UserControl
    {
        private Modelo model=Ventana.darModelo();
        private List<Objeto> lista;

        public void reporteArticulos() {

            if (checkBox2.Checked)
            {
                var consulta = from s in lista
                               where s.getArticulo().Contains(textBox1.Text)
                               select s;
                String msg = "";
                foreach (Objeto item in consulta)
                {
                    msg += "Articulo: " + item.getArticulo() + "-Color: " + item.getColor() + "-Lugar: " + item.getLugar() + "-Fecha: " + item.getFecha() + "-Hora: " + item.getHora() + "\n" + "\n";
                }
                richTextBox1.Text = msg;

            }

            else if (checkBox1.Checked)
            {
                var consulta = from s in lista
                               where s.getColor().Contains(textBox1.Text)
                               select s;
                String msg = "";
                foreach (Objeto item in consulta)
                {
                    msg += "Articulo: " + item.getArticulo() + "-Color: " + item.getColor() + "-Lugar: " + item.getLugar() + "-Fecha: " + item.getFecha() + "-Hora: " + item.getHora() + "\n" + "\n";
                }
                richTextBox1.Text = msg;

            }

            else if (checkBox3.Checked)
            {
                var consulta = from s in lista
                               where s.getLugar().Contains(textBox1.Text)
                               select s;
                String msg = "";
                foreach (Objeto item in consulta)
                {
                    msg += "Articulo: " + item.getArticulo() + "-Color: " + item.getColor() + "-Lugar: " + item.getLugar() + "-Fecha: " + item.getFecha() + "-Hora: " + item.getHora() + "\n" + "\n";
                }
                richTextBox1.Text = msg;

            }
            else
            {
                var consulta = from s in lista
                               select s;
                String msg = "";
                foreach (Objeto item in consulta)
                {
                    msg += "Articulo: " + item.getArticulo() + "-Color: " + item.getColor() + "-Lugar: " + item.getLugar() + "-Fecha: " + item.getFecha() + "-Hora: " + item.getHora() + "\n" + "\n";
                }
                richTextBox1.Text = msg;

            }
        }
        public UserControl3()
        {
            InitializeComponent();
            lista = model.getObjetos();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reporteArticulos();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
