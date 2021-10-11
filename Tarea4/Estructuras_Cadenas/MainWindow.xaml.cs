using Estructuras_Cadenas.Capitulo8;
using Estructuras_Cadenas.Capitulo9;
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

namespace Estructuras_Cadenas
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

        private void Ejercicio3MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio3_8 ej3 = new Ejercicio3_8();
            ej3.Show();
        }

        private void Ejercicio5MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5_8 ej5 = new Ejercicio5_8();
            ej5.Show();
        }

        private void Ejercicio1MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio1_9 eje1 = new Ejercicio1_9();
            eje1.Show();
        }

        private void Ejercicio3_9MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio3_9 eje3 = new Ejercicio3_9();
            eje3.Show();
        }

        private void Ejercicio4MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio4_ ej4 = new Ejercicio4_();
            ej4.Show();
        }
    }
}
