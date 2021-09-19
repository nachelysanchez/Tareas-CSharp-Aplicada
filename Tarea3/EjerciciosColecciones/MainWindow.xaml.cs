using EjerciciosColecciones.Ejercicios;
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

namespace EjerciciosColecciones
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

        private void Ejercicio1Menutem_Click(object sender, RoutedEventArgs e)
        {
            Ejemplo1 ejercicio1 = new Ejemplo1();
            ejercicio1.Show();
        }

        private void Ejercicio2Menutem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio2 ejercicio2 = new Ejercicio2();
            ejercicio2.Show();
        }

        private void Ejercicio3Menutem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5 ejercicio5 = new Ejercicio5();
            ejercicio5.Show();
        }
    }
}
