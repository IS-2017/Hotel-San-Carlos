using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_corrientes
{
    public class cls_tcredi
    {
        public int cod { get; set; }        
        public string tipo { get; set; }
        public string valor { get; set; }


        public cls_tcredi() { }

        public cls_tcredi(int icodi, string tip, string val)

        {
            this.cod = icodi;
            this.tipo = tip;
            this.valor = val;


        }
    }
}
