﻿using System;
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

namespace Lesson5WpfContainers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //stPanel.Children.Add(new Label { Content = "Hakuna matata" });
        }
        //public string LblText { get; set; }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button btn)
            {
                MessageBox.Show(btn.Content.ToString());
            }

            // 7 * 8 + 9 * 2 = 56 + 18 
        }
    }
}
