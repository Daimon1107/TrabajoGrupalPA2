using System;
using System.Windows.Forms;

using Word = Microsoft.Office.Interop.Word;

namespace ArquitecturaPresentacion
{
    public partial class IngresoDatos : Form
    {
        public IngresoDatos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
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

        private void IngresoDatos_Load(object sender, EventArgs e)
        {

        // Método para insertar tabla con bordes
        static void InsertarTabla(Word.Document doc)
        {
            int filas = 5; // Cantidad de filas de la tabla
            int columnas = 2; // Cantidad de columnas de la tabla

            Word.Range range = doc.Content;
            Word.Table tabla = doc.Tables.Add(range, filas, columnas);

            // Establecer estilo de borde para la tabla
            tabla.Borders.Enable = 1; // Habilitar bordes

            // Establecer ancho de las columnas
            tabla.Columns[1].SetWidth(100, Word.WdRulerStyle.wdAdjustNone);
            tabla.Columns[2].SetWidth(300, Word.WdRulerStyle.wdAdjustNone);

            // Rellenar la tabla con datos de ejemplo
            for (int i = 1; i <= filas; i++)
            {
                tabla.Cell(i, 1).Range.Text = "Fecha " + i.ToString();
                tabla.Cell(i, 2).Range.Text = "Actividad " + i.ToString();
            }
        }

        // Método para insertar texto centrado
        static void InsertarTextoCentrado(Word.Document doc, string texto)
        {
            Word.Paragraph para = doc.Paragraphs.Add();
            para.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            para.Range.Text = texto;
            para.Range.InsertParagraphAfter();
        }

        // Método para insertar texto alineado a la izquierda
        static void InsertarTextoIzquierda(Word.Document doc, string texto)
        {
            Word.Paragraph para = doc.Paragraphs.Add();
            para.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            para.Range.Text = texto;
            para.Range.InsertParagraphAfter();
        }

        private void axWebBrowser1_Enter(object sender, EventArgs e)
        {

        }

        private void IngresoDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
