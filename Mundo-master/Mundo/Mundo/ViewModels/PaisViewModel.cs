﻿
namespace Mundo.ViewModels
{
    using Models;
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;

    public class PaisViewModel : BaseViewModel
    {

        #region Atributos
        private ObservableCollection<Border> borders;
        private ObservableCollection<Currency> currencies;
        private ObservableCollection<Language> languages;
        #endregion

        #region Popiedades
        public Land Pais
        {
            get;
            set;
        }


        public ObservableCollection<Currency> Currencies
        {
            get { return this.currencies; }
            set { this.SetValue(ref this.currencies, value);}

        }
        public ObservableCollection<Border> Borders
        {
            get { return this.borders; }
            set { this.SetValue(ref this.borders, value); }

        }

        public ObservableCollection<Language> Languages
        {
            get { return this.languages; }
            set { this.SetValue(ref this.languages, value); }

        }

        #endregion

        #region Constructores

        public PaisViewModel(Land pais)
        {
            this.Pais = pais;
            this.LoadBorders();
            this.Currencies = new ObservableCollection<Currency>(this.Pais.Currencies);
            this.Languages = new ObservableCollection<Language>(this.Pais.Languages);
        }
        #endregion

        #region Metodos
        private void LoadBorders()
        {
            this.Borders = new ObservableCollection<Border>();
            foreach (var border in this.Pais.Borders)
            {
                var land = MainViewModel.GetInstance().PaisesList.
                        Where(l => l.Alpha3Code == border).
                        FirstOrDefault();
                if (land != null)
                {
                    this.Borders.Add(new Border
                    {
                        Code = land.Alpha3Code,
                        Name = land.Name,
                    });
                }
            }
        }
        #endregion
    }
}
