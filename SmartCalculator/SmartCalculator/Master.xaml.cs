using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartCalculator.Views;
using Xamarin.Forms;

namespace SmartCalculator
{
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();

            BasicCalculatorPage.Clicked += async (sender, e) =>
            {
                App.MasterDetail.IsPresented = false;
                await App.MasterDetail.Detail.Navigation.PushAsync(new BasicCalculatorPage());
            };

            Formulas.Clicked += async (sender, e) =>
            {
                App.MasterDetail.IsPresented = false;
                await App.MasterDetail.Detail.Navigation.PushAsync(new Formulas());
            };

            Convertor.Clicked += async (sender, e) =>
            {
                App.MasterDetail.IsPresented = false;
                await App.MasterDetail.Detail.Navigation.PushAsync(new Convertor());
            };

            History.Clicked += async (sender, e) =>
            {
                App.MasterDetail.IsPresented = false;
                await App.MasterDetail.Detail.Navigation.PushAsync(new History());
            };
        }
    }
}
