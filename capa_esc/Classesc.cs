using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using capa_de_datos;
using capa_entidad;


// HACEMOS UNA REFERENCIA A CAPA DATOS Y ENTIDAD
// ESTA CAPA ES PARA LLAMAR A LAS TABLAS DE LA CAPA DATOS
namespace capa_esc
{
    public class Classesc
    {
        // VARIABLE QUE REPRESENTA ALA CLASE DATOS
        ClassDatos objd = new ClassDatos();

        // LLAMAR A LAS TABLAS
        // TABLA DE LISTADO DE ALUMN
        public DataTable E_listado_de_alumnos()
        {
            return objd.D_listado_de_alumnos();

        }

        // TABLA DE BUSCAR

        public DataTable E_buscar_alumno(Classentidad obje)
        {
            return objd.D_buscar_alumno(obje);

        }

        // TABLA MANTENIMIENTO
        public String E_mantenimiento_alumno(Classentidad obje)
        {
            return objd.D_mantenimiento_alumno(obje);

        }


    }
}
