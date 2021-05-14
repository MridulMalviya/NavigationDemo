using NavigationDemo.Common;
using NavigationDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationDemo
{
    public partial class MainPage : ContentPage
    {
       private readonly MainPageViewModel _mainPageViewModel;
        public MainPage()
        {
            InitializeComponent();
            _mainPageViewModel = new MainPageViewModel();
            BindingContext = _mainPageViewModel;
        }
    }
}
