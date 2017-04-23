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
    public sealed partial class person : Page
    {
        public person()
        {
            this.InitializeComponent();
        }
        private void CollectStore_Click(object sender, RoutedEventArgs e)
        {
            CollectStore.Visibility = Visibility.Collapsed;
            MyFrame.Navigate(typeof(CollectStore));

        }



        private void WoDeDingDanButton_Click(object sender, RoutedEventArgs e)
        {
            WoDeDingDan.Visibility = Visibility.Collapsed;
            MyFrame.Navigate(typeof(WoDeDingDan));

        }

        private void Music_Click(object sender, RoutedEventArgs e)
        {
            Music.Visibility = Visibility.Collapsed;
            MyFrame.Navigate(typeof(Music));

        }


        private void AddressButton_Click(object sender, RoutedEventArgs e)
        {
            AddressButton.Visibility = Visibility.Collapsed;
            MyFrame.Navigate(typeof(Address));

        }

        private void QuestionButton_Click(object sender, RoutedEventArgs e)
        {
            QuestionButton.Visibility = Visibility.Collapsed;
            MyFrame.Navigate(typeof(QuestionPage));

        }
    }
}
