using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppCTO.ViewModel
{
    public class LoginViewModel: BaseViewModel
    {
        private Command Ingreso { get; set; }

        public LoginViewModel()
        {
            Title = "INGRESO CTOApp";
            IsBusy = false;

            Ingreso = new Command(()=> { 

                
            });
        }


    }
}
