using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Google.Framework.Tools
{
    public class WebDriverManager : IWebDriverManager

    {
        public IWebDriver Driver;

        public IWebDriver GetDriver()
        {
            if (Driver != null)
            {
                return Driver;
            }

            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Driver.Manage().Window.Maximize();
            return Driver;
        }

        public WebDriverWait GetWaiter()
        {
            return new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(3));
        }

        public void Dispose()
        {
            if (Driver == null) return;

            Driver.Close();
            Driver.Quit();
            Driver = null;
        }
    }
}