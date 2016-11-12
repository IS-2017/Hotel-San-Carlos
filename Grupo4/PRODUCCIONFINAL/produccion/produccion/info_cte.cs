using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produccion
{
    public class info_cte
    {
        public string id_cliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string nit { get; set; }
        public string direcion { get; set; }

        public info_cte()
        {

        }
        public info_cte(string pid, string pnombre, string papellido, string pnit,string pdireccion)
        {
            this.id_cliente = pid;
            this.nombre = pnombre;
            this.apellido = papellido;
            this.nit = pnit;
            this.direcion = pdireccion;
        }
    }
}
