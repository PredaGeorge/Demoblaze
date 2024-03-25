using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Drawing;

namespace Demoblaze
{
    [TestFixture]
    public class Phones
    {
        [Test]
        public void NavigateTestSamsung()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.demoblaze.com/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            Assert.That(driver.Title, Is.EqualTo("STORE"));

            IWebElement samsungLink = driver.FindElement(By.XPath("//a[@href='prod.html?idp_=1' and contains(@class, 'hrefch')]"));
            samsungLink.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            IWebElement buyLink = driver.FindElement(By.XPath("//a[contains(text(),'Add to cart')]"));
            buyLink.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            var expectedMessage = "Product added";
            Assert.That(expectedMessage, Is.EqualTo("Product added"));

            driver.Quit();

        }
        [Test]
        public void NavigateTestNokia()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.demoblaze.com/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            Assert.That(driver.Title, Is.EqualTo("STORE"));

            IWebElement nokiaLink = driver.FindElement(By.XPath("//a[@href='prod.html?idp_=2' and contains(@class, 'hrefch')]"));
            nokiaLink.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            IWebElement buyLink = driver.FindElement(By.XPath("//a[contains(text(),'Add to cart')]"));
            buyLink.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            var expectedMessage = "Product added";
            Assert.That(expectedMessage, Is.EqualTo("Product added"));

            driver.Quit();

        }
    }
}
