using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_facturas.MODELOS
{
    public class Producto
    {
        private string Cod;
        private string nombre;
        private string precio;
        private string stop;
        public Producto() { }

        public string Cod1 { get => Cod; set => Cod = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Precio { get => precio; set => precio = value; }
        public string Stop { get => stop; set => stop = value; }
    }
    
}
