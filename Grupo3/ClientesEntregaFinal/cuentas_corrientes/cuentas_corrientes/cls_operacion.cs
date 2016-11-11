using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_corrientes
{
    public class cls_operacion
    {
        public int cod { get; set; }
        public int codde { get; set; }
        public int coddoc { get; set; }
        public int cantidad { get; set; }
        public string fecha { get; set; }
        public string desc { get; set; }        

        public cls_operacion() { }

        public cls_operacion(int icodi, int code, int codo, int cant, string fec, string des)

        {
            this.cod = icodi;
            this.codde = code;
            this.coddoc = codo;
            this.cantidad = cant;
            this.fecha = fec;
            this.desc = des;


        }
    }
}
