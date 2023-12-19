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
    public partial class Form_Carrera : Form
    {

        CarreraEntidad carrera = new CarreraEntidad();  
        public Form_Carrera()
        {
            InitializeComponent();
        }

        private void Form_Carrera_Load(object sender, EventArgs e)
        {
            CargarListadoCarreras();
            CargarComboFacultad();
        }

        private void CargarComboFacultad()
        {
            comboBox_Facultad.DataSource = FacultadNegocio.DevolverListaFacultades();
            comboBox_Facultad.DisplayMember = "nombre";
            comboBox_Facultad.ValueMember = "id";
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            GuardarCarrera();
        }

        private void GuardarCarrera()
        {

            carrera.Nombre = textBox_Carrera.Text;
            carrera.Id_Facultad = Convert.ToInt32(comboBox_Facultad.SelectedValue);

            carrera = CarreraNegocio.GuardarCarrera(carrera);
          


            if (carrera != null)
            {
                textBox_IdCarrera.Text= carrera.Id.ToString();
                CargarListadoCarreras();
                MessageBox.Show("Los datos se guardaron exitosamente");
            }
            else
            {
                MessageBox.Show("Los datos NO se guardaron");
            }
        }

        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            EliminarCarrera();
        }

        private void EliminarCarrera()
        {
            if (MessageBox.Show("¿Está seguro de eliminar permanentemente  el registro?",
                              "Eliminación de Carrera",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Invocar a Negocio Eliminar
                if (CarreraNegocio.EliminarCarreraId(carrera.Id))
                {
                    MessageBox.Show("Se ha eliminado el dato con el ID " + carrera.Id + ".",
                                "Eliminación de Paciente",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    // Actualizar la tabla de Datos
                    CargarListadoCarreras();
                    EncerarDatos();

                }
            }
        }

        private void CargarListadoCarreras()
        {
            dataGridView_Carreras.DataSource = CarreraNegocio.DevolverCarreras();
        }

        private void dataGridView_Carreras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridView_Carreras.Rows[e.RowIndex].Cells["id"].Value.ToString());
            CargarCarrerasId(id);
        }

        private void CargarCarrerasId(int id)
        {
            carrera = CarreraNegocio.DevolverCarreraID(id);
            textBox_IdCarrera.Text = carrera.Id.ToString();
            textBox_Carrera.Text = carrera.Nombre.ToString();
        }

        private void EncerarDatos()
        {
            textBox_IdCarrera.Text = "";
            textBox_Carrera.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Menu menu = new Form_Menu();
            menu.Show();
            this.Visible = false;
        }
    }
}
