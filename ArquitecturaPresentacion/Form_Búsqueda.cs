using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArquitecturaEntidades;
using ArquitecturaLogicaNegocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArquitecturaPresentacion
{
    public partial class Form_Búsqueda : Form
    {
        private int id_Docente;
        public Form_Búsqueda(int id)
        {
            InitializeComponent();
            id_Docente = id;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarListadoEstudiante();
            CargarListadoGénero();
            CargarListadoCarrera(); 

        }

        private void CargarListadoCarrera() {
            combo_Carrera.DataSource = CarreraNegocio.DevolverCarreras();
            combo_Carrera.ValueMember = "id";
            combo_Carrera.DisplayMember = "Nombre";
        }

        private void CargarListadoGénero() {
            combo_Género.DataSource = GéneroNegocio.DevolverGéneros();
            combo_Género.ValueMember = "id";
            combo_Género.DisplayMember = "Nombre";
        }

        private void CargarListadoEstudiante()
{
            dataGridView_Estudiante.DataSource = EstudianteNegocio.DevolverListaEstudiantes();
        }

        //private void CargarListadoEstudiante(FiltradorBuilderEntidad filtro) {
        //    dataGridView_Estudiante.DataSource = EstudianteNegocio.DevolverListaEstudiantes(filtro);
        //}

        private void dataGridView_Estudiante_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var id = Convert.ToInt32(dataGridView_Estudiante.Rows[e.RowIndex].Cells["id"].Value.ToString());
            dataGridView_Informes.DataSource = InformeNegocio.DevolverListaInformes(id);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void groupBox3_Enter(object sender, EventArgs e) {

        }

        private void checkBox_Carrera_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_Carrera.Checked) {

            } else {

            }
        }

        private void checkBox_Nombre_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_Nombre.Checked) {
                txt_Nombre.ReadOnly = false; 
            } else {
                txt_Nombre.ReadOnly = true;
            }
        }

        private void txt_Apellido_TextChanged(object sender, EventArgs e) {

        }

        private void checkBox_Apellido_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_Apellido.Checked) {
                txt_Apellido.ReadOnly = false;
            } else {
                txt_Apellido.ReadOnly = true;
            }
        }

        private void checkBox_Cédula_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_Cédula.Checked) {
                txt_Cédula.ReadOnly = false;
            } else {
                txt_Cédula.ReadOnly = true;
            }
        }

        private void checkBox_Género_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_Nombre.Checked) {

            } else {

            }
        }

        private void txt_AñoAP_TextChanged(object sender, EventArgs e) {

        }

        private void checkBox_AP_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_AñoAP.Checked) {
                txt_AñoAP.ReadOnly = false;
            } else {
                txt_AñoAP.ReadOnly = true;
            }
        }

        private void checkBox_MesAP_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_MesAP.Checked) {
                txt_MesAP.ReadOnly = false;
            } else {
                txt_MesAP.ReadOnly = true;
            }
        }

        private void Filtrar()
        {

            FiltradorBuilderEntidad filtroBuilder = new FiltradorBuilderEntidad();
            filtroBuilder.AñadirIdDocente(id_Docente.ToString());

            if (VerificarFiltros())
            {

                if (checkBox_Cédula.Checked)
                {
                    filtroBuilder.AñadirCédula(txt_Cédula.Text);
                }
                if (checkBox_Apellido.Checked)
                {
                    filtroBuilder.AñadirApellido(txt_Apellido.Text);
                }
                if (checkBox_Nombre.Checked)
                {
                    filtroBuilder.AñadirNombre(txt_Nombre.Text);
                }
                if (checkBox_Carrera.Checked)
                {
                    filtroBuilder.AñadirCarrera(combo_Carrera.SelectedValue.ToString());
                }
                if (checkBox_Género.Checked)
                {
                    filtroBuilder.AñadirGénero(combo_Género.SelectedValue.ToString());
                }
                if (checkBox_AñoAP.Checked)
                {
                    filtroBuilder.AñadirAñoAP(txt_AñoAP.Text);
                }
                if (checkBox_MesAP.Checked)
                {
                    filtroBuilder.AñadirMesAP(txt_MesAP.Text);
                }
            }

           // CargarListadoEstudiante(filtroBuilder);
        }

        private bool VerificarFiltros()
        {
            return checkBox_Cédula.Checked || checkBox_Apellido.Checked
                || checkBox_Nombre.Checked || checkBox_Carrera.Checked
                || checkBox_Género.Checked || checkBox_AñoAP.Checked
                || checkBox_MesAP.Checked;
        }

        private void btn_QuitarF_Click(object sender, EventArgs e) {
            checkBox_Cédula.Checked = false;
            checkBox_Apellido.Checked = false;
            checkBox_Nombre.Checked = false;
            checkBox_Carrera.Checked = false;
            checkBox_Género.Checked = false;
            checkBox_AñoAP.Checked = false;
            checkBox_MesAP.Checked = false;
            CargarListadoEstudiante();
        }

        private void btn_Filtrar_Click(object sender, EventArgs e) {
            Filtrar();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_Cédula_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelar el carácter ingresado si no es un número
            }
        }

        private void txt_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelar el carácter ingresado si es un número
            }
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelar el carácter ingresado si es un número
            }
        }

        private void txt_MesAP_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Permitir solo números (0-9), teclas de control (como retroceso) y evitar ceros a la izquierda
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelar el carácter ingresado si no es un número
            }

            // Verificar que el número esté en el rango del 1 al 12
            if (!string.IsNullOrEmpty(checkBox_MesAP.Text) && int.TryParse(checkBox_MesAP.Text, out int number))
            {
                if (number < 1 || number > 12)
                {
                    // El número está fuera del rango, puedes mostrar un mensaje o realizar alguna acción aquí
                    // Por ejemplo, mostrar un mensaje de error
                    MessageBox.Show("Por favor, ingresa un número del 1 al 12.");
                    checkBox_MesAP.Text = ""; // Limpiar el TextBox si el número está fuera del rango
                }
            }

        }

        private void txt_AñoAP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelar el carácter ingresado si no es un número
            }
        }
    }
}
