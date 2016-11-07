using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_corrientes
{
    public class cls_deuda
    {
        public int cod { get; set; }
        public int codclte { get; set; }
        public int codfac { get; set; }
        public int codemp { get; set; }
        public int codempl { get; set; }
        public string monto { get; set; }
        public string saldo { get; set; }
        public string serie { get; set; }       
        
        public cls_deuda() { }

        public cls_deuda(int icodi, int codc, int codf, int code, int codem, string mon, string sal, string ser)

        {
            this.cod = icodi;
            this.codclte = codc;
            this.codfac = codf;
            this.codemp = code;
            this.codempl = codem;
            this.monto = mon;
            this.saldo = sal;
            this.serie = ser;            

        }
    }
}
