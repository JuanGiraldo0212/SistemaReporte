using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tarea1;

namespace WindowsFormsApplication3
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 ventanita = new Form1();
            ventanita.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 ventanita = new Form2();
            ventanita.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter("..\\..\\Objetos.txt");
            Modelo model = Ventana.darModelo();
            List<Objeto> listaObjetos = model.getObjetos();
            foreach (Objeto item in listaObjetos) {
                file.WriteLine((item.getArticulo()+"-"+item.getColor()+"-"+item.getFecha()+"-"+item.getHora()+"-"+item.getLugar()).Trim());
            }
            
            file.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String pathUsuarios = "..\\..\\Objetos.txt";
            List<String> lines = File.ReadAllLines(pathUsuarios).ToList();
            Modelo model = Ventana.darModelo();
            List<Objeto> lista = model.getObjetos();
            foreach (string item in lines)
            {
                String[] split = item.Split('-');
                String articulo = split[0];
                String color = split[1];
                String fecha = split[2];
                String hora = split[3];
                String lugar = split[4];
                Objeto nuevo = new Objeto(articulo,color,fecha,hora,lugar);
                lista.Add(nuevo);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
