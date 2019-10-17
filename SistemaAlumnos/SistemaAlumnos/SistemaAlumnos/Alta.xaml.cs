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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Conexion.llenarComboAlta(cbProgramas);
        }

        private void BtAgregar_Click(object sender, RoutedEventArgs e)
        {
            int res;
            Alumnocs a = new Alumnocs(Int16.Parse(txtClaveUnica.Text), txtNombre.Text, txtSexo.Text, txtCorreo.Text, Int16.Parse(txtSemestre.Text), cbProgramas.SelectedIndex);

            res = a.alta(a);
            if (res > 0)
            {
                MessageBox.Show("Se dio de alta");
            }
            else
            {
                MessageBox.Show("No se dio de alta");
            }
            
        }

        private void BtEliminar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Baja w = new Baja();
            w.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Buscar w = new Buscar();
            w.Show();
        }

        private void BtModificar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Modificar w = new Modificar();
            w.Show();
        }

        private void BtSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
