using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_corrientes
{
   public class cls_Producto
    {
        public int id_bien_pk { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public int id_categoria_pk { get; set; }
        public int id_precio { get; set; }      
        public int existencia { get; set; }
        public string tipo_categoria { get; set; }
        
        public cls_Producto() { }

        public cls_Producto(int idbien, string descrip, decimal pre, int idcate, int idpre,  int exis, string tipocate)

        {
            this.id_bien_pk = idbien;
            this.descripcion = descrip;
            this.precio = pre;
            this.id_categoria_pk = idcate;
            this.id_precio = idpre;      
            this.existencia = exis;
            this.tipo_categoria = tipocate;
           

        }
    }
}
