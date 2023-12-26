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
        FiltradorBuilderEntidad filtroBuilder = new FiltradorBuilderEntidad();

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

        private void CargarListadoEstudiante(FiltradorBuilderEntidad filtro) {
           dataGridView_Estudiante.DataSource = EstudianteNegocio.DevolverListaEstudiantes(filtro);
        }

        private void dataGridView_Estudiante_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var id = Convert.ToInt32(dataGridView_Estudiante.Rows[e.RowIndex].Cells["id"].Value.ToString());
            dataGridView_Informes.DataSource = InformeNegocio.DevolverListaInformes(id);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void groupBox3_Enter(object sender, EventArgs e) {

        }



        private void txt_Apellido_TextChanged(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(txt_Apellido.Text)) {
                filtroBuilder.AñadirApellido(txt_Apellido.Text);
            } else {
                filtroBuilder.LimpiarParámetro("apellido");
            }
            CargarListadoEstudiante(filtroBuilder);
        }


        private void txt_AñoAP_TextChanged(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(txt_AñoAP.Text)) {
                filtroBuilder.AñadirAñoAP(txt_AñoAP.Text);
            } else {
                filtroBuilder.LimpiarParámetro("añoAP");
            }
            CargarListadoEstudiante(filtroBuilder);
        }

        private void btn_QuitarF_Click(object sender, EventArgs e) {
            txt_Cédula.Text = string.Empty;
            txt_Apellido.Text = string.Empty;
            txt_Nombre.Text = string.Empty;
            txt_AñoAP.Text = string.Empty;
            txt_MesAP.Text = string.Empty;
            combo_Carrera.Text = "Seleccione una carrera";
            combo_Género.Text = "Seleccione un género";
            filtroBuilder = new FiltradorBuilderEntidad();
            CargarListadoEstudiante();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Nombre.Text)) {
                filtroBuilder.AñadirNombre(txt_Nombre.Text);
            } else {
                filtroBuilder.LimpiarParámetro("nombre");
            }
            CargarListadoEstudiante(filtroBuilder);
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
            //if (!string.IsNullOrEmpty(checkBox_MesAP.Text) && int.TryParse(checkBox_MesAP.Text, out int number))
            //{
            //    if (number < 1 || number > 12)
            //    {
            //        // El número está fuera del rango, puedes mostrar un mensaje o realizar alguna acción aquí
            //        // Por ejemplo, mostrar un mensaje de error
            //        MessageBox.Show("Por favor, ingresa un número del 1 al 12.");
            //        checkBox_MesAP.Text = ""; // Limpiar el TextBox si el número está fuera del rango
            //    }
            //}

        }

        private void txt_AñoAP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Cédula_TextChanged(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(txt_Cédula.Text)) {
                filtroBuilder.AñadirCédula(txt_Cédula.Text);
            } else {
                filtroBuilder.LimpiarParámetro("cedula");
            }
            CargarListadoEstudiante(filtroBuilder);
        }

        private void txt_MesAP_TextChanged(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(txt_MesAP.Text)) {
                filtroBuilder.AñadirMesAP(txt_MesAP.Text);
            } else {
                filtroBuilder.LimpiarParámetro("mesAP");
            }
            CargarListadoEstudiante(filtroBuilder);

        }
    }
}
