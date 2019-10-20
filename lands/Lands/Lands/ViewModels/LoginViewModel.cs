using System;
using System.Collections.Generic;
using System.Text;

namespace Lands.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.ComponentModel;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class LoginViewModel : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Attributes
        private string email;
        private string password;
        private bool isRunning;
        private bool isEnabled;
        #endregion

        #region Properties
        public string Email { get; set; }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (this.password != value)
                {
                    this.password = value;
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(Password)));
                }
            } 
        }
        public bool IsRunning 
        {
            get
            {
                return isRunning;
            }
            set
            {
                if (this.isRunning != value)
                {
                    this.isRunning = value;
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(IsRunning)));
                }
            }
        }
        public bool IsRemembered { get; set; }
        public bool IsEnabled 
        {
            get
            {
                return isEnabled;
            }
            set
            {
                if (this.isEnabled != value)
                {
                    this.isEnabled = value;
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(IsEnabled)));
                }
            }
        }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.IsRemembered = true;
            this.IsEnabled = true;

        }
        #endregion

        #region Commands
        public ICommand LoginCommand 
            {
            get
                {
                return new RelayCommand(Login);
                }
            }

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Introduzca E-mail.",
                    "Accept");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Introduzca Contraseña.",
                    "Accept");
                return;
            }

            this.IsRunning = true;
            this.IsEnabled = false;

            if (this.Email != "jerodrig001@gmail.com" || this.Password != "1234")
            {
                this.IsRunning = false;
                this.IsEnabled = true;
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "E-mail o Contraseña erroneos.",
                    "Accept");
                this.Password = string.Empty;
                return;
            }

            this.IsRunning = false;
            this.IsEnabled = true;

            await Application.Current.MainPage.DisplayAlert(
                "Información",
                "E-mail y Contraseña correctos!",
                "Accept");
            return;
        }
        #endregion
    }
}
