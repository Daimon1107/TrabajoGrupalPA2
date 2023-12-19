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
using System.IO;


namespace ArquitecturaPresentacion
{
    public partial class Form_Estudiante : Form
    {

        EstudianteEntidad estudiante = new EstudianteEntidad();
        public Form_Estudiante()
        {
            InitializeComponent();
        }

        private void Form_Estudiante_Load(object sender, EventArgs e)
        {
            CargarListadoEstudiantes();
            CargarComboCarrera();
            CargarComboGenero();
            CargarComboDocente();
        }

        private void CargarComboDocente()
        {
            comboBox_Docente.DataSource = DocenteNegocio.DevolverListaDocentes();
            comboBox_Docente.DisplayMember = "nombre";
            comboBox_Docente.ValueMember = "id";
        }

        private void CargarComboGenero()
        {
            comboBox_Genero.DataSource = GéneroNegocio.DevolverGéneros();
            comboBox_Genero.DisplayMember = "nombre";
            comboBox_Genero.ValueMember = "id";
        }

        private void CargarComboCarrera()
        {
            comboBox_Carrera.DataSource = CarreraNegocio.DevolverCarreras();
            comboBox_Carrera.DisplayMember = "nombre";
            comboBox_Carrera.ValueMember = "id";
        }

        private void CargarListadoEstudiantes()
        {
         dataGridView_Estudiante.DataSource = EstudianteNegocio.DevolverListaEstudiantes();
        }

        private void button_AgregarEstudiante_Click(object sender, EventArgs e)
        {
            GuardarEstudiante();
        }

        private void GuardarEstudiante()
        {

            estudiante.Nombre = textBox_Nombre.Text;
            estudiante.Apellido = textBox_Apellido.Text;
            estudiante.Cedula = textBox_Cedula.Text;
            estudiante.FechaNacimiento = dateTimePicker_FechaNacimiento.Value;
            estudiante.EstadoCivil = char.Parse(textBox_EstadoCivil.Text);
            estudiante.IdCarrera = Convert.ToInt32(comboBox_Carrera.SelectedValue);
            estudiante.IdGenero = Convert.ToInt32(comboBox_Genero.SelectedValue);
            estudiante.IdDocente = Convert.ToInt32(comboBox_Docente.SelectedValue);
            estudiante.Tema = textBox_Tema.Text;


            estudiante = EstudianteNegocio.GuardarEstudiante(estudiante);

            if (estudiante != null)
            {
                textBox_Id.Text = estudiante.Id.ToString();
                CargarListadoEstudiantes();
                MessageBox.Show("Los datos se guardaron exitosamente");
            }
            else
            {
                MessageBox.Show("Los datos NO se guardaron");
            }

        }

        private void dataGridView_Estudiante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(
    dataGridView_Estudiante.Rows[e.RowIndex].Cells["id"].Value.ToString());
            CargarValoresEstudianteId(id);
        }

        private void CargarValoresEstudianteId(int id)
        {
            estudiante = EstudianteNegocio.DevolverEstudianteId(id);
            textBox_Id.Text = estudiante.Id.ToString();
            textBox_Nombre.Text = estudiante.Nombre;
            textBox_Apellido.Text = estudiante.Apellido;
            textBox_Cedula.Text = estudiante.Cedula;
            dateTimePicker_FechaNacimiento.Value = estudiante.FechaNacimiento;
            textBox_Tema.Text = estudiante.Tema;
            comboBox_Carrera.SelectedValue = estudiante.IdCarrera;
            comboBox_Docente.SelectedValue = estudiante.IdDocente;
            comboBox_Genero.SelectedValue = estudiante.IdGenero;
        }

        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            EliminarDocente();
        }

        private void EliminarDocente()
        {
            if (MessageBox.Show("¿Está seguro de eliminar permanentemente  el registro?",
                                "Eliminación de Estudiante",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Invocar a Negocio Eliminar
                if (DocenteNegocio.EliminarDocenteID(estudiante.Id))
                {
                    MessageBox.Show("Se ha eliminado el dato con el ID " + estudiante.Id + ".",
                                "Eliminación de Paciente",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    CargarListadoEstudiantes();
                }
            }
        }

        private void button_Nuevo_Click(object sender, EventArgs e)
        {
            EncerarCampos();
        }

        private void EncerarCampos()
        {
            estudiante = new EstudianteEntidad();
            textBox_Id.Text = string.Empty;
            textBox_Nombre.Text = estudiante.Nombre;
            textBox_Apellido.Text = estudiante.Apellido;
            textBox_Cedula.Text = estudiante.Cedula;
            dateTimePicker_FechaNacimiento.Value = DateTime.Now;
            textBox_Tema.Text = estudiante.Tema;
            comboBox_Carrera.SelectedValue = estudiante.IdCarrera;
            comboBox_Docente.SelectedValue = estudiante.IdDocente;
            comboBox_Genero.SelectedValue = estudiante.IdGenero;

        }

        private void button1_Click(object sender, EventArgs e)
        {
                 Form_Menu menu= new Form_Menu();
            menu.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
          var verificar =   LeerDatosCSV("C:\\Users\\User\\Desktop\\Universidad\\Programación Avanzada\\estudianteDatos.csv");
            
            Console.WriteLine("termino de leer");

            //foreach (var item in verificar)
            //{
            //    Console.WriteLine("id: "+item.Id);
            //    Console.WriteLine("cedula: " + item.Cedula);
            //    Console.WriteLine("nombre: " + item.Nombre);
            //    Console.WriteLine("apellido: " + item.Apellido);
            //    Console.WriteLine("fecha nacimiento: " + item.FechaNacimiento);
            //    Console.WriteLine("estado civil: " + item.EstadoCivil);
            //    Console.WriteLine("carrera: " + item.IdCarrera);
            //    Console.WriteLine("tema: " + item.Tema);
            //    Console.WriteLine("docente: " + item.IdDocente);
            //    Console.WriteLine("genero: " + item.IdGenero);

            //}

            estudiante = EstudianteNegocio.AñadirEstudianteCSV(verificar);

            if (estudiante != null)
            {
                textBox_Id.Text = estudiante.Id.ToString();
                CargarListadoEstudiantes();
                MessageBox.Show("Los datos se guardaron exitosamente");
            }
            else
            {
                MessageBox.Show("Los datos NO se guardaron");
            }

        }

        static List<EstudianteEntidad> LeerDatosCSV(string filepath)
        {

            Console.WriteLine();

            var registros = new List<EstudianteEntidad>();

            if (File.Exists(filepath))
            {
                string[] lines = File.ReadAllLines(filepath);

                foreach (string line in lines.Skip(1))
                {
                    string[] parts = line.Split(';');

                    if (parts.Length >= 4)
                    {

                        int id = Convert.ToInt32(parts[0]);
                        string cedula = parts[1];
                        string nombre = parts[2];
                        string apellido = parts[3];
                        DateTime fechaNacimiento = DateTime.Parse(parts[4]);
                        char estadoCivil = Char.Parse(parts[5]);
                        int idCarrera = Convert.ToInt32(parts[6]);
                        string tema = parts[7];
                        int idDocente = Convert.ToInt32(parts[8]);
                        int idGenero = Convert.ToInt32(parts[9]);

                        var registro = new EstudianteEntidad(id,cedula,nombre,
                            apellido,fechaNacimiento,estadoCivil,idCarrera,tema,idDocente,idGenero);

                        registros.Add(registro);
                    }
                }
            }
            return registros;
        }
    }
}
