using Geometric.Class_laba2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Логика взаимодействия для Inheritance.xaml
    /// </summary>
    public partial class Inheritance : Window
    {
        public Inheritance()
        {
            InitializeComponent();
        }

        

        private void CalculateYieldButton_Click(object sender, RoutedEventArgs e)
        {
            string cropName = CropNameTextBox.Text;
            double cropR = double.Parse(CropRTextBox.Text);
            double potatoCropS = double.Parse(PotatoCropSTextBox.Text);

            // Create a Crop instance
            Crop crop = new Crop(cropR);

            // Create a PotatoCrop instance
            PotatoCrop potatoCrop = new PotatoCrop(cropR, potatoCropS);

            // Calculate and display the total yield
            double k = 1; // Set the coefficient as needed
            double totalYield = potatoCrop.TotalYield(k);

            ResultTextBlock.Text = $"Total yield for {cropName} on {potatoCrop.S} acres: {totalYield}";
        }
    }
}
