using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_corrientes
{
   public  class clsFomPago
    {
        public int icod { get; set; }
       
        public string stp { get; set; }
        public string sdecripcion { get; set; }


        public clsFomPago() { }

        public clsFomPago(int icoemp,  string stip, string sdesc)

        {
            this.icod = icoemp;
          
            this.stp = stip;
            this.sdecripcion = sdesc;


        }
    }
}
