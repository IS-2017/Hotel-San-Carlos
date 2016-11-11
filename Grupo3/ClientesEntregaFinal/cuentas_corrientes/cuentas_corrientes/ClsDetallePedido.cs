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
        public int idemple { get; set;}
        public int idpedi { get; set; }
        public int idbien { get; set; }
        public int cantidad { get; set; }
        public string descripcion { get; set; }
        public decimal prec { get; set; }
        public decimal subtotal { get; set; }
        public int idcat { get; set; }
        public int idprecio { get; set; }
        public string estado { get; set; }
        
        public string estadetalle { get; set; }



        public ClsDetallePedido() { }

        public ClsDetallePedido(int icodi, int emple, int pedi, int bien, int cant, string desc, decimal preci, decimal subt, int cate, int pre, string estado, string estado1)

        {
            this.cod = icodi;
            this.idemple = emple;
            this.idpedi = pedi;
            this.idbien = bien;
            this.cantidad = cant;
            this.descripcion = desc;
            this.prec = preci;
            this.subtotal = subt;
            this.idcat = cate;
            this.idprecio = pre;
            this.estado = estado;
            this.estadetalle = estado1;

        }
    }
}
