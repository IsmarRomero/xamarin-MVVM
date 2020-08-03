using System;
using System.Collections.Generic;
using MVVMSample.ViewModels;
using Xamarin.Forms;

namespace MVVMSample.Views
{
    public partial class PeopleView : ContentPage
    {
        public PeopleView()
        {
            InitializeComponent();
            BindingContext = new PeopleViewModel();

        }

    }
}
