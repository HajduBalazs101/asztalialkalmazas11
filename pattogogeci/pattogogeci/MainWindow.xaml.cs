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
using System.Windows.Threading;

namespace pattogogeci
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            int xseb = 100;
            int yseb = 100;
            int labdaSzelesseg = 58;
            int labdaMagassag = 95;
            int utoSzelesseg = 100;
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

            if (Canvas.GetLeft(labda) > 1000 - labdaSzelesseg || Canvas.GetLeft(labda) < 0) { xseb = xseb * -1; }
            if (Canvas.GetTop(labda) > 600 - labdaMagassag || Canvas.GetTop(labda) < 0) { yseb = yseb * -1; }
            Canvas.SetLeft(labda, Canvas.GetLeft(labda) + xseb);
            Canvas.SetTop(labda, Canvas.GetTop(labda) + yseb);
        }
    }
}
