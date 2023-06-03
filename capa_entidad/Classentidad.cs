using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidad
{
    //AGREGAMOS LAAS VARIABLES QUE UTILIZAREMOS EN SQL Y FORM
    //UTILIZAREMOS GET SET PARA ENVIAR Y RECIBIR DATOS DE SQL
    public class Classentidad
    {
        public String nombre { get; set; }
        public String codigo { get; set; }
        public String direc { get; set; }
        public int carnet { get; set; }
        public int fecha  {get; set;  }
        public String accion { get; set; }
    }
}
