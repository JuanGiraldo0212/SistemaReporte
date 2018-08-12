using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public class Objeto
    {
        private String articulo;
        private String color;
        private String fecha;
        private String hora;
        private String lugar;


        public Objeto(String articulo,String color, String fecha, String hora, String lugar ) {
            this.articulo = articulo;
            this.color = color;
            this.fecha = fecha;
            this.hora = hora;
            this.lugar = lugar;
           
        }

        public String getArticulo() {
            return articulo;
        }

        public String getColor()
        {
            return color;
        }

        public String getFecha()
        {
            return fecha;
        }

        public String getHora()
        {
            return hora;
        }

        public String getLugar()
        {
            return lugar;
        }

    }
}
