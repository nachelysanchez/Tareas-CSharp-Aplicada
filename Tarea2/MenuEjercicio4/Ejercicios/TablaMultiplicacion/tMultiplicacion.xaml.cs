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

namespace MenuEjercicio4.Ejercicios.TablaMultiplicacion
{
    /// <summary>
    /// Interaction logic for tMultiplicacion.xaml
    /// </summary>
    public partial class tMultiplicacion : Window
    {
        public tMultiplicacion()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            TablaListBox.Items.Clear();
            int tabla = int.Parse(NumeroTextBox.Text);
            int limite = 10;
            int resultado;

            for (int i=1; i <= limite; i++)
            {
                resultado = tabla * i;
                TablaListBox.Items.Add(tabla + "x" + i + "=" + resultado);
            }
        }
    }
}
