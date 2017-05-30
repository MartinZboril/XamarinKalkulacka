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
using SmartCalculator.ViewModels;
using UnitsNet.Units;

namespace SmartCalculator.Views
{
  
    public partial class ConvertorDetailPage : ContentPage
    { 
        ConvertorModel convertor = new ConvertorModel(); 
        string Example;
        int CheckTheNull;
        public ConvertorDetailPage()
        {
            InitializeComponent();
            if (Device.OS == TargetPlatform.Windows)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }
        }

        public ConvertorDetailPage(ConvertorModel convertorDetail)
        {
            InitializeComponent();
            if (Device.OS == TargetPlatform.Windows)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }
            Example = 0.ToString();
            CheckTheNull = 1;
            Title = convertorDetail.Name;
            PickerList.ItemsSource = convertorDetail.Unit;
            PickerList.SelectedIndex = convertorDetail.DefaultValue;
            PickerList1.ItemsSource = convertorDetail.Unit;
            PickerList1.SelectedIndex = convertorDetail.DefaultValue; ;
            convertor = convertorDetail;
        }

        public string GetResult(string Example)
        {
            double result = 0;
            if (Example.Equals(0) || Example.Equals(""))
            {

            } else
            {
                ConvertorViewModel ConvertorToSent = new ConvertorViewModel();
                var selectedValue = PickerList.Items[PickerList.SelectedIndex];
                var selectedValue1 = PickerList1.Items[PickerList1.SelectedIndex];
                result = ConvertorToSent.GetResult(convertor, selectedValue, Example, selectedValue1);
            }

            return result.ToString();
        }

        private void Zero_OnClicked(object sender, EventArgs e)
        {
            if (CheckTheNull == 1)
            {
                Example = "0";
                CheckTheNull = 1;
            }
            else
            {
                Example += 0;
            }
            Output.Text = Example;
            Output1.Text = GetResult(Example).ToString();
        }

        private void One_OnClicked(object sender, EventArgs e)
        {
            CheckTheNullFirst(1);
            Output.Text = Example;
            Output1.Text = GetResult(Example).ToString();
        }

        private void Two_OnClicked(object sender, EventArgs e)
        {
            CheckTheNullFirst(2);
            Output.Text = Example;
            Output1.Text = GetResult(Example).ToString();
        }

        private void Three_OnClicked(object sender, EventArgs e)
        {
            CheckTheNullFirst(3);
            Output.Text = Example;
            Output1.Text = GetResult(Example).ToString();
        }

        private void Four_OnClicked(object sender, EventArgs e)
        {
            CheckTheNullFirst(4);
            Output.Text = Example;
            Output1.Text = GetResult(Example).ToString();
        }

        private void Five_OnClicked(object sender, EventArgs e)
        {
            CheckTheNullFirst(5);
            Output.Text = Example;
            Output1.Text = GetResult(Example).ToString();
        }

        private void Six_OnClicked(object sender, EventArgs e)
        {
            CheckTheNullFirst(6);
            Output.Text = Example;
            Output1.Text = GetResult(Example).ToString();
        }

        private void Seven_OnClicked(object sender, EventArgs e)
        {
            CheckTheNullFirst(7);
            Output.Text = Example;
            Output1.Text = GetResult(Example).ToString();
        }

        private void Eight_OnClicked(object sender, EventArgs e)
        {
            CheckTheNullFirst(8);
            Output.Text = Example;
            Output1.Text = GetResult(Example).ToString();
        }

        private void Nine_OnClicked(object sender, EventArgs e)
        {
            CheckTheNullFirst(9);
            Output.Text = Example;
            Output1.Text = GetResult(Example).ToString();
        }

        private void DeleteOneChar_OnClicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Example) == false)
            {
                Example = Example.Remove(Example.Length - 1);
            }

            if (Example.Equals(""))
            {
                Example = 0.ToString();
                CheckTheNull = 1;
            }
            Output.Text = Example;
            Output1.Text = GetResult(Example).ToString();
        }

        private void DeleteAll_OnClicked(object sender, EventArgs e)
        {
            Example = "0";
            Output.Text = Example;
            Output1.Text = 0.ToString();
            CheckTheNull = 1;
        }

        private void Comma_OnCLicked(object sender, EventArgs e)
        {
            Example += ".";
            Output.Text = Example;
        }

        private void PickerList_Focused(object sender, FocusEventArgs e)
        {
            if (Example.Equals("0"))
            {
                Output1.Text = 0.ToString();
            }
            else
            {
                Output1.Text = GetResult(Example).ToString();
            }
        }

        private void PickerList1_Focused(object sender, FocusEventArgs e)
        {
            if (Example.Equals("0"))
            {
                Output1.Text = 0.ToString();
            }
            else
            {
                Output1.Text = GetResult(Example).ToString();
            }
        }

        public void CheckTheNullFirst(int number)
        {
            if (CheckTheNull == 1)
            {
                Example = number.ToString();
                CheckTheNull = 0;
            }
            else
            {
                Example += number;
            }
        }
    }
   
}
