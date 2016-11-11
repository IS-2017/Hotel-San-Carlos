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

        public int icodmep{ get; set; }
        public int codimp{ get; set; }


        public clsParamFact() { }

        public clsParamFact(int icoemp, int emp, int imp)

        {
            this.icod = icoemp;

            this.icodmep = emp;
            this.codimp = imp;


        }
    }
}
