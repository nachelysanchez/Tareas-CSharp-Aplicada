using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Depuracion_Clases.Capitulo_10
{
    /// <summary>
    /// Interaction logic for Ej2_10.xaml
    /// </summary>
    public partial class Ej2_10 : Window
    {
        public Ej2_10()
        {
            InitializeComponent();
        }
        class Estudiantes
        {
            public int codigo;
            public string nombre;
            public int edad;
            public string grado;
            public string seccion;
            public Estudiantes(int c, string n, int e, string g, string s)
            {
                codigo = c;
                nombre = n;
                edad = e;
                grado = g;
                seccion = s;
            }
            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Codigo: {codigo}\tNombre del Estudiante: {nombre}\tEdad: {edad}\tGrado: {grado}\tSeccion: {seccion}");
                return sb.ToString();
            }
        }
        private void IngresarButton_Click(object sender, RoutedEventArgs e)
        {
            Estudiantes estudiantes = new Estudiantes(Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Codigo del estudiante: ", "Codigo", " ", 50, 0)),
                Microsoft.VisualBasic.Interaction.InputBox($"Nombre del estudiante: ", "Nombre", " ", 50, 0),
                int.Parse(Microsoft.VisualBasic.Interaction.InputBox($"Edad del estudiante: ", "Edad", " ", 50, 0)),
                Microsoft.VisualBasic.Interaction.InputBox($"Grado del estudiante: ", "Grado", " ", 50, 0),
                Microsoft.VisualBasic.Interaction.InputBox($"Seccion del estudiante: ", "Seccion", " ", 50, 0));
            MostrarListBox.Items.Add(estudiantes.ToString());
        }
    }
}
