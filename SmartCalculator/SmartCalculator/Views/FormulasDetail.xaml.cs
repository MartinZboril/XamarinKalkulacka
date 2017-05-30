using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SmartCalculator.ViewModels;
using SmartCalculator.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace SmartCalculator.Views
{

    public partial class FormulasDetail : ContentPage
    {
        int inputPick = 0;
        FormulasModel formula = new FormulasModel();
        public FormulasDetail()
        {
            InitializeComponent();
            if(Device.OS == TargetPlatform.Windows)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }

        }

        public FormulasDetail(FormulasModel formulaDetail)
        {
            InitializeComponent();
            if (Device.OS == TargetPlatform.Windows)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }

            Title = formulaDetail.Name;
            Formula.Text = formulaDetail.Formula;
            FirstNameOfValue.Text = formulaDetail.FirstValue;
            FirstNameOfUnit.Text = formulaDetail.FirstValueUnit;
            SecondNameOfValue.Text = formulaDetail.SecondValue;
            SecondNameOfUnit.Text = formulaDetail.SecondValueUnit;
            formula = formulaDetail;
        }

        private void ResultButton_Clicked(object sender, EventArgs e)
        {
            int num1 = 0;
            bool check = int.TryParse(Number1.Text, out num1);
            int num2 = 0;
            bool check2 = int.TryParse(Number2.Text, out num2);

            if (check)
            {
                if (check2)
                {             
                    FormulasViewModel FormulaToSent = new FormulasViewModel();            
                    double result = FormulaToSent.GetResult(formula, double.Parse(Number1.Text), double.Parse(Number2.Text));
                    ResultDatabase resultDatabase = App.Database;
                    Result item = new Result();
                    item.Name = formula.Name;
                    item.Type = formula.Type;
                    item.Formula = formula.Formula;
                    item.NameValue1 = formula.FirstValue + ":";
                    item.Value1 = Number1.Text + formula.FirstValueUnit;
                    item.NameValue2 = formula.SecondValue + ":";
                    item.Value2 = Number2.Text + formula.SecondValueUnit;
                    item.ResultValue = result.ToString() + " " + formula.Unit;
                    item.Favourite = "unfavourite.png";
                    App.Database.SaveItemAsync(item);
                    Result.Text = result.ToString() + " " + formula.Unit;
                }
            }
        }

        private void Number1_Focused(object sender, FocusEventArgs e)
        {
            Number1.Keyboard = Keyboard.Chat;
        }

        
    }

}