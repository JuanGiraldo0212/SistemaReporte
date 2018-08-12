using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Tarea1
{
    public class Modelo
    {

        private List<Objeto> objetos;
        private Hashtable usuarios;
  
        public Modelo() {

            objetos = new List<Objeto>();
            usuarios = new Hashtable();
            cargarUsuarios();
            
        }
        public void cargarUsuarios() {
        
            String pathUsuarios = "..\\..\\Usuarios.txt";
            List<String> lines = File.ReadAllLines(pathUsuarios).ToList();
            foreach (string item in lines) {
                String[] split = item.Split('-');
                usuarios.Add(split[0],split[1]);
                Console.WriteLine("ok");
            }
            
        }

        public void agregarArticulo(Objeto nuevo) {

            objetos.Add(nuevo);
        }

        public Hashtable getUsuarios() {

            return usuarios;
        }

        public List<Objeto> getObjetos() {

            return objetos;
        }
       
    }
}
