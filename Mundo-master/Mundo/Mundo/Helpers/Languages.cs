namespace Mundo.Helpers
{
    using Xamarin.Forms;
    using Interfaces;
    using Resources;

    public static class Languages
    {
        static Languages()
        {
            var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            Resource.Culture = ci;
            DependencyService.Get<ILocalize>().SetLocale(ci);
        }

        public static string Error
        {
            get { return Resource.Error; }
        }
        public static string validacionEmail
        {
            get { return Resource.validacionEmail; }
        }

        public static string Aceptar
        {
            get { return Resource.Aceptar; }
        }
    }

}
