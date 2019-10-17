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

namespace SistemaAlumnos
{
    /// <summary>
    /// Interaction logic for Baja.xaml
    /// </summary>
    public partial class Baja : Window
    {
        public Baja()
        {
            InitializeComponent();
        }

        private void btBaja_Click(object sender, RoutedEventArgs e)
        {
            int res;
            Alumnocs a = new Alumnocs(Int16.Parse(tbFolio.Text));
            res = a.baja(a);

            if (res > 0)
            {
                MessageBox.Show("Se dio de baja");
            }
            else
            {
                MessageBox.Show("No se dio de baja");
            }
        }

        private void btRegresar_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.Show();
            this.Hide();
        }
    }
}
