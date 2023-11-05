using Geometric.Class_laba3;
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

namespace Geometric
{
    /// <summary>
    /// Логика взаимодействия для Abstract.xaml
    /// </summary>
    public partial class Abstract : Window
    {
        public Abstract()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var n = Convert.ToInt32(N.Text);
            var a = new Figura3D[n * 2];
            for(int i = 0; i < a.Length; i = i + 2)
            {
                a[i] = new Conus(i + 1, (i + 1) * 2);
                a[i + 1] = new Piramid(i + 2, (i + 2) * 2);
            }
            var maxS = 0.0;
            listBox.Items.Clear();
            for(int i = 0; i < a.Length; i++)
            {
                listBox.Items.Add(a[i].Show() + "Площа = "
                    + a[i].S().ToString());
                if (a[i].S() > maxS)
                {
                    maxS = a[i].S();
                }
            }
            max.Content = maxS.ToString();
        }
    }
}
