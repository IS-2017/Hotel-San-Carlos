using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Report
{
    class Transporta
    {

        public crystal TraspasaDatos(DataSet MisDatos)
        {
            // Creamos el objeto
            crystal Empleados = new crystal();

            // Creamos filas y se la vamos agregando mediante un bucle
            for (int i = 0; MisDatos.Tables[0].Rows.Count > i; i++)
            {
                crystal.DataTable1Row fila = Empleados.DataTable1.NewDataTable1Row();
                fila.ID = MisDatos.Tables[0].Rows[i]["ID"].ToString();
                fila.Nombre = MisDatos.Tables[0].Rows[i]["Nombre"].ToString();
                fila.Apellido = MisDatos.Tables[0].Rows[i]["Apellido"].ToString();
                fila.Telefono = MisDatos.Tables[0].Rows[i]["Telefono"].ToString();


                // Agregamos la fila a nuestro DataSet tipado
                Empleados.DataTable1.AddDataTable1Row(fila);
            }

            return Empleados;

        }
    }
}
