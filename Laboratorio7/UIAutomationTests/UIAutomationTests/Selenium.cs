using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace UIAutomationTests
{
    public class Selenium
    {
        IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
        }

        [Test]
        public void Register_New_Country_Test()
        {
            // Arrange
            var URL = "http://localhost:8080/";

            _driver.Manage().Window.Maximize();

            // Act
            _driver.Navigate().GoToUrl(URL);

            // Assert
            Assert.That(_driver.Title, Is.EqualTo("frontend-lab"));
            Thread.Sleep(2000);

            IWebElement addCountryButton = _driver.FindElement(By.CssSelector(".btn-outline-secondary"));
            Assert.NotNull(addCountryButton);
            addCountryButton.Click();
            Thread.Sleep(2000);

            IWebElement countryName = _driver.FindElement(By.Id("name"));
            countryName.Click();
            countryName.SendKeys("Japón");
            Assert.That(countryName.GetAttribute("value"), Is.EqualTo("Japón"));
            Thread.Sleep(2000);

            SelectElement continentSelection = new SelectElement(_driver.FindElement(By.Id("continente")));
            continentSelection.SelectByText("Asia");
            Assert.That(continentSelection.SelectedOption.Text, Is.EqualTo("Asia"));
            Thread.Sleep(2000);

            IWebElement language = _driver.FindElement(By.Id("idioma"));
            language.Click();
            language.SendKeys("Japonés");
            Assert.That(language.GetAttribute("value"), Is.EqualTo("Japonés"));
            Thread.Sleep(2000);

            IWebElement saveButton = _driver.FindElement(By.CssSelector(".btn"));
            saveButton.Click();

        }
    }
}
