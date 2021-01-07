﻿using StravaUsability.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StravaUsability.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PausePage : ContentPage
    {
        public PausePage()
        {
            InitializeComponent();
            BindingContext = new PausePageModel();
        }
    }
}