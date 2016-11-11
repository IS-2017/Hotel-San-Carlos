using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_corrientes
{
    public class ClsListadoPrecio
    {
        public int codtipo { get; set; }
        public float precio { get; set; }
        public int codbien { get; set; }
        public float costo { get; set; }
        public string descripcion { get; set; }

        public ClsListadoPrecio() { }

        public ClsListadoPrecio(int codt, float pre, int cbien, float c, string desc)

        {
            this.codtipo = codt;
            this.precio = pre;
            this.codbien = cbien;
            this.costo = c;
            this.descripcion = desc;
        }
    }
}
