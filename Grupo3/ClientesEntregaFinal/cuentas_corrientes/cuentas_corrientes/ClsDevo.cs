using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_corrientes
{
   public  class ClsDevo
    {
        public int id_dev { get; set; }
        public int cod_emp { get; set; }
        public string serie { get; set; }
        public int cod_fact { get; set; }
        public int cod_cte { get; set; }
        public string fec_emision { get; set; }
        public string motivo { get; set; }
        public decimal total { get; set; }

        public ClsDevo() { }

        public ClsDevo(int codev, int codfact, int codemp, string seri, int concte, string fecemi, decimal subt, decimal tot)

        {
            this.cod_fact = cod_fact;
            this.cod_emp = cod_emp;
            this.serie = seri;
            this.id_dev = codev;
            this.cod_cte = concte;
           
            this.fec_emision = fecemi;
  
           this.total = total;
        }
    }
}
