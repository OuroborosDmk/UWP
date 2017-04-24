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
    public sealed partial class waimai10: Page
    {
        public waimai10()
        {
            this.InitializeComponent();
        }
        public void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Financial));
        }
        private static int _clicks = 0;
        private static int _clicks2 = 0;
        private static int _clicks3 = 0;
        private static int _clicks4 = 0;
        private static int _clicks5 = 0;
        private static int _clicks6 = 0;
        private void Increase_Click(object sender, RoutedEventArgs e)
        {
            _clicks += 1;
            clickTextBlock.Text = "('▽`)ﾉ 你点了: " + _clicks +"份饭";
        }

        private void Decrease_Click(object sender, RoutedEventArgs e)
        {
            if (_clicks > 0)
            {
                _clicks -= 1;
                clickTextBlock.Text = "('▽`)ﾉ 你点了: " + _clicks + "份饭";
            }
        }
        private void Increase_Click2(object sender, RoutedEventArgs e)
        {
            _clicks2 += 1;
            clickTextBlock2.Text = "('▽`)ﾉ 你点了: " + _clicks2 + "份饭";
        }

        private void Decrease_Click2(object sender, RoutedEventArgs e)
        {
            if (_clicks2 > 0)
            {
                _clicks2 -= 1;
                clickTextBlock2.Text = "('▽`)ﾉ 你点了: " + _clicks2 + "份饭";
            }
        }
        private void Increase_Click3(object sender, RoutedEventArgs e)
        {
            _clicks3 += 1;
            clickTextBlock3.Text = "('▽`)ﾉ 你点了: " + _clicks3 + "份饭";
        }

        private void Decrease_Click3(object sender, RoutedEventArgs e)
        {
            if (_clicks3 > 0)
            {
                _clicks3 -= 1;
                clickTextBlock3.Text = "('▽`)ﾉ 你点了: " + _clicks3 + "份饭";
            }
        }
        private void Increase_Click4(object sender, RoutedEventArgs e)
        {
            _clicks4 += 1;
            clickTextBlock4.Text = "('▽`)ﾉ 你点了: " + _clicks4 + "份饭";
        }

        private void Decrease_Click4(object sender, RoutedEventArgs e)
        {
            if (_clicks4 > 0)
            {
                _clicks4 -= 1;
                clickTextBlock4.Text = "('▽`)ﾉ 你点了: " + _clicks4 + "份饭";
            }
        }
        private void Increase_Click5(object sender, RoutedEventArgs e)
        {
            _clicks5 += 1;
            clickTextBlock5.Text = "('▽`)ﾉ 你点了: " + _clicks5 + "份饭";
        }

        private void Decrease_Click5(object sender, RoutedEventArgs e)
        {
            if (_clicks5 > 0)
            {
                _clicks5 -= 1;
                clickTextBlock5.Text = "('▽`)ﾉ 你点了: " + _clicks5 + "份饭";
            }
        }
        private void Increase_Click6(object sender, RoutedEventArgs e)
        {
            _clicks6 += 1;
            clickTextBlock6.Text = "('▽`)ﾉ 你点了: " + _clicks6 + "份饭";
        }

        private void Decrease_Click6(object sender, RoutedEventArgs e)
        {
            if (_clicks6 > 0)
            {
                _clicks6 -= 1;
                clickTextBlock6.Text = "('▽`)ﾉ 你点了: " + _clicks6 + "份饭";
            }
        }
    }
    
}

