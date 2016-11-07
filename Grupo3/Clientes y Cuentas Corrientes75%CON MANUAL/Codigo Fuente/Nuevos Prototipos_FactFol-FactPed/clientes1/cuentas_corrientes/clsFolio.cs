using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_corrientes
{
    public class clsFolio
    {
        public int cod { get; set; }
        public string estado { get; set; }
        public string fec_pago { get; set; }
        public string fec_ingre { get; set; }
        public int codcte { get; set; }
        public int costo { get; set; }
       

        public clsFolio() { }

        public clsFolio(int icodi, string esta, string fec_p , int codct ,string fec_ing, int cost)

        {
            this.cod = icodi;
            this.estado = esta;
            this.fec_pago = fec_p;
            this.codcte = codct;
            this.fec_ingre = fec_ing;
            this.costo = cost;
        }
    }
}
