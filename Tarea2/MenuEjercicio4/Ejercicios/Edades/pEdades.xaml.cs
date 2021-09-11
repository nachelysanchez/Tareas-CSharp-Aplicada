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

namespace MenuEjercicio4.Ejercicios.Edades
{
    /// <summary>
    /// Interaction logic for pEdades.xaml
    /// </summary>
    public partial class pEdades : Window
    {
        //float promedio = 0;
        //int contador = 1;
        //int mayor = 2147483647;
        //int menor = 2147483647;
        public static int minimo = 0, maximo = 0, edad = 0;
        public static int contadorEdades = 0;
        public static float promedio = 0, acumuladorSuma = 0;
        public pEdades()
        {
            InitializeComponent();
        }

        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {
            int n = 0;

            if (EdadTextBox.Text != "")
            {
                string str = EdadTextBox.Text;
                int.TryParse(str, out n);

                this.EdadListView.Items.Add(n);
                EdadTextBox.Text = "";
                contadorEdades++;
                acumuladorSuma += n;
                EdadTextBox.Focus();

            }
            else
            {
                MessageBox.Show("Campo vacio...", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Error);
                EdadTextBox.Focus();
            }
            edad = n;
            minimo = maximo = edad;
            for (int i = 0; i < EdadListView.Items.Count; i++)
            {

                if (maximo < Convert.ToInt32(EdadListView.Items[i]))
                {
                    maximo = Convert.ToInt32(EdadListView.Items[i]);

                }
                else if (minimo > Convert.ToInt32(EdadListView.Items[i]))
                {
                    minimo = Convert.ToInt32(EdadListView.Items[i]);
                }
            }
        }
        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            promedio = (acumuladorSuma / contadorEdades);

            ResultadoListView.Items.Add("Promedio: ");
            ResultadoListView.Items.Add(promedio);

            ResultadoListView.Items.Add("Edad minima: ");
            ResultadoListView.Items.Add(minimo);

            ResultadoListView.Items.Add("Edad Maxima: ");
            ResultadoListView.Items.Add(maximo);
        }
    }
}
