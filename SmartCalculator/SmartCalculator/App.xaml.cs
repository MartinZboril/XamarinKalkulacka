using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartCalculator.Views;
using Xamarin.Forms;

namespace SmartCalculator
{
    public partial class App : Application
    {
        public static MainPage MasterDetail { get; internal set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        internal static Task NavigationMasterDetail(BasicCalculatorPage basicCalculatorPage)
        {
            throw new NotImplementedException();
        }

        internal static Task NavigationMasterDetail(Formulas formulas)
        {
            throw new NotImplementedException();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        private static ResultDatabase _database;

        public static ResultDatabase Database
        {
            get
            {
                if (_database == null)
                {
                    _database = new ResultDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("TodoSQLite.db3"));
                }
                return _database;
            }
        }
    }
}
