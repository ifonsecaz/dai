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

namespace Convertidor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TextBox objTextBox = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BttCalcular_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double grados;
                //si escribió en la caja de txt centígrados
                if (objTextBox == txtCentígrados)
                {
                    MessageBox.Show("Escribiste en la txtCentígrados");
                    grados = Convert.ToDouble(txtCentígrados.Text) * 9.0 / 5.0 + 32.0;
                    txtFahrenheit.Text = string.Format("{0:F2}", grados);
                }
                else
                {
                    if (objTextBox == txtFahrenheit)
                    {
                        MessageBox.Show("Escribiste en la txtCentígrados");
                        grados = (Convert.ToDouble(txtFahrenheit.Text) - 32.0) * 5.0 / 9.0;
                        txtCentígrados.Text = String.Format("{0:F2}", grados);
                    }
                }
            }
            catch (FormatException)
            {
                txtCentígrados.Text = "0.0";
                txtFahrenheit.Text = "32.0";
            }
        }

        private void TxtCentígrados_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            objTextBox = sender as TextBox;
        }

        private void TxtFahrenheit_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            objTextBox = sender as TextBox;
        }
    }
}
