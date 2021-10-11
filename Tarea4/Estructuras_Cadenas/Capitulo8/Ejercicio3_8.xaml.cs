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

namespace Estructuras_Cadenas.Capitulo8
{
    /// <summary>
    /// Interaction logic for Ejercicio3_8.xaml
    /// </summary>
    public partial class Ejercicio3_8 : Window
    {
        public Ejercicio3_8()
        {
            InitializeComponent();
        }
        public String Formato;
        private void AMButton_Click(object sender, RoutedEventArgs e)
        {
            if (DateTime.Now.Hour > 12){
                Formato = String.Format("La fecha es: {0: dd MM yyyy} {0: hh mm} PM", DateTime.Now);
                MessageBox.Show(Formato, "Fecha actual", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                Formato = String.Format("La fecha es: {0: dd MM yyyy} {0: hh mm} AM", DateTime.Now);
                MessageBox.Show(Formato, "Fecha actual", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            
        }
    }
}
