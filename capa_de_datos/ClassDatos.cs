using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ACTIVAMOS LAS REFERENCIAS
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using capa_entidad;

// EN LA CAPA DATOS AGREGAMOS UNA REFERENCIA DE LA CAPA ENTIDAD
//Y SISTEM CONFIGURATION
namespace capa_de_datos
{
    public class ClassDatos
    {
        // CREAMOS LA VARIABLE QUE MANTENDRA LA CONEXION A SQL = CN
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        //CREAMOS LA TABLA PARA LOS PROCEDIMIENTOS ALMACENADOS EN SQL
        public DataTable D_listado_de_alumnos()
        {
            //SQL COMAND PARA OBTENER LOS PROCEDIMIENTOS DE SQL
            //PARA OBTENERLO COLOCAMOS EL NOMBRE Y LA VARIABLE DE CONEXION EN ESTE CASO CN
            //TODO LO ANTERIOR SE ALMACENA EN CMD
            SqlCommand cmd = new SqlCommand("sp_listado_de_alumnos", cn);
            //SQL ADAPTER SERVIRA DE PUENTE PARA EL ENVIO DE DATOS ENTRE FORMS Y SQL
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // LO MISMO DE ARRIBA
        //LLAMAMOS ALA CLSE ENTIDAD PARA LLAMAR A LA VARIABLE NOMBRE
        public DataTable D_buscar_alumno(Classentidad obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_alumno", cn);
            //COMANDTYPE = A VARIABES DE SQL
            cmd.CommandType = CommandType.StoredProcedure;
            //BUSCAMOS AL ALUMNO CON LA VARIABLE NOMBRE
            cmd.Parameters.AddWithValue("@nombre", obje.nombre);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;  

        }

        // CREAMOS MANTENIMIENTO CLIENTE UTILIZANDO VARIABLES ECHAS PREVIAMENTE

        public string D_mantenimiento_alumno(Classentidad obje)
        {
            String accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_alumno", cn);
            cmd. CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", obje.codigo);
            cmd.Parameters.AddWithValue("@nombre", obje.nombre);
            cmd.Parameters.AddWithValue("@direc", obje.direc);
            cmd.Parameters.AddWithValue("@carnet", obje.carnet);
            cmd.Parameters.AddWithValue("@fecha", obje.fecha);
            //ACCION ARA LOS PROCEDIMIENTOS ECHOS EN SQL DEL 1 AL 3 
            //GENERAR MODIFICAR Y BORRAR
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;



        }

    }

   
}
