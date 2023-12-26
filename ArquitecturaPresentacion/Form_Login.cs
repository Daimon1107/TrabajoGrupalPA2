using ArquitecturaEntidades;
using ArquitecturaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArquitecturaPresentacion
{
    public partial class Form_Login : Form
    {
        UsuarioEntidad usuario = new UsuarioEntidad();

        public Form_Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          IniciarSesión();

        }

        private void IniciarSesión() {
           usuario.Usuario = txt_Usuario.Text;
           usuario.Contraseña = txt_Contraseña.Text;
           usuario = UsuarioNegocio.DevolverUsuarioContraseña(usuario);

            if(usuario == null) {
                MessageBox.Show("El usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                if (usuario.Rol) {

                } else {

                }

              //  Form_Búsqueda búsqueda = new Form_Búsqueda(CuentasDocente.Id);
               // búsqueda.Show();
                this.Visible = false;
            }



        }

        private void ComprobarUsuario() {
            

        }

        private bool ValidarInicioSesion()
        {
            return true;
           // return DocenteNegocio.ComprobarSesiónVálida(CuentasDocente);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_Usuario_Enter(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "USUARIO:")
            {
                txt_Usuario.Text = "";
                txt_Usuario.ForeColor = Color.LightGray;
            }
        }

        private void textBox_Usuario_Leave(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "")
            {
                txt_Usuario.Text = "USUARIO:";
                txt_Usuario.ForeColor = Color.DimGray;
            }
        }

        private void textBox_Contraseña_Enter(object sender, EventArgs e)
        {
            if (txt_Contraseña.Text == "CONTRASEÑA:") {
                txt_Contraseña.Text = "";
                txt_Contraseña.ForeColor = Color.Red;
                txt_Contraseña.UseSystemPasswordChar = true;

            }
        }

        private void textBox_Contraseña_Leave(object sender, EventArgs e)
        {
            if (txt_Contraseña.Text == "")
            {
                txt_Contraseña.Text = "CONTRASEÑA:";
                txt_Contraseña.ForeColor = Color.DimGray;
                txt_Contraseña.UseSystemPasswordChar = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Estudiante búsqueda = new Form_Estudiante();
            búsqueda.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Carrera carrera = new Form_Carrera();
            carrera.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form_Facultad facultad = new Form_Facultad();
            facultad.Show();
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_Docente CuentasDocente= new Form_Docente();
            CuentasDocente.Show();
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form_Menu menu= new Form_Menu();
            menu.Show();
            this.Visible = false;

        }
    }
}
