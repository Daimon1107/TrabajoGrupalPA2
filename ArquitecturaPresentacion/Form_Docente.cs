using ArquitecturaEntidades;
using ArquitecturaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArquitecturaPresentacion
{
    public partial class Form_Docente : Form
    {
        CuentaDocenteEntidad CuentasDocente = new CuentaDocenteEntidad();
        public Form_Docente()
        {
            InitializeComponent();
        }

        private void Form_Docente_Load(object sender, EventArgs e)
        {
            CargarComboFacultad();
            CargarListadoDocentes();
        }

        private void CargarListadoDocentes()
        {
            dataGridView_Docentes.DataSource = DocenteNegocio.DevolverListaDocentes();
        }

        private void CargarComboFacultad()
        {
            comboBox_Facultad.DataSource = FacultadNegocio.DevolverListaFacultades();
            comboBox_Facultad.DisplayMember = "nombre";
            comboBox_Facultad.ValueMember = "id";
        }

        private void button_Agregar_Click(object sender, EventArgs e)
        {
            GuardarDocente();
        }

        private void GuardarDocente()
        {
          CuentasDocente.Nombre = textBox_Nombre.Text;
        CuentasDocente.Apellido = textBox_Apellido.Text;   
            CuentasDocente.Cedula = textBox_Cedula.Text;
            CuentasDocente.FechaNacimiento = dateTimePicker_FechaNacimiento.Value;
          //  CuentasDocente.IdFacultad = Convert.ToInt32(comboBox_Facultad.SelectedValue);


            CuentasDocente = DocenteNegocio.GuardarDocente(CuentasDocente);

            if (CuentasDocente != null)
            {
                textBox_Id.Text = CuentasDocente.Id.ToString();
                CargarListadoDocentes();
                MessageBox.Show("Los datos se guardaron exitosamente");
            }
            else
            {
                MessageBox.Show("Los datos NO se guardaron");
            }
        }

        private void dataGridView_Docentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(
               dataGridView_Docentes.Rows[e.RowIndex].Cells["id"].Value.ToString());
            CargarValoresDocenteId(id);
        }

        private void CargarValoresDocenteId(int id)
        {

            CuentasDocente = DocenteNegocio.DevolverDocenteId(id);
            textBox_Id.Text = CuentasDocente.Id.ToString();
            textBox_Cedula.Text = CuentasDocente.Cedula;
            textBox_Nombre.Text = CuentasDocente.Nombre;
            textBox_Apellido.Text = CuentasDocente.Apellido;
            dateTimePicker_FechaNacimiento.Value = CuentasDocente.FechaNacimiento;
          //  comboBox_Facultad.SelectedValue = CuentasDocente.IdFacultad;

          }

        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            EliminarDocente();
        }

        private void EliminarDocente()
        {
            if (MessageBox.Show("¿Está seguro de eliminar permanentemente  el registro?",
                               "Eliminación de CuentasDocente",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Invocar a Negocio Eliminar
                if (DocenteNegocio.EliminarDocenteID(CuentasDocente.Id))
                {
                    MessageBox.Show("Se ha eliminado el dato con el ID " + CuentasDocente.Id + ".",
                                "Eliminación de Paciente",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    // Actualizar la tabla de Datos
                    CargarListadoDocentes();

                    // Procedimiento almacenado: Es un proceso que solo se ejecuta en la BD.
                    // En Oracle es SQL
                    // En MSSQL es TSQL.
                }
            }
        }

        private void button_Nuevo_Click(object sender, EventArgs e)
        {
            EncerarCampos();
        }

        private void EncerarCampos()
        {
            CuentasDocente= new CuentaDocenteEntidad();
            textBox_Id.Text = string.Empty;
            textBox_Nombre.Text = CuentasDocente.Nombre;
            textBox_Apellido.Text = CuentasDocente.Apellido;
            textBox_Cedula.Text = CuentasDocente.Cedula;
          //  comboBox_Facultad.SelectedValue = CuentasDocente.IdFacultad;
            dateTimePicker_FechaNacimiento.Value = DateTime.Now;
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Menu menu = new Form_Menu();
            menu.Show();
            this.Visible = false;
        }

        private void comboBox_Facultad_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
