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
    /// Interaction logic for Ej5_10.xaml
    /// </summary>
    public partial class Ej5_10 : Window
    {
        public Ej5_10()
        {
            InitializeComponent();
        }
        class Poligono
        {
            public int cantidad;
            public int medidas;
            public int angulos;
            public Poligono(int c, int m, int a)
            {
                cantidad = c;
                medidas = m;
                angulos = a;
            }
            public Poligono()
            {
                cantidad = 0;
                medidas = 0;
                angulos = 0;
            }
            public int Cantidad
            {
                get
                {
                    return cantidad;
                }

                set
                {
                    if (value <= 0)
                    {
                        cantidad = 1;
                    }
                    else
                    {
                        cantidad = value;
                    }
                }
            }
            public int Medidas
            {
                get
                {
                    return medidas;
                }

                set
                {
                    if (value <= 0)
                    {
                        medidas = 1;
                    }
                    else
                    {
                        medidas = value;
                    }
                }
            }
            public int Angulos
            {
                get
                {
                    return angulos;
                }

                set
                {
                    if (value <= 0)
                    {
                        angulos = 1;
                    }
                    else
                    {
                        angulos = value;
                    }
                }
            }
            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Cantidad de lados: {cantidad}\tMedidas de lados: {medidas}\t Angulos: {angulos}");
                return sb.ToString();
            }
        }
        private void IngresarButton_Click(object sender, RoutedEventArgs e)
        {
            Poligono poligono = new Poligono();
            poligono.Cantidad = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Cantidad de lados: ", "Lados", " ", 50, 0));
            poligono.Medidas = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Medidas de lados: ", "Medidas", " ", 50, 0));
            poligono.Angulos = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Angulos: ", "Angulo", " ", 50, 0));

            PoligonosListBox.Items.Add(poligono.ToString());
        }
    }
}
