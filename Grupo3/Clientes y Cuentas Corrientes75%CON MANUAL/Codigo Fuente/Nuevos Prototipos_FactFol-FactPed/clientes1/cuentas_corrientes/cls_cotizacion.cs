using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_corrientes
{
     public class cls_cotizacion
    {
        public int id_cotizacion { get; set; }
        public string nombre_cte { get; set; }
        public string direccion_cte { get; set; }
        public string apellido_cte { get; set; }
        public string fecha_cot { get; set; }
        public string nit_cte { get; set; }
        public string estado_cot { get; set; }
        public string telefono1 { get; set; }
        public string telefono2 { get; set; }
        public cls_cotizacion() { }

        public cls_cotizacion(int id_cotizacion, string nombre_cte, string direccion_cte, string apellido_cte, string fecha_cot, string nit_cte, string telefono1, string telefono2, string estado_cot)

        {
            this.id_cotizacion = id_cotizacion;
            this.nombre_cte = nombre_cte;
            this.direccion_cte = direccion_cte;
            this.fecha_cot = fecha_cot;
            //this.observ_prov = observ_prov;
            this.nit_cte = nit_cte;
            this.estado_cot = estado_cot;
            this.telefono1 = telefono1;
            this.telefono2 = telefono2;
        }
      
        }
    public class bien
    {
        public int id_bien_pk { get; set; }
        public string descripcion { get; set; }
        public string precio { get; set; }
        public string cantidad { get; set; }

        public bien() { }

        public bien(int id_bien_pk, string descripcion, string precio, string cantidad)
        {
            this.id_bien_pk = id_bien_pk;
            this.descripcion = descripcion;
            this.precio = precio;
            this.cantidad = cantidad;
        }
    }
    public class encabezado
    {
        public int id_cotizacion { get; set;}
        public string nombre_cte { get; set;}
        public string apellido_cte { get; set; }
        public string nit_cte { get; set; }
        public string direccion_cte { get; set; }
        public string fecha_cot { get; set; }
        public string estado_cot { get; set; }

        public encabezado() { }
        public encabezado(int id_cotizacion, string nombre_cte, string apellido_cte, string nit_cte, string direccion_cte, string fecha_cot, string estado_cot)
        {
            this.id_cotizacion = id_cotizacion;
            this.nombre_cte = nombre_cte;
            this.nit_cte = nit_cte;
            this.direccion_cte = direccion_cte;
            this.fecha_cot = fecha_cot;
            this.estado_cot = estado_cot;
        }

    }
    public class detalle_cot
    {
        public int id_detallecot_pk { get; set; }
        public int cantidad_detallecot { get; set; }
        public decimal desc_servicio_detcot { get; set; }
        public int id_cotizacion_pk { get; set; }
        public int id_precio { get; set; }
        public string estado { get; set; }
        public int id_bien_pk { get; set; }

        public detalle_cot() { }
        public detalle_cot(int id_detallecot_pk, int cantidad_detallecot, decimal desc_servicio_detcot, int id_cotizacion_pk, int id_precio, string precio, int id_bien_pk)
        {
            this.id_detallecot_pk = id_detallecot_pk;
            this.cantidad_detallecot = cantidad_detallecot;
            this.desc_servicio_detcot = desc_servicio_detcot;
            this.id_cotizacion_pk = id_cotizacion_pk;
            this.id_precio = id_precio;
            this.estado = estado;
            this.id_bien_pk = id_bien_pk;
        }
    }
 }

