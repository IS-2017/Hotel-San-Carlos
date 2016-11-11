using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_corrientes
{
    public class ClsFactura
    {
        public int cod_fact { get; set; }
        public int cod_emp { get; set; }
        public string serie { get; set; }
        public int cod_vendedor { get; set; }
        public int cod_cte { get; set; }
        public decimal cod_imp { get; set; }
        public string fec_ven{ get; set; }
        public string fec_emision { get; set; }
        public string estado_fact { get; set; }
        public string estado { get; set; }
        public decimal subtotal { get; set; }
        public decimal total { get; set; }

        public ClsFactura() { }

        public ClsFactura(int codfact, int codemp, string seri, int codven, int concte, decimal codimp, string fecven, string fecemi, string efact, string est, decimal subt, decimal tot )

        {
            this.cod_fact = cod_fact;
            this.cod_emp = cod_emp;
            this.serie = seri;
            this.cod_vendedor = codven;
            this.cod_cte = concte;
            this.cod_imp = codimp;
            this.fec_ven = fecven;
            this.fec_emision = fecemi;
            this.estado_fact = efact;
            this.estado = est;
            this.subtotal = subt;
            this.total = total;
        }
    }
}
