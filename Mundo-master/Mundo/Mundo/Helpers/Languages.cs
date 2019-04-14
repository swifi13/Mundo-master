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
        public static string error1
        {
            get { return Resource.error1; }
        }

        public static string validacionEmail
        {
            get { return Resource.validacionEmail; }
        }

        public static string Aceptar
        {
            get { return Resource.Aceptar; }
        }

        public static string ingresaemail
        {
            get { return Resource.ingresaemail; }
        }

        public static string recordarme
        {
            get { return Resource.recordarme; }
        }

        

        public static string login
        {
            get { return Resource.login; }
        }

        public static string contraseña
        {
            get { return Resource.contraseña; }
        }

        public static string mundo
        {
            get { return Resource.mundo; }
        }
        
            public static string iniciarsesion
        {
            get { return Resource.iniciarsesion; }
        }

        public static string Registrarse
        {
            get { return Resource.Registrarse; }
        }

        public static string contra
        {
            get { return Resource.contra; }
        }

        public static string validacioncontra
        {
            get { return Resource.validacioncontra; }
        }

        public static string buscar 
        {
            get { return Resource.buscar; }
        }
        public static string Pais   
        {
            get { return Resource.Pais; }
        }
    }

}
