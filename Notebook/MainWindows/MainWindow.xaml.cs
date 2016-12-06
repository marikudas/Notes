﻿using System.Collections.Generic;
using System.Windows;

namespace Presentation.MainWindows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public static Logic.Logic logic = new Logic.Logic();

        public MainWindow()
        {
            InitializeComponent();
            Window qwe = new Window();
            
        }

        private void NewBookButton_Click(object sender, RoutedEventArgs e)
        {
            NewBook newbook = new NewBook();
            newbook.Show();
        }
    }
}
