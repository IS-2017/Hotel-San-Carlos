using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Diagnostics;
using System.IO;
using MySql.Data.MySqlClient;

namespace PdfPDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                DataTable datas = Conexion.DatosAsignacion_Catedratico(); ;
                dgv_datos.DataSource = datas;
            }
            catch (Exception ex){
              MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_datos_Click(object sender, EventArgs e)
        {
            DataTable datas = Conexion.DatosAsignacion_Catedratico(); ;
            dgv_datos.DataSource = datas;
        }

        public void btn_pdf_Click(object sender, EventArgs e)
        {
            
            if (dgv_datos.RowCount == 0)
            {
                MessageBox.Show("No Hay Datos Para Realizar Un Reporte");
            }
            else
            {    // SE ESCOJE LA RUTA DONDE SE GUARDARA EL PDF
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    //SE LE ASIGNA AL DOCUMENTO, DISEÑO DE PAGINA
                    string filename = save.FileName;
                    Document doc = new Document(PageSize.A2.Rotate(), 9, 9, 9, 9);
                    // SE AGREGA UN LOGO AL DOCUMENTO PDF -- POSICION Y TAMAÑO
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance("muestra2.jpg");
                    logo.SetAbsolutePosition(60f, 1035f);
                    logo.ScaleAbsoluteHeight(150);
                    logo.ScaleAbsoluteWidth(150);
                    // generar otro encabezado
                    Paragraph rolo = new Paragraph(new Phrase("\n UNIVERSIDAD JOHNNY CALITO FLORES \n Reporte de Catedraticos Registrados en el Sistema Y \n Asignaciones Registradas \n " + "", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 26f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                    rolo.Alignment = Element.ALIGN_CENTER;

                    try
                    {
                        FileStream file = new FileStream(filename, FileMode.OpenOrCreate);
                        PdfWriter writer = PdfWriter.GetInstance(doc, file);
                        writer.ViewerPreferences = PdfWriter.PageModeUseThumbs;
                        writer.ViewerPreferences = PdfWriter.PageLayoutOneColumn;
                        doc.Open();
                        // SE AGREGA EL LOGO, EL ENCABEZADO Y EL CUERPO AL PDF                 
                        doc.Add(logo);
                        doc.Add(rolo);
                        GenerarPdf.GenerarDocumentos(doc);
                        Process.Start(filename);
                        doc.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }} }


    } }
