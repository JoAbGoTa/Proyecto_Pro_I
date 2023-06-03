using capa_entidad;
using capa_esc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// referencia a capa entidad y esc
namespace proyecto
{
    public partial class Form3 : Form
    {
        //variables que representan a cada clase
        Classentidad objent = new Classentidad();
        Classesc objneg = new Classesc(); 

        public Form3()
        {
            InitializeComponent();
        }


        // creamos el void  mantenimiento que esta relacinado con
        // el boton accion, despues solo indicamos el numero de 
        // la accion que queremos que realise en las variables

        void mantenimiento (string accion )
        {
            //variables tipo varchar
            objent.codigo = textCodigo.Text;
            objent.nombre = txtNombre1.Text;
            objent.direc = txtdireccion.Text;
            //variables tipo int
            objent.carnet = Convert.ToInt32(txtcarnet.Text);
            objent.fecha = Convert.ToInt32(txtfecha.Text);
            objent.accion = accion;
            String men = objneg.E_mantenimiento_alumno(objent);
            // MOSTRAMOS EL MENSAJE QUE ENVIAMOS DE SQL
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //LIMPIAR

        void limpiar()
        {
            textCodigo.Text = "";
            txtNombre1.Text = "";
            txtdireccion.Text = "";
            txtcarnet.Text = "";
            txtfecha.Text = "";
            dataGridView1.DataSource = objneg.E_listado_de_alumnos();
            
        }

        // MOSTRARA LOS DATOS INGRESADOS DE SQL
        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg.E_listado_de_alumnos();
        }

        //LIMPIA LOS DATOS QUE ESTAN EN LA PARTE DE INGRESO DE DATOS DEL FROM
        private void btnNUEV_Click(object sender, EventArgs e)
        {
           limpiar();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // CONDICION QUE PERMITE INGRESAR SOLO SI EL CODIGO ESTA VACIO POR QUE SI LA CAJA TIENE UN CODIGO 
            //SERIA UNA EDICION NO REGISTRO
            if (textCodigo.Text == "")
            {
                if (MessageBox.Show("¿Deseas registrar a " + txtNombre1.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    //OCUPARA EL PROCEDIMIENTO 1 INF¡GRESADO EN SQL LUEGO LIMPIARA
                    mantenimiento("1");
                    limpiar();

                }

            }
           
        }
        
        //LO MISMO DE ARRIBA PERO OCUPANDO EL PROCEDIMIENTO NO2
        private void btneditar_Click(object sender, EventArgs e)
        {
            if (textCodigo.Text != "")
            {
                if (MessageBox.Show("¿Deseas editar a " + txtNombre1.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("2");
                    limpiar();

                }

            }

        }

        //SE REPITE LO MISMO DE ARRIBA PERO UTILIZANDO EL PRODCEDIMIENTO NO3

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (textCodigo.Text != "")
            {
                if (MessageBox.Show("¿Deseas Eliminar a " + txtNombre1.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("3");
                    limpiar();

                }

            }
        }

        private void txtbus_TextChanged(object sender, EventArgs e)
        {
            // CONDICION QUE ENLISTA CON LA PRIMERA LETRA SI NO HAY LETRAS MOSTRARA TODOS LOS DATOS
            if (txtbus.Text != "")
            {
                objent.nombre = txtbus.Text;
                DataTable dt = new DataTable();
                dt = objneg.E_buscar_alumno(objent);
                dataGridView1.DataSource = dt;

            }
            else
            {
                dataGridView1.DataSource = objneg.E_listado_de_alumnos();

            }
        }

        //UTILIZANDO EL EVENTO CELLCONTERCLIK ENVIAMOS LOS DATOS DEL DATAVIEW A LAS CAJAS DE TEXTO

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;
            //TENER EN CUENTA LA CANTIDAD DE COLUMNA QUE HAY EN SQL Y SE ENPIESA DE 0
            textCodigo.Text = dataGridView1[0, fila].Value.ToString();
            txtNombre1.Text = dataGridView1[1, fila].Value.ToString();
            txtdireccion.Text = dataGridView1[2, fila].Value.ToString();
            txtcarnet.Text = dataGridView1[3, fila].Value.ToString();
            txtfecha.Text = dataGridView1[4, fila].Value.ToString(); 

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
