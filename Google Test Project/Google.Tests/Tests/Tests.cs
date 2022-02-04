using Google.Framework.PageObjects.Pages;
using Infrastructure.Settings;
using NUnit.Framework;

namespace Google.Tests.Tests
{
    [TestFixture]
    public class Tests : TestBase
    {
        private GoogleSearchPage _googleSearchPage;
        private Appsettings _settings;
        
        public Tests()
        {
            _googleSearchPage = new GoogleSearchPage(Manager, Settings);
            _settings = new ConfigurationManager().GetSettings();
        }

        [SetUp]
        public void Start()
        {
            _googleSearchPage.OpenGooglePage();
        }

        [Test]

        public void CheckGooglePageUi()
        {
            Assert.IsTrue(_googleSearchPage.IsLogoExists(), "");
            Assert.IsTrue(_googleSearchPage.IsSearchInputExists(), "");
            Assert.IsTrue(_googleSearchPage.IsSearchIconExists(), "");
            Assert.IsTrue(_googleSearchPage.IsVirtualKeyboardsButtonExists(), "");
            Assert.IsTrue(_googleSearchPage.IsSearchButtonExists());
            Assert.IsTrue(_googleSearchPage.IsSearchLuckyButtonExists());
            Assert.IsTrue(_googleSearchPage.IsMailLinkExists());
            Assert.IsTrue(_googleSearchPage.IsPicturesLinkButtonExists());
            Assert.IsTrue(_googleSearchPage.IsGoogleAppsMenuExists());
            Assert.IsTrue(_googleSearchPage.IsLoginButtonExists());
            Assert.IsTrue(_googleSearchPage.IsAboutGoogleExists());
            Assert.IsTrue(_googleSearchPage.IsSettingsExist());
            Assert.IsTrue(_googleSearchPage.IsAdvertasingExists());
            Assert.IsTrue(_googleSearchPage.IsConditionsExist());
            Assert.IsTrue(_googleSearchPage.IsConfidentialityExists());
            Assert.IsTrue(_googleSearchPage.IsCountryNameExists());
            Assert.IsTrue(_googleSearchPage.IsForBusinessExists());
            Assert.IsTrue(_googleSearchPage.IsHowWorkGoogleSearchExists());
            Assert.IsTrue(_googleSearchPage.IsSpanCarbonDioxideExists());
        }

        [Test]
        public void ALoginPage()
        {
            Assert.IsTrue(_googleSearchPage.IsLoginFormPresents(), "Login form should be present");
        }

        [Test]
        public void CheckSimpleGoogleSearch()
        {
            _googleSearchPage.SearchInputEnter();
            Assert.IsTrue(_googleSearchPage.IsStringContainsText("Привет"), "Search result should contain the word");
        }

        [Test]
        public void CheckGoogleSearchWithSearchButton()
        {
            _googleSearchPage.SearchInputClick();
            Assert.AreEqual("Привет, Мир!", _googleSearchPage.SearchResult(), "Search result should be equal");
        }

        [Test]
        public void CheckGoogleSearchWithEnter()
        {
            _googleSearchPage.SearchInputEnter();
            Assert.AreEqual("Привет, Мир!", _googleSearchPage.SearchResult(), "Search result should be equal");
        }

        [Test]
        public void CheckKeyboard()
        {
            Assert.IsTrue(_googleSearchPage.IsKeyboardVisible(), "Keyboard should be visible");
        }

        [Test]
        public void CheckHintsDropdown()
        {
            Assert.IsTrue(_googleSearchPage.IsHintsVisible(), "HintsDropdown should be visible");
        }

        [Test]
        public void CheckSearchButtonWithEmptyInput()
        {
            _googleSearchPage.ClickSearchButton();
            Assert.AreEqual(_settings.BaseUrl, _googleSearchPage.GetCurrentUrl(), "Urls should be equal");
        }

        [Test]
        public void CheckLuckyButtonWithEmptyInput()
        { 
            _googleSearchPage.ClickLuckyButton();
            Assert.AreEqual(_settings.LuckyPageUrl, _googleSearchPage.GetCurrentUrl(), "Urls should be equal");
        }

        [Test]
        public void CheckLogin()
        {
            _googleSearchPage.Login();
            Assert.AreEqual(_settings.Email, _googleSearchPage.GetAccountEmail(), "User must be logged in");
        }
    }
}