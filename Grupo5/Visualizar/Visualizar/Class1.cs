using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Visualizar
{
    public class Traspaso
    {
        public dt TraspasaDatos(DataSet MisDatos)
        {
            dt Empleados = new dt();

            for(int i= 0;MisDatos.Tables[0].Rows.Count >i; i++)
            { 
                dt.DataTable1Row fila = Empleados.DataTable1.NewDataTable1Row();
                fila.ID = MisDatos.Tables[0].Rows[i]["ID"].ToString();
                fila.Nombre = MisDatos.Tables[0].Rows[i]["Nombre"].ToString();
                fila.Apellido = MisDatos.Tables[0].Rows[i]["Apellido"].ToString();
                fila.Telefono = MisDatos.Tables[0].Rows[i]["Telefono"].ToString();

                Empleados.DataTable1.AddDataTable1Row(fila);
            }
            return Empleados;
        }
    }
}
