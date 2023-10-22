using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaGUI.Entidades
{
    public class Producto
    {
        public int Productonro { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public bool Activo { get; set; }

        public Producto()
        {
            Productonro= 0;
            Nombre= "";
            Precio= 0;
            Activo= false;
        }

        public Producto(int productonro, string nombre, double precio)
        {
            Productonro = productonro;
            Nombre = nombre;
            Precio = precio;
            Activo = true;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
