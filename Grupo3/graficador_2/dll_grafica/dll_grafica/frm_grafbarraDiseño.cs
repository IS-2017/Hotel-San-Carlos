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
            InitializeComponent();
            this._listy = _listy;
            this._listx = _listx;
            this.tlt = tlt;


        }

        List<int> _listy;
        List<string> _listx;
        string tlt;

        private void frm_grafbarraDiseño_Load(object sender, EventArgs e)
        {

            string[] series = _listx.ToArray();
            int[] puntos = _listy.ToArray();


            chart2.Titles.Add(tlt);
            chart2.Palette = ChartColorPalette.Berry;



            for (int i = 0; i < series.Length; i++)
            {
                Series ser = chart2.Series.Add(series[i]);
                ser.Label = puntos[i].ToString();
                ser.Points.Add(puntos[i]);
            }


        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            //Obtiene la gráfica
            var charimgen = new MemoryStream();
            chart2.SaveImage(charimgen, ChartImageFormat.Png);
            iTextSharp.text.Image charImagen = iTextSharp.text.Image.GetInstance(charimgen.GetBuffer());
            charImagen.Alignment = Element.ALIGN_CENTER;

            // Creamos la imagen y le ajustamos el tamaño
            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance("C:\\Users\\Merlyn\\Pictures\\Geek Software.jpg");
            imagen.BorderWidth = 0;
            imagen.Alignment = Element.ALIGN_RIGHT;
            float percentage = 0.0f;
            percentage = 150 / imagen.Width;
            imagen.ScalePercent(percentage * 100);

            //EXPORTA AL PDF
            string folderPath = " D:\\Merlyn c\\Desktop\\Graficas pdf\\";

            if (!Directory.Exists(folderPath))
            {
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
            if (chart2 != null)
            {
                chart2.Series.Clear();
                _listx.Clear();
                _listy.Clear();
                this.Close();
            }
        }
    }
}
