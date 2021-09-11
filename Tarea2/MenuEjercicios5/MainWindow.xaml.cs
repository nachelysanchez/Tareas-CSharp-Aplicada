using MenuEjercicios5.Ejercicios.Factorial;
using MenuEjercicios5.Ejercicios.NumeroEnLetras;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MenuEjercicios5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FactorialMenuItem_Click(object sender, RoutedEventArgs e)
        {
            fNumero factorial = new fNumero();
            factorial.Show();
        }

        private void NumeroEscritoMenuItem_Click(object sender, RoutedEventArgs e)
        {
            nLetras numero = new nLetras();
            numero.Show();
        }
    }
}
