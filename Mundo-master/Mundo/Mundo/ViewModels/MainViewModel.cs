﻿namespace Mundo.ViewModels
{
    using Models;
    using System.Collections.Generic;
    public class MainViewModel
    {
        #region ViewModels
        public LoginViewModel Login
        {
            get;
            set;
        }
        public PaisesViewModel Paises
        {
            get;
            set;
        }
        public PaisViewModel Pais
        {
            get;
            set;
        }
        #endregion

        #region Propiedades

        public List<Land> PaisesList
        {
            get;
            set;
        }

        public TokenResponse Token
        {
            get;
            set;
        }

        #endregion

        #region Constructores
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }
            else
            {
                return instance;
            }
        }
        #endregion
    }
}
