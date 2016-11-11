using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class FormDocumento : Form
    {
        public FormDocumento()
        {
            InitializeComponent();
        }

        private void FormDocumento_Load(object sender, EventArgs e)
        {
            try
            {
                dgw_det.Columns[0].Width = 95;
                dgw_det.Columns[1].Width = 340;
                dgw_det.Columns[2].Width = 95;

                dgw_det.Columns[0].HeaderText = "Codigo";
                dgw_det.Columns[1].HeaderText = "Descripción";
                dgw_det.Columns[2].HeaderText = "Cantidad";
            }
            catch { }
        }
    }
}
