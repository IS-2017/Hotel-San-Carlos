using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Graf1
{
    public partial class frm_grafbarraDiseño : Form
    {
           
        public frm_grafbarraDiseño(List<int> _listy, List<string> _listx, string tlt)
        {
            /* OBTIENE LOS VALORES DE LA LISTA x Y y           
             * Autor: Olivia Tinoco*/             

            InitializeComponent();
            this._listy = _listy;
            this._listx = _listx;
            this.tlt = tlt;


        }

        //Declaracion de Variables para X y Y
        List<int> _listy;
        List<string> _listx;
        string tlt;
        /*--------------------------------------------*/

        private void frm_grafbarraDiseño_Load(object sender, EventArgs e)
        {
           /*AGREGA A LA GRAFICA
            * Autor: Merlyn Franco
            * Fecha: 09/10/2016*/

            string[] series = _listx.ToArray();
            int[] puntos = _listy.ToArray();

            //Agrega el titulo a la grafica
            chart2.Titles.Add(tlt).Font = new System.Drawing.Font("Century Gothic", 26, FontStyle.Bold); //Fuente, tamaño y estilo del título
            chart2.Palette = ChartColorPalette.Berry;

            /*DIBUJA GRAFICA
             * Autor : Olivia Tinoco*/           

            for (int i = 0; i < series.Length; i++)
            {
                //Agrega los valores a la grafica
                int y = puntos[i];
                string x = series[i];
                chart2.Series["Series1"].Points.AddXY(x, y);
            }
            /*------------------------------------------------------*/

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            /* GUARDA LA GRAFICA EN UNA IMAGEN
            * Autor: Merlyn Franco
            * Fecha: 09/10/2016*/

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Imagen|*.jpg|Bitmap Imagen|*.bmp|PNG Imagen|*.png";
            saveFileDialog1.Title = "Guardar Grafico en Imagen";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs =
                (System.IO.FileStream)saveFileDialog1.OpenFile();
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        chart2.SaveImage(fs, ChartImageFormat.Jpeg);
                        break;
                    case 2:
                        chart2.SaveImage(fs, ChartImageFormat.Bmp);
                        break;
                    case 3:
                        chart2.SaveImage(fs, ChartImageFormat.Png);
                        break;
                }
                fs.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*GUARDA LA GRAFICA EN UN PDF
            * Autor: Merlyn Franco
            * Fecha: 09/10/2016*/

            //Obtiene la gráfica
            var charimgen = new MemoryStream();
            chart2.SaveImage(charimgen, ChartImageFormat.Png);
            iTextSharp.text.Image charImagen = iTextSharp.text.Image.GetInstance(charimgen.GetBuffer());
            charImagen.Alignment = Element.ALIGN_CENTER;

            // Creamos la imagen y le ajustamos el tamaño
            string patimagen = Path.Combine(Application.StartupPath, "Logotipo\\Hotel San Carlos.png");
            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(patimagen);
            imagen.BorderWidth = 0;
            imagen.Alignment = Element.ALIGN_RIGHT;
            float percentage = 0.0f;
            percentage = 150 / imagen.Width;
            imagen.ScalePercent(percentage * 100);

            //EXPORTA AL PDF
            string folderPath = "C:\\Users\\Public\\Document\\";  //C:\Users\Public\Documents

            if (!Directory.Exists(folderPath)) { 
         
                Directory.CreateDirectory(folderPath);
            }

            if (Directory.Exists(folderPath))
            {
                MessageBox.Show("Gráfica guardada exitosamente!!!");
            }

            string descripcion = textBox1.Text;
            


            using (FileStream stream = new FileStream(folderPath + "Grafica de Barras.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(imagen);
                pdfDoc.Add(Chunk.NEWLINE);
                pdfDoc.Add(charImagen); //agrega la gráfica
                pdfDoc.Add(new Paragraph(descripcion)); //una breve descripcion de la grafica
                pdfDoc.Close();
                stream.Close();
               
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(chart2 != null)
            {
                this.chart2.Series.Clear();
                this.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //----------------------- Nombre: Pedro Alejandro Martinez Aguirre --------------------//
            //----------------------- Carne: 0901-12-4321 -------------------------------------//
            //------------------------Funcion para eliminar el grafico generado y limpia cadenas para poder generar una nueva--------//
            if (chart2 != null)
            {
                chart2.Series.Clear();
                _listx.Clear();
                _listy.Clear();
                this.Close();
            }
        }

        private void chart2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            //chart2.Series.Clear();

        }
    }
}
