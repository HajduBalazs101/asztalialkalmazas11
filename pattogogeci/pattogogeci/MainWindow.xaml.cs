using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
using System.Windows.Threading;

namespace pattogogeci
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int xseb = 5;
        int yseb = 5;
        int labdaSzelesseg = 58;
        int labdaMagassag = 95;
        int utoSzelesseg = 100;
        int pont = 0;
        int sorokSzama = 2;
        public MainWindow()
        {
            InitializeComponent();
            for(var j = 0; j < sorokSzama; j++) { 
                for(var i = 0; i<int.MaxValue; i++) {
                
                var tegla = new Image();
                tegla.Source = new BitmapImage(new Uri("/tegla-removebg-preview.png", UriKind.Relative));
                tegla.Width = 50;
            
                jatekter.Children.Add(tegla);
                Canvas.SetLeft(tegla, i*1);
                Canvas.SetTop(tegla, j*100);
            }
            }

            var ido = new DispatcherTimer();
            ido.Interval = TimeSpan.FromMilliseconds(1);
            ido.Tick += idoLepes;
            ido.Start();
        }

        private void idoLepes(object sender, EventArgs e)
        {
            // Balról és jobbról visszapattanás
            if (Canvas.GetLeft(labda) >= 1000 - labdaSzelesseg || Canvas.GetLeft(labda) <= 0)
            {
                xseb *= -1;
            }

            // Fentről és lentről visszapattanás
            if (Canvas.GetTop(labda) >= 600 - labdaMagassag || Canvas.GetTop(labda) <= 0)
            {
                yseb *= -1;
            }

            // Labda mozgatás
            Canvas.SetLeft(labda, Canvas.GetLeft(labda) + xseb);
            Canvas.SetTop(labda, Canvas.GetTop(labda) + yseb);

            // Az ütő mozgatása egérpozíció alapján
            var egerPozicio = Mouse.GetPosition(jatekter).X;
            if (egerPozicio >= 0 && egerPozicio <= 900) // Figyelembe véve az ütő szélességét
            {
                Canvas.SetLeft(uto, egerPozicio);
            }

            // Ütközésvizsgálat
            double utoY = Canvas.GetTop(uto);
            double utoX = Canvas.GetLeft(uto);
            double labdaY = Canvas.GetTop(labda);
            double labdaX = Canvas.GetLeft(labda);

            if (labdaX + labdaSzelesseg > utoX
                && labdaX < utoX + utoSzelesseg
                && labdaY + labdaMagassag > utoY
                && labdaY < utoY)
            {
                yseb *= -1;
                pont++;
                szamlalo.Content = pont;
            }
        }

    }
}
