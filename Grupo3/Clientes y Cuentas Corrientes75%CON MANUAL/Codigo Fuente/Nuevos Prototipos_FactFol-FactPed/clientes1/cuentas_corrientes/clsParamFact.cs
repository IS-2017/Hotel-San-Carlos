using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_corrientes
{
  public   class clsParamFact
    {
        public int icod { get; set; }

        public string snombre { get; set; }
        public string sdecripcion { get; set; }


        public clsParamFact() { }

        public clsParamFact(int icoemp, string snom, string sdesc)

        {
            this.icod = icoemp;

            this.snombre = snom;
            this.sdecripcion = sdesc;


        }
    }
}
