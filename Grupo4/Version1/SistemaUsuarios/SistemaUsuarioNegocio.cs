using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace SistemaUsuarios
{
    class SistemaUsuarioNegocio
    {
       public int  ValidarChecklistVacia(DataTable lista)
        {
            if( lista.Rows.Count != 0)
            {
                return 1;
            }
            else
               {
                return 0;
               }
        }

    }
}
