using System;
using System.Windows.Forms;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using mshtml;


namespace ArquitecturaPresentacion

{
    public partial class IngresoDatos : Form
    {
        private Object oDocument;
        public IngresoDatos()
        {
            InitializeComponent();
            //   this.axWebBrowser1.NavigateComplete2 += new AxSHDocVw.DWebBrowserEvents2_NavigateComplete2EventHandler(this.axWebBrowser1_NavigateComplete2);
            //  this.Load += new System.EventHandler(this.IngresoDatos_Load);
            //  this.Closed += new System.EventHandler(this.IngresoDatos_Closed);
            LoadHtmlFile("D:\\index.html");
        }



        private void button1_Click_2(object sender, EventArgs e)
        {
            GenerarWord();
        }



        private void GenerarWord()
        {

            object ObjMiss = System.Reflection.Missing.Value;
            Word.Application ObjWord = new Word.Application();
            //   Word.Document ObjDoc = ObjWord.Documents.Open(ObjMiss);
            string ruta = Application.StartupPath + @"\anexo.docx";
            object parametro = ruta;
            //object nombre1 = "nombre";
            //object telefono1 = "telefono";
            Word.Document ObjDoc = ObjWord.Documents.Open(parametro, ObjMiss);


            //Word.Range nom = ObjDoc.Bookmarks.get_Item(ref nombre1).Range;
            //Word.Range nom = ObjDoc.Bookmarks.get_Item("nombre").Range;
            //nom.Text = "damian";
            //Word.Range tel = ObjDoc.Bookmarks.get_Item(ref telefono1).Range;
            //tel.Text = "0985";

            //object rango1 = nom;
            //object rango2 = tel;

            //ObjDoc.Bookmarks.Add("nombre", ref rango1);
            //ObjDoc.Bookmarks.Add("telefono", ref rango2);
            //ObjWord.Visible = true;

            // Word.Document ObjDoc = ObjWord.Documents.Add(ref ObjMiss, ref ObjMiss, ref ObjMiss);
            //ObjDoc.Activate();
            //ObjWord.Selection.Font.Color = Word.WdColor.wdColorRed;
            //ObjWord.Selection.TypeText("hola como estas");
            //ObjWord.Visible = true;
            if (ObjDoc.Bookmarks.Exists("fecha") && ObjDoc.Bookmarks.Exists("actividad"))
            {
                // Texto nuevo para los marcadores
                string nuevoNombre = "10/12/2023";
                string nuevoTelefono = "la siguiente actividad se desarrollo en esta fecha";

                // Obtener los rangos de los marcadores
                Word.Range nom = ObjDoc.Bookmarks.get_Item("fecha").Range;
                Word.Range tel = ObjDoc.Bookmarks.get_Item("actividad").Range;

                // Actualizar el texto en los rangos
                nom.Text = nuevoNombre;
                tel.Text = nuevoTelefono;

                // Reasignar los rangos a los marcadores
                object rangoNom = nom;
                object rangoTel = tel;

                ObjDoc.Bookmarks.Add("fecha", ref rangoNom);
                ObjDoc.Bookmarks.Add("actividad", ref rangoTel);

                // Hacer visible la aplicación Word (opcional)
                ObjWord.Visible = true;
            }
            else
            {
                // Manejar la situación si los marcadores no existen
                System.Console.WriteLine("Los marcadores 'nombre' y 'telefono' no existen en el documento.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModificarDocumentoHTML();
        }

        private void ModificarDocumentoHTML()
        {
            
            } // fin

        private void LoadHtmlFile(string filePath)
        {
            axWebBrowser1.Navigate(filePath);
        }

        private void axWebBrowser1_DownloadComplete(object sender, EventArgs e)
        {

        }

        private void IngresoDatos_Load(object sender, EventArgs e)
        {
        }
    }
}
