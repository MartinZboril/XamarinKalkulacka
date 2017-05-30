using Xamarin.Forms;
using SmartCalculator.Views;

namespace SmartCalculator
{

    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Master = new Master();
            this.Detail = new NavigationPage(new BasicCalculatorPage());
            App.MasterDetail = this;
            MasterBehavior = MasterBehavior.Popover;
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}