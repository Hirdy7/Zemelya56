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
using Zemelya56.ViewModels;

namespace Zemelya56.Views
{
    /// <summary>
    /// Логика взаимодействия для RequestView.xaml
    /// </summary>
    public partial class RequestView : Window
    {
        public RequestView()
        {
            InitializeComponent();
            DataContext = new RequestViewModel();
        }
    }
}
