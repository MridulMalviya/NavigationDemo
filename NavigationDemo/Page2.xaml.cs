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
    public partial class Page2 : ContentPage
    {
        private readonly Page2ViewModel _page2ViewModel;
        public Page2(object obj)
        {
            InitializeComponent();
            _page2ViewModel = new Page2ViewModel(obj);
            BindingContext = _page2ViewModel;
        }

        /*public Page2(string parameter) : this()
        {
            _page2ViewModel.MessageForPage2 = $"Welcome, I received the following navigation parameter {parameter}";
        }*/
    }
}