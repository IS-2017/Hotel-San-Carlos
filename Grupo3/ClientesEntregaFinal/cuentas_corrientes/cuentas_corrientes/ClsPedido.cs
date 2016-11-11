using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_corrientes
{
   public  class ClsPedido
    {
        public int codped { get; set; }
        public int codemp { get; set; }
        public DateTime fec_pedido { get; set; }
        public string estado { get; set; }
        public int codcte { get; set; }
        public string estado2 { get; set; }
        public int codvende { get; set; }
        


        public ClsPedido() { }

        public ClsPedido(int icodi, int icoemp, DateTime fecped, string est,  int codct, string esta2, int vende)

        {
            this.codped = icodi;
            this.codemp = icoemp;
            this.fec_pedido = fecped;
            this.estado = est;
            this.codcte = codct;
            this.estado2 = estado2;
            this.codvende = vende;
            
        }
    }
}
