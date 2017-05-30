using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SmartCalculator.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SmartCalculator.Model;
using System.Collections.ObjectModel;

namespace SmartCalculator.Views
{
    public partial class Convertor : ContentPage
    {
        public ObservableCollection<ConvertorModel> convertor { get; set; }
        public Convertor()
        {
            InitializeComponent();
            if (Device.OS == TargetPlatform.Windows)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }
            convertor = new ObservableCollection<ConvertorModel>();
            DeclareTheFormulas();
            ListViewOfConvertor.ItemsSource = convertor;
        }

        private async void ListViewOfConvertor_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            App.MasterDetail.IsPresented = false;
            await App.MasterDetail.Detail.Navigation.PushAsync(new ConvertorDetailPage((e.Item as ConvertorModel)));
        }

        /// <summary>
        /// Metoda slouzi pro vytvoreni vzorcu
        /// </summary>
        public void DeclareTheFormulas()
        {
            List<String> LengthUnit = GetLengthUnit();
            convertor.Add(new ConvertorModel { Name = "Délka", Unit = LengthUnit, DefaultValue = 3 });
            List<String> WeightUnit = GetWeightUnit();
            convertor.Add(new ConvertorModel { Name = "Hmotnost", Unit = WeightUnit, DefaultValue = 3 });
            List<String> TemperatureUnit = GetTemperatureUnit();
            convertor.Add(new ConvertorModel { Name = "Teplota", Unit = TemperatureUnit, DefaultValue = 0 });
            List<String> SpeedUnit = GetSpeedUnit();
            convertor.Add(new ConvertorModel { Name = "Rychlost", Unit = SpeedUnit, DefaultValue = 1 });
            List<String> AreaUnit = GetAreaUnit();
            convertor.Add(new ConvertorModel { Name = "Plocha", Unit = AreaUnit, DefaultValue = 1 });
            List<String> TimeUnit = GetTimeUnit();
            convertor.Add(new ConvertorModel { Name = "Čas", Unit = TimeUnit, DefaultValue = 1 });
        }

        /// Metody vraci List ktery obsahuje nazvy jednotek


        // Delka
        public List<string> GetLengthUnit()
        {
            List<String> LengthUnit = new List<string>();
            LengthUnit.Add("mm");
            LengthUnit.Add("cm");
            LengthUnit.Add("dm");
            LengthUnit.Add("m");
            LengthUnit.Add("km");
            return LengthUnit;
        }

        // Hmotnost
        public List<string> GetWeightUnit()
        {
            List<String> WeightUnit = new List<string>();
            WeightUnit.Add("mg");
            WeightUnit.Add("g");
            WeightUnit.Add("dkg");
            WeightUnit.Add("kg");
            WeightUnit.Add("t");
            return WeightUnit;
        }

        // Teplota
        public List<string> GetTemperatureUnit()
        {
            List<String> TemperatureUnit = new List<string>();
            TemperatureUnit.Add("°C");
            TemperatureUnit.Add("°F");
            TemperatureUnit.Add("K");
            return TemperatureUnit;
        }

        // Rychlost
        public List<string> GetSpeedUnit()
        {
            List<String> SpeedUnit = new List<string>();
            SpeedUnit.Add("m/s");
            SpeedUnit.Add("km/h");
            SpeedUnit.Add("MPH");
            return SpeedUnit;
        }

        // Plocha
        public List<string> GetAreaUnit()
        {
            List<String> AreaUnit = new List<string>();
            AreaUnit.Add("mm²");
            AreaUnit.Add("cm²");
            AreaUnit.Add("dm²");
            AreaUnit.Add("m²");
            AreaUnit.Add("km²");
            return AreaUnit;
        }

        // Cas
        public List<string> GetTimeUnit()
        {
            List<String> AreaUnit = new List<string>();
            AreaUnit.Add("s");
            AreaUnit.Add("m");
            AreaUnit.Add("h");
            AreaUnit.Add("den");
            AreaUnit.Add("týden");
            return AreaUnit;
        }
    }
}