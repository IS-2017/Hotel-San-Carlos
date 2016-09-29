using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Windows.Forms;
using System.Data;
using TamanioDatagrid;

namespace PdfPDF
{
    class GenerarPdf
    {
        
        //Función que genera el documento Pdf
        public static Phrase GenerarDocumentos(Document document)
        {
            TamanioDatagridView casacas = new TamanioDatagridView();
            Form1 conta = new Form1();

            PdfPTable datatables = new PdfPTable(conta.dgv_datos.ColumnCount);

            //se crea un objeto PdfTable con el numero de columnas del dataGridView 
            PdfPTable datatable = new PdfPTable(conta.dgv_datos.ColumnCount);

            //se asigna algunas propiedades para el diseño del pdf 
            datatable.DefaultCell.Padding = 1;
            float[] headerwidths = casacas.GetTamañoColumnas(conta.dgv_datos);

            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 1;

            //SE DEFINE EL COLOR DE LAS CELDAS EN EL PDF
            datatable.DefaultCell.BackgroundColor = iTextSharp.text.BaseColor.WHITE;

            //SE DEFINE EL COLOR DE LOS BORDES
            datatable.DefaultCell.BorderColor = iTextSharp.text.BaseColor.WHITE;

            //LAS FUENTES DE TEXTO
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA);
            iTextSharp.text.Font fuente2 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 11f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLUE);
            Phrase objP = new Phrase("A", fuente);

            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            //SE GENERA EL ENCABEZADO DE LA TABLA EN EL PDF 
            for (int i = 0; i < conta.dgv_datos.ColumnCount; i++)
            {
                //OBITNE TODOS LOS NOMBRES DE LOS ENCABEZADOS DEL DATAGRIEDVIEW
                objP = new Phrase(conta.dgv_datos.Columns[i].HeaderText, fuente2);
                datatable.AddCell(objP);
            }
            datatable.DefaultCell.BorderWidth = 1;
            datatable.HeaderRows = 2;

            //SE GENERA EL CUERPO DEL PDF // FILAS
            for (int i = 0; i < conta.dgv_datos.RowCount - 1; i++)
            {
                //COLUMNAS
                for (int j = 0; j < conta.dgv_datos.ColumnCount; j++)
                {
                    //SE GENERAN LAS CELDAS
                    objP = new Phrase(conta.dgv_datos[j, i].Value.ToString(), fuente);
                    datatable.AddCell(objP);
                }
                datatable.CompleteRow();
            }
            //SE AGREGA LAS FILAS Y COLUMNAS AL DOCUMENTO PDF
            document.Add(datatable);
            document.Close();
            return objP;
        }

/*
        public static float[] GetTamañoColumnas(DataGridView dg)
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
*/
    }
}
