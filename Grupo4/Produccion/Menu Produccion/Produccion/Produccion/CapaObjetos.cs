using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produccion
{
   public class CapaObjetos
    {

        public class nuevoproceso// objeto utilizado para insertar en la tabla de procesos
        {

            public string nom_proceso { get; set; }
            public double tiempo_elabora { get; set; }
            public string medida_tiempo { get; set; }
            public string descripcion { get; set; }
            public string observacion { get; set; }
            

            public nuevoproceso() { }

            public nuevoproceso(string nom_proceso, double tiempo_elabora,string medida_tiempo,  string descripcion,string observacion)
            {
                this.nom_proceso = nom_proceso;
                this.tiempo_elabora = tiempo_elabora;
                this.medida_tiempo = medida_tiempo;
                this.descripcion = descripcion;
                this.observacion = observacion;
            }
        }

    }
}
