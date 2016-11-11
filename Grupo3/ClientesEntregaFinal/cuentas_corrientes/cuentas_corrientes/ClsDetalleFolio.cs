using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_corrientes
{
    class ClsDetalleFolio
    {
        public int cod { get; set; }
        public string cantidad { get; set; }
        public string descripcion { get; set; }
        public int prec { get; set; }
        public int subtotal { get; set; }


        public ClsDetalleFolio() { }

        public ClsDetalleFolio(int icodi, string cant, string desc, int preci)

        {
            this.cod = icodi;
            this.cantidad = cant;
            this.descripcion = desc;
            this.prec = preci;

        }
    }
}
