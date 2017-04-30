using System;
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

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace Hamburger
{
    public sealed partial class Food : Page
    {
        public Food()
        {
            this.InitializeComponent();
        }
        public void Button1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(waimai1));
        }
        public void Button2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(waimai1));
        }
        public void Button3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(waimai1));
        }
    }
}
