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

namespace WpfLesson4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Car> GetCars()
        {
            return new List<Car>
            {
                new Car
                {
                    Vendor="Mercedes",
                    Model="E-200",
                    Year=2011
                },
                new Car
                {
                    Vendor="Ferrari",
                    Model="F12 Berlinetta",
                    Year=2011
                },
                new Car
                {
                    Vendor="BMW",
                    Model="F10",
                    Year=2011
                },
                new Car
                {
                    Vendor="Cadillac",
                    Model="Escalade",
                    Year=2011
                },
                new Car
                {
                    Vendor="Chevrolet",
                    Model="Cruze LTZ RS",
                    Year=2015
                },
            };
        }
        public MainWindow()
        {
            InitializeComponent();

            //listBox.ItemsSource = GetCars();

        }

        private void downBtn_Click(object sender, RoutedEventArgs e)
        {
            //if (prgbar.Value > prgbar.Minimum)
            //{
            //    prgbar.Value--;
            //}
        }

        private void upBtn_Click(object sender, RoutedEventArgs e)
        {
            //if (prgbar.Value < prgbar.Maximum)
            //{
            //    prgbar.Value++;
            //}
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
        //    txtBlock1.Text = Convert.ToInt32(slider.Value).ToString();
        //    txtBlock2.Text = Convert.ToInt32(slider.Value).ToString();
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var car = listBox.SelectedItem as Car;
            //   MessageBox.Show(car.Model);

            //modelTxtb.Text = $"Model : {car.Model}";
            //vendorTxtb.Text = $"Vendor : {car.Vendor}";
            //yearTxtb.Text = $"Year : {car.Year}";





            //modelTxtb.Text = $"Model : ";
            //vendorTxtb.Text = $"Vendor : ";
            //yearTxtb.Text = $"Year : ";
            //var cars = listBox.SelectedItems;
            //foreach (var item in cars)
            //{
            //    var car = item as Car;
            //    modelTxtb.Text += car.Model+" ";
            //    vendorTxtb.Text += car.Vendor + " ";
            //    yearTxtb.Text += car.Year.ToString() + " ";
            //}

        }
    }
}
