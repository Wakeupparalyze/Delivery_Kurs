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
using System.Windows.Shapes;

namespace Delivery_Kurs
{
    /// <summary>
    /// Логика взаимодействия для BalanceWindow.xaml
    /// </summary>
    public partial class BalanceWindow : Window
    {
        public BalanceWindow()
        {
            InitializeComponent();
        }

        private void AddBalanceBtn(object sender, RoutedEventArgs e)
        {
            // сделать добавление баланса
            Close();
        }
    }
}
