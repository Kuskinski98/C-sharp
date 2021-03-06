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

namespace University
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null)
                return;
            PersonInfoInput info = new PersonInfoInput();
            string cont = btn.Content.ToString();

           switch (cont)
            {
                case "Teacher":
                    info.txtFNum.IsEnabled = false; 
                    info.Show();
                    break;
                case "Student":
                    info.txtSubject.IsEnabled = false;
                    info.Show();
                    break;
            }
            
        }
    }
}
