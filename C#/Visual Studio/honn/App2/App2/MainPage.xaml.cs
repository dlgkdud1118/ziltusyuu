﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Imaging;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace App2
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            string fileUri = "ms-appx:///Assets/image01.jpg";
            BitmapImage bitmap = new BitmapImage(new Uri(fileUri));
            image01.Source = bitmap;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            string fileUri = "ms-appx:///Assets/image02.jpg";
            BitmapImage bitmap = new BitmapImage(new Uri(fileUri));
            image01.Source = bitmap;
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            string fileUri = "ms-appx:///Assets/image03.jpg";
            BitmapImage bitmap = new BitmapImage(new Uri(fileUri));
            image01.Source = bitmap;
        }
    }
}
