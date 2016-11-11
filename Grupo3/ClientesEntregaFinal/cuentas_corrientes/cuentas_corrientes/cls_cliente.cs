using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_corrientes
{
    public class cls_cliente
    {   
        public int cod { get; set; }
        public int codcredi { get; set; }
        public int codcontri { get; set; }
        public int codpre { get; set; }
        public string correo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dpi { get; set; }
        public string nit { get; set; }
        public string dire { get; set; }
        public string tel { get; set; }
        public string fecha { get; set; }
        public int codven { get; set; }
        public int dias_cre { get; set; }
        public int codtipo { get; set; }


        public cls_cliente() { }

        public cls_cliente(int icodi, int codc, int codco, int codp, string cor, string nom, string apel, int dp, string niit, string dir, string tel, string fec, int codve, int dias, int codtip)

        {
            this.cod = icodi;
            this.codcredi = codc;
            this.codcontri = codco;
            this.codpre = codp;
            this.correo = cor;
            this.nombre = nom;
            this.apellido = apel;
            this.dpi = dp;
            this.dire = dir;
            this.tel = tel;
            this.fecha = fec;
            this.codven = codve;
            this.dias_cre = dias;
            this.codtipo = codtip;


        }
    }
}
