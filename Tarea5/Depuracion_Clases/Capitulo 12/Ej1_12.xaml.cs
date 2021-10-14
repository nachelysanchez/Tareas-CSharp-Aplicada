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

namespace Depuracion_Clases.Capitulo_12
{
    /// <summary>
    /// Interaction logic for Ej1_12.xaml
    /// </summary>
    public partial class Ej1_12 : Window
    {
        public Ej1_12()
        {
            InitializeComponent();
        }

        private void VerificarButton_Click(object sender, RoutedEventArgs e)
        {
            int factorial = 1;
            int numero = int.Parse(NumeroTextBox.Text);
            for (int i = numero; i >= 1; i--)
            {
                factorial *= i;
            }
            MessageBox.Show($"El factorial de {numero} es {factorial}");
        }
        //Favor de utilizar la depuración paso a paso
    }
}
