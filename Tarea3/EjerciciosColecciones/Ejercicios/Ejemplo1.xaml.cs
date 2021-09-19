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
    /// Interaction logic for Ejemplo1.xaml
    /// </summary>
    public partial class Ejemplo1 : Window
    {
        ArrayList calificaciones = new ArrayList();
        public static int minimo = 1, maximo = 1;
        public static int contador = 0;
        public static float promedio = 0.00f, AcuSuma = 0;
        public Ejemplo1()
        {
            InitializeComponent();
        }

        public static int ToInt(string valor)
        {
            int retorno = 0;

            int.TryParse(valor, out retorno);

            return retorno;
        }
        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            int n = 0;
            n = ToInt(CalificacionTextBot.Text);
            if (CalificacionTextBot.Text != "")
            {
                calificaciones.Add(ToInt(CalificacionTextBot.Text));
                CalificacionTextBot.Text = "";
                contador++;
                AcuSuma += n;
                CalificacionTextBot.Focus();

            }
            else
            {
                MessageBox.Show("Campo vacio...", "Advertencia",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                CalificacionTextBot.Focus();
            }

            minimo = maximo = n;
            foreach (int i in calificaciones)
            {
                if (maximo < i)
                {
                    maximo = i;

                }
                else if (minimo > i)
                {
                    minimo = i;
                }
            }
        }

        private void ResultadosButton_Click(object sender, RoutedEventArgs e)
        {
            promedio = (AcuSuma / contador);

            ResultadosListView.Items.Add("Promedio: ");
            ResultadosListView.Items.Add(promedio);

            ResultadosListView.Items.Add("Edad minima: ");
            ResultadosListView.Items.Add(minimo);

            ResultadosListView.Items.Add("Edad Maxima: ");
            ResultadosListView.Items.Add(maximo);

            foreach (int i in calificaciones)
            {
                NotasListView.Items.Add(i);
            }
        }
    }
}
