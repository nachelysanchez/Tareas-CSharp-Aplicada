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

namespace MenuEjercicios5.Ejercicios.Factorial
{
    /// <summary>
    /// Interaction logic for fNumero.xaml
    /// </summary>
    public partial class fNumero : Window
    {
        public fNumero()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            int factorial = 1;
            int numero = Convert.ToInt32(NumeroTextBox.Text);

            for (int i = numero; i >= 1; i--)
            {
                factorial *= i;
            }

            MessageBox.Show($"El factorial de {numero} es {factorial}");
        }
    }
}
