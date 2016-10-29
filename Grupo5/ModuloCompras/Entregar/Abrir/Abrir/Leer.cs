using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Abrir
{
    class Leer
    {
        public void lecturaArchivo(DataGridView tabla, Char caracter, String ruta)
        {
            try
            {
                StreamReader objReader = new StreamReader(ruta);
                string sLine = "";
                int fila = 0;
                tabla.Rows.Clear();
                tabla.AllowUserToAddRows = false;
                do
                {
                    sLine = objReader.ReadLine();
                    if ((sLine != null))
                    {
                        if (fila == 0)
                        {
                            tabla.ColumnCount = sLine.Split(caracter).Length;
                            nombrarTitulo(tabla, sLine.Split(caracter));
                            fila += 1;
                        }
                        else
                        {
                            agregarFilaDataGridView(tabla, sLine, caracter, fila);
                            fila += 1;
                        }
                    }
                }
                while (!(sLine == null));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        

        public static void nombrarTitulo(DataGridView tabla, string[] titulos)
        {
            try
            {
                int x = 0;
                for (x = 0; x <= tabla.ColumnCount - 1; x++)
                {
                    tabla.Columns[x].HeaderText = titulos[x];
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void agregarFilaDataGridView(DataGridView tabla,string linea,char caracter,int fila)
        {
            try
            {
                string[] arreglo = linea.Split(caracter);
                tabla.Rows.Add(arreglo);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
