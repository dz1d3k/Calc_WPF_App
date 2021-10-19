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

namespace Calc_WPF_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Num1_Click(object sender, RoutedEventArgs e)

        {
            if (Result.Content == "0")
            {
                Result.Content = "1"; 
            }
            else
            { 
            Result.Content = Result.Content + "1";
            }
        }

        private void Num2_Click(object sender, RoutedEventArgs e)
        {
            Result.Content = Result.Content + "2";
        }

        private void Num3_Click(object sender, RoutedEventArgs e)
        {
            Result.Content = Result.Content + "3";
        }

        private void Num4_Click(object sender, RoutedEventArgs e)
        {
            Result.Content = Result.Content + "4";
        }

        private void Num5_Click(object sender, RoutedEventArgs e)
        {
            Result.Content = Result.Content + "5";
        }

        private void Num6_Click(object sender, RoutedEventArgs e)
        {
            Result.Content = Result.Content + "6";
        }

        private void Num7_Click(object sender, RoutedEventArgs e)
        {
            Result.Content = Result.Content + "7";
        }

        private void Num8_Click(object sender, RoutedEventArgs e)
        {
            Result.Content = Result.Content + "8";
        }

        private void Num9_Click(object sender, RoutedEventArgs e)
        {
            Result.Content = Result.Content + "9";
        }

        private void Num0_Click(object sender, RoutedEventArgs e)
        {
            Result.Content = Result.Content + "0";
        }

        private void signc_Click(object sender, RoutedEventArgs e)
        {
            Result.Content = "";
        }

        private void Signplus_Click(object sender, RoutedEventArgs e)
        {
            Result.Content = Result.Content + "+";
        }

        private void Signminus_Click(object sender, RoutedEventArgs e)
        {
            Result.Content = Result.Content + "-";
        }

        private void Signby_Click(object sender, RoutedEventArgs e)
        {
            Result.Content = Result.Content + "/";
        }

        private void Signtimes_Click(object sender, RoutedEventArgs e)
        {
            Result.Content = Result.Content + "*";
        }

        private void Signcoma_Click(object sender, RoutedEventArgs e)
        {
            Result.Content = Result.Content + ",";
        }










    }



}
