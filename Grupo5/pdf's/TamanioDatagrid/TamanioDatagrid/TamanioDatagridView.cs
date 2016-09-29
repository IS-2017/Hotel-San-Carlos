using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TamanioDatagrid
{
    public class TamanioDatagridView
    {
        public float[] GetTamañoColumnas(DataGridView dg)
        {
            //Se toma el numero de columnas
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                //Se toma el ancho de cada columna
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }

    }
}
