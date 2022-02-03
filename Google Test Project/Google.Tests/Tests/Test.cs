using Google.Framework.PageObjects.Pages;
using Google.Framework.Tools;
using Infrastructure.Settings;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Google.Tests.Tests
{
    [TestFixture]
    public class Test /*: TestBase*/
    {
        private GoogleSearchPage _googleSearchPage;
        private IWebDriverManager _manager;
        public Test()
        {
            _manager = new WebDriverManager();
            _googleSearchPage = new GoogleSearchPage(_manager, new Appsettings());
        }

        [Test]

        public void CheckGooglePageUI()
        {
            _googleSearchPage.OpenGooglePage();
            Assert.IsTrue(_googleSearchPage.IsLogoExists());
            Assert.IsTrue(_googleSearchPage.IsSearchInputExists());
            Assert.IsTrue(_googleSearchPage.IsSearchIconExists());
            Assert.IsTrue(_googleSearchPage.IsVirtualKeyboardsButtonExists());
            Assert.IsTrue(_googleSearchPage.IsSearchButtonExists());
            Assert.IsTrue(_googleSearchPage.IsSearchLuckyButtonExists());
            Assert.IsTrue(_googleSearchPage.IsMailLinkExists());
            Assert.IsTrue(_googleSearchPage.IsPicturesLinkButtonExists());
            Assert.IsTrue(_googleSearchPage.IsGoogleAppsMenuExists());
            Assert.IsTrue(_googleSearchPage.IsLoginButtonExists());
            Assert.IsTrue(_googleSearchPage.IsSettingsExist());
            Assert.IsTrue(_googleSearchPage.IsAboutGoogleExists());
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
            _googleSearchPage.OpenGooglePage();
            Assert.IsTrue(_googleSearchPage.IsEnterFormPresents());
        }

        [Test]
        public void CheckGoogleSearch()
        {
            _googleSearchPage.OpenGooglePage();
            _googleSearchPage.SearchInput();
        }

        [TearDown]
        public void Stop()
        {
            _manager.Dispose();
        }
    }
}