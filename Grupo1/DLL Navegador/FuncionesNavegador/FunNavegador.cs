using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FuncionesNavegador
{
    public class FunNavegador
    {
        public void activartextbox(TextBox textbox)
        {
            textbox.Enabled = true;
        }

        public void desactivartextbox(TextBox textbox)
        {
            textbox.Enabled = false;
        }

        public void insertar(DataTable datos, string tabla)
        {
            Conexionmysql.ObtenerConexion();
            string query1 = "insert into " + tabla + " (";
            string query2 = "values (";
            int cuentaFilas = datos.Rows.Count;
            DataRow contenido;
            for (int fila = 0; fila < cuentaFilas; fila++)
            {
                contenido = datos.Rows[fila];
                query1 = query1 + contenido["Columna"].ToString();
                query2 = query2 + "'" + contenido["Valor"].ToString() + "'";
                if (fila!=(cuentaFilas-1))
                {
                    query1 = query1 + ", ";
                    query2 = query2 + ", ";
                }
            }
            string query = query1 + ") " + query2 + ");";
            Conexionmysql.EjecutarMySql(query);
            Conexionmysql.Desconectar();
        }
    }
}
