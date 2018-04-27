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
using System.Xaml;

namespace composantDemo
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            feux1.CouleurChangeEvent += new MonComposant.FeuHandler(Feux1_CouleurChangeEvent);
        }

        private void Feux1_CouleurChangeEvent(object sender, EventArgs e)
        {
            labelfeux.Content = feux1.couleur;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
