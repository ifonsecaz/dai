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
    /// Interaction logic for Buscar.xaml
    /// </summary>
    public partial class Buscar : Window
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Alumnocs a = new Alumnocs(tbNombre.Text);
            List<Alumnocs> l = new List<Alumnocs>();
            l = a.busca(a);
            dgDatos.ItemsSource = l;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.Show();
            this.Hide();
        }
    }
}
