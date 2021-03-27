using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using PizzaIllico.Mobile.Dtos;
using PizzaIllico.Mobile.Dtos.Pizzas;
using PizzaIllico.Mobile.Services;
using Storm.Mvvm;
using Xamarin.Forms;

namespace PizzaIllico.Mobile.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string _login;
        public string Login
        {
            get => _login;
            set => SetProperty(ref _login, value);
        }
        private string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }
        public ICommand SelectedCommand { get; }

        public LoginViewModel()
        {
            SelectedCommand = new Command(OnSubmit);
        }

        public void OnSubmit()
        {
            // test validité login
        }
    }
}
