using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUsuarios
{
    public class CapaNegocio : Objetos
    {

       

           
        // modificar
            public void Modificar(cuentas CuentaModificar)
            {
                CapaDatos ModificaDato = new CapaDatos();
                ModificaDato.Modificar(CuentaModificar.usuario, CuentaModificar.Acontrasenia, CuentaModificar.Ncontrasenia,CuentaModificar.RNcontrasenia);
            }
        // bitacora
            //public void bitacora(bitacora registro)
            //{

            //    CapaDatos dato = new CapaDatos();
            //    dato.registro(registro.usuario, registro.pass);

            //}

    }
}
