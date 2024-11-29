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

namespace WpfApp5666
{
    /// <summary>
    /// Логика взаимодействия для ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
        public ClientPage()
        {
            InitializeComponent();
            var data = appdate.conn.Clients.ToList();
            ClientsGrid.ItemsSource = data;
        }

        private void StaffButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Staff());
        }

        private void ServiseButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Services());
        }

        private void OrdersButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Reservations());

        }
    }
}
