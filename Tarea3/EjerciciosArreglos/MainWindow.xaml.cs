using EjerciciosArreglos.Ejercicios;
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

namespace EjerciciosArreglos
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

        private void Ejercicio1MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio1 ejercicio1 = new Ejercicio1();
            ejercicio1.Show();
        }

        private void Ejercicio2MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio2 ejercicio2 = new Ejercicio2();
            ejercicio2.Show();
        }

        private void Ejercicio3MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio3 ejercicio3 = new Ejercicio3();
            ejercicio3.Show();
        }

        private void Ejercicio4MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio4 ejercicio4 = new Ejercicio4();
            ejercicio4.Show();
        }

        private void Ejercicio5MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5 ejercicio5 = new Ejercicio5();
            ejercicio5.Show();
        }
    }
}
