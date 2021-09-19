using System;
using System.Collections;
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

namespace EjerciciosColecciones.Ejercicios
{
    /// <summary>
    /// Interaction logic for Ejercicio2.xaml
    /// </summary>
    public partial class Ejercicio2 : Window
    {
        Hashtable diccionario = new Hashtable();
        public Ejercicio2()
        {
            InitializeComponent();
            PalabrasListView.Items.Add("Programacion\nVirtualizacion\nAlgoritmo\nComputacion\nDepuracion");
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            diccionario.Add("programacion", " Es el arte del proceso por el cual se limpia, codifica, traza y protege el código fuente de programas computacionales");
            diccionario.Add("virtualizacion", "Es la creación a través de software de una representación de algún recurso tecnológico.");
            diccionario.Add("algoritmo", "Conjunto ordenado y finito de operaciones que permite hallar la solución de un problema");
            diccionario.Add("computacion", "Es un dispositivo informático que es capaz de recibir, almacenar y procesar información de una forma útil.");
            diccionario.Add("depuracion", "Es el proceso de identificar y corregir errores de programación");

            DescripcionTextBox.Text = (String)diccionario[PalabraTextBox.Text.ToLower()];
        }
    }
}
