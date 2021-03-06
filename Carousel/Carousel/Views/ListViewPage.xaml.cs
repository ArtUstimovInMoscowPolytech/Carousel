﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Carousel.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Carousel.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();
            var vm = new CarouselViewPageViewModel();
            listView.FlowItemsSource = vm.Items;
        }
    }
}
