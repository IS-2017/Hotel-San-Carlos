using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_corrientes
{
   public class clsComun
    {
        public int cod { get; set; }
        public string nombre { get; set; }
        
        public clsComun() { }

        public clsComun(int icodi, string nombre)

        {
            this.cod = icodi;
            this.nombre = nombre;


        }
    }
}
