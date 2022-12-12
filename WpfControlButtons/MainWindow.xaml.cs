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

namespace WpfControlButtons
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {
            //var result = spExpanded.Children.OfType<Expander>().ToList();

            foreach(var item in spExpander.Children)
            {
                Expander data = (Expander)item;
                if((Expander)sender != data)
                    data.IsExpanded = false;
                else
                    data.IsExpanded = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(pswPassword.Password + " / " + tbxName);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lbCities.Items.Add(tbxAddCity.Text);
        }

        private void lbCities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblSlider.Content = ((Slider)sender).Value;
        }
    }
}
