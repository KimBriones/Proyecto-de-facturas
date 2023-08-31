using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_facturas.MODELOS
{
    public class Det_factura
    {
        private string num_factura;
        private string Cod_producto;
        public Det_factura() { }

        public string Num_factura { get => num_factura; set => num_factura = value; }
        public string Cod_producto1 { get => Cod_producto; set => Cod_producto = value; }
    }
}
