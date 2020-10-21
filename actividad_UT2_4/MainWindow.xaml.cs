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

namespace actividad_UT2_4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            contadorTextBlock.Text = Convert.ToString(palabrasTextBox.Text.Length) + "/" + palabrasTextBox.MaxLength;
        }
        
        private void PalabrasTextBox_TextChanged(object sender, RoutedEventArgs e)
        {
            if (palabrasTextBox.Text.Length >= palabrasTextBox.MaxLength) palabrasTextBox.IsReadOnly = true;
            contadorTextBlock.Text = Convert.ToString(palabrasTextBox.Text.Length) +"/" + palabrasTextBox.MaxLength;
        }

        
    }
}
