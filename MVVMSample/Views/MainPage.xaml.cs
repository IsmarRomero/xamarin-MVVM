﻿//using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMSample.Models;
using Xamarin.Forms;
using MVVMSample.ViewModels;

namespace MVVMSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        MainPageViewModel vm = new MainPageViewModel();
        public MainPage()
        {
            InitializeComponent();
            vm.LoadData();
            BindingContext = vm;
        }
    }
}
