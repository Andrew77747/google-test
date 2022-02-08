using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Google.Framework.Tools
{
    public class SeleniumWrapper
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        private WebDriverWait _customDriverWait;


        public SeleniumWrapper(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
            _customDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
        }

        #region Actions

        public void SwitchToAlertAccept()
        {
            _driver.SwitchTo().Alert().Accept();
        }

        public void SwitchToAnotherTab(int numberOfTab)
        {
            var tabs = new List<String>(_driver.WindowHandles);
            _driver.SwitchTo().Window(tabs[numberOfTab]);
        }

        public void NavigateBack()
        {
            _driver.Navigate().Back();
        }

        public void Navigate(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void SendKeysAndEscape(By by, string text)
        {
            FindElement(by).SendKeys(text + Keys.Escape);
        }

        public void PointToElement(By selector)
        {
            Actions action = new Actions(_driver);
            action.MoveToElement(FindElement(selector)).Build().Perform();
        }

        public void Type(By by, string text)
        {
            FindElement(by).SendKeys(text);
        }

        public void TypeAndSendWithEnter(By by, string text)
        {
            FindElement(by).SendKeys(text + Keys.Enter);
        }

        public void ClearTypeAndSend(By by, string text)
        {
            _driver.FindElement(by).SendKeys(Keys.Control + text);
        }

        public IWebElement FindElement(By by)
        {
            WaitElementDisplayed(by);
            return _driver.FindElement(by);
        }

        public void ClickElement(By by)
        {
            FindElement(by).Click();
        }

        public string GetUrl()
        {
            return _driver.Url;
        }

        public string GetUserName()
        {
            return _driver.PageSource;
        }

        public void HoverMouseOnElement(string selector)
        {
            try
            {
                Actions action = new Actions(_driver);
                action.MoveToElement(FindElement(By.XPath(selector))).Build().Perform();
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("There is no such element! Error: " + e);
            }
        }

        public List<IWebElement> GetElements(By selector)
        {
            return _driver.FindElements(selector).ToList();
        }

        #endregion

        #region Validation

        public bool IsElementExists(By selector)
        {
            try
            {
                _driver.FindElement(selector);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool IsElementDisplayed(By selector)
        {
            try
            {
                return _driver.FindElement(selector).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool IsElementExistsWithWaiter(By selector)
        {
            try
            {
                _wait.Until(d => IsElementDisplayed(selector));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }

        public bool IsTextExists(string text)
        {
            try
            {
                _driver.FindElement(By.XPath($"//*[contains(text(), '{text}')]"));
                Console.WriteLine($"This text exists {text}");
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine($"This text does not exists {text}");
                return false;
            }
        }

        public string GetValuesOfAttribute(By by)
        {
            return _driver.FindElement(by).GetAttribute("value");
        }

        public bool IsElementVisible(By by)
        {
            try
            {
                return _driver.FindElement(by).Displayed;
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Здесь нет дропдауна");
                return false;
            }
        }

        public bool WaitElementVisible(By by)
        {
            try
            {
                _customDriverWait.Until(d => IsElementVisible(by));
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool IsSortingAskRight(string[] actualArray)
        {

            string[] expectedArray = new string[actualArray.Length];
            actualArray.CopyTo(expectedArray, 0);

            Array.Sort(expectedArray);

            if (actualArray.SequenceEqual(expectedArray))
            {
                Console.WriteLine(expectedArray);
                return true;
            }
            else
            {
                Console.WriteLine(expectedArray);
                return false;
            }
        }

        public bool IsSortingDescRight(string[] actualArray)
        {

            string[] expectedArray = new string[actualArray.Length];
            actualArray.CopyTo(expectedArray, 0);

            Array.Sort(expectedArray);
            Array.Reverse(expectedArray);

            if (actualArray.SequenceEqual(expectedArray))
            {
                Console.WriteLine(expectedArray);
                return true;
            }
            else
            {
                Console.WriteLine(expectedArray);
                return false;
            }
        }


        #endregion

        #region Waiters

        public void WaitElementDisplayed(By by)
        {
            WaitElement(by);
            _wait.Until(d => ElementVisible(by));
        }

        public void WaitElement(By by)
        {
            _wait.Until(d => ElementExists(by));
        }

        public bool ElementExists(By by)
        {
            try
            {
                _driver.FindElement(by);
                return true;
            }

            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool ElementVisible(By by)
        {
            try
            {
                return _driver.FindElement(by).Displayed;
            }

            catch (NoSuchElementException)
            {
                return false;
            }
        }

        #endregion

    }
}