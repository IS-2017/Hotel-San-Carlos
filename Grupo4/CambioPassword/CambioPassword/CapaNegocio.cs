using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CambioPassword
{
    public class CapaNegocio:Objetos
    {

        public void Modificar(cuentas CuentaModificar)
        {
            CapaDatos ModificaDato = new CapaDatos();
            ModificaDato.Modificar(CuentaModificar.usuario, CuentaModificar.Acontrasenia, CuentaModificar.Ncontrasenia, CuentaModificar.RNcontrasenia);
        }

    }
}
