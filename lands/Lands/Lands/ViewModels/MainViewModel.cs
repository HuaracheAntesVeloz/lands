﻿
namespace Lands.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Models;
    using Helpers;

    public class MainViewModel
    {
        #region Properties
        public List<Land> LandsList 
        {
            get; 
            set;
        }

        public String Token 
        {
            get;
            set; 
        }

        public String TokenType
        {
            get;
            set;
        }

        public ObservableCollection<MenuItemViewModel> Menus
        { 
            get;
            set; 
        }
        #endregion

        #region ViewModels
        public LoginViewModel Login 
            {   
                get;
                set; 
            }
        public LandsViewModel Lands
            {
                get;
                set; 
            }
        public LandViewModel Land
            {
            get;
            set; 
            }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
            this.LoadMenu();
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance==null)
            {
                return new MainViewModel();
            }
            return instance;
        }
        #endregion

        #region Methods
        private void LoadMenu()
        {
            this.Menus = new ObservableCollection<MenuItemViewModel>();

            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_settings",
                PageName = "MyProfilePage",
                Title = Languages.MyProfile
            });

            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_show_chart",
                PageName = "StatisticsPage",
                Title = Languages.Statistics
            });

            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_exit_to_app",
                PageName = "LoginPage",
                Title = Languages.Logout
            });
        }
        #endregion
    }
}
