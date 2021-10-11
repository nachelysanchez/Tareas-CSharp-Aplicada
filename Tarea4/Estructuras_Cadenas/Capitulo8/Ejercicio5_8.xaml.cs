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

namespace Estructuras_Cadenas.Capitulo8
{
    /// <summary>
    /// Interaction logic for Ejercicio5_8.xaml
    /// </summary>
    public partial class Ejercicio5_8 : Window
    {
        public Ejercicio5_8()
        {
            InitializeComponent();
        }

        private void AlfabeticoButton_Click(object sender, RoutedEventArgs e)
        {
            string cadena1 = "";
            string cadena2 = "";
            cadena1 = Cadena1TextBox.Text;
            cadena2 = Cadena2TextBox.Text;

            string ordenado1 = new string(cadena1.OrderBy(x => x).ToArray());
            string ordenado2 = new string(cadena2.OrderBy(x => x).ToArray());

            MessageBox.Show($"La cadena 1 {cadena1} ordenada alfabeticamente es: {ordenado1}\nLa cadena 2 {cadena2} ordenada alfabeticamente es: {ordenado2}",
                "Ordenar", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
