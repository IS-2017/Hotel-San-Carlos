using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    class Validaciones
    {

        public static void ValidarNoEspacios(KeyPressEventArgs t)
        {
            if (Char.IsSeparator(t.KeyChar))
            {
                MessageBox.Show("No se permite ingresar espacios");
                t.Handled = true;
            }
        }

    }
}
