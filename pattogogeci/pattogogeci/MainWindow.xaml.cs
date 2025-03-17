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
        public MainWindow()
        {
            InitializeComponent();
            var ido = new DispatcherTimer();
            ido.Interval = TimeSpan.FromMilliseconds(1);
            ido.Tick += idoLepes;
            ido.Start();
        }

        private void idoLepes(object sender, EventArgs e)
        {
            // 1. balról és jobbról forduljon vissza
            if (Canvas.GetLeft(labda) > 1000 - labdaSzelesseg || Canvas.GetLeft(labda) < 0)
            {
                xseb = xseb * -1;
            }

            if (Canvas.GetTop(labda) > 600 - labdaMagassag || Canvas.GetTop(labda) < 0)
            {
                yseb = yseb * -1;
            }

            Canvas.SetLeft(labda, Canvas.GetLeft(labda) + xseb);
            Canvas.SetTop(labda, Canvas.GetTop(labda) + yseb);

            // 2. fentről és lentről is forduljon vissza
            if (Canvas.GetTop(labda) > 560 || Canvas.GetTop(labda) < 0)
            {
                yseb = yseb * -1;
            }

            // labda mozgatás
            Canvas.SetLeft(labda, Canvas.GetLeft(labda) + xseb);
            Canvas.SetTop(labda, Canvas.GetTop(labda) + yseb);

            // 3. ne menjen ki az ütő a szélén
            var egerPozicio = Mouse.GetPosition(jatekter).X;
            if (egerPozicio > 0 && egerPozicio < 950)
            {
                // ütő mozgatás
                Canvas.SetLeft(uto, egerPozicio);
            }
            // 4. ütközésvizsgálat a labda és az ütő között
            var utoX = Canvas.GetLeft(uto);
            var utoY = Canvas.GetTop(uto);
            var labdaX = Canvas.GetLeft(labda);
            var labdaY = Canvas.GetTop(labda);

            if (labdaX + labda.Width > utoX
                && labdaX < utoX + uto.Width
                && labdaY + labda.Height > utoY
                && labdaY < utoY + uto.Height
            )
            {
                yseb *= -1;
                pont += 1;
                szamlalo.Content = pont;
            }

            // labda mozgatás
            Canvas.SetLeft(labda, Canvas.GetLeft(labda) + xseb);
            Canvas.SetTop(labda, Canvas.GetTop(labda) + yseb);
        }
    }
}
