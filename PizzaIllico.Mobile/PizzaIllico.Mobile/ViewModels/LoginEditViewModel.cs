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
    public class LoginEditViewModel : ViewModelBase
    {        
        private string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }
        public ICommand SelectedCommand { get; }

        public LoginEditViewModel(String login)
        {
            SelectedCommand = new Command(OnSubmit);
        }

        public void OnSubmit()
        {
            // modification mdp
        } 
    }
}
