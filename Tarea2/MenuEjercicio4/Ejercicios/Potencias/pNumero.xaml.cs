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

namespace MenuEjercicio4.Ejercicios.Potencias
{
    /// <summary>
    /// Interaction logic for pNumero.xaml
    /// </summary>
    public partial class pNumero : Window
    {
        public pNumero()
        {
            InitializeComponent();
        }
        
        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            int resultado = 1, numeroentero = 0, potenciaentero = 0, contenedor = 1;
            String valor;
            String potencia;
            potencia = this.PotenciaTextBox.Text;
            valor = this.NumeroTextBox.Text;
            int.TryParse(valor, out numeroentero);
            int.TryParse(potencia, out potenciaentero);

            //contenedor = numeroentero;
            for (int i = 0; i < potenciaentero; i++)
            {
                contenedor = resultado;
                resultado = numeroentero * contenedor;

            }
            this.PotenciaTextBox.Clear();
            this.NumeroTextBox.Clear();
            MessageBox.Show($"{resultado}", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
