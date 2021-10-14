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

namespace Depuracion_Clases.Capitulo_10
{
    /// <summary>
    /// Interaction logic for Ej1_10.xaml
    /// </summary>
    public partial class Ej1_10 : Window
    {
        public Ej1_10()
        {
            InitializeComponent();
        }
        class Inventario
        {
            public int codigo;
            public string producto;
            public string descripcion;
            public int existencia;

            public Inventario(int c, string p, string d, int e)
            {
                codigo = c;
                producto = p;
                descripcion = d;
                existencia = e;
            }

            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Codigo: {codigo}\tNombre del Producto: {producto}\tDescripcion: {descripcion}\tExistencia: {existencia}");
                return sb.ToString();
            }
        }
        private void IngresarButton_Click(object sender, RoutedEventArgs e)
        {
            Inventario inventario = new Inventario(Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Codigo del producto: ", "Codigo del Producto", " ", 50, 0)),
               Microsoft.VisualBasic.Interaction.InputBox($"Nombre del producto: ", "Nombre del Producto", " ", 50, 0),
               Microsoft.VisualBasic.Interaction.InputBox($"Descripcion del producto: ", "Descripcion del Producto", " ", 50, 0),
               Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Existencia del producto: ", "Existencia del Producto", " ", 50, 0)));
            MostrarListBox.Items.Add(inventario.ToString());
        }
    }
}
