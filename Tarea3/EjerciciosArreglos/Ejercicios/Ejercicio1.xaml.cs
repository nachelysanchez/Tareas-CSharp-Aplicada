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

namespace EjerciciosArreglos.Ejercicios
{
    /// <summary>
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>
    public partial class Ejercicio1 : Window
    {
        int cantidad;
        int curso = 0;
        float[][] calificaciones;

        public static float suma = 0.0f;
        public static float promedio = 0.0f;
        public static int contador = 0;
        public Ejercicio1()
        {
            InitializeComponent();
        }

        public static int ToInt(string valor)
        {
            int conversion = 0;
            int.TryParse(valor, out conversion);
            return conversion;
        }
        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {
            curso = ToInt(CantidadCursosTextBox.Text);
            calificaciones = new float[curso][];
            for (int i = 0; i < curso; i++)
            {
                cantidad = ToInt(Microsoft.VisualBasic.Interaction.InputBox($"Ingrese la cantidad de alumnos del salón: {i + 1}", " Cantidad de Alumnos ", " ", 50, 0));
                calificaciones[i] = new float[cantidad];
                contador += cantidad;
                cantidad += cantidad;
            }
            CantidadCursosTextBox.Text = "";
        }

        private void AgregarCalificacionButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < curso; i++)
            {
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    calificaciones[i][j] = ToInt(Microsoft.VisualBasic.Interaction.InputBox($"Ingrese la calificación del alumno {j + 1}  del salón {i + 1}", "Calificaciones Alumnos", " ", 50, 0));
                    suma += calificaciones[i][j];
                }
            }
        }

        private void ResultadoButton_Click(object sender, RoutedEventArgs e)
        {
            promedio = suma / contador;
            CalificacionesListView.Items.Add("Promedio: ");
            CalificacionesListView.Items.Add(promedio);
        }
    }
}
