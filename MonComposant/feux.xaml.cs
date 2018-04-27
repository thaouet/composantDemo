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

namespace MonComposant
{

    public delegate void FeuHandler(Object sender, EventArgs e);
    
    /// <summary>
    /// Logique d'interaction pour feux.xaml
    /// </summary>
    public partial class feux : UserControl
    {

        public event FeuHandler CouleurChangeEvent;

        public String couleur;
        public feux()
        {
            InitializeComponent();
        }

        private void bRed_Click(object sender, RoutedEventArgs e)
        {
            bRed.Background = Brushes.Red;
            bGreen.Background = Brushes.LightGray;
            bOrange.Background = Brushes.LightGray;
            couleur = "Rouge";
            CouleurChangeEvent(this, new EventArgs());
        }

        private void bOrange_Click(object sender, RoutedEventArgs e)
        {
            bRed.Background = Brushes.LightGray;
            bGreen.Background = Brushes.LightGray;
            bOrange.Background = Brushes.Orange;
            couleur = "Orange";
            CouleurChangeEvent(this, new EventArgs());
        }

        private void bGreen_Click(object sender, RoutedEventArgs e)
        {
            bRed.Background = Brushes.LightGray;
            bGreen.Background = Brushes.Green;
            bOrange.Background = Brushes.LightGray;
            couleur = "Vert";
            CouleurChangeEvent(this, new EventArgs());
        }
    }
}
