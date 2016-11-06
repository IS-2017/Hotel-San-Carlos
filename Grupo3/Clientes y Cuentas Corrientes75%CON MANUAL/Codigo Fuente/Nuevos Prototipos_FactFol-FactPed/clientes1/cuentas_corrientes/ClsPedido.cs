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

        public string estado { get; set; }
        public string fec_pedido { get; set; }
   
        public int codcte { get; set; }
        


        public ClsPedido() { }

        public ClsPedido(int icodi, int icoemp, string est, string fecped, int codct)

        {
            this.codped = icodi;
            this.codemp = icoemp;
            this.estado = est;
            this.fec_pedido = fecped;
            this.codcte = codct;
            
        }
    }
}
