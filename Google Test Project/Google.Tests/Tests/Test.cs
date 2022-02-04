using System.Threading;
using Google.Framework.PageObjects.Pages;
using Infrastructure.Settings;
using NUnit.Framework;

namespace Google.Tests.Tests
{
    [TestFixture]
    public class Test : TestBase
    {
        private GoogleSearchPage _googleSearchPage;
        
        public Test()
        {
            _googleSearchPage = new GoogleSearchPage(Manager, new Appsettings());
        }

        [SetUp]
        public void Start()
        {
            _googleSearchPage.OpenGooglePage();
        }

        [Test]

        public void CheckGooglePageUI()
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
        public void CheckLoginPage()
        {
            Assert.IsTrue(_googleSearchPage.IsEnterFormPresents(), "");
        }

        [Test]
        public void CheckGoogleSearchWithSearchButton()
        {
            _googleSearchPage.SearchInputClick();
            Assert.AreEqual("Привет, Мир!", _googleSearchPage.SearchResult(), "");
        }

        [Test]
        public void CheckGoogleSearchWithEnter()
        {
            _googleSearchPage.SearchInputEnter();
            Assert.AreEqual("Привет, Мир!", _googleSearchPage.SearchResult(), "");
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
        public void CheckEmptyInput()
        {
            //Assert.AreEqual(_googleSearchPage.BaseUrl, _googleSearchPage.ClickSearchButton(), "Urls should be equal");
            //Assert.AreEqual(_googleSearchPage.LuckyPageUrl, _googleSearchPage.ClickLuckyButton(), "Urls should be equal");// вынести в отдельный метод
        }

        [Test]
        public void CheckLogin()
        {
            _googleSearchPage.Login();
            Assert.AreEqual("test37670@gmail.com", _googleSearchPage.GetAccountEmail(), "");
        }
    }
}