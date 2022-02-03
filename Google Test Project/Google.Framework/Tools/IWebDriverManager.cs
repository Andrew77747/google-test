using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Google.Framework.Tools
{
    public interface IWebDriverManager : IDisposable
    {
        IWebDriver GetDriver();
        WebDriverWait GetWaiter();
    }
}