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
    /// Interaction logic for Ejercicio5.xaml
    /// </summary>
    public partial class Ejercicio5 : Window
    {
        Hashtable listaNumeros = new Hashtable();
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            listaNumeros.Add(NombreTextBox.Text, NumeroTextBox.Text);
            NumeroTextBox.Text = "";
            NombreTextBox.Text = "";
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            BusquedaTextBox.Text = (String)listaNumeros[Convert.ToString(NombreTextBox.Text)];
        }
    }
}
