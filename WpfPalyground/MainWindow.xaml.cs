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

namespace WpfPalyground
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button 1 pressed");
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button 2 pressed");
        }

        private void Sp_Click(object sender, RoutedEventArgs e)
        {
            Button b = e.Source as Button;
            MessageBox.Show(b.Name + " clicked");
        }
    }
}
