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
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class Financial : Page
    {
        public Financial()
        {
            this.InitializeComponent();
        }
        public void button1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(waimai1));
        }
        public void button2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(waimai2));
        }
        public void button3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(waimai3));
        }
        public void button4_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(waimai4));
        }
        public void button5_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(waimai5));
        }
        public void button6_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(waimai6));
        }
        public void button7_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(waimai7));
        }
        public void button8_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(waimai8));
        }
        public void button9_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(waimai9));
        }
        public void button10_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(waimai10));
        }
        public void button11_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(waimai11));
        }
        public void button12_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(waimai12));
        }
    }
}


