﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PresentationWPF
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
private void Introduction_Click(object sender, RoutedEventArgs e)
{

            introductionHeader.BringIntoView();
        }

        private void History_Click(object sender, RoutedEventArgs e)
        {

            historyHeader.BringIntoView();
        }

        private void Symbolism_Click(object sender, RoutedEventArgs e)
        {

            symbolismHeader.BringIntoView();
        }

    }
}