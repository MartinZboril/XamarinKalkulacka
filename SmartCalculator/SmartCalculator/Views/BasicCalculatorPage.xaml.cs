using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartCalculator.Views
{

    public partial class BasicCalculatorPage : ContentPage
    {
        string Example;
        int count, CheckTheNull;
        public BasicCalculatorPage()
        {
            InitializeComponent();
            if (Device.OS == TargetPlatform.Windows)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }
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
            CheckTheNull = 1;
            Output.Text = Example;
        }

        private void One_OnClicked(object sender, EventArgs e)
        {
            CheckTheNullFirst(1);
            Output.Text = Example;
        }

        private void Two_OnClicked(object sender, EventArgs e)
        {
            CheckTheNullFirst(2);
            Output.Text = Example;
        }

        private void Three_OnClicked(object sender, EventArgs e)
        {
            CheckTheNullFirst(3);
            Output.Text = Example;
        }

        private void Four_OnClicked(object sender, EventArgs e)
        {
            CheckTheNullFirst(4);
            Output.Text = Example;
        }

        private void Five_OnClicked(object sender, EventArgs e)
        {
            CheckTheNullFirst(5);
            Output.Text = Example;
        }

        private void Six_OnClicked(object sender, EventArgs e)
        {
            CheckTheNullFirst(6);
            Output.Text = Example;
        }

        private void Seven_OnClicked(object sender, EventArgs e)
        {
            CheckTheNullFirst(7);
            Output.Text = Example;
        }

        private void Eight_OnClicked(object sender, EventArgs e)
        {
            CheckTheNullFirst(8);
            Output.Text = Example;
        }

        private void Nine_OnClicked(object sender, EventArgs e)
        {
            CheckTheNullFirst(9);
            Output.Text = Example;
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
        }

        private void DeleteAll_OnClicked(object sender, EventArgs e)
        {
            Example = "0";
            CheckTheNull = 1;
            Output.Text = Example;
        }

        private void DeleteCurrentExample_OnClicked(object sender, EventArgs e)
        {
            Example = "0";
            CheckTheNull = 1;
            Output.Text = Example;
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

        private void Result_OnClicked(object sender, EventArgs e)
        {
            String s = Example;
            double result = new Expression(s).calculate();
            Example = result.ToString();
            Output.Text = Example;
        }

        private void Plus_OnClicked(object sender, EventArgs e)
        {
            Example += "+";
            Output.Text = Example;
        }

        private void Multiply_OnClicked(object sender, EventArgs e)
        {
            Example += "*";
            Output.Text = Example;
        }

        private void Divider_OnClicked(object sender, EventArgs e)
        {
            Example += "/";

            Output.Text = Example;
        }

        private void Minus_OnClicked(object sender, EventArgs e)
        {
            Example += "-";
            Output.Text = Example;
        }

        private void Square__OnClicked(object sender, EventArgs e)
        {
            Example += "^2";
            Output.Text = Example;
        }

        private void LeftBracket_OnClicked(object sender, EventArgs e)
        {
            Example += "(";
            Output.Text = Example;
        }

        private void RightBracket_OnClicked(object sender, EventArgs e)
        {
            Example += ")";
            Output.Text = Example;
        }

        private void SquareByNumber__OnClicked(object sender, EventArgs e)
        {
            Example += "^(";
            Output.Text = Example;
        }

        private void Comma_OnCLicked(object sender, EventArgs e)
        {
            Example += ".";
            Output.Text = Example;
        }

        private void Root__OnClicked(object sender, EventArgs e)
        {
            Example += "sqrt(";
            Output.Text = Example;
        }

        private void ChangeValueOfNumber_Clicked(object sender, EventArgs e)
        {
            String s = Example;
            double result = new Expression(s).calculate() * (-1);
            Example = result.ToString();
            Output.Text = Example;
        }
    }
}
