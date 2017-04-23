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
    public sealed partial class Address : Page
    {
        public Address()
        {
            this.InitializeComponent();
        }

        public string Text { get; set; }

        private void SearchAddressButton_Click(object sender, RoutedEventArgs e)
        {
            if (text1.Text == "new")
            {

                text1.Text = AddAddress.Text;
            }
            else if (text2.Text == "new")
            {
                text2.Text = AddAddress.Text;
            }
            else if (text3.Text == "new")
            {
                text3.Text = AddAddress.Text;
            }
            else if (text4.Text == "new")
            {
                text4.Text = AddAddress.Text;
            }
            else if (text5.Text == "new")
            {
                text5.Text = AddAddress.Text;
            }

        }






    }
}
