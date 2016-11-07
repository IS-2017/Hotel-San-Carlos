using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_corrientes
{
    public class ClsDetallePedido
    {
        public int cod { get; set; }
        public int cantidad { get; set; }
        public string descripcion { get; set; }
        public decimal prec { get; set; }
        public decimal subtotal { get; set; }


        public ClsDetallePedido() { }

        public ClsDetallePedido(int icodi, int cant, string desc, decimal preci, decimal subt)

        {
            this.cod = icodi;
            this.cantidad = cant;
            this.descripcion = desc;
            this.prec = preci;
            this.subtotal = subt;

        }
    }
}
