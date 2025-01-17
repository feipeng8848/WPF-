﻿using System;
using System.Windows;
using System.Windows.Input;
using WpfApp.ViewModel;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var dataContext = new MainViewModel() {
                Name = "FeiPeng8848"
            };
            DataContext = dataContext;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel vm = DataContext as MainViewModel;
            vm.Name = "haha";
        }

        private void BtnTestResources_Click(object sender, RoutedEventArgs e)
        {
            TestResources testResources = new TestResources();
            testResources.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ThemeWindow themeWindow = new ThemeWindow();
            themeWindow.Show();
        }
    }
}
