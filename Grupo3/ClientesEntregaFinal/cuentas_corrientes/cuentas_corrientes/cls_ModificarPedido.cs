using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_corrientes
{
  public  class cls_ModificarPedido
    {
        public int idpedi { get; set; }
        public int idempresa { get; set; }
        public DateTime fecha { get; set; }
        public string estado_pedido { get; set; }
        public int id_cliente { get; set; }
        public string estado { get; set; }
        public int idvendedor { get; set; }
        public int idbien { get; set; }
        public int cantidad { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public decimal subtotal { get; set; }
        public int idcat { get; set; }
        public int idprecio { get; set; }
        public string esta { get; set; }
        public string esta_detalle { get; set; }

        public cls_ModificarPedido() { }

        public cls_ModificarPedido(int idpedii, int idemp, DateTime fe, string esta_pe, int idclie, string estaa, int idvende, int bien, int canti, string descrip, decimal pre, decimal sub, int cat, int idpre, string est, string esta_deta) 

        {
            this.idpedi = idpedii;
            this.idempresa = idemp;
            this.fecha = fe;
            this.estado_pedido = esta_pe;
            this.id_cliente = idclie;
            this.estado = estaa;
            this.idvendedor = idvende;
            this.idbien = bien;
            this.cantidad = canti;
            this.descripcion = descrip;
            this.precio = pre;
            this.subtotal = sub;
            this.idcat = cat;
            this.idprecio = idpre;
            this.esta = est;
            this.esta_detalle = esta_deta;
         


        }


    }
}
