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
using Hamburger.Models;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace Hamburger
{
    public sealed partial class Food : Page
    {
        private List<FoodItem> Foods;

        public Food()
        {
            this.InitializeComponent();
            Foods = FoodManager.GetFoods();
        }

        private void Grid_ItemClick(object sender ,ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(Financial));
        }
    }
}
