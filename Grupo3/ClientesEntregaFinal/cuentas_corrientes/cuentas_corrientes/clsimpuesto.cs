using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_corrientes
{
    public class clsimpuesto
    {
        public int icod { get; set; }
        public Decimal iporcentaje { get; set; }
        public string snombre { get; set; }
        public string sdecripcion { get; set; }


        public clsimpuesto() { }

        public clsimpuesto(int icoemp, decimal ipor, string snom, string sdesc)

        {
            this.icod = icoemp;
            this.iporcentaje = ipor;
            this.snombre = snom;
            this.sdecripcion = sdesc;


        }

    }
}
