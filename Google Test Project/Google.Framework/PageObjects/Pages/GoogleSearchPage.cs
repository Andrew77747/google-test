using System.IO;
using System.Threading;
using Google.Framework.PageObjects.Elements;
using Google.Framework.Tools;
using Infrastructure.Settings;
using OpenQA.Selenium;

namespace Google.Framework.PageObjects.Pages
{
    public class GoogleSearchPage : BaseElement
    {
        private Appsettings _settings;
        private Footer _footer;
        private string Url = "https://www.google.ru";
        private string _searchText = "Привет, мир!";


        public GoogleSearchPage(IWebDriverManager manager, Appsettings settings) : base(manager)
        {
            _settings = settings;
            _footer = new Footer();
        }

        #region Map Of Elements

        private readonly By _googleLogo = By.CssSelector("img.lnXdpd");
        private readonly By _searchInput = By.CssSelector(".gLFyf.gsfi");
        private readonly By _searchIcon = By.CssSelector(".QCzoEc.z1asCe.MZy1Rb");
        private readonly By _virtualKeyboardsButton = By.CssSelector(".Umvnrc .ly0Ckb");
        private readonly By _searchButton = By.CssSelector(".FPdoLc .gNO89b");
        private readonly By _luckyButton = By.CssSelector(".FPdoLc .RNmpXc");
        private readonly By _mail = By.CssSelector(".gb_e [data-pid='23']");
        private readonly By _pictures = By.CssSelector(".gb_e [data-pid='2']");
        private readonly By _googleApps = By.CssSelector(".gb_A .gb_Oe");
        private readonly By _loginButton = By.CssSelector(".gb_1.gb_2.gb_2d.gb_2c");
        private readonly By _enterForm = By.CssSelector("div.xkfVF");
        private readonly By _searchResult = By.CssSelector(".yuRUbf");


        #endregion

        public void OpenGooglePage()
        {
            Wrapper.Navigate(Url);
        }

        public bool IsLogoExists()
        {
            return Wrapper.IsElementDisplayed(_googleLogo);
        }

        public bool IsSearchInputExists()
        {
            return Wrapper.IsElementDisplayed(_searchInput);
        }

        public bool IsSearchIconExists()
        {
            return Wrapper.IsElementDisplayed(_searchIcon);
        }

        public bool IsVirtualKeyboardsButtonExists()
        {
            return Wrapper.IsElementDisplayed(_virtualKeyboardsButton);
        }

        public bool IsSearchButtonExists()
        {
            return Wrapper.IsElementDisplayed(_searchButton);
        }

        public bool IsSearchLuckyButtonExists()
        {
            return Wrapper.IsElementDisplayed(_luckyButton);
        }

        public bool IsMailLinkExists()
        {
            return Wrapper.IsElementDisplayed(_mail);
        }

        public bool IsPicturesLinkButtonExists()
        {
            return Wrapper.IsElementDisplayed(_pictures);
        }

        public bool IsGoogleAppsMenuExists()
        {
            return Wrapper.IsElementDisplayed(_googleApps);
        }

        public bool IsLoginButtonExists()
        {
            return Wrapper.IsElementDisplayed(_loginButton);
        }

        public bool IsSettingsExist()
        {
            return Wrapper.IsElementDisplayed(_footer._settings);
        }

        public bool IsAboutGoogleExists()
        {
            return Wrapper.IsElementDisplayed(_footer._aboutGoogle);
        }

        public bool IsAdvertasingExists()
        {
            return Wrapper.IsElementDisplayed(_footer._advertising);
        }

        public bool IsConditionsExist()
        {
            return Wrapper.IsElementDisplayed(_footer._conditions);
        }

        public bool IsConfidentialityExists()
        {
            return Wrapper.IsElementDisplayed(_footer._confidentiality);
        }

        public bool IsCountryNameExists()
        {
            return Wrapper.IsElementDisplayed(_footer._countryName);
        }

        public bool IsForBusinessExists()
        {
            return Wrapper.IsElementDisplayed(_footer._forBusiness);
        }

        public bool IsHowWorkGoogleSearchExists()
        {
            return Wrapper.IsElementDisplayed(_footer._howWorkGoogleSearch);
        }

        public bool IsSpanCarbonDioxideExists()
        {
            return Wrapper.IsElementDisplayed(_footer._spanCarbonDioxide);
        }

        public bool IsEnterFormPresents()
        {
            Wrapper.ClickElement(_loginButton);
            return Wrapper.IsElementDisplayed(_enterForm);
        }

        public void SearchInput()
        {
            Wrapper.TypeAndSendWithEnter(_searchInput, _searchText);
        }

        public 
    }
}