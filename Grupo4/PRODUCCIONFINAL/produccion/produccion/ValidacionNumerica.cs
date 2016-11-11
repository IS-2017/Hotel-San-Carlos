using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produccion
{
    public class ValidacionNumerica
    {

        public bool funnumero(string numero)
        {
            try
            {
                double evaluar = Convert.ToDouble(numero);
                return true;
            }
            catch(Exception)
            {
                return false;

            }

        }

    }
}
