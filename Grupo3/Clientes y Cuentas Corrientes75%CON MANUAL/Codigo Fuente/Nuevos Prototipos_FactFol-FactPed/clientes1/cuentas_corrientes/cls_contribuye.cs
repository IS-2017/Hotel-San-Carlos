using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_corrientes
{
    public class cls_contribuye
    {
        public int cod { get; set; }
        public string nombre { get; set; }
        public string nit { get; set; }


        public cls_contribuye() { }

        public cls_contribuye(int icodi, string nom, string val)

        {
            this.cod = icodi;
            this.nombre = nom;
            this.nit = val;


        }
    }
}
