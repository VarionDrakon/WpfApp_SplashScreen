﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp_SplashScreen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SplashScreen splashScreen = new SplashScreen("Resources/splash screen.png");
        public MainWindow()
        {
            splashScreen.Show(false, true);
            InitializeComponent(); 
            Thread threadClosedSplashScreen = new Thread(ThreadMethodClosedSplashScreen);
            threadClosedSplashScreen.Start();
        }
        private void ThreadMethodClosedSplashScreen()
        {
            Thread.Sleep(3000);
            splashScreen.Close(TimeSpan.FromMilliseconds(0));
        }
    }
}
