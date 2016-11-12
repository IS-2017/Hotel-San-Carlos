using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produccion
{
   public class CapaNegocio:CapaObjetos
    {

        public void InsertarNuevoProceso(nuevoproceso proceso)
        {
            CapaDatos insertarproceso = new CapaDatos();
            insertarproceso.InsertarNuevoProceso(proceso.nom_proceso,proceso.tiempo_elabora,proceso.medida_tiempo,proceso.descripcion,proceso.observacion);
        }

    }
}
