using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_facturas.MODELOS
{
    public class Cliente
    {
        private string cedula;
        private string nombre;
        private string apellido;
        private string direccion;
     public Cliente (){}

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
