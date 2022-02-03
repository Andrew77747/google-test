using OpenQA.Selenium;

namespace Google.Framework.PageObjects.Elements
{
    public class Footer
    {
        #region Maps Of Elements

        public readonly By _countryName = By.CssSelector("div.uU7dJb");
        public readonly By _aboutGoogle = By.XPath("//*[contains(text(), 'Всё о Google')]");
        public readonly By _advertising = By.XPath("//*[contains(text(), 'Реклама')]");
        public readonly By _forBusiness = By.XPath("//*[contains(text(), 'Для бизнеса')]");
        public readonly By _howWorkGoogleSearch = By.XPath("//*[contains(text(), 'Как работает Google Поиск')]");
        public readonly By _confidentiality = By.XPath("//*[contains(text(), 'Конфиденциальность')]");
        public readonly By _conditions = By.XPath("//*[contains(text(), 'Условия')]");
        public readonly By _settings = By.XPath("//button[contains(text(), 'Настройки')]");
        public readonly By _spanCarbonDioxide = By.CssSelector("span.ktLKi");

        #endregion
    }
}