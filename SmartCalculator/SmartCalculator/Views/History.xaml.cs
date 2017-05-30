using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartCalculator.Views
{
    public partial class History : ContentPage
    {
        ResultDatabase resultDatabase = App.Database;
        private int tempSelectedIndex;
        public History()
        {
            InitializeComponent();
            if (Device.OS == TargetPlatform.Windows)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }
            DisplayDatabase();
            
        }

        //Zobrazení záznamů z databáze
        private void DisplayDatabase()
        {
            var itemsFromDb = resultDatabase.GetItemsNotDoneAsync().Result;
            Debug.WriteLine(itemsFromDb.Count);
            foreach (Result result in itemsFromDb)
            {
                Debug.WriteLine(result);              
            }
            //itemsFromDb.Clear();
            ResultListView.ItemsSource = itemsFromDb;
        }

        private async void ResultListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (ResultListView.SelectedItem != null)
            {

                var result = ResultListView.SelectedItem as Result;
                // tempSelectedIndex = ;

                if (result.Favourite.Equals("favourite.png"))
                {
                    result.Favourite = "unfavourite.png";
                    await App.Database.SaveItemAsync(result);
                }
                else if (result.Favourite.Equals("unfavourite.png"))
                {
                    result.Favourite = "favourite.png";
                    await App.Database.SaveItemAsync(result);
                }
                DisplayDatabase();
            }
        }

        // Pridani k oblibenym
        private async void FavouriteClicked(object sender, EventArgs e)
        {
            if (ResultListView.SelectedItem != null)
            {
                var result = ResultListView.SelectedItem as Result;
                // tempSelectedIndex = ;

                if (result.Favourite.Equals("favourite.png"))
                {
                    result.Favourite = "unfavourite.png";
                    await App.Database.SaveItemAsync(result);
                }
                else if (result.Favourite.Equals("unfavourite.png"))
                {
                    result.Favourite = "favourite.png";
                    await App.Database.SaveItemAsync(result);
                }
                DisplayDatabase();
            }
        }

        //Odstranění záznamu
        private async void DeleteClicked(object sender, EventArgs e)
        {
            if (ResultListView.SelectedItem != null)
            {
                // ResultListView.SelectedItem = tempSelectedIndex;
                var result = ResultListView.SelectedItem as Result;
                await App.Database.DeleteItemAsync(result);
                DisplayDatabase();
            }
        }

    }
}