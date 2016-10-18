using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUsuarios
{
    public class Objetos
    {
        // Capa Entidad

        public class cuentas
        {
            public string usuario { get; set; }
            public string Acontrasenia { get; set; }
            public string Ncontrasenia { get; set; }
            public string RNcontrasenia { get; set; }


            public cuentas() { }

            public cuentas(string usuario, string Acontrasenia, string Ncontrasenia, string RNcontrasenia)
            {
                this.usuario = usuario;
                this.Acontrasenia = Acontrasenia;
                this.Ncontrasenia = Ncontrasenia;
                this.RNcontrasenia = RNcontrasenia;
            }
        }

        // objeto Bitacora
        //public class bitacora
        //{
        //    public string usuario { get; set; }
        //    public string pass { get; set; }

        //    public bitacora() { }

        //    public bitacora(string usuario, string pass)
        //    {
        //        this.usuario = usuario;
        //        this.pass = pass;
        //    }

        //}


    }
}
