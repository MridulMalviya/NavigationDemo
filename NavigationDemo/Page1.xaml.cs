using NavigationDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationDemo
{
    public partial class Page1 : ContentPage
    {
        private readonly Page1ViewModel _page1ViewModel;

        public Page1(object obj)
        {
            InitializeComponent();
            _page1ViewModel = new Page1ViewModel(obj);
            BindingContext = _page1ViewModel;
        }

       /* public Page1(string parameter) 
        {
            _page1ViewModel.MessageForPage1= $"Welcome, I received the following navigation parameter {parameter}";
        }*/
    }
}