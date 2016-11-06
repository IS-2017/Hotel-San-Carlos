using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_corrientes
{
   public  class ClsDetalleFact
    {
      
        public int cod_fact { get; set; }
        public int cod_emp { get; set; }
        public string serie { get; set; }
        public int  cod_bien { get; set; }
        public int cantidad { get; set; }
        public string descripcion { get; set; }
        public int prec { get; set; }
        public int subtotal { get; set; }


        public ClsDetalleFact() { }

        public ClsDetalleFact(int codfact, int codemp, int codbien,  string ser,  int cant, string desc, int preci, int subto)

        {
            this.cod_fact = codfact;
            this.cod_emp = codemp;
            this.cod_bien = codbien;
            this.serie = ser;
            this.cantidad = cant;
            this.descripcion = desc;
            this.prec = preci;
            this.subtotal = subto;
        }
    }
}
