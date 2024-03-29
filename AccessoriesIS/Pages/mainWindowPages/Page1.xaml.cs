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

namespace AccessoriesIS.pages.mainWindowPages
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        CatalogBooksViewModel _catalogBooksViewModel;
        public Page1()
        {
            //было
            //InitializeComponent();
            //DataContext = new CatalogBooksViewModel();

            //стало
            InitializeComponent();
            _catalogBooksViewModel = new CatalogBooksViewModel();
            DataContext = _catalogBooksViewModel;
        }
        private void SearchTextBox_textChanged(object sender, TextChangedEventArgs e) => _catalogBooksViewModel.UpdateBookList();
        private void Filter_Checked(object sender, RoutedEventArgs e) => _catalogBooksViewModel.UpdateBookList();
        private void Filter_UnChecked(object sender, RoutedEventArgs e)
        {
            if(_catalogBooksViewModel.ResetFilterActive == Visibility.Visible)
                _catalogBooksViewModel.UpdateBookList();
        }
        private void ResetFilterButton_Click(object sender, RoutedEventArgs e)
        {
            _catalogBooksViewModel.ResetFilters();
        }

        private void SortComboBoxChanged(object sender, SelectionChangedEventArgs e)
        {
            _catalogBooksViewModel.UpdateBookList();
        }
    }
}
