using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produccion
{
    public class datosp
    {
        public string id_pedido { get; set; }
        public string hora_ingreso{get;set;}
        public string fecha_ingreso{get;set;}
        public string id_cliente{get;set;}
        public string fecha_entrega{get;set;}
        public string hora_entrega{get;set;}
        public string id_empresa{get;set;}
        public string id_empleado{get;set;}
        public string estado{get;set;}
        public string id_menu{get;set;}
        public string correlativo{get;set;}
        public double cantidad{get;set;}
        public double descuento { get; set; }
        public datosp()
        { }
        public datosp(string iid_pedido, string ihorai, string ifeci, string iid_cte, string ifece, string ihorae, string iempresa, string icolab, string istat, string iid_menu, string icor, double icant, double idesc)
        {
            this.id_pedido = iid_pedido;
            this.hora_ingreso = ihorai;
            this.fecha_ingreso = ifeci;
            this.id_cliente = iid_cte;
            this.fecha_entrega = ifece;
            this.hora_entrega = ihorae;
            this.id_empresa = iempresa;
            this.id_empleado = icolab;
            this.estado = istat;
            this.id_menu = iid_menu;
            this.correlativo = icor;
            this.cantidad = icant;
            this.descuento = idesc;
        }
    }
    
}
