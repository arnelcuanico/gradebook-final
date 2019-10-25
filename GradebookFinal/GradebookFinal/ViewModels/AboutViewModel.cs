﻿using System;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Essentials;
using System.Threading.Tasks;

namespace GradebookFinal.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Launcher.OpenAsync(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}