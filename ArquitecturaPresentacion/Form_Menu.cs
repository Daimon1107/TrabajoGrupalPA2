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
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Login login= new Form_Login();
            login.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Estudiante estudiante= new Form_Estudiante();
            estudiante.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Carrera carrera= new Form_Carrera();
            carrera.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_Facultad facultad= new Form_Facultad();
            facultad.Show();
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_Docente docente= new Form_Docente();
            docente.Show();
            this.Visible = false;
        }
    }
}
