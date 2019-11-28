
namespace Lands.Helpers
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

        public static string Accept
        {
            get { return Resource.Accept; }
        }

        public static string Error
        {
            get { return Resource.Error; }
        }

        public static string EmailValidation
        {
            get { return Resource.EmailValidation; }
        }

        public static string Rememberme
        {
            get { return Resource.Rememberme; }
        }

        public static string EmailPlaceholder
        {
            get { return Resource.EmailPlaceHolder; }
        }

        public static string Lands
        {
            get { return Resource.TLands; }
        }

        public static string Password
        {
            get { return Resource.Password; }
        }

        public static string Login
        {
            get { return Resource.TLogin; }
        }

        public static string ForgotPass
        {
            get { return Resource.ForgotPass; }
        }

        public static string Ittranslatesas
        {
            get { return Resource.Ittranslatesas; }
        }

        public static string OfficialLanguages
        {
            get { return Resource.OfficialLanguages; }
        }

        public static string TLand
        {
            get { return Resource.TLand; }
        }

        public static string Search
        {
            get { return Resource.Search; }
        }

        public static string GeneralInformation
        {
            get { return Resource.GeneralInformation; }
        }

        public static string CourseCoins
        {
            get { return Resource.CourseCoins; }
        }

        public static string Borders
        {
            get { return Resource.Borders; }
        }

        public static string Population
        {
            get { return Resource.Population; }
        }

        public static string Area
        {
            get { return Resource.Area; }
        }

        public static string Region
        {
            get { return Resource.Region; }
        }

        public static string Subregion
        {
            get { return Resource.Subregion; }
        }

        public static string Denomination
        {
            get { return Resource.Denomination; }
        }

        public static string NativeName
        {
            get { return Resource.NativeName; }
        }

        public static string AlphaCode2
        {
            get { return Resource.AlphaCode2; }
        }

        public static string AlphaCode3
        {
            get { return Resource.AlphaCode3; }
        }

        public static string GINI
        {
            get { return Resource.GINI; }
        }

        public static string Germany
        {
            get { return Resource.Germany; }
        }

        public static string Spanish
        {
            get { return Resource.Spanish; }
        }

        public static string French
        {
            get { return Resource.French; }
        }

        public static string Japanese
        {
            get { return Resource.Japanese; }
        }

        public static string Italian
        {
            get { return Resource.Italian; }
        }

        public static string Brazilian
        {
            get { return Resource.Brazilian; }
        }

        public static string Portuguese
        {
            get { return Resource.Portuguese; }
        }

        public static string Dutch
        {
            get { return Resource.Dutch; }
        }

        public static string Croatian
        {
            get { return Resource.Croatian; }
        }

        public static string Persian
        {
            get { return Resource.Persian; }
        }

        public static string Menu
        {
            get { return Resource.Menu; }
        }

        public static string MyProfile
        {
            get { return Resource.MyProfile; }
        }

        public static string Statistics
        {
            get { return Resource.Statistics; }
        }

        public static string Logout
        {
            get { return Resource.Logout; }
        }
    }
}
