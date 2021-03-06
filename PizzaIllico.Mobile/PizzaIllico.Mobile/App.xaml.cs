using System.Diagnostics;
using PizzaIllico.Mobile.Pages;
using PizzaIllico.Mobile.Services;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Storm.Mvvm;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace PizzaIllico.Mobile
{
    public partial class App : MvvmApplication
    {
        public App() : base(() => new ShopListPage(), RegisterServices)
        {
#if DEBUG
            Log.Listeners.Add(new DelegateLogListener((arg1, arg2) => Debug.WriteLine($"{arg1} : {arg2}")));
#endif
            InitializeComponent();
        }

        private static void RegisterServices()
        {
            DependencyService.RegisterSingleton<IApiService>(new ApiService());
            
            DependencyService.RegisterSingleton<IPizzaApiService>(new PizzaApiService());
        }
    }
}