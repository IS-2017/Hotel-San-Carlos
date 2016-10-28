using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuncionesNavegador;
using dllconsultas;

namespace Modulo_Bancos
{
    public partial class Busqueda_Documento : Form
    {
        string id_documento_pk,conciliado,fecha,valor_total,destinatario,no_documento,descripcion,id_cuenta_bancaria_pk,id_tipo_documento,id_cuenta_pk,id_proveedor_pk;
        Boolean Editar1;
        operaciones op = new operaciones();
        CapaNegocio fn = new CapaNegocio();

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar1 = false;
            Documento a = new Documento(dgv_busqueda_documento, id_documento_pk, conciliado, fecha, valor_total, destinatario, no_documento, descripcion, id_cuenta_bancaria_pk, id_tipo_documento, id_cuenta_pk, id_proveedor_pk, Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string tabla = "documento";
            op.ejecutar(dgv_busqueda_documento, tabla);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "documento";
            fn.ActualizarGrid(this.dgv_busqueda_documento, "Select * from documento WHERE estado <> 'INACTIVO' ", tabla);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgv_busqueda_documento);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgv_busqueda_documento);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_busqueda_documento);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_busqueda_documento);
        }

        private void dgv_busqueda_documento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public Busqueda_Documento()
        {
            InitializeComponent();
        }

        private void dgv_busqueda_documento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar1 = true;
            id_documento_pk = this.dgv_busqueda_documento.CurrentRow.Cells[0].Value.ToString();
            conciliado = this.dgv_busqueda_documento.CurrentRow.Cells[1].Value.ToString();
            fecha = this.dgv_busqueda_documento.CurrentRow.Cells[2].Value.ToString();
            valor_total = this.dgv_busqueda_documento.CurrentRow.Cells[3].Value.ToString();
            destinatario = this.dgv_busqueda_documento.CurrentRow.Cells[4].Value.ToString();
            no_documento = this.dgv_busqueda_documento.CurrentRow.Cells[5].Value.ToString();
            descripcion = this.dgv_busqueda_documento.CurrentRow.Cells[6].Value.ToString();
            id_cuenta_bancaria_pk = this.dgv_busqueda_documento.CurrentRow.Cells[8].Value.ToString();
            id_tipo_documento = this.dgv_busqueda_documento.CurrentRow.Cells[9].Value.ToString();
            id_cuenta_pk = this.dgv_busqueda_documento.CurrentRow.Cells[10].Value.ToString();
            id_proveedor_pk = this.dgv_busqueda_documento.CurrentRow.Cells[11].Value.ToString();
            Documento a = new Documento(dgv_busqueda_documento, id_documento_pk,conciliado, fecha, valor_total, destinatario, no_documento, descripcion, id_cuenta_bancaria_pk, id_tipo_documento, id_cuenta_pk, id_proveedor_pk,Editar1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }

        private void Busqueda_Documento_Load(object sender, EventArgs e)
        {
            string tabla = "documento";
            fn.ActualizarGrid(this.dgv_busqueda_documento, "Select * from documento WHERE estado <> 'INACTIVO' ", tabla);
        }
    }
}
