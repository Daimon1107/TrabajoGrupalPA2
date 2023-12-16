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
    public partial class Form_Facultad : Form
    {

        FacultadEntidad facultad = new FacultadEntidad();
        public Form_Facultad()
        {
            InitializeComponent();
        }


        private void Form_Facultad_Load(object sender, EventArgs e)
        {
            CargarListadoFacultades();
        }

        private void CargarListadoFacultades()
        {
            dataGridView_Facultades.DataSource = FacultadNegocio.DevolverListaFacultades();
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            GuardarFacultad();
        }

        private void GuardarFacultad()
        {
            facultad.Nombre = textBox_Facultad.Text;

            facultad = FacultadNegocio.GuardarFacultad(facultad);

            if (facultad != null)
            {
                textBox_IdFacultad.Text = facultad.Id.ToString();
                CargarListadoFacultades();
                MessageBox.Show("Los datos se guardaron exitosamente");
                EncerarCampos();
            }
            else
            {

                MessageBox.Show("Los datos NO se guardaron");
            }

        }

        private void dataGridView_Facultades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridView_Facultades.Rows[e.RowIndex].Cells["id"].Value.ToString());
            CargarValoresFacultadId(id);
        }

        private void CargarValoresFacultadId(int id)
        {
            facultad = FacultadNegocio.DevolverFacultadId(id);
            textBox_IdFacultad.Text = facultad.Id.ToString();
            textBox_Facultad.Text = facultad.Nombre.ToString();
        }

        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            EliminarFacultad();
        }

        private void EliminarFacultad()
        {
            if (MessageBox.Show("¿Está seguro de eliminar permanentemente  el registro?",
                               "Eliminación de Facultad",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Invocar a Negocio Eliminar
                if (FacultadNegocio.EliminarFacultadId(facultad.Id))
                {
                    MessageBox.Show("Se ha eliminado el dato con el ID " + facultad.Id + ".",
                                "Eliminación de Facultad",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    // Actualizar la tabla de Datos
                    CargarListadoFacultades();
                    EncerarCampos();
                    // Procedimiento almacenado: Es un proceso que solo se ejecuta en la BD.
                    // En Oracle es SQL
                    // En MSSQL es TSQL.
                }
            }
        }

        public void EncerarCampos()
        {
            facultad = new FacultadEntidad();
            textBox_IdFacultad.Text = string.Empty;
            textBox_Facultad.Text = facultad.Nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EncerarCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Menu menu = new Form_Menu();
            menu.Show();
            this.Visible = false;
        }
    }
}
