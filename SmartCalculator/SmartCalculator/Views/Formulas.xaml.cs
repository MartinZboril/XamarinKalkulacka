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
using System.Collections.ObjectModel;
using SmartCalculator.Model;
using System.Collections;

namespace SmartCalculator.Views
{

    public partial class Formulas : ContentPage
    {
        public ObservableCollection<FormulasModel> formulas { get; set; }
        public Formulas()
        {
            InitializeComponent();
            if (Device.OS == TargetPlatform.Windows)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }
            formulas = new ObservableCollection<FormulasModel>();
            formulas.Add(new FormulasModel { Name = "Výkon", Type = "Fyzikální veličina", Unit = "W", FirstValue = "Práce", FirstValueUnit = "J", SecondValue = "Čas", SecondValueUnit="s", Formula = "P=W/t" });
            formulas.Add(new FormulasModel { Name = "Rychlost", Type = "Fyzikální veličina", Unit = "m/s", FirstValue = "Dráha", FirstValueUnit = "m", SecondValue = "Čas", SecondValueUnit = "s", Formula = "v = s/t" });
            formulas.Add(new FormulasModel { Name = "Tlak", Type = "Mechanické vlastnosti plynů", Unit = "Pa", FirstValue = "Síla", FirstValueUnit = "N", SecondValue = "Plocha", SecondValueUnit = "m²", Formula = "p = F/S" });
            formulas.Add(new FormulasModel { Name = "Práce", Type = "Fyzikální veličina", Unit = "J", FirstValue = "Síla", FirstValueUnit = "N", SecondValue = "Dráha", SecondValueUnit = "m", Formula = "W = F*s" });
            formulas.Add(new FormulasModel { Name = "Proud", Type = "Elektrické jevy", Unit = "A", FirstValue = "Napětí", FirstValueUnit = "V", SecondValue = "Odpor", SecondValueUnit = "Ω", Formula = "I = U/R" });
            formulas.Add(new FormulasModel { Name = "Odpor", Type = "Elektrické jevy", Unit = "Ω", FirstValue = "Napětí", FirstValueUnit = "V", SecondValue = "Proud", SecondValueUnit = "A", Formula = "R = U/I" });
            formulas.Add(new FormulasModel { Name = "Napětí", Type = "Elektrické jevy", Unit = "V", FirstValue = "Odpor", FirstValueUnit = "Ω", SecondValue = "Proud", SecondValueUnit = "A", Formula = "U = R*I" });
            formulas.Add(new FormulasModel { Name = "Kmitočet", Type = "Elektromagnetické záření", Unit = "Hz", FirstValue = "c", FirstValueUnit = "km/s", SecondValue = "λ", SecondValueUnit = "m", Formula = "f = c/λ" });
            formulas.Add(new FormulasModel { Name = "Energie", Type = "Jaderná energie", Unit = "J", FirstValue = "Hmotnost", FirstValueUnit = "kg", SecondValue = "c", SecondValueUnit = "km/s", Formula = "E = m*c²" });
            ListViewOfFormulas.ItemsSource = formulas;
        }

        private async void ListViewOfFormulas_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            App.MasterDetail.IsPresented = false;
            await App.MasterDetail.Detail.Navigation.PushAsync(new FormulasDetail((e.Item as FormulasModel)));
        }
    }
}

