﻿using AccessoriesIS.views;
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


namespace AccessoriesIS
{
    /// <summary>
    /// Логика взаимодействия для MWindow.xaml
    /// </summary>
    public partial class MWindow : Window
    {
        public MWindow(Authorization authorization)
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(authorization);
        }

        private void Button_Click(object sender, RoutedEventArgs e) => this.Close();

        private void Window_Closed(object sender, EventArgs e) => this.Owner.Show();
    }
}
