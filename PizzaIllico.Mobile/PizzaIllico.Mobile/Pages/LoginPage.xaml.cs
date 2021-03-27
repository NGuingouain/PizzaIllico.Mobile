using PizzaIllico.Mobile.ViewModels;
using Storm.Mvvm.Forms;
using Xamarin.Forms.Xaml;

namespace PizzaIllico.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage
    {
        public LoginPage()
        {
            BindingContext = new LoginViewModel();
            InitializeComponent();
        }
    }
}