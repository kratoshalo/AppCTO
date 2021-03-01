using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppCTO.Model
{
    public class LoginModel : BaseViewModel
    {
        private string user;
        private string password;

        public Command Ingreso { get;  }

        public string User { get => user; set => SetProperty(ref user, value); } 
        public string Password { get => password; set => SetProperty(ref password, value); }

        public LoginModel()
        {
            Title = "INGRESO CTOApp";
            IsBusy = false;

            Ingreso = new Command(async() =>
            {                
                await DoIn();
            });
        }

        private async Task DoIn()
        {
            IsBusy = true;

            //await App.Current.MainPage.DisplayAlert("Mensaje", "Entraré a la App", "OK");

            await Task.Delay(15000);

            IsBusy = false;
        }
    }
}
