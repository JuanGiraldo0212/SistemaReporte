using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Objeto
    {
        private String articulo;
        private String color;
        private String fecha;
        private String hora;
        private String lugar;
        private String descripcion;

        public Objeto(String articulo,String color, String fecha, String hora, String lugar, String descripcion) {
            this.articulo = articulo;
            this.color = color;
            this.fecha = fecha;
            this.hora = hora;
            this.lugar = lugar;
            this.descripcion = descripcion;
        }

    }
}
