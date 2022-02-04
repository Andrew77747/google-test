using OpenQA.Selenium;

namespace Google.Framework.PageObjects.Elements
{
    public class Footer
    {
        #region Maps Of Elements

        public readonly By CountryName = By.CssSelector("div.uU7dJb");
        public readonly By AboutGoogle = By.XPath("//*[contains(text(), 'Всё о Google')]");
        public readonly By Advertising = By.XPath("//*[contains(text(), 'Реклама')]");
        public readonly By ForBusiness = By.XPath("//*[contains(text(), 'Для бизнеса')]");
        public readonly By HowWorkGoogleSearch = By.XPath("//*[contains(text(), 'Как работает Google Поиск')]");
        public readonly By Confidentiality = By.XPath("//*[contains(text(), 'Конфиденциальность')]");
        public readonly By Conditions = By.XPath("//*[contains(text(), 'Условия')]");
        public readonly By Settings = By.XPath("//button[contains(text(), 'Настройки')]");
        public readonly By SpanCarbonDioxide = By.CssSelector("span.ktLKi");

        #endregion
    }
}