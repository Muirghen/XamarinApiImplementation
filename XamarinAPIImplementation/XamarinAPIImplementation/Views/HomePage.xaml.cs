﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinAPIImplementation.ViewModels;

namespace XamarinAPIImplementation
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
        }
    }
}
