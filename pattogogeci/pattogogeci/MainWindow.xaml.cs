using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace pattogogeci
{
    public partial class MainWindow : Window
    {
        int xseb = 5;
        int yseb = 5;
        int labdaSzelesseg = 58;
        int labdaMagassag = 95;
        int utoSzelesseg = 100;
        int pont = 0;
        int sorokSzama = 5;
        

        public MainWindow()
        {
            InitializeComponent();
            for (var j = 0; j < sorokSzama; j++)
            {
                for (var i = 0; i < 14; i++)
                {
                    var tegla = new Image();
                    tegla.Source = new BitmapImage(new Uri("/tegla-removebg-preview.png", UriKind.Relative));
                    tegla.Width = 50;
                    tegla.Height = 100;
                    tegla.Stretch = Stretch.Fill;
                    jatekter.Children.Add(tegla);
                    Canvas.SetLeft(tegla, i * 60);
                    Canvas.SetTop(tegla, j * 110);
                }
            }

            var ido = new DispatcherTimer();
            ido.Interval = TimeSpan.FromMilliseconds(1);
            ido.Tick += idoLepes;
            ido.Start();
        }

        private void idoLepes(object sender, EventArgs e)
        {
            if (Canvas.GetLeft(labda) >= 1000 - labdaSzelesseg || Canvas.GetLeft(labda) <= 0)
            {
                xseb *= -1;
            }

            if (Canvas.GetTop(labda) >= 600 - labdaMagassag || Canvas.GetTop(labda) <= 0)
            {
                yseb *= -1;
            }


            var egerPozicio = Mouse.GetPosition(jatekter).X;
            if (egerPozicio >= 0 && egerPozicio <= 900)
            {
                Canvas.SetLeft(uto, egerPozicio);
            }

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


            //tegla collision
            foreach (var tegla in jatekter.Children.OfType<Image>())
            {
                var teglaX = Canvas.GetLeft(tegla);
                var teglaY = Canvas.GetTop(tegla);
                if (labdaX + labdaSzelesseg > teglaX
                    && labdaX < teglaX + tegla.Width
                    && labdaY + labda.Height > teglaY
                    && labdaY < teglaY + tegla.Height)
                {
                    yseb *= -1;
                    jatekter.Children.Remove(tegla);
                    pont++;
                    szamlalo.Content = pont;
                    break;
                }
            }

            Canvas.SetLeft(labda, Canvas.GetLeft(labda) + xseb);
            Canvas.SetTop(labda, Canvas.GetTop(labda) + yseb);

        }
    }
}
